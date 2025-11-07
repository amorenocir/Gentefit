using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gentefit.Modelo
{
    public class Entrenador
    {
        [Key]
        public string idEntrenador { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string dni { get; set; }
        public List<Clase> listaClases { get; set; }

        public Entrenador(string idEntrenador, string nombre, string apellidos, string dni, List<Clase> listaClases)
        {
            this.idEntrenador = idEntrenador;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.listaClases = listaClases;
        }

        public Entrenador(string idEntrenador, string nombre, string apellidos, string dni)
        {
            this.idEntrenador = idEntrenador;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
        }

        public Entrenador()
        {
        }
    }
}
