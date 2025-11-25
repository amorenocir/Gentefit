using Gentefit.Controlador;
using Gentefit.db;
using Gentefit.Modelo;
using Gentefit.Modelo.Enums;
using System;
using System.Windows.Forms;


namespace Gentefit.Vistas.PantallasAdmin.GestionReservas
{
    public partial class AnadirReserva : Form
    {
        public AnadirReserva()
        {
            InitializeComponent();
            this.Text = "GenteFit";
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
            DgvClases.Columns["enEspera"].Visible = false;
        }

        //  Cargar tablas de clientes y clases
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
            DgvClases.Columns["Horario"].HeaderText = "Fecha";
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
                txtDia.Text = clase.Dia.ToString();
                txtHora.Text = clase.Hora.ToString();
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
            if (!int.TryParse(txtBuscarClase.Text, out int idClase))
            {
                MessageBox.Show("Por favor introduce un ID de actividad válido.");
                return;
            }

            LogicaClases logica = new LogicaClases();

            var resultados = logica.BuscarPorId(idClase);

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
            LogicaClases logicaClases = new LogicaClases();
            EstadoReserva estado = logicaReservas.ReservarClase(idClase, idCliente);

            switch (estado)
            {
                case EstadoReserva.Confirmada:
                    MessageBox.Show("Reserva confirmada correctamente.", "Reserva");
                    break;
                case EstadoReserva.EnEspera:
                    MessageBox.Show("Clase llena. Estás en lista de espera.", "Reserva");
                    break;
                case EstadoReserva.Cancelada: // se puede usar para errores o duplicados
                    MessageBox.Show("No se pudo crear la reserva.", "Error");
                    break;
            }
            // Refrescar la tabla de clases
            var listaClasesActualizada = logicaClases.ObtenerClasesDisponibles();
            DgvClases.DataSource = null;
            DgvClases.DataSource = listaClasesActualizada;
            

            // Volver a calcular plazasLibres y enEspera
            using var contexto = new GentefitContext();
            foreach (DataGridViewRow fila in DgvClases.Rows)
            {
                Clase clase = fila.DataBoundItem as Clase;
                if (clase == null) continue;

                // Traer la clase completa desde la BD
                var claseCompleta = contexto.Clases.FirstOrDefault(c => c.idClase == clase.idClase);
                if (claseCompleta != null)
                {
                    logicaReservas.GestionarListasReservas(claseCompleta);

                    // Actualizar las columnas del DataGridView
                    fila.Cells["plazasLibres"].Value = claseCompleta.plazasLibres;
                    fila.Cells["enEspera"].Value = claseCompleta.enEspera;
                }
            }
        }
       

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new ReservasAdmin().Show();
            this.Hide();
        }

        private void BotonVerTodos_Click_1(object sender, EventArgs e)
        {
            CargarTablas();
        }
    }
}
