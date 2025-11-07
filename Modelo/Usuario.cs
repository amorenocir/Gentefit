
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gentefit.Modelo;

namespace Gentefit.Modelo
{

    public class Usuario
    {
        [Key]
        public int idUsuario { get; set; }

        public string nombre { get; set; } = null!;

        public string apellidos { get; set; } = null!;

        public string email { get; set; } = null!;

        public string contrasena { get; set; } = null!;

        public int idRol { get; set; }
        public virtual Rol idRolNavigation { get; set; }


        public Usuario() { }
    }
}
