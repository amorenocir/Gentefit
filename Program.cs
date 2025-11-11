using Gentefit.Modelo;
using Gentefit.Test;
using Gentefit.Vistas;
using Gentefit.Vistas.PantallasAdmin;


namespace Gentefit
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Login());
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
            Application.Run(new MenuCliente(clienteTest)); //Saltarse login e ir a cliente
        }
    }
}