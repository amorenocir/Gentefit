using Gentefit.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gentefit.Modelo
{
    public class Cliente
    {
        [Key]
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string dni { get; set; }
        public string email { get; set; }
        public string contrasena { get; set; }
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
