using Gentefit.db;
using Gentefit.Controlador;
using Gentefit.Modelo;
using Gentefit.Modelo.Enums;
using Gentefit.ModeloXml;
using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Gentefit.Controlador
{
    internal class LogicaReservas
    {
        private LogicaClases logicaClases = new LogicaClases();
        // Obtener todos las reservas
        public List<Reserva> ObtenerTodos()
        {
            using var contexto = new GentefitContext();
            return contexto.Reservas.ToList();
        }

        // Buscar reserva por ID
        public List<Reserva> BuscarPorId(int id)
        {
            using var contexto = new GentefitContext();
            return contexto.Reservas
                            .Where(c => c.idCliente == id)
                            .ToList();
        }

        public List<ReservaDTO> ObtenerReservasDetalladas()
        {
            using var contexto = new GentefitContext();

            return contexto.Reservas
                .Include(r => r.cliente)
                .Include(r => r.clase)
                    .ThenInclude(c => c.actividad)
                .Select(r => new ReservaDTO
                {
                    IdReserva = r.idReserva,
                    Cliente = r.cliente.nombre + " " + r.cliente.apellidos,
                    Clase = r.clase.actividad.nombre,
                    FechaClase = r.fechaClase,
                    Estado = r.estado.ToString(),
                    FechaReserva = r.fechaReserva
                })
                .ToList();
        }


        // Crear una reserva
        public EstadoReserva ReservarClase(int idClase, int idCliente)
        {
            using var contexto = new GentefitContext();

            // Comprobar si el cliente ya tiene una reserva para esa clase
            bool existeReserva = contexto.Reservas
                .Any(r => r.idClase == idClase && r.idCliente == idCliente && r.estado != EstadoReserva.Cancelada);

            if (existeReserva)
            {
                MessageBox.Show(
                    "Ya tienes una reserva para esta clase.",
                    "Reserva duplicada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return EstadoReserva.Cancelada; ;
            }

            // Obtener la clase
            var clase = contexto.Clases
                .Include(c => c.reservas)
                .Include(c => c.actividad)
                .FirstOrDefault(c => c.idClase == idClase);

            if (clase == null) return EstadoReserva.Cancelada; ;

            // Buscar la fecha de la clase que se reserva
            DayOfWeek diaObjetivo = DayOfWeek.Monday;
            DateTime fechaHoraClase;
            switch (clase.dia)
            {
                case Dia.Lunes:
                    diaObjetivo = DayOfWeek.Monday;
                    break;
                case Dia.Martes:
                    diaObjetivo = DayOfWeek.Tuesday;
                    break;
                case Dia.Miercoles:
                    diaObjetivo = DayOfWeek.Wednesday;
                    break;
                case Dia.Jueves:
                    diaObjetivo = DayOfWeek.Thursday;
                    break;
                case Dia.Viernes:
                    diaObjetivo = DayOfWeek.Friday;
                    break;
                case Dia.Sabado:
                    diaObjetivo = DayOfWeek.Saturday;
                    break;
                case Dia.Domingo:
                    diaObjetivo = DayOfWeek.Sunday;
                    break;
            }
            fechaHoraClase = BuscarFechaReserva(diaObjetivo, clase);

            // Crear la reserva
            Reserva nuevaReserva = new Reserva
            {
                idClase = clase.idClase,
                idCliente = idCliente,
                fechaClase = fechaHoraClase,
                fechaReserva = DateTime.Now
            };

            List<Reserva> reservasAceptadas = ReservasAceptadas(clase);
            if(reservasAceptadas.Count < 16)
            {
                nuevaReserva.estado = EstadoReserva.Confirmada;
            }
            else
            {
                nuevaReserva.estado = EstadoReserva.EnEspera;
            }
            
            // Guardar la reserva
            GuardarReserva(nuevaReserva);
            GestionarListasReservas(clase);

            // Guardar los cambios en la clase (plazas libres y plazas en espera)
            contexto.SaveChanges();

            // Enviar mail de confirmación:
            var cliente = contexto.Clientes.FirstOrDefault(c => c.idCliente == idCliente);
            if (cliente != null)
            {
                string estadoTexto = nuevaReserva.estado == EstadoReserva.Confirmada ? "Confirmada ✅" : "En espera ⏳";
                string asunto = "📋 Confirmación de tu reserva en Gentefit";
                string cuerpo = $@"
                <h3>Hola {cliente.nombre},</h3>
                <p>Tu reserva para la clase <b>{clase.actividad.nombre}</b> se ha registrado correctamente.</p>
                <p><b>Estado actual:</b> {estadoTexto}</p>
                <p>Fecha de la clase: {clase.dia}</p>
                <p>Hora de la clase: {clase.hora}</p>
                <hr><p>Gracias por confiar en Gentefit 💪</p>";

                // Dejo el envio de emails desconectado para no petar a emails por ahora.
                //EnviarCorreo.Notificar(cliente.email, asunto, cuerpo);

            }

            return nuevaReserva.estado; ;
        }


        // Guardar una reserva nueva
        public void GuardarReserva(Reserva nuevaReserva)
        {
            using var contexto = new GentefitContext();
            contexto.Reservas.Add(nuevaReserva);
            contexto.SaveChanges();
        }

        // Modificar una reserva
        public bool ModificarReserva(Reserva reserva)
        {
            using var contexto = new GentefitContext();
            var c = contexto.Reservas.FirstOrDefault(x => x.idReserva == reserva.idReserva);
            if (c == null) return false;

            c.idCliente = reserva.idCliente;
            c.idClase = reserva.idClase;
            c.estado = reserva.estado;
            c.fechaClase = reserva.fechaClase;
            c.fechaReserva = reserva.fechaReserva;

            contexto.SaveChanges();
            return true;
        }

        // Cancelar una reserva
        public bool CancelarReserva(int idReserva)
        {
            using var contexto = new GentefitContext();

            // Obtener la reserva con su clase
            var reserva = contexto.Reservas
                .Include(r => r.cliente)
                .Include(r => r.clase)
                    .ThenInclude(c => c.actividad)
                .FirstOrDefault(r => r.idReserva == idReserva);


            if (reserva == null)
            {
                return false;
            }

            var clase = reserva.clase;
            bool estabaConfirmada = reserva.estado == EstadoReserva.Confirmada;

            // Si estaba confirmada, gestionar lista de espera antes de eliminar
            if (estabaConfirmada)
            {
                // Buscar la reserva en espera más antigua
                var primeraEnEspera = contexto.Reservas
                    .Include(r => r.cliente)
                    .Where(r => r.idClase == clase.idClase && r.estado == EstadoReserva.EnEspera)
                    .OrderBy(r => r.fechaReserva)
                    .FirstOrDefault();

                if (primeraEnEspera != null)
                {
                    // Cambiar a confirmada
                    primeraEnEspera.estado = EstadoReserva.Confirmada;

                    // Enviar correo al cliente que pasa de espera a confirmada
                    string asunto = "🎉 ¡Tu reserva ha sido confirmada!";
                    string cuerpo = $@"
                            <h3>Hola {primeraEnEspera.cliente.nombre},</h3>
                            <p>Tu reserva en Gentefit ha pasado de <b>espera</b> a <b>confirmada</b>.</p>
                            <p><b>Clase:</b> {clase.actividad?.nombre}</p>
                            <p><b>Fecha de la clase:</b> {clase.dia}</p>
                            <p><b>Hora de la clase:</b> {clase.hora}</p>
                            <hr><p>¡Nos vemos en el gimnasio 🏋️‍♀️!</p>";
                    // Dejo el envio de emails desconectado para no petar a emails por ahora.
                    //EnviarCorreo.Notificar(primeraEnEspera.cliente.email, asunto, cuerpo);
                }
                else
                {
                    // No hay lista de espera → liberar plaza
                    clase.plazasLibres++;
                }
            }

            // Cambiar estado a cancelada
            reserva.estado = EstadoReserva.Cancelada;

            // Guardar cambio inicial
            contexto.SaveChanges();

            if (reserva != null)
            {
                string asunto = "❌ Reserva cancelada";
                string cuerpo = $@"
            <h3>Hola {reserva.cliente.nombre},</h3>
            <p>Tu reserva para la clase <b>{clase.actividad?.nombre}</b> ha sido cancelada correctamente.</p>
            <p><b>Fecha de la clase:</b> {clase.dia}</p>
            <p><b>Hora de la clase:</b> {clase.hora}</p>
            <hr><p>Esperamos verte pronto 💪</p>";

                // Dejo el envio de emails desconectado para no petar a emails por ahora.
                //EnviarCorreo.Notificar(reserva.cliente.email, asunto, cuerpo);
            }

            MessageBox.Show("Reserva cancelada correctamente.",
                "Reserva cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }


        // Eliminar una reserva cancelada
        public bool EliminarReserva(int id)
        {
            using var contexto = new GentefitContext();
            var reserva = contexto.Reservas.Find(id);
            if (reserva != null)
            {
                contexto.Reservas.Remove(reserva);
                Clase clase = logicaClases.BuscarPorId(reserva.idClase).FirstOrDefault();
                contexto.SaveChanges();
                GestionarListasReservas(clase);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        //Filtrar reservas del usuario logeado
        public List<ReservaDTO> FiltrarReservas(int id)
        {
            using var contexto = new GentefitContext();

            return contexto.Reservas
                .Where(r => r.idCliente == id)
                .Include(r => r.cliente)
                .Include(r => r.clase)
                    .ThenInclude(c => c.actividad)
                .Select(r => new ReservaDTO
                {
                    IdReserva = r.idReserva,
                    Clase = r.clase.actividad.nombre,
                    Estado = r.estado.ToString(),
                    FechaClase = r.clase.horario,
                    //Dia = r.clase.dia,
                    //Hora = r.clase.hora,
                    FechaReserva = r.fechaReserva,
                })
                .ToList();
        }

        public class ReservaDTO
        {
            public int IdReserva { get; set; }
            public string Cliente { get; set; } 
            public string Clase { get; set; }
            public DateTime FechaClase { get; set; }
            public DateTime FechaReserva { get; set; }
            //public Dia Dia { get; set; }
            //public TimeOnly Hora { get; set; }
            public string Estado { get; set; }



        }


        // Exportar reservas a XML
        public void ExportarXmlReservas(string rutaArchivo)
        {
            var reservas = ObtenerTodos();
            var reservasXml = reservas.Select(c => ConvertirAXml(c)).ToList();

            XmlSerializer serializer = new XmlSerializer(typeof(List<ReservaXml>));
            using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create))
            {
                serializer.Serialize(fs, reservasXml);
            }
        }

        // Importar reservas desde XML
        public void ImportarXmlReservas(string rutaArchivo)
        {
            using var contexto = new GentefitContext();
            XmlSerializer serializer = new XmlSerializer(typeof(List<ReservaXml>));
            using (FileStream fs = new FileStream(rutaArchivo, FileMode.Open))
            {
                List<ReservaXml> reservasXml = (List<ReservaXml>)serializer.Deserialize(fs);
                List<Reserva> reservas = reservasXml.Select(x =>
                {
                    var c = ConvertirAEntidad(x);
                    c.idReserva = 0; // Ignorar el ID del XML
                    return c;
                }).ToList();

                contexto.Reservas.AddRange(reservas);
                contexto.SaveChanges();

                List<Clase> todasClases = logicaClases.ObtenerTodo();
                foreach (Clase clase in todasClases)
                {
                    GestionarListasReservas(clase);
                    contexto.SaveChanges();
                }
            }
        }

        // Conversión Reserva -> ReservaXml
        public static ReservaXml ConvertirAXml(Reserva reserva)
        {
            return new ReservaXml
            {
                IdReserva = reserva.idReserva,
                IdCliente = reserva.idCliente,
                Cliente = reserva.cliente,
                IdClase = reserva.idClase,
                Clase = reserva.clase,
                Estado = reserva.estado,
                FechaReserva = reserva.fechaReserva,
                FechaClase = reserva.fechaClase
            };
        }

        // Conversión ReservaXml -> Reserva
        public static Reserva ConvertirAEntidad(ReservaXml reservaXml)
        {
            return new Reserva
            {
                idReserva = reservaXml.IdReserva,
                idCliente = reservaXml.IdCliente,
                cliente = reservaXml.Cliente,
                idClase = reservaXml.IdClase,
                clase = reservaXml.Clase,
                estado = reservaXml.Estado,
                fechaClase = reservaXml.FechaClase,
                fechaReserva = reservaXml.FechaReserva
            };
        }

        //Busca la fecha y hora de la clase que se quiere reservar
        public static DateTime BuscarFechaReserva(DayOfWeek diaObjetivo, Clase clase)
        {
            DateTime hoy = DateTime.Today;
            int diasQueFaltan = ((int)diaObjetivo - (int)hoy.DayOfWeek + 7) % 7;
            if (diasQueFaltan == 0) //Aseguramos que la reserva se hace para un futuro
            {
                if (clase.hora < TimeOnly.FromDateTime(DateTime.Now))
                {
                    diasQueFaltan = 7;
                }
            }
            DateTime diaClase = hoy.AddDays(diasQueFaltan);
            DateTime fechaHoraClase = diaClase.Add(clase.hora.ToTimeSpan());
            return fechaHoraClase;
        }

        public void GestionarListasReservas(Clase clase)
        {
            List<Reserva> todasRes = ObtenerTodos();
            List<Reserva> aceptadas = new List<Reserva>();
            aceptadas.Clear();
            List<Reserva> enEspera = new List<Reserva>();
            enEspera.Clear();
            using var contexto = new GentefitContext();
            foreach (Reserva res in todasRes)
            {
                if (res == null) return;

                if (res.idClase == clase.idClase)
                {
                    if (res.estado == EstadoReserva.Confirmada)
                    {
                        aceptadas.Add(res);
                    }else if(res.estado == EstadoReserva.EnEspera)
                    {
                        if(aceptadas.Count < 16)
                        {                          
                            res.estado = EstadoReserva.Confirmada;
                            aceptadas.Add(res);

                            var r = contexto.Reservas.FirstOrDefault(x => x.idReserva == res.idReserva);
                            r.estado = res.estado;
                            contexto.SaveChanges();
                        }
                        else
                        {
                            enEspera.Add(res);
                        }
                    }
                }
            }
            var c = contexto.Clases.FirstOrDefault(x => x.idClase == clase.idClase);
            c.plazasLibres = (16 - aceptadas.Count);
            c.enEspera = enEspera.Count;
            contexto.SaveChanges();

            clase.plazasLibres = (16 - aceptadas.Count);
            clase.enEspera = enEspera.Count;
        }

        public List<Reserva> ReservasAceptadas(Clase clase)
        {
            List<Reserva> todasReservas = ObtenerTodos();
            List<Reserva> listaAceptadas = new List<Reserva>();
            foreach (Reserva res in todasReservas)
            {
                if(res.idClase == clase.idClase)
                {
                    if(res.estado == EstadoReserva.Confirmada)
                    {
                        listaAceptadas.Add(res);
                    }
                }
            }
            return listaAceptadas;
        }
    }
}
