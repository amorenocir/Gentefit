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
    public partial class ActividadesCliente : Form
    {
        public ActividadesCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void BotonInicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuCliente().Show();
        }
        private void BotonHorarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HorariosCliente().Show();
        }
        private void BotonReservas_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ReservasCliente().Show();
        }


        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
