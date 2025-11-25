using Gentefit.Vistas.PantallasAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gentefit.Vistas.PantallasEncargado
{
    public partial class InicioEncargado : Form
    {
        public InicioEncargado()
        {
            InitializeComponent();
            this.Text = "GenteFit";
        }
        private void BotonVerClientes_Click(object sender, EventArgs e)
        {
            new ClientesEncargado().Show();
            this.Hide();
        }
        private void BotonVerReservas_Click(object sender, EventArgs e)
        {
            new EscogerListaReservas().Show();
            this.Hide();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }
    }
}
