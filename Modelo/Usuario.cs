
using Gentefit.Modelo.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gentefit.Modelo
{

    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idUsuario { get; set; }
        [Required, MaxLength(50)]
        public string nombre { get; set; } = null!;
        [Required, MaxLength(100)]
        public string apellidos { get; set; } = null!;
        [Required, MaxLength(150)]
        public string email { get; set; } = null!;
        [Required, MaxLength(50)]
        public string contrasena { get; set; } = null!;
        public TipoRol rol { get; set; }


        public Usuario() { }
    }
}
