using Gentefit.db;
using Gentefit.Modelo;
using Gentefit.ModeloXml;
using System.Collections.Generic;
using System.Linq;
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

    // Añadir una nueva reserva
    public void AnadirReserva(Reserva nuevaReserva)
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
        c.cliente = reserva.cliente;
        c.idClase = reserva.idClase;
        c.clase = reserva.clase;
        c.estado = reserva.estado;
        c.fecha = reserva.fecha;

        contexto.SaveChanges();
        return true;
    }


    // Eliminar reserva por ID
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
