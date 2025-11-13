using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gentefit.Vistas.Admin.GestiEntrenadores
{
    public partial class MenuAdEntrenadores : Form
    {
        public MenuAdEntrenadores()
        {
            InitializeComponent();
        }

        private void Entrenadores_Click(object sender, EventArgs e)
        {

        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new MenuAdmin().Show();
            this.Close();
        }

        private void BotonAnadir_Click(object sender, EventArgs e)
        {
            new AnadirEntrenador().Show();
            this.Hide();
        }

        private void BotonListar_Click(object sender, EventArgs e)
        {
            new ListarEntrenadores().Show();
            this.Hide();
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            new ModificarEntrenadores().Show();
            this.Hide();
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            new EliminarEntrenador().Show();
            this.Hide();
        }
    }
}
