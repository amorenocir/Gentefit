using Gentefit.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gentefit.Vistas.Admin.GestSalas
{
    public partial class ListarSalas : Form
    {
        private LogicaSala logica = new LogicaSala();
        public ListarSalas()
        {
            InitializeComponent();
            this.Load += (s, e) => PanelSalas.DataSource = logica.ListarSalas();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new MenuAdSalas().Show();
            this.Close();
        }
    }
}
