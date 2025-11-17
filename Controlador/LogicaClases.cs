using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gentefit.db;
using Gentefit.Modelo;
using Gentefit.Modelo.Enums;
using Microsoft.EntityFrameworkCore;

namespace Gentefit.Controlador
{
    internal class LogicaClases
    {
        //Obtener todas las clases
        public List<Clase> ListarClases()
        {
            using var contexto = new GentefitContext();
            return contexto.Clases.ToList();
        }

        //Buscar clase por ID
        public List<Clase> BuscarPorId(int id)
        {
            using var contexto = new GentefitContext();
            return contexto.Clases.Where(c => c.idClase == id).ToList();
        }

        // Obtener las clases disponibles:
        public List<ClaseDTO> ObtenerClasesDisponibles()
        {
            using var contexto = new GentefitContext();
            return contexto.Clases
                .Include(c => c.actividad)
                .Include(c => c.entrenador)
                .Include(c => c.sala)
                .OrderBy(c => c.horario)
                .Select(c => new ClaseDTO
                {
                    IdClase = c.idClase,
                    IdActividad = c.idActividad,
                    NombreActividad = c.actividad.nombre,
                    NombreEntrenador = c.entrenador.nombre,
                    NombreSala = c.sala.nombre,
                    Horario = c.horario,
                    Dia = c.dia,
                    Hora = c.hora,
                    PlazasLibres = c.plazasLibres,
                })
                .ToList();
        }

        //Añadir una nueva clase
        public void AddClase(Clase clase)
        {
            using var contexto = new GentefitContext();
            contexto.Clases.Add(clase);
            contexto.SaveChanges();
        }

        //Modificar una clase
        public bool Modificar(Clase clase)
        {
            using var contexto = new GentefitContext();
            var c = contexto.Clases.FirstOrDefault(x => x.idClase == clase.idClase);
            if (c == null) return false;

            c.idActividad = clase.idActividad;
            c.idEntrenador = clase.idEntrenador;
            c.idSala = clase.idSala;
            c.dia = clase.dia;
            c.hora = clase.hora;

            contexto.SaveChanges();
            return true;
        }

        //Eliminar clase
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
                    IdActividad = c.idActividad,
                    NombreActividad = c.actividad.nombre,
                    NombreEntrenador = c.entrenador.nombre,
                    NombreSala = c.sala.nombre,
                    Dia = (Dia)c.horario.DayOfWeek,
                    Horario = c.horario,
                    Hora = TimeOnly.FromDateTime(c.horario),
                    PlazasLibres = c.plazasLibres,
                    EnEspera = c.enEspera
                })
                .ToList();
        }

        // Estructura para mostrar la clase al cliente.
        public class ClaseDTO
        {
            public int IdClase { get; set; }
            public int IdActividad { get; set; }
            public string NombreActividad { get; set; }
            public string NombreEntrenador { get; set; }
            public string NombreSala { get; set; }
            public DateTime Horario { get; set; }
            public Dia Dia { get; set; }
            public TimeOnly Hora { get; set; }
            public int PlazasLibres { get; set; }
            public int EnEspera { get; set; }
        }

        // Buscar clase por ID
        public List<ClaseDTO> BuscarDTOPorId(int id)
        {
            using var contexto = new GentefitContext();
            return contexto.Clases
                .Where(c => c.idClase == id)
                .Include(c => c.actividad)
                .Include(c => c.entrenador)
                .Include(c => c.sala)
                .Select(c => new ClaseDTO
                {
                    IdClase = c.idClase,
                    NombreActividad = c.actividad.nombre,
                    NombreEntrenador = c.entrenador.nombre,
                    NombreSala = c.sala.nombre,
                    //Horario = c.horario,
                    PlazasLibres = c.plazasLibres,
                    //EnEspera = c.enEspera
                })
                .ToList();
        }
    }
}
