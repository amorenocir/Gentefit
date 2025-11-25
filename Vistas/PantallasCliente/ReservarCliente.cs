using Gentefit.Controlador;
using Gentefit.Modelo;
using Gentefit.Modelo.Enums;
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
    public partial class ReservarCliente : Form
    {
        private Cliente clienteLogeado;
        private int idActividad;
        private LogicaActividades logicaAct = new LogicaActividades();
        private LogicaClases logicaClases = new LogicaClases();
        private LogicaSalas logicaSalas = new LogicaSalas();
        private LogicaEntrenadores logicaEntre = new LogicaEntrenadores();
        private LogicaReservas logicaRes = new LogicaReservas();
        public ReservarCliente(Cliente cliente, int idActividad)
        {
            InitializeComponent();
            this.Text = "GenteFit";
            clienteLogeado = cliente;
            this.idActividad = idActividad;

            List<Actividad> posiblesAct = logicaAct.BuscarPorId(idActividad);
            Actividad actividad = posiblesAct[0];
            Titulo.Text = "Clases de " + actividad.nombre;
            this.Load += (s, e) => CrearPanelClases(idActividad);
        }

        private void BotonReservar_Click(object sender, EventArgs e)
        {
            if(PanelClases.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona una clase para reservar.");
                return;
            }
            int idClase = (int)PanelClases.CurrentRow.Cells["idClase"].Value;
            int idCliente = clienteLogeado.idCliente;
            if(logicaRes.ReservarClase(idClase, idCliente))
            {
                List<Reserva> todasRes = logicaRes.ObtenerTodos();
                var reserva = todasRes.LastOrDefault(r => r.idCliente == idCliente);

                MessageBox.Show($"¡Perfecto! Tu reserva está " + reserva.estado);
                CrearPanelClases(idActividad);
            }
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new ActividadesCliente(clienteLogeado).Show();
            this.Close();
        }

        private void CrearPanelClases(int idActividad)
        {
            List<Clase> todasClases = logicaClases.ObtenerTodo();
            List<Clase> lista = new List<Clase>();
            foreach (Clase clase in todasClases)
            {
                if (clase.idActividad == idActividad)
                {
                    lista.Add(clase);
                }
            }
            PanelClases.DataSource = lista;
            PanelClases.Columns["idActividad"].Visible = false;
            PanelClases.Columns["actividad"].Visible = false;
            PanelClases.Columns["idEntrenador"].Visible = false;
            PanelClases.Columns["entrenador"].Visible = false;
            PanelClases.Columns["idSala"].Visible = false;
            PanelClases.Columns["sala"].Visible = false;
            PanelClases.Columns["horario"].Visible = false;
            PanelClases.Columns["idClase"].HeaderText = "ID de clase";
            PanelClases.Columns["plazasLibres"].HeaderText = "Plazas libres";
            PanelClases.Columns["enEspera"].HeaderText = "En espera";
            PanelClases.Columns.Add("nombreSala", "Sala");
            PanelClases.Columns.Add("nombreEntrenador", "Entrenador");
            foreach (DataGridViewRow fila in PanelClases.Rows)
            {
                Clase clase = fila.DataBoundItem as Clase;
                List<Sala> posiblesSalas = logicaSalas.BuscarPorId(clase.idSala);
                Sala sala = posiblesSalas[0];
                fila.Cells["nombreSala"].Value = sala.nombre;

                List<Entrenador> posiblesEntre = logicaEntre.BuscarPorId(clase.idEntrenador);
                Entrenador entrenador = posiblesEntre[0];
                fila.Cells["nombreEntrenador"].Value = entrenador.nombre + " " + entrenador.apellidos;
                
                logicaRes.GestionarListasReservas(clase);
            }
        }
    }
}
