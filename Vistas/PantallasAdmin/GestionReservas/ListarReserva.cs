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

namespace Gentefit.Vistas.PantallasAdmin
{
    public partial class ListarReservas : Form
    {
        private readonly LogicaReservas logicaCl = new LogicaReservas();

        public ListarReservas()
        {
            InitializeComponent();
            PanelReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PanelReservas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.Load += (s, e) => PanelReservas.DataSource = logicaCl.ObtenerTodasParaAdmin();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new InicioAdmin().Show();
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
                logicaCl.ExportarXmlReservas(saveFileDialog.FileName);
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
                logicaCl.ImportarXmlReservas(openFileDialog.FileName);
                MessageBox.Show("Reservas importadas correctamente.");
                PanelReservas.DataSource = logicaCl.ObtenerTodos();

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
                Fecha = reserva.fecha,
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
                fecha = reservaXml.Fecha,
            };
        }
    }
}
