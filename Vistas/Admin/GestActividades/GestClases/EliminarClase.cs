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
    public partial class EliminarClase : Form
    {
        private int idActividad;
        LogicaClases logicaClases = new LogicaClases();
        LogicaActividades logicaAct = new LogicaActividades();
        public EliminarClase(int idActividad)
        {
            InitializeComponent();
            this.idActividad = idActividad;
        }

        private void EliminarClase_Load(object sender, EventArgs e)
        {
            CargarDatos();
            PanelClases.Columns["actividad"].Visible = false;
            PanelClases.Columns["entrenador"].Visible = false;
            PanelClases.Columns["sala"].Visible = false;

            List<Actividad> posiblesAct = logicaAct.BuscarPorID(idActividad);
            Actividad actividad = posiblesAct[0];
            string tituloMin = "Modificar clases de " + actividad.nombre;
            Titulo.Text = tituloMin.ToUpper();
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

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(CajaTextoBuscar.Text, out int idBuscar))
            {
                MessageBox.Show("Por favor introduce un ID válido.");
            }
            PanelClases.DataSource = logicaClases.BuscarPorId(idBuscar);
        }

        private void BotonVerTodos_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new MenuAdClases(idActividad).Show();
            this.Close();
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (PanelClases.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona una actividad para eliminar.");
                return;
            }
            int idClase = (int)PanelClases.CurrentRow.Cells["idClase"].Value;
            var confirmacion = MessageBox.Show(
                "¿Seguro que deseas eliminar esta clase?",
                "Confirmar eliminación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if(confirmacion == DialogResult.Yes)
            {
                if (logicaClases.EliminarClase(idClase))
                {
                    MessageBox.Show("Clase eliminada correctamente.");
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("No se encontró la clase en la base de datos.");
                }
            }
        }
    }
}
