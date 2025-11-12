using Gentefit.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gentefit.db;

namespace Gentefit.Vistas.PantallasAdmin
{
    public partial class AnadirCliente : Form
    {
        public AnadirCliente()
        {
            InitializeComponent();
        }

        private void BotonAnadir_Click(object sender, EventArgs e)
        {
            // Recoger los datos del formulario
            Cliente nuevoCliente = new Cliente
            {
                nombre = CajaTextoNombre.Text,
                apellidos = CajaTextoApellidos.Text,
                dni = CajaTextoDNI.Text,
                telefono = int.Parse(CajaTextoTelefono.Text),
                email = CajaTextoEmail.Text,
                contrasena = CajaTextoContrasena.Text,
            };

            // Insertar en la base de datos usando EF Core
            using (var contexto = new GentefitContext())
            {
                var logica = new LogicaClientes();
                logica.AnadirCliente(nuevoCliente);
            }

            MessageBox.Show("Cliente añadido correctamente");
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuAdClientes().Show();

        }
    }
}
