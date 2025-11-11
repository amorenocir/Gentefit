using Gentefit.db;
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
            Application.Run(new Login());
            //Application.Run(new MenuAdmin()); //Run de pruebas para saltarse el login e ir a admin

            using var contexto = new GentefitContext();
            var cliente = contexto.Clientes.FirstOrDefault(); // obtiene el primero existente
            /*
            if (cliente != null)
            {
                // ?? Pasamos ese cliente al menú del cliente
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