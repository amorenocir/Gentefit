using Gentefit.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gentefit.Modelo
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idCliente { get; set; }
        [Required, MaxLength(50)]
        public string nombre { get; set; }
        [Required, MaxLength(100)]
        public string apellidos { get; set; }
        [Required, MaxLength(15)]
        public string dni { get; set; }
        [Required, MaxLength(150)]
        public string email { get; set; }
        [Required, MaxLength(50)]
        public string contrasena { get; set; }
        [Required, MaxLength(20)]
        public int telefono { get; set; }
        public List<Reserva> listaReservas { get; set; }

        public Cliente(int idCliente, string nombre, string apellidos, string dni, string email, string contrasena, int telefono, List<Reserva> listaReservas)
        {
            this.idCliente = idCliente;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.email = email;
            this.contrasena = contrasena;
            this.telefono = telefono;
            this.listaReservas = listaReservas;
        }

        public Cliente(int idCliente, string nombre, string apellidos, string dni, string email, string contrasena, int telefono)
        {
            this.idCliente = idCliente;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.email = email;
            this.contrasena = contrasena;
            this.telefono = telefono;
        }

        public Cliente()
        {
        }
    }
}
