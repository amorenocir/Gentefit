using Gentefit.db;
using Gentefit.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LogicaClases;

namespace Gentefit.Vistas.PantallasAdmin.GestionClases
{

    public partial class EliminarClase : Form
    {
        private LogicaClases logicaClases;
        public EliminarClase()
        {
            InitializeComponent();
            this.Load += EliminarClase_Load;
        }

        private void EliminarClase_Load(object sender, EventArgs e)
        {
            using var contexto = new GentefitContext();
            logicaClases = new LogicaClases();
            PanelClases.DataSource = logicaClases.ObtenerClasesDisponibles();
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(CajaTextoBuscar.Text, out int idBuscado))
            {
                MessageBox.Show("Por favor introduce un ID válido.");
                return;
            }

            // Usar el nuevo método que devuelve DTOs
            listaClases = logicaClases.BuscarDTOPorId(idBuscado);
            PanelClases.DataSource = listaClases;
        }



        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (PanelClases.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona una clase para eliminar.");
                return;
            }

            int idClase = (int)PanelClases.CurrentRow.Cells["idClase"].Value;

            var confirmacion = MessageBox.Show(
                "¿Seguro que deseas eliminar esta clase?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
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

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new ClasesAdmin().Show();
            this.Hide();
        }

        private void BotonVerTodos_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private List<ClaseDTO> listaClases;
        private void CargarDatos()
        {
            // Obtener la lista de DTOs con nombres y IDs
            listaClases = logicaClases.ObtenerClasesDisponibles(); // Devuelve List<ClaseDTO>

            // Asignar al DataGridView
            PanelClases.DataSource = listaClases;

            // Ajustar encabezados
            PanelClases.Columns["IdClase"].HeaderText = "ID";
            PanelClases.Columns["NombreActividad"].HeaderText = "Actividad";
            PanelClases.Columns["NombreEntrenador"].HeaderText = "Entrenador";
            PanelClases.Columns["NombreSala"].HeaderText = "Sala";
            PanelClases.Columns["Horario"].HeaderText = "Horario";
            PanelClases.Columns["PlazasLibres"].HeaderText = "Plazas libres";
            PanelClases.Columns["EnEspera"].HeaderText = "En espera";
        }

    }
}
