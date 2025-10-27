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

namespace Gentefit.Vistas.Admin
{
    public partial class EliminarCliente : Form
    {
        public EliminarCliente()
        {
            InitializeComponent();
            this.Load += cargarDatos;
        }
        private void cargarDatos(object sender, EventArgs e)
        {
            using var context = new GentefitContext();
            var clientes = context.Clientes.ToList(); // Obtiene los clientes
            PanelClientes.DataSource = clientes; // Asigna la lista al grid

        }
        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(CajaTextoBuscar.Text, out int idBuscado))
            {
                MessageBox.Show("Por favor introduce un ID válido.");
                return;
            }
            using (var contexto = new GentefitContext())
            {
                var resultados = contexto.Clientes
                    .Where(c => c.Id == idBuscado)
                    .ToList();

                PanelClientes.DataSource = resultados;
            }
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (PanelClientes.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona un cliente para eliminar.");
                return;
            }

            // Obtenemos el ID de la fila seleccionada (asegúrate de que la columna se llama Id o cambia el nombre)
            int idCliente = (int)PanelClientes.CurrentRow.Cells["Id"].Value;

            // Confirmamos antes de eliminar
            var confirmacion = MessageBox.Show(
                "¿Seguro que deseas eliminar este cliente?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                using (var contexto = new GentefitContext())
                {
                    var clienteAEliminar = contexto.Clientes.Find(idCliente);

                    if (clienteAEliminar != null)
                    {
                        contexto.Clientes.Remove(clienteAEliminar);
                        contexto.SaveChanges();
                        MessageBox.Show("Cliente eliminado correctamente.");

                        // Vuelves a cargar los datos (puedes usar tu método de búsqueda o cargar todo)
                        cargarDatos(null, null);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el cliente en la base de datos.");
                    }
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
            cargarDatos(null, null);
        }
    }
}
