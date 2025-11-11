using Gentefit.db;
using Gentefit.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gentefit.Controlador
{
    internal class LogicaActividades
    {
        //Obtener todas las actividades
        public List<Actividad> MostrarLista()
        {
            using var contexto = new GentefitContext();
            return contexto.Actividades.ToList();
        }

        //Añadir una nueva actividad
        public void AddActividad(Actividad nuevaActividad)
        {
            using var contexto = new GentefitContext();
            contexto.Actividades.Add(nuevaActividad);
            contexto.SaveChanges();
        }

        //Modificar una actividad
        public bool Modificar(Actividad actividad)
        {
            using var contexto = new GentefitContext();
            var c = contexto.Actividades.FirstOrDefault(x => x.idActividad == actividad.idActividad);
            if (c == null) return false;

            c.nombre = actividad.nombre;
            c.duracion = actividad.duracion;
            c.descripcion = actividad.descripcion;
            c.intensidad = actividad.intensidad;

            contexto.SaveChanges();
            return true;
        }
    }
}
