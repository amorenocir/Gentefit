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


namespace Gentefit.Vistas.Admin.GestiEntrenadores
{
    public partial class ListarEntrenadores : Form
    {
        private readonly LogicaEntrenadores logica = new LogicaEntrenadores();
        public ListarEntrenadores()
        {
            InitializeComponent();
            this.Load += (s, e) => PanelEntrenadores.DataSource = logica.ListarEntrenadores();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            new MenuAdEntrenadores().Show();
        }
    }
}
