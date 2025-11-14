using Gentefit.Modelo;
using Gentefit.db;
using System;
using System.Windows.Forms;

namespace Gentefit.Vistas.PantallasAdmin
{
    public partial class EliminarEntrenador : Form
    {
        private LogicaEntrenadores logica;

        public EliminarEntrenador()
        {
            InitializeComponent();
            this.Load += EliminarEntrenador_Load;
        }

        private void EliminarEntrenador_Load(object sender, EventArgs e)
        {
            using var contexto = new GentefitContext();
            logica = new LogicaEntrenadores();
            PanelEntrenadores.DataSource = logica.ObtenerTodos();
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(CajaTextoBuscar.Text, out int idBuscado))
            {
                MessageBox.Show("Por favor introduce un ID válido.");
                return;
            }
            PanelEntrenadores.DataSource = logica.BuscarPorId(idBuscado);
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (PanelEntrenadores.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona un Entrenador para eliminar.");
                return;
            }

            int idEntrenador = (int)PanelEntrenadores.CurrentRow.Cells["idEntrenador"].Value;

            var confirmacion = MessageBox.Show(
                "¿Seguro que deseas eliminar este Entrenador?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                if (logica.EliminarEntrenador(idEntrenador))
                {
                    MessageBox.Show("Entrenador eliminado correctamente.");
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("No se encontró el Entrenador en la base de datos.");
                }
            }
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EntrenadoresAdmin().Show();
        }

        private void BotonVerTodos_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            PanelEntrenadores.DataSource = logica.ObtenerTodos();
        }
    }
}

