using System;
using System.Collections.Generic;

namespace Gentefit.Modelo;

public partial class Sala
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string Gimnasio { get; set; } = null!;

    public virtual ICollection<Clase> Clases { get; set; } = new List<Clase>();

    public virtual Gimnasio GimnasioNavigation { get; set; } = null!;
}
