using Gentefit.Modelo;
using Gentefit.Modelo.Enums;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Gentefit.Test
{
    public partial class TestValidacionesUsuario : Form
    {
        public TestValidacionesUsuario()
        {
            InitializeComponent();
        }

        private void TestValidacionesUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnValidarEmail_Click(object sender, EventArgs e)
        {
            string email = "usuario@correo.com";

            bool valido = Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            MessageBox.Show(valido ?
                "V Email válido" :
                "X Email inválido");
        }

        private void btnValidarContrasena_Click(object sender, EventArgs e)
        {
            string pass = "12345";

            bool valido = pass.Length >= 6;

            MessageBox.Show(valido ?
                "✔ Contraseña válida" :
                "❌ La contraseña debe tener mínimo 6 caracteres");
        }

        private void btnValidarNombre_Click(object sender, EventArgs e)
        {
            string nombre = "";

            bool valido = !string.IsNullOrWhiteSpace(nombre);

            MessageBox.Show(valido ?
                "V Nombre válido" :
                "X El nombre no puede estar vacío");
        }

        private void btnValidarRol_Click(object sender, EventArgs e)
        {
            string rolTexto = "Admin";

            bool valido = Enum.TryParse<TipoRol>(rolTexto, out _);

            MessageBox.Show(valido ?
                "V Rol válido" :
                "X Rol no válido o inexistente");
        }

        private void btnValidarCompleto_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario
            {
                nombre = "",
                apellidos = "Martinez",
                email = "email_malformado",
                contrasena = "123",
                rol = TipoRol.Admin
            };

            if (string.IsNullOrWhiteSpace(u.nombre))
            {
                MessageBox.Show("X Nombre obligatorio");
                return;
            }

            if (!Regex.IsMatch(u.email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("X Email inválido");
                return;
            }

            if (u.contrasena.Length < 6)
            {
                MessageBox.Show("X Contraseña demasiado corta");
                return;
            }

            MessageBox.Show("V Usuario válido");
        }

        private void TestValidacionesUsuario_Load_1(object sender, EventArgs e)
        {

        }
    }
}
