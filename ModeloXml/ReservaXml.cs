using Gentefit.Modelo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gentefit.Modelo;

namespace Gentefit.ModeloXml
{
    public class ReservaXml
    {
        public int IdReserva { get; set; }
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public int IdClase { get; set; }
        public Clase Clase { get; set; }
        public EstadoReserva Estado { get; set; }
        public DateTime Fecha { get; set; }
    }
}
