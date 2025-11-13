using Gentefit.Modelo;
using Gentefit.db;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Gentefit.Vistas.PantallasRecepcionista
{
    public partial class ModificarCliente : Form
    {
        private readonly LogicaClientes logica = new LogicaClientes();

        public ModificarCliente()
        {
            InitializeComponent();
            this.Load += (s, e) => CargarDatos();
            CajaTextoId.ReadOnly = true;
        }

        private void PanelClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = PanelClientes.Rows[e.RowIndex];

            CajaTextoId.Text = fila.Cells["idCliente"].Value.ToString();
            CajaTextoNombre.Text = fila.Cells["nombre"].Value.ToString();
            CajaTextoApellidos.Text = fila.Cells["apellidos"].Value.ToString();
            CajaTextoDNI.Text = fila.Cells["dni"].Value.ToString();
            CajaTextoTelefono.Text = fila.Cells["telefono"].Value.ToString();
            CajaTextoEmail.Text = fila.Cells["email"].Value.ToString();
            CajaTextoContrasena.Text = fila.Cells["contrasena"].Value.ToString();
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(CajaTextoId.Text, out int id)) return;

            var cliente = new Cliente
            {
                idCliente = id,
                nombre = CajaTextoNombre.Text,
                apellidos = CajaTextoApellidos.Text,
                dni = CajaTextoDNI.Text,
                telefono = int.Parse(CajaTextoTelefono.Text),
                email = CajaTextoEmail.Text,
                contrasena = CajaTextoContrasena.Text
            };

            bool exito = logica.Modificar(cliente);
            if (exito)
            {
                MessageBox.Show("Cliente modificado correctamente");
                CargarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el cliente.");
            }
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(CajaTextoBuscar.Text, out int idBuscado))
            {
                MessageBox.Show("Por favor introduce un ID válido.");
                return;
            }

            var resultados = logica.BuscarPorId(idBuscado);
            PanelClientes.DataSource = resultados;
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new InicioRecepcionista().Show();
            this.Hide();
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


