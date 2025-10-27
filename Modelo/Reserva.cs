using System;
using System.Collections.Generic;

namespace Gentefit.Modelo;

public partial class Reserva
{
    public int Id { get; set; }

    public int Cliente { get; set; }

    public string Clase { get; set; } = null!;

    public DateTime FechaSolicitud { get; set; }

    public string Estado { get; set; } = null!;

    public virtual Cliente ClienteNavigation { get; set; } = null!;

    public virtual ICollection<EstadoReserva> EstadoReservas { get; set; } = new List<EstadoReserva>();
}
