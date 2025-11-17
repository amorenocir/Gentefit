using Gentefit.Controlador;
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

namespace Gentefit.Vistas.PantallasAdmin
{
    public partial class ListarClases : Form
    {
        private int idActividad;
        LogicaClases logicaClases = new LogicaClases();
        LogicaActividades logicaAct = new LogicaActividades();
        public ListarClases(int idActividad)
        {
            InitializeComponent();
            this.idActividad = idActividad;
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new MenuAdClases(idActividad).Show();
            this.Close();
        }

        private void ListarClases_Load(object sender, EventArgs e)
        {
            // Obtener todas las clases disponibles como DTO
            List<LogicaClases.ClaseDTO> todasClasesDTO = logicaClases.ObtenerClasesDisponibles();

            // Filtrar por la actividad seleccionada
            List<LogicaClases.ClaseDTO> clasesMostrar = todasClasesDTO
                .Where(c => c.IdActividad == idActividad)
                .ToList();

            // Asignar al DataGridView
            PanelClases.DataSource = clasesMostrar;

            // Ajustar columnas visibles
            PanelClases.Columns["IdClase"].HeaderText = "ID Clase";
            PanelClases.Columns["NombreActividad"].HeaderText = "Actividad";
            PanelClases.Columns["NombreEntrenador"].HeaderText = "Entrenador";
            PanelClases.Columns["NombreSala"].HeaderText = "Sala";
            PanelClases.Columns["Dia"].HeaderText = "Día";
            PanelClases.Columns["Hora"].HeaderText = "Hora";
            PanelClases.Columns["PlazasLibres"].HeaderText = "Plazas Libres";

            PanelClases.Columns["Horario"].Visible = false;
            PanelClases.Columns["IdActividad"].Visible = false;
        }
    }
}
