using Gentefit.Modelo;
using Gentefit.db;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Gentefit.Vistas.Admin
{
    public partial class ModificarCliente : Form
    {
        private readonly LogicaClientes logica = new LogicaClientes();

        public ModificarCliente()
        {
            InitializeComponent();
            this.Load += (s, e) => CargarDatos();
        }

        private void PanelClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = PanelClientes.Rows[e.RowIndex];

            // Se asume que las columnas del DataGridView se llaman igual que las propiedades de Cliente
            CajaTextoID.Text = fila.Cells["idCliente"].Value.ToString();
            CajaTextoNombre.Text = fila.Cells["nombre"].Value.ToString();
            CajaTextoApellidos.Text = fila.Cells["apellidos"].Value.ToString();
            CajaTextoDNI.Text = fila.Cells["dni"].Value.ToString();
            CajaTextoTelefono.Text = fila.Cells["telefono"].Value.ToString();
            CajaTextoEmail.Text = fila.Cells["email"].Value.ToString();
            CajaTextoContrasena.Text = fila.Cells["contrasena"].Value.ToString();
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente
            {
                idCliente = int.Parse(CajaTextoID.Text),
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
            new MenuAdClientes().Show();
            this.Close();
        }

        // Método vacío para evitar error del Designer
        private void CajaTextoId_TextChanged(object sender, EventArgs e)
        {
        }

        private void CajaTextoNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void CargarDatos()
        {
            PanelClientes.DataSource = logica.ObtenerTodos();
        }

        private void CajaTextoID_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}


