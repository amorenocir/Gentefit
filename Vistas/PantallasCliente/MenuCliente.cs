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

namespace Gentefit.Vistas
{
    public partial class MenuCliente : Form
    {
        public MenuCliente()
        {
            InitializeComponent();
        }
        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            FechaYHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void BotonActividades_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ActividadesCliente().Show();
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

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

    }
}
