using System;
using System.Collections.Generic;

namespace Gentefit.Modelo;

public partial class Clase
{
    public int Id { get; set; }

    public int Actividad { get; set; }

    public DateTime Horario { get; set; }

    public int Monitor { get; set; }

    public int Sala { get; set; }

    public int PlazasLibres { get; set; }

    public int? ListaDeEspera { get; set; }

    public virtual Actividad ActividadNavigation { get; set; } = null!;

    public virtual Monitor MonitorNavigation { get; set; } = null!;

    public virtual Sala SalaNavigation { get; set; } = null!;
}
