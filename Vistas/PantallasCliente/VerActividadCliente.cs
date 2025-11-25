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

namespace Gentefit.Vistas.PantallasCliente
{
    public partial class VerActividadCliente : Form
    {
        private Cliente clienteLogeado;
        private int idActividad;
        private LogicaActividades logicaActividades = new LogicaActividades();
        private LogicaReservas logicaReservas = new LogicaReservas();
        private LogicaClases logicaClases = new LogicaClases();
        private LogicaSalas logicaSalas = new LogicaSalas();
        private LogicaEntrenadores logicaEntre = new LogicaEntrenadores();
        public VerActividadCliente(Cliente cliente, int idActividad)
        {
            InitializeComponent();
            this.Text = "GenteFit";
            clienteLogeado = cliente;
            this.idActividad = idActividad;

            List<Actividad> posiblesAct = logicaActividades.BuscarPorId(idActividad);
            Actividad actividad = posiblesAct[0];
            Titulo.Text = actividad.nombre.ToUpper();
            CajaDescripcion.Text = actividad.descripcion;
            this.Load += (s, e) => CrearPanelHorarios(idActividad);
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new ActividadesCliente(clienteLogeado).Show();
            this.Close();
        }
        
        private void CrearPanelHorarios(int idActividad)
        {
            List<Clase> todasClases = logicaClases.ObtenerTodo();
            List<Clase> lista = new List<Clase>();
            foreach(Clase clase in todasClases)
            {
                if(clase.idActividad == idActividad)
                {
                    lista.Add(clase);
                }
            }
            PanelHorarios.DataSource = lista;
            PanelHorarios.Columns["idActividad"].Visible = false;
            PanelHorarios.Columns["actividad"].Visible = false;
            PanelHorarios.Columns["idEntrenador"].Visible = false;
            PanelHorarios.Columns["entrenador"].Visible = false;
            PanelHorarios.Columns["idSala"].Visible = false;
            PanelHorarios.Columns["sala"].Visible = false;
            PanelHorarios.Columns["horario"].Visible = false;
            PanelHorarios.Columns["idClase"].HeaderText = "ID de clase";
            PanelHorarios.Columns["plazasLibres"].HeaderText = "Plazas libres";
            PanelHorarios.Columns["enEspera"].HeaderText = "En espera";
            PanelHorarios.Columns.Add("nombreSala", "Sala");
            PanelHorarios.Columns.Add("nombreEntrenador", "Entrenador");
            foreach (DataGridViewRow fila in PanelHorarios.Rows)
            {
                Clase clase = fila.DataBoundItem as Clase;
                List<Sala> posiblesSalas = logicaSalas.BuscarPorId(clase.idSala);
                Sala sala = posiblesSalas[0];
                fila.Cells["nombreSala"].Value = sala.nombre;

                List<Entrenador> posiblesEnt = logicaEntre.BuscarPorId(clase.idEntrenador);
                Entrenador entrenador = posiblesEnt[0];
                fila.Cells["nombreEntrenador"].Value = entrenador.nombre + " " + entrenador.apellidos;

                logicaReservas.GestionarListasReservas(clase);
            }
        }
    }
}
