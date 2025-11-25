using Gentefit.db;
using Gentefit.Modelo;
using Gentefit.Modelo.Enums;
using System;
using System.Linq;
using System.Windows.Forms;
using Gentefit.Controlador;

namespace Gentefit.Vistas.PantallasAdmin
{
    public partial class ModificarReserva : Form
    {
        private readonly LogicaReservas logica = new LogicaReservas();

        public ModificarReserva()
        {
            InitializeComponent();
            this.Text = "GenteFit";
            CajaTextoId.ReadOnly = true;
        }

        private void PanelReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = PanelReservas.Rows[e.RowIndex];

            CajaTextoId.Text = fila.Cells["idReserva"].Value.ToString();

            CajaTextoIdCliente.Text = fila.Cells["idCliente"].Value.ToString();
            CajaTextoIdClase.Text = fila.Cells["idClase"].Value.ToString();

            string estadoTexto = fila.Cells["estado"].Value.ToString();
            comboBoxEstado.SelectedItem = Enum.Parse(typeof(EstadoReserva), estadoTexto);
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(CajaTextoId.Text, out int id)) return;
            if (!int.TryParse(CajaTextoIdCliente.Text, out int idCliente)) return;
            if (!int.TryParse(CajaTextoIdClase.Text, out int idClase)) return;

            // Busca la reserva original
            var reservaOriginal = logica.ObtenerTodos().FirstOrDefault(r => r.idReserva == id);
            if (reservaOriginal == null)
            {
                MessageBox.Show("Reserva no encontrada.");
                return;
            }

            // Crea una nueva modificada
            var reservaModificada = new Reserva
            {
                idReserva = id,
                idCliente = idCliente,
                idClase = idClase,
                estado = (EstadoReserva)comboBoxEstado.SelectedItem,
                fechaClase = reservaOriginal.fechaClase,
                fechaReserva = reservaOriginal.fechaReserva
            };

            bool exito = logica.ModificarReserva(reservaModificada);

            if (exito)
            {
                MessageBox.Show("Reserva modificada correctamente");
                CargarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo modificar la reserva.");
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
            PanelReservas.DataSource = resultados;
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new ReservasAdmin().Show();
            this.Hide();
        }

        private void BotonVerTodos_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            var reservas = logica.ObtenerTodos()
                .Select(r => new
                {
                    r.idReserva,
                    r.idCliente,
                    r.idClase,
                    Estado = r.estado,   // enum
                    r.fechaClase,
                    r.fechaReserva,
                })
                .ToList();

            //var reservas = logica.ObtenerReservasDetalladas();

            PanelReservas.DataSource = reservas;

            PanelReservas.DataSource = reservas;
        }

        private void FormModificarReserva_Load(object sender, EventArgs e)
        {
            CargarDatos();
            comboBoxEstado.DataSource = Enum.GetValues(typeof(EstadoReserva));
        }
    }
}
