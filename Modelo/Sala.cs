using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gentefit.Modelo
{
    public class Sala
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id_sala")]
        public int idSala { get; set; }
        [Required, MaxLength(50)]
        public string nombre { get; set; }
        public List<Clase> listaClases { get; set; } = new List<Clase>();

        public Sala(int idSala, string nombre, List<Clase> listaClases)
        {
            this.idSala = idSala;
            this.nombre = nombre;
            this.listaClases = listaClases;
        }

        public Sala(int idSala, string nombre)
        {
            this.idSala = idSala;
            this.nombre = nombre;
        }

        public Sala()
        {
        }
    }
}
