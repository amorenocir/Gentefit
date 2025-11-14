using Gentefit.db;
using Gentefit.Modelo;
using Gentefit.ModeloXml;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

public class LogicaEntrenadores
{

    // Obtener todos los Entrenadores
    public List<Entrenador> ObtenerTodos()
    {
        using var contexto = new GentefitContext();
        return contexto.Entrenadores.ToList();
    }

    // Buscar Entrenador por ID
    public List<Entrenador> BuscarPorId(int id)
    {
        using var contexto = new GentefitContext();
        var resultado = contexto.Entrenadores
            .Where(u => u.idEntrenador == id)
            .ToList();
        return resultado;
    }

    // Añadir un nuevo Entrenador
    public void AnadirEntrenador(Entrenador nuevoEntrenador)
    {
        using var contexto = new GentefitContext();
        contexto.Entrenadores.Add(nuevoEntrenador);
        contexto.SaveChanges();
    }

    // Modificar un Entrenador
    public bool Modificar(Entrenador Entrenador)
    {
        using var contexto = new GentefitContext();
        var c = contexto.Entrenadores.FirstOrDefault(x => x.idEntrenador == Entrenador.idEntrenador);
        if (c == null) return false;

        c.nombre = Entrenador.nombre;
        c.apellidos = Entrenador.apellidos;
        c.dni = Entrenador.dni;

        contexto.SaveChanges();
        return true;
    }


    // Eliminar Entrenador por ID
    public bool EliminarEntrenador(int id)
    {
        using var contexto = new GentefitContext();
        var Entrenador = contexto.Entrenadores.Find(id);
        if (Entrenador != null)
        {
            contexto.Entrenadores.Remove(Entrenador);
            contexto.SaveChanges();
            return true;
        }
        return false;
    }

    // Exportar Entrenadores a XML
    public void ExportarXml(string rutaArchivo)
    {
        var Entrenadores = ObtenerTodos();
        var EntrenadoresXml = Entrenadores.Select(c => ConvertirAXml(c)).ToList();

        XmlSerializer serializer = new XmlSerializer(typeof(List<EntrenadorXML>));
        using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create))
        {
            serializer.Serialize(fs, EntrenadoresXml);
        }
    }

    // Importar Entrenadores desde XML
    public void ImportarXml(string rutaArchivo)
    {
        using var contexto = new GentefitContext();
        XmlSerializer serializer = new XmlSerializer(typeof(List<EntrenadorXML>));
        using (FileStream fs = new FileStream(rutaArchivo, FileMode.Open))
        {
            List<EntrenadorXML> EntrenadoresXml = (List<EntrenadorXML>)serializer.Deserialize(fs);
            List<Entrenador> Entrenadores = EntrenadoresXml.Select(x =>
            {
                var c = ConvertirAEntidad(x);
                c.idEntrenador = 0; // Ignorar el ID del XML
                return c;
            }).ToList();

            contexto.Entrenadores.AddRange(Entrenadores);
            contexto.SaveChanges();
        }
    }

    // Conversión Entrenador -> EntrenadorXml
    public static EntrenadorXML ConvertirAXml(Entrenador Entrenador)
    {
        return new EntrenadorXML
        {
            Id = Entrenador.idEntrenador,
            Nombre = Entrenador.nombre,
            Apellidos = Entrenador.apellidos,
            Dni = Entrenador.dni,
        };
    }

    // Conversión EntrenadorXml -> Entrenador
    public static Entrenador ConvertirAEntidad(EntrenadorXML EntrenadorXml)
    {
        return new Entrenador
        {
            idEntrenador = EntrenadorXml.Id,
            nombre = EntrenadorXml.Nombre,
            apellidos = EntrenadorXml.Apellidos,
            dni = EntrenadorXml.Dni,
        };
    }
}


