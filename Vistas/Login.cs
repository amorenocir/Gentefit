using Gentefit.db;
using Gentefit.Modelo;
using Gentefit.Modelo.Enums;
using Gentefit.Vistas.PantallasAdmin;
using Gentefit.Vistas.PantallasRecepcionista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gentefit.Vistas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BotonEntrar_Click(object sender, EventArgs e)
        {
            string email = CajaTextoEmail.Text.Trim();
            string contrasena = CajaTextoContrasena.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Debes ingresar email y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var contexto = new GentefitContext())
            {
                // Buscar en Usuarios
                var usuario = contexto.Usuarios
                    .FirstOrDefault(u => u.email == email && u.contrasena == contrasena);

                if (usuario != null)
                {
                    // Abrir formulario según tipo
                    switch (usuario.rol)
                    {
                        case TipoRol.Admin:
                            new InicioAdmin().Show();
                            break;
                        case TipoRol.Encargado:
                            new InicioEncargado().Show();
                            break;
                        case TipoRol.Recepcionista:
                            new InicioRecepcionista().Show();
                            break;
                    }
                    this.Hide();
                    return;
                }


                // Buscar en Clientes (si no está en Usuarios)
                var cliente = contexto.Clientes
                    .FirstOrDefault(c => c.email == email && c.contrasena == contrasena);

                if (cliente != null)
                {
                    new InicioCliente(cliente).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
