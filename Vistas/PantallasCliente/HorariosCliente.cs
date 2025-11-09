using Gentefit.Modelo;
using MySqlX.XDevAPI;
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
        private Cliente clienteLogeado;
        public HorariosCliente(Cliente cliente)
        {
            InitializeComponent();
            clienteLogeado = cliente;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // Tu código aquí, o dejar vacío
        }
        private void BotonInicio_Click(object sender, EventArgs e)
        {
            new MenuCliente(clienteLogeado).Show();
            this.Hide();
        }
        private void BotonActividades_Click(object sender, EventArgs e)
        {
            new ActividadesCliente(clienteLogeado).Show();
            this.Hide();
        }
        
        private void BotonReservas_Click(object sender, EventArgs e)
        {
            new ReservasCliente(clienteLogeado).Show();
            this.Hide();
        }
    }
}
