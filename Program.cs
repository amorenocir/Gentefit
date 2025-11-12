
using Gentefit.Modelo;
using Gentefit.db;
using Gentefit.Test;
using Gentefit.Vistas;
using Gentefit.Vistas.PantallasAdmin;


namespace Gentefit
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
            //Application.Run(new MenuAdmin()); //Run de pruebas para saltarse el login e ir a admin
            
            var clienteTest = new Cliente //Cliente falso de prueba para poder acceder sin pasar por login y agilizar testeo
            {
                idCliente = 1,
                nombre = "Usuario",
                apellidos = "Test Prueba",
                dni = "00000000A",
                email = "prueba@test.com",
                contrasena = "1234",
                telefono = 600000000,
                listaReservas = new List<Reserva>()
            };
            //Application.Run(new MenuCliente(clienteTest)); //Saltarse login e ir a cliente


            using var contexto = new GentefitContext();
            var cliente = contexto.Clientes.FirstOrDefault(); // obtiene el primero existente
            /*
            if (cliente != null)
            {
                // ?? Pasamos ese cliente al men� del cliente
                Application.Run(new MenuCliente(cliente));
            }
            else
            {
                MessageBox.Show("No hay clientes en la base de datos.");
            }
            Application.Run(new MenuCliente(cliente)); //Saltarse login e ir a cliente
            */
        }
    }
}