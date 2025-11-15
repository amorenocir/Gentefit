using Gentefit.Controlador;
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

namespace Gentefit.Vistas.Admin.GestActividades.GestClases
{
    public partial class ListarClases : Form
    {
        private int idActividad;
        LogicaClases logicaClases = new LogicaClases();
        LogicaActividades logicaAct = new LogicaActividades();
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
            List<Clase> todasClases = logicaClases.ListarClases();
            List<Clase> clasesMostrar = new List<Clase>();
            for(int i = 0; i < todasClases.Count; i++)
            {
                if (todasClases[i].idActividad  == idActividad)
                {
                    clasesMostrar.Add(todasClases[i]);
                }
            }
            PanelClases.DataSource = clasesMostrar;

            PanelClases.Columns["actividad"].Visible = false;
            PanelClases.Columns["entrenador"].Visible = false;
            PanelClases.Columns["sala"].Visible = false;

            List<Actividad> posiblesAct = logicaAct.BuscarPorID(idActividad);
            Actividad actividad = posiblesAct[0];
            string tituloMin = "Lista de clases de " + actividad.nombre;
            Tituloo.Text = tituloMin.ToUpper();
        }
    }
}
