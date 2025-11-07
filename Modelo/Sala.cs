using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gentefit.Modelo
{
    public class Sala
    {
        [Key]
        public string idSala { get; set; }
        public string nombre { get; set; }
        public List<Clase> listaClases { get; set; }

        public Sala(string idSala, string nombre, List<Clase> listaClases)
        {
            this.idSala = idSala;
            this.nombre = nombre;
            this.listaClases = listaClases;
        }

        public Sala(string idSala, string nombre)
        {
            this.idSala = idSala;
            this.nombre = nombre;
        }

        public Sala()
        {
        }
    }
}
