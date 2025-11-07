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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Gentefit.db;

namespace Gentefit.Vistas.Admin
{
    public partial class ModificarCliente : Form
    {
        public ModificarCliente()
        {
            InitializeComponent();
            this.Load += cargarDatos;
            CajaTextoId.ReadOnly = true;

        }
        private void cargarDatos(object sender, EventArgs e)
        {
            using var context = new GentefitContext();
            var clientes = context.Clientes.ToList(); // Obtiene los clientes
            PanelClientes.DataSource = clientes; // Asigna la lista al grid

        }
        private void PanelClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = PanelClientes.Rows[e.RowIndex];

                CajaTextoId.Text = fila.Cells["Id"].Value.ToString(); // Mejor ponerlo solo lectura
                CajaTextoNombre.Text = fila.Cells["Nombre"].Value.ToString();
                CajaTextoApellidos.Text = fila.Cells["Apellidos"].Value.ToString();
                CajaTextoDNI.Text = fila.Cells["Dni"].Value.ToString();
                CajaTextoTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                CajaTextoEmail.Text = fila.Cells["Email"].Value.ToString();
                CajaTextoContrasena.Text = fila.Cells["Contrasena"].Value.ToString();
            }
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(CajaTextoId.Text);

            using (var contexto = new GentefitContext())
            {
                var cliente = contexto.Clientes.FirstOrDefault(c => c.idCliente == id);
                if (cliente != null)
                {
                    cliente.nombre = CajaTextoNombre.Text;
                    cliente.apellidos = CajaTextoApellidos.Text;
                    cliente.dni = CajaTextoDNI.Text;
                    cliente.telefono = int.Parse(CajaTextoTelefono.Text);
                    cliente.email = CajaTextoEmail.Text;
                    cliente.contrasena = CajaTextoContrasena.Text;

                    contexto.SaveChanges();
                    MessageBox.Show("Cliente modificado correctamente");
                }
            }

            // Refrescar la lista
            cargarDatos(null, null);
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
                    .Where(c => c.idCliente == idBuscado)
                    .ToList();

                PanelClientes.DataSource = resultados;
            }
        }
        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new MenuAdClientes().Show();
            this.Hide();
        }
    }
}
