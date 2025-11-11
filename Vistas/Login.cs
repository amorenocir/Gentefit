using Gentefit.db;
using Gentefit.Modelo;
using Gentefit.Modelo.Enums;
using Gentefit.Vistas.Admin;
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
                var usuarioAdmin = contexto.Usuarios
                    .FirstOrDefault(u => u.email == email && u.contrasena == contrasena);

                if (usuarioAdmin != null)
                {
                    // Abrir formulario según tipo
                    switch (usuarioAdmin.rol)
                    {
                        case TipoRol.Admin:
                            new MenuAdmin().Show();
                            break;
                        case TipoRol.Encargado:
                            new MenuEncargado().Show();
                            break;
                        case TipoRol.Recepcionista:
                            new MenuRecepcionista().Show();
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
                    new MenuCliente().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
