using Gentefit.db;
using Gentefit.Logica;
using Gentefit.Modelo;
using Gentefit.Modelo.Enums;
using Gentefit.ModeloXml;
using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

public class LogicaReservas
{
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

    // Crear una reserva
    public bool ReservarClase(int idClase, int idCliente)
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
            return false;
        }

        // Obtener la clase
        var clase = contexto.Clases
            .Include(c => c.reservas)
            .Include(c => c.actividad)  
            .FirstOrDefault(c => c.idClase == idClase);

        if (clase == null) return false;

        // Crear la reserva
        Reserva nuevaReserva = new Reserva
        {
            idClase = clase.idClase,
            idCliente = idCliente,
            fecha = DateTime.Now
        };

        // Comprobar plazas libres
        if (clase.plazasLibres > 0)
        {
            clase.plazasLibres--;
            nuevaReserva.estado = EstadoReserva.Confirmada;
        }
        else
        {
            nuevaReserva.estado = EstadoReserva.EnEspera; // en espera
        }

        // Guardar la reserva
        GuardarReserva(nuevaReserva);

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
                <p>Fecha de la clase: {clase.horario.ToString("dd HH:mm")}</p>
                <hr><p>Gracias por confiar en Gentefit 💪</p>";
            
            // Dejo el envio de emails desconectado para no petar a emails por ahora.
            //EnviarCorreo.Notificar(cliente.email, asunto, cuerpo);
            
        }

        return true;
    }


    // Guardar una reserva nueva
    public void GuardarReserva(Reserva nuevaReserva)
    {
        using var contexto = new GentefitContext();
        contexto.Reservas.Add(nuevaReserva);
        contexto.SaveChanges();
    }

    // Modificar una reserva
    public bool ModificarReserva(Reserva reservaMod)
    {
        using var contexto = new GentefitContext();
        var reserva = contexto.Reservas
            .Include(r => r.clase)
                .ThenInclude(c => c.actividad)
            .Include(r => r.cliente)
            .FirstOrDefault(r => r.idReserva == reservaMod.idReserva);

        if (reserva == null)
            return false;

        var clase = reserva.clase;

        EstadoReserva estadoAnterior = reserva.estado;
        EstadoReserva nuevoEstado = reservaMod.estado;

        // 🔹 VALIDACIÓN: no permitir Confirmada si no hay plazas
        if (nuevoEstado == EstadoReserva.Confirmada &&
            estadoAnterior != EstadoReserva.Confirmada &&
            clase.plazasLibres == 0)
        {
            MessageBox.Show("No se puede confirmar la reserva porque la clase está completa.");
            return false;
        }

        // 🔹 CASO 1: Confirmada → EnEspera  (liberar 1 plaza + promover siguiente)
        if (estadoAnterior == EstadoReserva.Confirmada &&
            nuevoEstado == EstadoReserva.EnEspera)
        {
            clase.plazasLibres++;

            // Buscar siguiente en espera
            var siguiente = contexto.Reservas
                .Include(r => r.cliente)
                .Where(r => r.idClase == clase.idClase && r.estado == EstadoReserva.EnEspera)
                .OrderBy(r => r.fecha)
                .FirstOrDefault();

            if (siguiente != null)
            {
                siguiente.estado = EstadoReserva.Confirmada;

                string asunto = "🎉 ¡Tu reserva ha sido confirmada!";
                string cuerpo = $@"
                    <h3>Hola {siguiente.cliente.nombre},</h3>
                    <p>Una plaza se ha liberado y tu reserva ahora está <b>CONFIRMADA</b>.</p>
                    <p>Clase: {clase.actividad.nombre}</p>
                    <p>Fecha: {clase.horario}</p>";
                EnviarCorreo.Notificar(siguiente.cliente.email, asunto, cuerpo);
            }
        }

        // 🔹 CASO 2: Confirmada → Cancelada  (usamos CancelarReserva para mantener la lógica)
        if (estadoAnterior == EstadoReserva.Confirmada &&
            nuevoEstado == EstadoReserva.Cancelada)
        {
            return CancelarReserva(reserva.idReserva);
        }

        // 🔹 CASO 3: EnEspera → Confirmada  (ocupa 1 plaza)
        if (estadoAnterior == EstadoReserva.EnEspera &&
            nuevoEstado == EstadoReserva.Confirmada)
        {
            clase.plazasLibres--;
        }

        // 🔹 CASO 4: Cualquier otro cambio simple (no requiere promoción ni cancelación)
        reserva.idCliente = reservaMod.idCliente;
        reserva.idClase = reservaMod.idClase;
        reserva.estado = nuevoEstado;

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
                .OrderBy(r => r.fecha)
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
                            <p><b>Fecha de la clase:</b> {clase.horario}</p>
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
            <p><b>Fecha de la clase:</b> {clase.horario}</p>
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
            contexto.SaveChanges();
            return true;
        }
        return false;
    }

    //Filtrar reservas del usuario logeado
    public List <ReservaDTO> FiltrarReservas(int id)
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
                ClaseNombre = r.clase.actividad.nombre,
                Estado = r.estado.ToString(),
                FechaClase = r.clase.horario,
                FechaReserva = r.fecha,
            })
            .ToList();
    }
    public List<ReservaAdminDTO> ObtenerTodasParaAdmin()
    {
        using var contexto = new GentefitContext();

        return contexto.Reservas
            .Include(r => r.cliente)
            .Include(r => r.clase)
                .ThenInclude(c => c.actividad)
            .Select(r => new ReservaAdminDTO
            {
                IdReserva = r.idReserva,
                IdCliente = r.idCliente,
                ClienteNombre = r.cliente.nombre + " " + r.cliente.apellidos,
                IdClase = r.idClase,
                ClaseNombre = r.clase.actividad.nombre,
                Estado = r.estado.ToString(),
                FechaReserva = r.fecha
            })
            .ToList();
    }


    public class ReservaAdminDTO
    {
        public int IdReserva { get; set; }
        public int IdCliente { get; set; }
        public string ClienteNombre { get; set; }
        public int IdClase { get; set; }
        public string ClaseNombre { get; set; }
        public string Estado { get; set; }
        public DateTime FechaReserva { get; set; }
    }

    public class ReservaDTO
    {
        public int IdReserva { get; set; }
        public string ClaseNombre { get; set; }
        public DateTime FechaClase { get; set; }
        public DateTime FechaReserva { get; set; }
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
            Fecha = reserva.fecha,
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
            fecha = reservaXml.Fecha,
        };
    }
}
