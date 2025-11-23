using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Gentefit.db;
using Gentefit.ModeloXml;
using Gentefit.Modelo;
using Gentefit.Controlador;

namespace Gentefit.Vistas.PantallasAdmin
{
    public partial class ListarReservas : Form
    {
        private readonly LogicaReservas logicaRs = new LogicaReservas();

        public ListarReservas()
        {
            InitializeComponent();
            PanelReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PanelReservas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.Load += (s, e) => CargarReservas();
        }
        private void CargarReservas()
        {
            var reservas = logicaRs.ObtenerReservasDetalladas();
            PanelReservas.DataSource = reservas;

            // Configurar nombres de columnas
            PanelReservas.Columns["IdReserva"].HeaderText = "ID Reserva";
            PanelReservas.Columns["Cliente"].HeaderText = "Cliente";
            PanelReservas.Columns["Clase"].HeaderText = "Clase";
            PanelReservas.Columns["FechaClase"].HeaderText = "Fecha de la Clase";
            //PanelReservas.Columns["Hora"].HeaderText = "Hora";
            PanelReservas.Columns["FechaReserva"].HeaderText = "Fecha de la Reserva";
            PanelReservas.Columns["Estado"].HeaderText = "Estado";
            
            PanelReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new ReservasAdmin().Show();
            this.Hide();
        }

        private void BotonExportarXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivos XML|*.xml",
                Title = "Exportar Reservas a XML"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                logicaRs.ExportarXmlReservas(saveFileDialog.FileName);
                MessageBox.Show("Reservas exportadas correctamente.");
            }
        }

        private void BotonImportarXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos XML|*.xml",
                Title = "Importar Reservas desde XML"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                logicaRs.ImportarXmlReservas(openFileDialog.FileName);
                MessageBox.Show("Reservas importadas correctamente.");
                PanelReservas.DataSource = logicaRs.ObtenerTodos();

            }
        }

        public static ReservaXml ConvertirAXml(Reserva reserva)
        {
            return new ReservaXml
            {
                IdReserva = reserva.idReserva,
                IdCliente = reserva.idCliente,
                Cliente = reserva.cliente,
                IdClase = reserva.idClase,
                Clase = reserva.clase,
                Estado = reserva.estado,
                FechaReserva = reserva.fechaReserva,
                FechaClase = reserva.fechaClase,
            };
        }

        public static Reserva ConvertirAEntidad(ReservaXml reservaXml)
        {
            return new Reserva
            {
                idReserva = reservaXml.IdReserva,
                idCliente = reservaXml.IdCliente,
                cliente = reservaXml.Cliente,
                idClase = reservaXml.IdClase,
                clase = reservaXml.Clase,
                estado = reservaXml.Estado,
                fechaReserva = reservaXml.FechaReserva,
                fechaClase = reservaXml.FechaClase,
            };
        }
    }
}
