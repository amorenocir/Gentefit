using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gentefit.ModeloXml;
using Gentefit.Modelo;
using Gentefit.Vistas.PantallasAdmin;

namespace Gentefit.Vistas.PantallasEncargado
{
    public partial class ClientesEncargado : Form
    {
        private readonly LogicaClientes logicaCl = new LogicaClientes();
        public ClientesEncargado()
        {
            InitializeComponent();
            this.Load += (s, e) => PanelClientes.DataSource = logicaCl.ObtenerTodos();
        }
        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new InicioEncargado().Show();
            this.Hide();
        }

    }
}
