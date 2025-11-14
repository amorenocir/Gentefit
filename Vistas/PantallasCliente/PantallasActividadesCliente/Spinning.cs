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

namespace Gentefit.Vistas.PantallasCliente.PantallasActividadesCliente
{
    public partial class Spinning : Form
    {
        private Cliente clienteLogeado;
        public Spinning()
        {
            InitializeComponent();
        }
        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new ActividadesCliente(clienteLogeado).Show();
            this.Hide();
        }

        private void TextoCore_Click(object sender, EventArgs e)
        {

        }
    }
}
