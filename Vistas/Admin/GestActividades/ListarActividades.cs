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

namespace Gentefit.Vistas.Admin.GestActividades
{
    public partial class ListarActividades : Form
    {
        private readonly LogicaActividades logica = new LogicaActividades();

        public ListarActividades()
        {
            InitializeComponent();
            this.Load += (s, e) => PanelActividades.DataSource = logica.MostrarLista();
        }

        private void Actividades_Click(object sender, EventArgs e)
        {

        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new MenuAdActividades().Show();
            this.Close();
        }

        private void PanelActividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
