using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gentefit.Vistas.PantallasAdmin.GestionUsuarios;

namespace Gentefit.Vistas.PantallasAdmin
{
    public partial class UsuariosAdmin : Form
    {
        public UsuariosAdmin()
        {
            InitializeComponent();
        }
        private void BotonAnadir_Click(object sender, EventArgs e)
        {
            new AnadirUsuario().Show();
            this.Hide();
        }
        private void BotonListar_Click(object sender, EventArgs e)
        {
            new ListarUsuarios().Show();
            this.Hide();
        }
        private void BotonModificar_Click(object sender, EventArgs e)
        {
            new ModificarUsuario().Show();
            this.Hide();
        }
        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            new EliminarUsuario().Show();
            this.Hide();
        }
        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new InicioAdmin().Show();
            this.Hide();
        }
    }
}
