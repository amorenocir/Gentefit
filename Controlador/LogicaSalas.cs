using Gentefit.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gentefit.Modelo;
using Gentefit.ModeloXml;
using System.Xml.Serialization;

namespace Gentefit.Controlador
{
    internal class LogicaSalas
    {
        //Mostrar todas las salas
        public List<Sala> ObtenerTodos()
        {
            using var contexto = new GentefitContext();
            return contexto.Salas.ToList();
        }

        //Buscar sala por ID
        public List<Sala> BuscarPorId(int id)
        {
            using var contexto = new GentefitContext();
            return contexto.Salas.Where(
                s => s.idSala == id).ToList();
        }

        //Añadir una sala
        public void AnadirSala(Sala nuevaSala)
        {
            using var contexto = new GentefitContext();
            contexto.Salas.Add(nuevaSala);
            contexto.SaveChanges();
        }

        //Modificar una sala
        public bool ModificarSala(Sala sala)
        {
            using var contexto = new GentefitContext();
            var s = contexto.Salas.FirstOrDefault(
                x => x.idSala == sala.idSala);
            if (s == null) return false;

            s.nombre = sala.nombre;
            contexto.SaveChanges();
            return true;
        }

        //Eliminar una sala
        public bool EliminarSala(int id)
        {
            using var contexto = new GentefitContext();
            var sala = contexto.Salas.Find(id);
            if (sala != null)
            {
                contexto.Salas.Remove(sala);
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
}
