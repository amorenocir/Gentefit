using Gentefit.db;
using Gentefit.Modelo;
using Gentefit.ModeloXml;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

public class LogicaSalas
{

    // Obtener todos los Salas
    public List<Sala> ObtenerTodos()
    {
        using var contexto = new GentefitContext();
        return contexto.Salas.ToList();
    }

    // Buscar Sala por ID
    public List<Sala> BuscarPorId(int id)
    {
        using var contexto = new GentefitContext();
        var resultado = contexto.Salas
            .Where(u => u.idSala == id)
            .ToList();
        return resultado;
    }

    // Añadir un nuevo Sala
    public void AnadirSala(Sala nuevoSala)
    {
        using var contexto = new GentefitContext();
        contexto.Salas.Add(nuevoSala);
        contexto.SaveChanges();
    }

    // Modificar un Sala
    public bool Modificar(Sala Sala)
    {
        using var contexto = new GentefitContext();
        var c = contexto.Salas.FirstOrDefault(x => x.idSala == Sala.idSala);
        if (c == null) return false;

        c.nombre = Sala.nombre;

        contexto.SaveChanges();
        return true;
    }


    // Eliminar Sala por ID
    public bool EliminarSala(int id)
    {
        using var contexto = new GentefitContext();
        var Sala = contexto.Salas.Find(id);
        if (Sala != null)
        {
            contexto.Salas.Remove(Sala);
            contexto.SaveChanges();
            return true;
        }
        return false;
    }

    // Exportar Salas a XML
    public void ExportarXml(string rutaArchivo)
    {
        var Salas = ObtenerTodos();
        var SalasXml = Salas.Select(c => ConvertirAXml(c)).ToList();

        XmlSerializer serializer = new XmlSerializer(typeof(List<SalaXml>));
        using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create))
        {
            serializer.Serialize(fs, SalasXml);
        }
    }

    // Importar Salas desde XML
    public void ImportarXml(string rutaArchivo)
    {
        using var contexto = new GentefitContext();
        XmlSerializer serializer = new XmlSerializer(typeof(List<SalaXml>));
        using (FileStream fs = new FileStream(rutaArchivo, FileMode.Open))
        {
            List<SalaXml> SalasXml = (List<SalaXml>)serializer.Deserialize(fs);
            List<Sala> Salas = SalasXml.Select(x =>
            {
                var c = ConvertirAEntidad(x);
                c.idSala = 0; // Ignorar el ID del XML
                return c;
            }).ToList();

            contexto.Salas.AddRange(Salas);
            contexto.SaveChanges();
        }
    }

    // Conversión Sala -> SalaXml
    public static SalaXml ConvertirAXml(Sala Sala)
    {
        return new SalaXml
        {
            Id = Sala.idSala,
            Nombre = Sala.nombre,
        };
    }

    // Conversión SalaXml -> Sala
    public static Sala ConvertirAEntidad(SalaXml SalaXml)
    {
        return new Sala
        {
            idSala = SalaXml.Id,
            nombre = SalaXml.Nombre,
        };
    }
}


