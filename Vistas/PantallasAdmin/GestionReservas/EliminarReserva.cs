using Gentefit.Modelo;
using Gentefit.db;
using System;
using System.Windows.Forms;
using Gentefit.Controlador;

namespace Gentefit.Vistas.PantallasAdmin
{
    public partial class EliminarReserva : Form
    {
        private LogicaReservas logica;

        public EliminarReserva()
        {
            InitializeComponent();
            this.Text = "GenteFit";

            this.Load += EliminarReserva_Load;
        }

        private void EliminarReserva_Load(object sender, EventArgs e)
        {
            using var contexto = new GentefitContext();
            logica = new LogicaReservas();
            CargarDatos();
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(CajaTextoBuscar.Text, out int idBuscado))
            {
                MessageBox.Show("Por favor introduce un ID válido.");
                return;
            }
            PanelReservas.DataSource = logica.BuscarPorId(idBuscado);
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (PanelReservas.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona un Reserva para eliminar.");
                return;
            }

            int idReserva = (int)PanelReservas.CurrentRow.Cells["idReserva"].Value;

            var confirmacion = MessageBox.Show(
                "¿Seguro que deseas eliminar este Reserva?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                if (logica.EliminarReserva(idReserva))
                {
                    MessageBox.Show("Reserva eliminado correctamente.");
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("No se encontró el Reserva en la base de datos.");
                }
            }
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InicioAdmin().Show();
        }

        private void BotonVerTodos_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            PanelReservas.DataSource = logica.ObtenerReservasDetalladas();
        }

        private void EliminarReserva_Load_1(object sender, EventArgs e)
        {

        }
    }
}

