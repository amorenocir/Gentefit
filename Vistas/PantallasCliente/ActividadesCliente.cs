using Gentefit.Modelo;
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
        private Cliente clienteLogeado;
        public ActividadesCliente(Cliente cliente)
        {
            InitializeComponent();
            clienteLogeado = cliente;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void BotonInicio_Click(object sender, EventArgs e)
        {
            new MenuCliente(clienteLogeado).Show();
            this.Hide();
        }
        private void BotonHorarios_Click(object sender, EventArgs e)
        {
            new HorariosCliente(clienteLogeado).Show();
            this.Hide();
        }
        private void BotonReservas_Click(object sender, EventArgs e)
        {
            new ReservasCliente(clienteLogeado).Show();
            this.Hide();
        }


        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
