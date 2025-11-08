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
            Application.Run(new MenuCliente()); //Saltarse login e ir a cliente
        }
    }
}