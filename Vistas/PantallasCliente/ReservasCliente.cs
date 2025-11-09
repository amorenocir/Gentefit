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

        private void CargarReservas()
        {
            var reservas = logicaRs.FiltrarReservas(idCliente); // devuelve List<ReservaDTO>
            PanelReservas.DataSource = reservas;

            // Configurar nombres de columnas
            PanelReservas.Columns["IdReserva"].HeaderText = "ID Reserva";
            PanelReservas.Columns["ClaseNombre"].HeaderText = "Clase";
            PanelReservas.Columns["Estado"].HeaderText = "Estado";
            PanelReservas.Columns["Fecha"].HeaderText = "Fecha";

            PanelReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Mostrar nombre del cliente en una etiqueta
            EtiquetaCliente.Text = $"Reservas de: {clienteLogeado.nombre} {clienteLogeado.apellidos}";
        }

        private void BotonInicio_Click(object sender, EventArgs e)
        {
            new MenuCliente(clienteLogeado).Show();
            this.Hide();
        }
        private void BotonActividades_Click(object sender, EventArgs e)
        {
            new ActividadesCliente(clienteLogeado).Show();
            this.Hide();
        }
        private void BotonHorarios_Click(object sender, EventArgs e)
        {
            new HorariosCliente(clienteLogeado).Show();
            this.Hide();
        }

    }
}
