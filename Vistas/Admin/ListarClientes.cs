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

namespace Gentefit.Vistas.Admin
{
    public partial class ListarClientes : Form
    {
        public ListarClientes()
        {
            InitializeComponent();
            this.Load += cargarDatos;
        }

        private void cargarDatos(object sender, EventArgs e)
        {
            using var context = new GentefitContext();
            var clientes = context.Clientes.ToList(); // Obtiene los clientes
            PanelClientes.DataSource = clientes; // Asigna la lista al grid

        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new MenuAdClientes().Show();
            this.Hide();
        }
    }
}
