using System;
using System.Collections.Generic;

namespace Gentefit.Modelo;

public partial class Cliente
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Dni { get; set; } = null!;

    public int Telefono { get; set; }

    public string Email { get; set; } = null!;

    public string Contrasena { get; set; } = null!;

    public string Gimnasio { get; set; } = null!;

    public virtual Gimnasio GimnasioNavigation { get; set; } = null!;

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
}
