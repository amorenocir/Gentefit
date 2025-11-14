using Gentefit.db;
using Gentefit.Modelo;
using Gentefit.Modelo.Enums;
using Gentefit.ModeloXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Gentefit.Logica
{
    internal class LogicaActividades
    {
        // Obtener todas las actividades
        public List<Actividad> ObtenerTodos()
        {
            using var contexto = new GentefitContext();
            return contexto.Actividades.ToList();
        }

        // Buscar actividad por ID
        public List<Actividad> BuscarPorId(int id)
        {
            using var contexto = new GentefitContext();
            var resultado = contexto.Actividades
                .Where(u => u.idActividad == id)
                .ToList();
            return resultado;
        }

        // Añadir una nueva actividad
        public void AnadirActividad(Actividad nuevaActividad)
        {
            using var contexto = new GentefitContext();
            contexto.Actividades.Add(nuevaActividad);
            contexto.SaveChanges();
        }

        // Modificar una actividad
        public bool Modificar(Actividad actividad)
        {
            using var contexto = new GentefitContext();
            var c = contexto.Actividades.FirstOrDefault(x => x.idActividad == actividad.idActividad);
            if (c == null) return false;

            c.nombre = actividad.nombre;
            c.duracion = actividad.duracion;
            c.intensidad = actividad.intensidad;
            c.descripcion = actividad.descripcion;
 

            contexto.SaveChanges();
            return true;
        }


        // Eliminar actividad por ID
        public bool EliminarActividad(int id)
        {
            using var contexto = new GentefitContext();
            var actividad = contexto.Actividades.Find(id);
            if (actividad != null)
            {
                contexto.Actividades.Remove(actividad);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        // Exportar actividades a XML
        public void ExportarXml(string rutaArchivo)
        {
            var actividades = ObtenerTodos();
            var actividadesXml = actividades.Select(c => ConvertirAXml(c)).ToList();

            XmlSerializer serializer = new XmlSerializer(typeof(List<ActividadXml>));
            using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create))
            {
                serializer.Serialize(fs, actividadesXml);
            }
        }

        // Importar actividades desde XML
        public void ImportarXml(string rutaArchivo)
        {
            using var contexto = new GentefitContext();
            XmlSerializer serializer = new XmlSerializer(typeof(List<ActividadXml>));
            using (FileStream fs = new FileStream(rutaArchivo, FileMode.Open))
            {
                List<ActividadXml> actividadesXml = (List<ActividadXml>)serializer.Deserialize(fs);
                List<Actividad> actividades = actividadesXml.Select(x =>
                {
                    var c = ConvertirAEntidad(x);
                    c.idActividad = 0; // Ignorar el ID del XML
                    return c;
                }).ToList();

                contexto.Actividades.AddRange(actividades);
                contexto.SaveChanges();
            }
        }

        // Conversión Actividad -> ActividadXml
        public static ActividadXml ConvertirAXml(Actividad actividad)
        {
            return new ActividadXml
            {
                Id = actividad.idActividad,
                Nombre = actividad.nombre,
                Duracion = (int)actividad.duracion,
                Intensidad = (int)actividad.intensidad,
                Descripcion = actividad.descripcion,
            };
        }

        // Conversión ActividadXml -> Actividad
        public static Actividad ConvertirAEntidad(ActividadXml actividadXml)
        {
            return new Actividad
            {
                idActividad = actividadXml.Id,
                nombre = actividadXml.Nombre,
                duracion = actividadXml.Duracion,
                intensidad = (Intensidad)actividadXml.Intensidad,
                descripcion = actividadXml.Descripcion,
            };
        }
    }
}
