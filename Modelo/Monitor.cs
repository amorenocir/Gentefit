using System;
using System.Collections.Generic;

namespace Gentefit.Modelo;

public partial class Monitor
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Dni { get; set; } = null!;

    public string Gimnasio { get; set; } = null!;

    public virtual ICollection<Clase> Clases { get; set; } = new List<Clase>();

    public virtual Gimnasio GimnasioNavigation { get; set; } = null!;
}
