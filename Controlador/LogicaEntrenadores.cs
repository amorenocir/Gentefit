using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Gentefit.db;
using Gentefit.Modelo;
using Gentefit.ModeloXml;

namespace Gentefit.Controlador
{
    internal class LogicaEntrenadores
    {
        //Obtener todos los entrenadores
        public List<Entrenador> ObtenerTodos()
        {
            using var contexto = new GentefitContext();
            return contexto.Entrenadores.ToList();
        }

        //Buscar entrenador por ID
        public List<Entrenador> BuscarPorId(int id)
        {
            using var contexto = new GentefitContext();
            return contexto.Entrenadores
                .Where(c => c.idEntrenador == id).ToList();
        }

        //Añadir un nuevo entrenador
        public void AnadirEntrenador(Entrenador nuevoEntrenador)
        {
            using var contexto = new GentefitContext();
            contexto.Entrenadores.Add(nuevoEntrenador);
            contexto.SaveChanges();
        }

        //Modificar entrenador
        public bool ModificarEntrenador(Entrenador entrenador)
        {
            using var contexto = new GentefitContext();
            var c = contexto.Entrenadores.
                FirstOrDefault(
                x => x.idEntrenador == entrenador.idEntrenador);
            if (c == null) return false;

            c.nombre = entrenador.nombre;
            c.apellidos = entrenador.apellidos;
            c.dni = entrenador.dni;
            contexto.SaveChanges();
            return true;
        }

        //Eliminar entrenador por ID
        public bool EliminarEntrenador(int id)
        {
            using var contexto = new GentefitContext();
            var entrenador = contexto.Entrenadores.Find(id);
            if(entrenador != null)
            {
                contexto.Entrenadores.Remove(entrenador);
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
}
