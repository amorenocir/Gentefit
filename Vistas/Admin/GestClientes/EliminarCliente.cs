using Gentefit.Modelo;
using Gentefit.db;
using System;
using System.Windows.Forms;

namespace Gentefit.Vistas.Admin
{
    public partial class EliminarActividad : Form
    {
        private LogicaClientes logica;

        public EliminarActividad()
        {
            InitializeComponent();
            this.Load += EliminarCliente_Load;
        }

        private void EliminarCliente_Load(object sender, EventArgs e)
        {
            using var contexto = new GentefitContext();
            logica = new LogicaClientes();
            PanelClientes.DataSource = logica.ObtenerTodos();
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(CajaTextoBuscar.Text, out int idBuscado))
            {
                MessageBox.Show("Por favor introduce un ID válido.");
                return;
            }
            PanelClientes.DataSource = logica.BuscarPorId(idBuscado);
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (PanelClientes.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona un cliente para eliminar.");
                return;
            }

            int idCliente = (int)PanelClientes.CurrentRow.Cells["idCliente"].Value;

            var confirmacion = MessageBox.Show(
                "¿Seguro que deseas eliminar este cliente?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                if (logica.EliminarCliente(idCliente))
                {
                    MessageBox.Show("Cliente eliminado correctamente.");
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("No se encontró el cliente en la base de datos.");
                }
            }
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuAdClientes().Show();
        }

        private void BotonVerTodos_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            PanelClientes.DataSource = logica.ObtenerTodos();
        }
    }
}

