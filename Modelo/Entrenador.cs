using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gentefit.Modelo
{
    public class Entrenador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idEntrenador { get; set; }
        [Required, MaxLength(50)]
        public string nombre { get; set; }
        [Required, MaxLength(100)]
        public string apellidos { get; set; }
        [Required, MaxLength(15)]
        public string dni { get; set; }
        public List<Clase> listaClases { get; set; }

        public Entrenador(int idEntrenador, string nombre, string apellidos, string dni, List<Clase> listaClases)
        {
            this.idEntrenador = idEntrenador;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.listaClases = listaClases;
        }

        public Entrenador(int idEntrenador, string nombre, string apellidos, string dni)
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
