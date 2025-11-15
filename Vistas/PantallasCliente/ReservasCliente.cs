using Gentefit.Modelo;
using Gentefit.Vistas.PantallasCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gentefit.Vistas
{
    public partial class ReservasCliente : Form
    {
        private readonly LogicaReservas logicaRs = new LogicaReservas();
        private readonly int idCliente;
        private Cliente clienteLogeado;

        public ReservasCliente(Cliente cliente)
        {
            InitializeComponent();
            clienteLogeado = cliente;
            idCliente = cliente.idCliente;
            CargarReservas();
        }
        private void ImagenPerfil_Click(object sender, EventArgs e)
        {
            PerfilCliente perfil = new PerfilCliente(clienteLogeado.Clone());
            perfil.Show();
            this.Hide();
        }

        private void CargarReservas()
        {
            var reservas = logicaRs.FiltrarReservas(idCliente); // devuelve List<ReservaDTO>
            PanelReservas.DataSource = reservas;

            // Configurar nombres de columnas
            PanelReservas.Columns["IdReserva"].HeaderText = "ID Reserva";
            PanelReservas.Columns["ClaseNombre"].HeaderText = "Clase";
            PanelReservas.Columns["Estado"].HeaderText = "Estado";
            PanelReservas.Columns["FechaClase"].HeaderText = "Fecha de la Clase";
            PanelReservas.Columns["FechaReserva"].HeaderText = "Fecha de Reserva";

            PanelReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Mostrar nombre del cliente en una etiqueta
            EtiquetaCliente.Text = $"Reservas de: {clienteLogeado.nombre} {clienteLogeado.apellidos}";
        }

        private void BotonInicio_Click(object sender, EventArgs e)
        {
            new InicioCliente(clienteLogeado.Clone()).Show();
            this.Hide();
        }
        private void BotonActividades_Click(object sender, EventArgs e)
        {
            new ActividadesCliente(clienteLogeado.Clone()).Show();
            this.Hide();
        }
        private void BotonHorarios_Click(object sender, EventArgs e)
        {
            new HorariosCliente(clienteLogeado.Clone()).Show();
            this.Hide();
        }

        private void BotonCancelarReserva_Click(object sender, EventArgs e)
        {
            if (PanelReservas.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una reserva para cancelar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var reservaDTO = (LogicaReservas.ReservaDTO)PanelReservas.CurrentRow.DataBoundItem;

            // Mensaje de confirmacion
            DialogResult resultado = MessageBox.Show(
                "¿Seguro que quieres cancelar esta reserva?",
                "Confirmar cancelacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (resultado != DialogResult.Yes) return;
            
            LogicaReservas logica = new LogicaReservas();
            if (logica.CancelarReserva(reservaDTO.IdReserva))
            {
                CargarReservas();
            }
        }
    }
}
