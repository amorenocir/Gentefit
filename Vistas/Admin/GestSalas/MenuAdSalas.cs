using Gentefit.Vistas.Admin.GestiEntrenadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gentefit.Vistas.Admin.GestSalas
{
    public partial class MenuAdSalas : Form
    {
        public MenuAdSalas()
        {
            InitializeComponent();
        }

        private void BotonAnadir_Click(object sender, EventArgs e)
        {
            new AnadirSala().Show();
            this.Hide();
        }

        private void BotonListar_Click(object sender, EventArgs e)
        {
            new ListarSalas().Show();
            this.Hide();
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            new ModificarSalas().Show();
            this.Hide();
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            new EliminarSala().Show();
            this.Hide();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new MenuAdmin().Show();
            this.Close();
        }
    }
}
