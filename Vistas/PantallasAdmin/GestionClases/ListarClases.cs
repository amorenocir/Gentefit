using Gentefit.Modelo;
using Gentefit.ModeloXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gentefit.Vistas.PantallasAdmin.GestionClases
{
    public partial class ListarClases : Form
    {
        private readonly LogicaClases logicaClases = new LogicaClases();

        public ListarClases()
        {
            InitializeComponent();
            this.Load += (s, e) => PanelClases.DataSource = logicaClases.ObtenerClasesDisponibles();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new ClasesAdmin().Show();
            this.Hide();
        }

        private void BotonExportarXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivos XML|*.xml",
                Title = "Exportar clases a XML"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                logicaClases.ExportarXmlClases(saveFileDialog.FileName);
                MessageBox.Show("Clases exportadas correctamente.");
            }
        }

        private void BotonImportarXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos XML|*.xml",
                Title = "Importar clases desde XML"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                logicaClases.ImportarXmlClases(openFileDialog.FileName);
                MessageBox.Show("Clases importadas correctamente.");
                PanelClases.DataSource = logicaClases.ObtenerTodos();

            }
        }

        public static ClaseXml ConvertirAXml(Clase clase)
        {
            return new ClaseXml
            {
                IdClase = clase.idClase,
                Actividad = clase.actividad,
                IdActividad = clase.idActividad,
                Entrenador = clase.entrenador,
                IdEntrenador = clase.idEntrenador,
                Sala = clase.sala,
                IdSala = clase.idSala,
                Horario = clase.horario,
                PlazasLibres = clase.plazasLibres,
                EnEspera = clase.enEspera,
                Reservas = clase.reservas,
            };
        }
        
        public static Clase ConvertirAEntidad(ClaseXml claseXml)
        {
            return new Clase
            {
                // Si el Id es autoincremental en la BD, podemos dejarlo en 0.
                idClase = claseXml.IdClase,
                actividad = claseXml.Actividad,
                idActividad = claseXml.IdActividad,
                entrenador = claseXml.Entrenador,
                idEntrenador = claseXml.IdEntrenador,
                sala = claseXml.Sala,
                idSala = claseXml.IdSala,
                horario = claseXml.Horario,
                plazasLibres = claseXml.PlazasLibres,
                enEspera = claseXml.EnEspera,
                reservas = claseXml.Reservas,
            };
        }
        
    }
}

