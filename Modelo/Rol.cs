using System;
using System.Collections.Generic;

namespace Gentefit.Modelo;

public partial class Rol
{
    public int Id { get; set; }
    public string TipoRol { get; set; }
    public virtual ICollection<Usuario> Usuarios { get; set; }
}

