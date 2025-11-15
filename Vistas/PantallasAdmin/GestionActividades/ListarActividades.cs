using Gentefit.Logica;
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
using Gentefit.Modelo.Enums;


namespace Gentefit.Vistas.PantallasAdmin.GestionActividades
{
    public partial class ListarActividades : Form
    {
        private readonly LogicaActividades logicaAct = new LogicaActividades();

        public ListarActividades()
        {
            InitializeComponent();
            this.Load += (s, e) => PanelActividades.DataSource = logicaAct.ObtenerTodos();
        }
       

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new ActividadesAdmin().Show();
            this.Hide();
        }

        private void BotonExportarXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivos XML|*.xml",
                Title = "Exportar actividades a XML"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                logicaAct.ExportarXml(saveFileDialog.FileName);
                MessageBox.Show("Actividades exportadas correctamente.");
            }
        }

        private void BotonImportarXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos XML|*.xml",
                Title = "Importar actividades desde XML"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                logicaAct.ImportarXml(openFileDialog.FileName);
                MessageBox.Show("Actividades importadas correctamente.");
                PanelActividades.DataSource = logicaAct.ObtenerTodos();
            }
        }

        public static ActividadXml ConvertirAXml(Actividad actividad)
        {
            return new ActividadXml
            {
                Id = actividad.idActividad,
                Nombre = actividad.nombre,
                Duracion = actividad.duracion,
                Intensidad = (int)actividad.intensidad,
                Descripcion = actividad.descripcion,
            };
        }

        public static Actividad ConvertirAEntidad(ActividadXml actividadXml)
        {
            return new Actividad
            {
                // Si el Id es autoincremental en la BD, podemos dejarlo en 0.
                idActividad = actividadXml.Id,
                nombre = actividadXml.Nombre,
                duracion = actividadXml.Duracion,
                intensidad = (Intensidad)actividadXml.Intensidad,
                descripcion = actividadXml.Descripcion,
            };
        }
    }
}
