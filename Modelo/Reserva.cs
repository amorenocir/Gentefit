using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gentefit.Modelo
{
    public class Reserva
    {
        [Key]
        public int idReserva { get; set; }

        [Column("id_cliente")]
        public int idCliente { get; set; }
        public Cliente cliente { get; set; }

        [Column("id_clase")]
        public string idClase { get; set; }
        public Clase clase { get; set; }

        public EstadoReserva estado { get; set; }

        public DateTime fecha { get; set; }

        public Reserva() { }
    }
}

