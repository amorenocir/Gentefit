using System;
using System.Collections.Generic;

namespace Gentefit.Modelo;

public partial class Rol
{
    public int Id { get; set; }

    public string TipoRol { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
