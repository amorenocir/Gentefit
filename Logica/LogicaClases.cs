using Gentefit.db;
using Gentefit.Modelo;
using Gentefit.ModeloXml;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.IO;

public class LogicaClases
{
    // Obtener todas las clases
    public List<Clase> ObtenerTodos()
    {
        using var contexto = new GentefitContext();
        return contexto.Clases
            .Include(c => c.actividad)
            .Include(c => c.entrenador)
            .Include(c => c.sala)
            .ToList();
    }

    // Obtener las clases disponibles:
    public List<ClaseDTO> ObtenerClasesDisponibles()
    {
        using var contexto = new GentefitContext();
        return contexto.Clases
            .Include(c => c.actividad)
            .Include(c => c.entrenador)
            .Include(c => c.sala)

            .Select(c => new ClaseDTO
            {
                IdClase = c.idClase,
                NombreActividad = c.actividad.nombre,
                NombreEntrenador = c.entrenador.nombre,
                NombreSala = c.sala.nombre,
                Horario = c.horario,
                PlazasLibres = c.plazasLibres,
                EnEspera = c.enEspera
            })
            .ToList();
    }

    // Estructura para mostrar la clase al cliente.
    public class ClaseDTO
    {
        public int IdClase { get; set; }
        public string NombreActividad { get; set; }
        public string NombreEntrenador { get; set; }
        public string NombreSala { get; set; }
        public DateTime Horario { get; set; }
        public int PlazasLibres { get; set; }
        public int EnEspera { get; set; }
    }

    // Buscar clase por ID
    public Clase BuscarPorId(int id)
    {
        using var contexto = new GentefitContext();
        return contexto.Clases
            .Include(c => c.actividad)
            .Include(c => c.entrenador)
            .Include(c => c.sala)
            .FirstOrDefault(c => c.idClase == id);
    }

    // Añadir una nueva clase
    public void GuardarClase(Clase nuevaClase)
    {
        using var contexto = new GentefitContext();
        contexto.Clases.Add(nuevaClase);
        contexto.SaveChanges();
    }

    // Modificar una clase
    public bool ModificarClase(Clase clase)
    {
        using var contexto = new GentefitContext();
        var c = contexto.Clases.FirstOrDefault(x => x.idClase == clase.idClase);
        if (c == null) return false;

        c.idActividad = clase.idActividad;
        c.idEntrenador = clase.idEntrenador;
        c.idSala = clase.idSala;
        c.horario = clase.horario;
        c.plazasLibres = clase.plazasLibres;
        c.enEspera = clase.enEspera;

        contexto.SaveChanges();
        return true;
    }

    // Eliminar clase por ID
    public bool EliminarClase(int id)
    {
        using var contexto = new GentefitContext();
        var clase = contexto.Clases.Find(id);
        if (clase != null)
        {
            contexto.Clases.Remove(clase);
            contexto.SaveChanges();
            return true;
        }
        return false;
    }

    // Filtrar clases por actividad
    public List<ClaseDTO> FiltrarPorActividad(int idActividad)
    {
        using var contexto = new GentefitContext();
        return contexto.Clases
            .Where(c => c.idActividad == idActividad)
            .Include(c => c.actividad)
            .Include(c => c.entrenador)
            .Include(c => c.sala)
            .Select(c => new ClaseDTO
            {
                IdClase = c.idClase,
                NombreActividad = c.actividad.nombre,
                NombreEntrenador = c.entrenador.nombre,
                NombreSala = c.sala.nombre,
                Horario = c.horario,
                PlazasLibres = c.plazasLibres,
                EnEspera = c.enEspera
            })
            .ToList();
    }


    // Exportar clases a XML
    public void ExportarXmlClases(string rutaArchivo)
    {
        var clases = ObtenerTodos();
        var clasesXml = clases.Select(c => ConvertirAXml(c)).ToList();

        XmlSerializer serializer = new XmlSerializer(typeof(List<ClaseXml>));
        using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create))
        {
            serializer.Serialize(fs, clasesXml);
        }
    }

    // Importar clases desde XML
    public void ImportarXmlClases(string rutaArchivo)
    {
        using var contexto = new GentefitContext();
        XmlSerializer serializer = new XmlSerializer(typeof(List<ClaseXml>));
        using (FileStream fs = new FileStream(rutaArchivo, FileMode.Open))
        {
            List<ClaseXml> clasesXml = (List<ClaseXml>)serializer.Deserialize(fs);
            List<Clase> clases = clasesXml.Select(x =>
            {
                var c = ConvertirAEntidad(x);
                c.idClase = 0; // Ignorar el ID del XML
                return c;
            }).ToList();

            contexto.Clases.AddRange(clases);
            contexto.SaveChanges();
        }
    }

    // Conversión Clase -> ClaseXml
    public static ClaseXml ConvertirAXml(Clase clase)
    {
        return new ClaseXml
        {
            IdClase = clase.idClase,
            IdActividad = clase.idActividad,
            Actividad = clase.actividad,
            IdEntrenador = clase.idEntrenador,
            Entrenador = clase.entrenador,
            IdSala = clase.idSala,
            Sala = clase.sala,
            Horario = clase.horario,
            PlazasLibres = clase.plazasLibres,
            EnEspera = clase.enEspera,
            Reservas = clase.reservas
        };
    }

    // Conversión ClaseXml -> Clase
    public static Clase ConvertirAEntidad(ClaseXml claseXml)
    {
        return new Clase
        {
            idClase = claseXml.IdClase,
            idActividad = claseXml.IdActividad,
            actividad = claseXml.Actividad,
            idEntrenador = claseXml.IdEntrenador,
            entrenador = claseXml.Entrenador,
            idSala = claseXml.IdSala,
            sala = claseXml.Sala,
            horario = claseXml.Horario,
            plazasLibres = claseXml.PlazasLibres,
            enEspera = claseXml.EnEspera,
            reservas = claseXml.Reservas
        };
    }
}

