using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gentefit.Vistas.Admin.GestActividades
{
    public partial class MenuAdActividades : Form
    {
        public MenuAdActividades()
        {
            InitializeComponent();
        }

        private void BotonAnadir_Click(object sender, EventArgs e)
        {
            new AnadirActividad().Show();
            this.Hide();
        }

        private void BotonListar_Click(object sender, EventArgs e)
        {
            new ListarActividades().Show();
            this.Hide();
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            new ModificarActividad().Show();
            this.Hide();
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            new EliminarActividad().Show();
            this.Hide();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new MenuAdmin().Show();
            this.Close();
        }
    }
}
