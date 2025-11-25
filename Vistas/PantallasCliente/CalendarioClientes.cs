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
    public partial class CalendarioClientes : Form
    {
        Cliente clienteLogeado;
        LogicaClases logicaClases = new LogicaClases();
        LogicaActividades logicaAct = new LogicaActividades();
        public CalendarioClientes(Cliente cliente)
        {
            InitializeComponent();
            clienteLogeado = cliente;
        }

        private void CalendarioClientes_Load(object sender, EventArgs e)
        {
            CrearCalendario();
        }

        private void CrearCalendario()
        {
            PanelCalendario.Columns.Clear();
            PanelCalendario.Rows.Clear();
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            foreach (string dia in dias)
            {
                PanelCalendario.Columns.Add(dia, dia);
            }
            for (int hora = 8; hora <= 22; hora++)
            {
                int rowIndex = PanelCalendario.Rows.Add();
                PanelCalendario.Rows[rowIndex].HeaderCell.Value = $"{hora}:00";
            }
            PanelCalendario.RowHeadersWidth = 80;
            foreach(DataGridViewColumn columna in PanelCalendario.Columns)
            {
                columna.Width = 80;
            }
            LlenarCalendario();
        }

        private void LlenarCalendario()
        {
            List<Clase> todasClases = logicaClases.ObtenerTodo();
            foreach (Clase clase in todasClases)
            {
                Actividad actividad = logicaAct.BuscarPorId(clase.idActividad).FirstOrDefault();

                int diaSemana = (int)clase.dia;
                int hora = clase.hora.Hour;
                foreach (DataGridViewRow fila in PanelCalendario.Rows)
                {
                    if (fila.HeaderCell.Value.ToString().StartsWith(hora.ToString()))
                    {
                        fila.Cells[diaSemana].Value = actividad.nombre;
                        fila.Cells[diaSemana].Style.BackColor = Color.LightBlue;
                        fila.Cells[diaSemana].Style.ForeColor = Color.Black;
                        fila.Cells[diaSemana].Style.SelectionBackColor = Color.DeepSkyBlue;
                        break;
                    }
                }
            }
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new InicioCliente(clienteLogeado).Show();
            this.Close();
        }
    }
}
