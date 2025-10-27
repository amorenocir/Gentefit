using System;
using System.Collections.Generic;

namespace Gentefit.Modelo;

public partial class EstadoReserva
{
    public int Id { get; set; }

    public string Estado { get; set; } = null!;

    public int? Reserva { get; set; }

    public virtual Reserva? ReservaNavigation { get; set; }
}
