using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gentefit.Vistas.PantallasAdmin.GestionClases;


namespace Gentefit.Vistas.PantallasAdmin
{
    public partial class ClasesAdmin : Form
    {
        public ClasesAdmin()
        {
            InitializeComponent();
        }
        private void BotonAnadir_Click(object sender, EventArgs e)
        {
            new AnadirClase().Show();
            this.Hide();
        }
        private void BotonListar_Click(object sender, EventArgs e)
        {
            new ListarClases().Show();
            this.Hide();
        }
        private void BotonModificar_Click(object sender, EventArgs e)
        {
            new ModificarClase().Show();
            this.Hide();
        }
        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            new EliminarClase().Show();
            this.Hide();
        }
        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new InicioAdmin().Show();
            this.Hide();
        }
    }
}
