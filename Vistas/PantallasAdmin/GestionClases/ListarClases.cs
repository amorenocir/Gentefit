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

namespace Gentefit.Vistas.PantallasAdmin
{
    public partial class ListarClases : Form
    {
        private int idActividad;
        LogicaClases logicaClases = new LogicaClases();
        LogicaActividades logicaAct = new LogicaActividades();
        LogicaEntrenadores logicaEnt = new LogicaEntrenadores();
        LogicaSalas logicaSalas = new LogicaSalas();
        LogicaReservas logicaRes = new LogicaReservas();
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
            List<Clase> todasClases = logicaClases.ObtenerTodo();
            List<Clase> listaBuena = new List<Clase>();
            foreach(Clase clase in todasClases)
            {
                if(clase.idActividad == idActividad)
                {
                    listaBuena.Add(clase);
                }
            }          

            PanelClases.DataSource = listaBuena;

            PanelClases.Columns["IdClase"].HeaderText = "ID Clase";
            PanelClases.Columns["IdClase"].DisplayIndex = 0;
            PanelClases.Columns.Add("nombreAct", "Actividad");
            PanelClases.Columns["nombreAct"].DisplayIndex = 1;
            PanelClases.Columns.Add("nombreEnt", "Entrenador");
            PanelClases.Columns["nombreEnt"].DisplayIndex = 2;
            PanelClases.Columns.Add("nombreSala", "Sala");
            PanelClases.Columns["nombreSala"].DisplayIndex = 3;
            PanelClases.Columns["dia"].HeaderText = "Día";
            PanelClases.Columns["hora"].HeaderText = "Hora";
            PanelClases.Columns["plazasLibres"].HeaderText = "Plazas Libres";
            PanelClases.Columns["enEspera"].HeaderText = "En espera";

            PanelClases.Columns["horario"].Visible = false;
            PanelClases.Columns["idActividad"].Visible = false;
            PanelClases.Columns["idEntrenador"].Visible = false;
            PanelClases.Columns["idSala"].Visible = false;
            PanelClases.Columns["actividad"].Visible = false;
            PanelClases.Columns["entrenador"].Visible = false;
            PanelClases.Columns["sala"].Visible = false;

            foreach (DataGridViewRow fila in PanelClases.Rows)
            {
                Clase clase = fila.DataBoundItem as Clase;

                logicaRes.GestionarListasReservas(clase);

                Actividad actividad = logicaAct.BuscarPorId(idActividad).FirstOrDefault();

                List<Entrenador> posiblesEnt = logicaEnt.BuscarPorId(clase.idEntrenador);
                Entrenador entrenador = posiblesEnt[0];

                List<Sala> posiblesSalas = logicaSalas.BuscarPorId(clase.idSala);
                Sala sala = posiblesSalas[0];

                fila.Cells["nombreAct"].Value = actividad.nombre;
                fila.Cells["nombreEnt"].Value = entrenador.nombre + " " + entrenador.apellidos;
                fila.Cells["nombreSala"].Value = sala.nombre;
            }
        }
    }
}
