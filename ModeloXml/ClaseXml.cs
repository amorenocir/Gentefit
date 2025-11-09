using Gentefit.Modelo;
using Gentefit.Modelo.Enums;
using System;
using System.Collections.Generic;

namespace Gentefit.ModeloXml
{
    public class ClaseXml
    {
        public int IdClase { get; set; }
        public int IdActividad { get; set; }
        public Actividad Actividad { get; set; }

        public int IdEntrenador { get; set; }
        public Entrenador Entrenador { get; set; }

        public int IdSala { get; set; }
        public Sala Sala { get; set; }

        public DateTime Horario { get; set; }
        public int PlazasLibres { get; set; }
        public int EnEspera { get; set; }

        public List<Reserva> Reservas { get; set; } = new List<Reserva>();
    }
}
