using Gentefit.db;
using Gentefit.Modelo;
using Gentefit.Modelo.Enums;
using Gentefit.ModeloXml;
using Microsoft.EntityFrameworkCore;
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
            clase.enEspera++;
            nuevaReserva.estado = EstadoReserva.EnEspera; // en espera
        }

        // Guardar la reserva
        GuardarReserva(nuevaReserva);

        // Guardar los cambios en la clase (plazas libres y plazas en espera)
        contexto.SaveChanges();

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
    public bool ModificarReserva(Reserva reserva)
    {
        using var contexto = new GentefitContext();
        var c = contexto.Reservas.FirstOrDefault(x => x.idReserva == reserva.idReserva);
        if (c == null) return false;

        c.idCliente = reserva.idCliente;
        c.idClase = reserva.idClase;
        c.estado = reserva.estado;
        c.fecha = reserva.fecha;

        contexto.SaveChanges();
        return true;
    }

    // Cancelar una reserva
    public bool CancelarReserva(int idReserva)
    {
        using var contexto = new GentefitContext();

        // Obtener la reserva con su clase
        var reserva = contexto.Reservas
            .Include(r => r.clase)
            .FirstOrDefault(r => r.idReserva == idReserva);

        if (reserva == null) return false;
        
        var clase = reserva.clase;
        bool estabaConfirmada = reserva.estado == EstadoReserva.Confirmada;
      
        // Si estaba confirmada, gestionar lista de espera antes de eliminar
        if (estabaConfirmada)
        {
            // Buscar la reserva en espera más antigua
            var primeraEnEspera = contexto.Reservas
                .Where(r => r.idClase == clase.idClase && r.estado == EstadoReserva.EnEspera)
                .OrderBy(r => r.fecha)
                .FirstOrDefault();

            if (primeraEnEspera != null)
            {
                // Cambiar a confirmada
                primeraEnEspera.estado = EstadoReserva.Confirmada;
                clase.enEspera--;
            }
            else
            {
                // No hay lista de espera → liberar plaza
                clase.plazasLibres++;
            }
            MessageBox.Show("Reserva cancelada",
                    "Reserva cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            // Estaba en espera
            clase.enEspera--;
            MessageBox.Show("Reserva en espera cancelada.",
                "Reserva cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Cambiar estado a cancelada
        reserva.estado = EstadoReserva.Cancelada;

        // Guardar cambio inicial
        contexto.SaveChanges();

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
