using Gentefit.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gentefit.Modelo.Enums;

namespace Gentefit.Modelo
{
    public class Actividad
    {
        [Key]
        public int idActividad { get; set; }
        public string nombre { get; set; }
        public int duracion { get; set; }
        public string descripcion { get; set; }
        public Intensidad intensidad { get; set; }
        public List<Clase> listaClases { get; set; }

        public Actividad(int idActividad, string nombre, int duracion, string descripcion, Intensidad intensidad, List<Clase> listaClases)
        {
            this.idActividad = idActividad;
            this.nombre = nombre;
            this.duracion = duracion;
            this.descripcion = descripcion;
            this.intensidad = intensidad;
            this.listaClases = listaClases;
        }

        public Actividad(int idActividad, string nombre, int duracion, string descripcion, Intensidad intensidad)
        {
            this.idActividad = idActividad;
            this.nombre = nombre;
            this.duracion = duracion;
            this.descripcion = descripcion;
            this.intensidad = intensidad;
        }

        public Actividad()
        {
        }
    }
}