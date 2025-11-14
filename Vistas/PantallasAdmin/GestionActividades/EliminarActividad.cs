using Gentefit.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gentefit.Logica;

namespace Gentefit.Vistas.PantallasAdmin.GestionActividades
{
    public partial class EliminarActividad : Form
    {
        private LogicaActividades logica;
        public EliminarActividad()
        {
            InitializeComponent();
            this.Load += EliminarActividad_Load;
        }

        private void EliminarActividad_Load(object sender, EventArgs e)
        {
            using var contexto = new GentefitContext();
            logica = new LogicaActividades();
            PanelActividades.DataSource = logica.ObtenerTodos();
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(CajaTextoBuscar.Text, out int idBuscado))
            {
                MessageBox.Show("Por favor introduce un ID válido.");
                return;
            }
            PanelActividades.DataSource = logica.BuscarPorId(idBuscado);
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (PanelActividades.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona una actividad para eliminar.");
                return;
            }

            int idActividad = (int)PanelActividades.CurrentRow.Cells["idActividad"].Value;

            var confirmacion = MessageBox.Show(
                "¿Seguro que deseas eliminar esta actividad?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                if (logica.EliminarActividad(idActividad))
                {
                    MessageBox.Show("Actividad eliminada correctamente.");
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("No se encontró la actividad en la base de datos.");
                }
            }
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ActividadesAdmin().Show();
        }

        private void BotonVerTodos_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            PanelActividades.DataSource = logica.ObtenerTodos();
        }
    }
}

