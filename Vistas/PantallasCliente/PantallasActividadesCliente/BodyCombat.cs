using Gentefit.Modelo;
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

namespace Gentefit.Vistas.PantallasCliente.PantallasActividadesCliente
{
    public partial class BodyCombat : Form
    {
        private Cliente clienteLogeado;
        public BodyCombat()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new ActividadesCliente(clienteLogeado).Show();
            this.Hide();
        }
    }
}
