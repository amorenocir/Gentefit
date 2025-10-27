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

namespace Gentefit.Vistas.Admin
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
                Nombre = CajaTextoNombre.Text,
                Apellidos = CajaTextoApellidos.Text,
                Dni = CajaTextoDNI.Text,
                Telefono = int.Parse(CajaTextoTelefono.Text),
                Email = CajaTextoEmail.Text,
                Contrasena = CajaTextoContrasena.Text,
                Gimnasio = "Gentefit"
            };

            // Insertar en la base de datos usando EF Core
            using (var contexto = new GentefitContext())
            {
                contexto.Clientes.Add(nuevoCliente);
                contexto.SaveChanges();
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
