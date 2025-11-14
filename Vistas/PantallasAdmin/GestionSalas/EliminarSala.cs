using Gentefit.Modelo;
using Gentefit.db;
using System;
using System.Windows.Forms;

namespace Gentefit.Vistas.PantallasAdmin
{
    public partial class EliminarSala : Form
    {
        private LogicaSalas logica;

        public EliminarSala()
        {
            InitializeComponent();
            this.Load += EliminarSala_Load;
        }

        private void EliminarSala_Load(object sender, EventArgs e)
        {
            using var contexto = new GentefitContext();
            logica = new LogicaSalas();
            PanelSalas.DataSource = logica.ObtenerTodos();
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(CajaTextoBuscar.Text, out int idBuscado))
            {
                MessageBox.Show("Por favor introduce un ID válido.");
                return;
            }
            PanelSalas.DataSource = logica.BuscarPorId(idBuscado);
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (PanelSalas.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona un Sala para eliminar.");
                return;
            }

            int idSala = (int)PanelSalas.CurrentRow.Cells["idSala"].Value;

            var confirmacion = MessageBox.Show(
                "¿Seguro que deseas eliminar este Sala?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                if (logica.EliminarSala(idSala))
                {
                    MessageBox.Show("Sala eliminado correctamente.");
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("No se encontró el Sala en la base de datos.");
                }
            }
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SalasAdmin().Show();
        }

        private void BotonVerTodos_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            PanelSalas.DataSource = logica.ObtenerTodos();
        }
    }
}

