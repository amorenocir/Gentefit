using Gentefit.Modelo;
using System;
using System.Windows.Forms;

namespace Gentefit.Vistas.PantallasAdmin.GestionReservas
{
    public partial class AnadirReserva : Form
    {
        public AnadirReserva()
        {
            InitializeComponent();
            CargarTablas();

            // Marcar los TextBox como solo lectura
            txtIdCliente.ReadOnly = true;
            txtIdClase.ReadOnly = true;

            txtIdCliente.ReadOnly = true;
            txtNombreCliente.ReadOnly = true;

            txtIdClase.ReadOnly = true;
            txtActividad.ReadOnly = true;
            txtDia.ReadOnly = true;
            txtHora.ReadOnly = true;

            // Eventos para seleccionar filas
            DgvClientes.CellClick += DgvClientes_CellClick;
            DgvClases.CellClick += DgvClases_CellClick;
        }

        // 👉 Cargar tablas de clientes y clases
        private void CargarTablas()
        {
            // === TABLA CLASES ===
            LogicaClases logicaClases = new LogicaClases();
            var clases = logicaClases.ObtenerClasesDisponibles();

            DgvClases.DataSource = clases;
            DgvClases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvClases.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            DgvClases.Columns["IdClase"].HeaderText = "ID";
            DgvClases.Columns["NombreActividad"].HeaderText = "Actividad";
            DgvClases.Columns["NombreEntrenador"].HeaderText = "Entrenador";
            DgvClases.Columns["NombreSala"].HeaderText = "Sala";
            DgvClases.Columns["Dia"].HeaderText = "Día";
            DgvClases.Columns["Fecha"].HeaderText = "Fecha";
            DgvClases.Columns["Hora"].HeaderText = "Hora";
            DgvClases.Columns["PlazasLibres"].HeaderText = "Plazas libres";

            // === TABLA CLIENTES ===
            LogicaClientes logicaClientes = new LogicaClientes();
            var clientes = logicaClientes.ObtenerTodos();

            DgvClientes.DataSource = clientes;
            DgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            DgvClientes.Columns["idCliente"].HeaderText = "ID";
            DgvClientes.Columns["nombre"].HeaderText = "Nombre";
            DgvClientes.Columns["apellidos"].HeaderText = "Apellidos";
            DgvClientes.Columns["dni"].HeaderText = "DNI";
            DgvClientes.Columns["email"].HeaderText = "Email";
            DgvClientes.Columns["contrasena"].Visible = false;

        }


        private void DgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvClientes.CurrentRow != null)
            {
                var cliente = (Cliente)DgvClientes.CurrentRow.DataBoundItem;
                txtIdCliente.Text = cliente.idCliente.ToString();
                txtNombreCliente.Text = cliente.nombre + " " + cliente.apellidos;

            }
        }

        private void DgvClases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvClases.CurrentRow != null)
            {
                var clase = (LogicaClases.ClaseDTO)DgvClases.CurrentRow.DataBoundItem;
                txtIdClase.Text = clase.IdClase.ToString();
                txtActividad.Text = clase.NombreActividad;
                txtDia.Text = clase.Dia;
                txtHora.Text = clase.Hora;
            }
        }


        private void BotonBuscarCliente_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBuscarCliente.Text, out int idBuscado))
            {
                MessageBox.Show("Por favor introduce un ID válido.");
                return;
            }

            LogicaClientes logica = new LogicaClientes();
            var resultados = logica.BuscarPorId(idBuscado);
            DgvClientes.DataSource = resultados;
        }

        private void BotonBuscarClase_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBuscarClase.Text, out int idActividad))
            {
                MessageBox.Show("Por favor introduce un ID de actividad válido.");
                return;
            }

            LogicaClases logica = new LogicaClases();
            var resultados = logica.FiltrarPorActividad(idActividad);

            if (resultados.Count == 0)
            {
                MessageBox.Show("No hay clases con esa actividad.");
                return;
            }

            DgvClases.DataSource = resultados;
        }


        private void BotonReservar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdCliente.Text) || string.IsNullOrWhiteSpace(txtIdClase.Text))
            {
                MessageBox.Show("Selecciona una clase y un cliente.", "Error");
                return;
            }

            int idCliente = int.Parse(txtIdCliente.Text);
            int idClase = int.Parse(txtIdClase.Text);

            LogicaReservas logicaReservas = new LogicaReservas();
            bool exito = logicaReservas.ReservarClase(idClase, idCliente);

            if (exito)
            {
                MessageBox.Show("Reserva creada correctamente.");
                CargarTablas();
            }
            else
            {
                MessageBox.Show("No se pudo crear la reserva.");
            }
        }


        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new InicioAdmin().Show();
            this.Hide();
        }

        private void BotonVerTodos_Click_1(object sender, EventArgs e)
        {
            CargarTablas();
        }
    }
}
