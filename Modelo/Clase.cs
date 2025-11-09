using Gentefit.Modelo.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gentefit.Modelo
{
    public class Clase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id_clase")]
        public int idClase { get; set; }

        [ForeignKey("actividad")]
        [Column("id_actividad")]
        public int idActividad { get; set; }
        public Actividad actividad { get; set; }
      
        [ForeignKey("entrenador")]
        [Column("id_entrenador")]
        public int idEntrenador { get; set; }
        public Entrenador entrenador { get; set; }

        [ForeignKey("sala")]
        [Column("id_sala")]
        public int idSala { get; set; }
        public Sala sala { get; set; }

        public DateTime horario { get; set; }
        public int plazasLibres { get; set; }
        public int enEspera { get; set; }

        public List<Reserva> reservas { get; set; } = new List<Reserva>();

        [NotMapped]
        public List<Reserva> registrados =>
            reservas.Where(r => r.estado == EstadoReserva.Confirmada).ToList();

        [NotMapped]
        public List<Reserva> listaEspera =>
            reservas.Where(r => r.estado == EstadoReserva.EnEspera).ToList();

        public Clase() { }
    }
}
