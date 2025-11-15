using Gentefit.db;
using Gentefit.Modelo;
using Gentefit.Modelo.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gentefit.Vistas.PantallasAdmin.GestionUsuarios
{
    public partial class AnadirUsuario : Form
    {
        public AnadirUsuario()
        {
            InitializeComponent();
        }

        private void BotonAnadir_Click(object sender, EventArgs e)
        {
            // Recoger los datos del formulario
            Usuario nuevoUsuario = new Usuario
            {
                nombre = CajaTextoNombre.Text,
                apellidos = CajaTextoApellidos.Text,
                email = CajaTextoEmail.Text,
                contrasena = CajaTextoContrasena.Text,
                rol = Enum.Parse<TipoRol>(ComboOpcionesRol.Text),

            };

            // Insertar en la base de datos usando EF Core
            using (var contexto = new GentefitContext())
            {
                var logica = new LogicaUsuarios();
                logica.AnadirUsuario(nuevoUsuario);
            }

            MessageBox.Show("Usuario añadido correctamente");
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UsuariosAdmin().Show();

        }

        private void ComboOpcionesRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
