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
    public partial class HorariosCliente : Form
    {
        public HorariosCliente()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // Tu código aquí, o dejar vacío
        }
        private void BotonInicio_Click(object sender, EventArgs e)
        {
            new MenuCliente().Show();
            this.Hide();
        }
        private void BotonActividades_Click(object sender, EventArgs e)
        {
            new ActividadesCliente().Show();
            this.Hide();
        }
        
        private void BotonReservas_Click(object sender, EventArgs e)
        {
            new ReservasCliente().Show();
            this.Hide();
        }
    }
}
