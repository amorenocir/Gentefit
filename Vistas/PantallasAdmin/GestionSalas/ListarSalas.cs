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
    public partial class ListarSalas : Form
    {
        private readonly LogicaSalas logicaCl = new LogicaSalas();

        public ListarSalas()
        {
            InitializeComponent();
            this.Load += (s, e) => PanelSalas.DataSource = logicaCl.ObtenerTodos();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new SalasAdmin().Show();
            this.Hide();
        }

        private void BotonExportarXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivos XML|*.xml",
                Title = "Exportar Salas a XML"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                logicaCl.ExportarXml(saveFileDialog.FileName);
                MessageBox.Show("Salas exportadas correctamente.");
            }
        }

        private void BotonImportarXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos XML|*.xml",
                Title = "Importar Salas desde XML"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                logicaCl.ImportarXml(openFileDialog.FileName);
                MessageBox.Show("Salas importadas correctamente.");
                PanelSalas.DataSource = logicaCl.ObtenerTodos();

            }
        }

        public static SalaXml ConvertirAXml(Sala Sala)
        {
            return new SalaXml
            {
                Id = Sala.idSala,
                Nombre = Sala.nombre,
            };
        }

        public static Sala ConvertirAEntidad(SalaXml SalaXml)
        {
            return new Sala
            {
                // Si el Id es autoincremental en la BD, podemos dejarlo en 0.
                idSala = SalaXml.Id,
                nombre = SalaXml.Nombre,
            };
        }
    }
}
