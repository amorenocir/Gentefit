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
using Gentefit.Modelo.Enums;
using Gentefit.Modelo;

namespace Gentefit.Vistas.Admin.GestActividades.GestClases
{
    public partial class ModificarClases : Form
    {
        private int idActividad;
        LogicaClases logicaClases = new LogicaClases();
        LogicaActividades logicaAct = new LogicaActividades();
        public ModificarClases(int idActividad)
        {
            InitializeComponent();
            this.idActividad = idActividad;
        }

        private void ModificarClases_Load(object sender, EventArgs e)
        {
            CargarDatos();
            DespleDia.DataSource = Enum.GetValues(typeof(Dia));
            PanelClases.Columns["actividad"].Visible = false;
            PanelClases.Columns["entrenador"].Visible = false;
            PanelClases.Columns["sala"].Visible = false;

            List<Actividad> posiblesAct = logicaAct.BuscarPorID(idActividad);
            Actividad actividad = posiblesAct[0];
            string tituloMin = "Modificar clases de " + actividad.nombre;
            Titulo.Text = tituloMin.ToUpper();
        }

        private void BotonSiguiente_Click(object sender, EventArgs e)
        {
            TimeOnly horaApertura = new TimeOnly(7, 0);
            TimeOnly horaCierre = new TimeOnly(22, 0);
            TimeOnly horaDada;
            if(string.IsNullOrEmpty(CajaTextoHora.Text))
            {
                MessageBox.Show("Escoge qué clase quieres modificar.");
                return;
            }
            else if (!TimeOnly.TryParse(CajaTextoHora.Text, out horaDada))
            {
                MessageBox.Show("Introduce una hora correcta.");
                return;
            }
            else if (horaDada < horaApertura || horaDada > horaCierre)
            {
                MessageBox.Show("El gimnasio solo abre de 8:00 a 22:00.");
                return;
            }
            var clase = new Clase
            {
                idClase = int.Parse(CajaTextoID.Text),
                idActividad = idActividad,
                hora = horaDada,
                dia = (Dia)DespleDia.SelectedItem
            };
            new ModificarClases2(idActividad, clase).Show();
            this.Hide();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new MenuAdClases(idActividad).Show();
            this.Close();
        }

        private void CargarDatos()
        {
            List<Clase> todasClases = logicaClases.ListarClases();
            List<Clase> clasesMostrar = new List<Clase>();
            for (int i = 0; i < todasClases.Count; i++)
            {
                if (todasClases[i].idActividad == idActividad)
                {
                    clasesMostrar.Add(todasClases[i]);
                }
            }
            PanelClases.DataSource = clasesMostrar;
        }

        private void PanelClases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = PanelClases.Rows[e.RowIndex];

            CajaTextoID.Text = fila.Cells["idClase"].Value.ToString();
            CajaTextoHora.Text = fila.Cells["hora"].Value.ToString();
            DespleDia.SelectedItem = fila.Cells["Dia"].Value;
        }
    }
}
