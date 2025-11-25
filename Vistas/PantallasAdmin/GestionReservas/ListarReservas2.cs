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

namespace Gentefit.Vistas.PantallasAdmin.GestionReservas
{
    public partial class ListarReservas2 : Form
    {
        private List<Reserva> lista = new List<Reserva>();
        Cliente cliente;
        Clase clase;
        LogicaClases logicaClases = new LogicaClases();
        LogicaActividades logicaActividades = new LogicaActividades();
        LogicaReservas logicaReservas = new LogicaReservas();
        public ListarReservas2(List<Reserva> lista, Cliente cliente, Clase clase)
        {
            this.lista = lista;
            this.cliente = cliente;
            this.clase = clase;

            InitializeComponent();
            this.Text = "GenteFit";
            this.Load += (s, e) => CargarDatos();
            EscogerTitulo(cliente, clase);
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new ListarReservas().Show();
            this.Close();
        }

        private void BotonImportarXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos XML|*.xml",
                Title = "Importar Reservas desde XML"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                logicaReservas.ImportarXmlReservas(openFileDialog.FileName);
                MessageBox.Show("Reservas importadas correctamente.");
                PanelReservas.DataSource = logicaReservas.ObtenerTodos();

            }
        }

        private void BotonExportarXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivos XML|*.xml",
                Title = "Exportar Reservas a XML"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                logicaReservas.ExportarXmlReservas(saveFileDialog.FileName);
                MessageBox.Show("Reservas exportadas correctamente.");
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
            foreach (DataGridViewRow fila in PanelReservas.Rows)
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

        private void EscogerTitulo(Cliente cliente, Clase clase)
        {
            if (cliente == null && clase == null)
            {
                Titulo.Text = "TODAS LAS RESERVAS";
            }
            else if (cliente != null)
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
    }
}
