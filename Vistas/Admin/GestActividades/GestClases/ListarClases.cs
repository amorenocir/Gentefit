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

namespace Gentefit.Vistas.Admin.GestActividades.GestClases
{
    public partial class ListarClases : Form
    {
        private int idActividad;
        LogicaClases logica = new LogicaClases();
        public ListarClases(int idActividad)
        {
            InitializeComponent();
            this.idActividad = idActividad;
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new MenuAdClases(idActividad).Show();
            this.Close();
        }

        private void ListarClases_Load(object sender, EventArgs e)
        {
            PanelClases.DataSource = logica.ListarClases();
            PanelClases.Columns["actividad"].Visible = false;
            PanelClases.Columns["entrenador"].Visible = false;
            PanelClases.Columns["sala"].Visible = false;
        }
    }
}
