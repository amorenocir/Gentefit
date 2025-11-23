using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gentefit.Controlador;
using Gentefit.Modelo;

namespace Gentefit.Vistas.PantallasEncargado
{
    public partial class ListadoReservasEncargado : Form
    {
        private List<Reserva> lista = new List<Reserva>();
        Cliente cliente;
        Clase clase;
        LogicaClases logicaClases = new LogicaClases();
        LogicaActividades logicaActividades = new LogicaActividades();

        public ListadoReservasEncargado(List<Reserva> lista, Cliente cliente, Clase clase)
        {
            this.lista = lista;
            this.cliente = cliente;
            this.clase = clase;

            InitializeComponent();
            this.Load += (s, e) => CargarDatos();
            EscogerTitulo(cliente, clase);
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new ReservasEncargado().Show();
            this.Close();
        }

        private void EscogerTitulo(Cliente cliente, Clase clase)
        {
            if(cliente == null && clase == null)
            {
                Titulo.Text = "TODAS LAS RESERVAS";
            }
            else if(cliente != null)
            {
                string tituloMin = "Reservas de " + cliente.nombre + " " + cliente.apellidos;
                Titulo.Text = tituloMin.ToUpper();
            }
            else
            {
                List<Actividad> posiblesAct = logicaActividades.BuscarPorId(clase.idActividad);
                Actividad actividad = posiblesAct[0];
                string tituloMin = "Reservas de " + actividad.nombre + " " + clase.dia + " " + clase.hora;
                Titulo.Text = tituloMin.ToUpper();
            }
        }

        private void CargarDatos()
        {
            PanelReservas.DataSource = lista;
            if (PanelReservas.Columns["cliente"] != null)
            {
                PanelReservas.Columns["cliente"].Visible = false;
            }
            if (PanelReservas.Columns["clase"] != null)
            {
                PanelReservas.Columns["clase"].Visible = false;
            }
            if (PanelReservas.Columns["idClase"] != null)
            {
                PanelReservas.Columns["idClase"].Visible = false;
            }
            if (!PanelReservas.Columns.Contains("nombreActividad"))
            {
                PanelReservas.Columns.Add("nombreActividad", "Actividad");
            }
            foreach(DataGridViewRow fila in PanelReservas.Rows)
            {
                Reserva reserva = fila.DataBoundItem as Reserva;

                int idClase = reserva.idClase;
                List<Clase> posiblesClases = logicaClases.BuscarPorId(idClase);
                Clase clase = posiblesClases[0];

                int idActividad = clase.idActividad;
                List<Actividad> posiblesAct = logicaActividades.BuscarPorId(idActividad);
                Actividad actividad = posiblesAct[0];

                fila.Cells["nombreActividad"].Value = actividad.nombre;
            }
        }
    }
}
