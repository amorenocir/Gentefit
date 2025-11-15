using Gentefit.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gentefit.Modelo;
using Gentefit.Modelo.Enums;

namespace Gentefit.Vistas.Admin.GestActividades
{
    public partial class ModificarActividad : Form
    {
        private readonly LogicaActividades logica = new LogicaActividades();
        public ModificarActividad()
        {
            InitializeComponent();
        }

        private void ModificarActividad_Load(object sender, EventArgs e)
        {
            CargarDatos();
            DespleIntensidad.DataSource = Enum.GetValues(typeof(Intensidad));
        }

        private void PanelActividades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = PanelActividades.Rows[e.RowIndex];

            CajaTextoID.Text = fila.Cells["idActividad"].Value.ToString();
            CajaTextoNombre.Text = fila.Cells["nombre"].Value.ToString();
            CajaTextoDuracion.Text = fila.Cells["duracion"].Value.ToString();
            CajaTextoDescripcion.Text = fila.Cells["descripcion"].Value.ToString();
            DespleIntensidad.SelectedItem = fila.Cells["Intensidad"].Value;
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            var actividad = new Actividad
            {
                idActividad = int.Parse(CajaTextoID.Text),
                nombre = CajaTextoNombre.Text,
                duracion = int.Parse(CajaTextoDuracion.Text),
                descripcion = CajaTextoDescripcion.Text,
                intensidad = (Intensidad)DespleIntensidad.SelectedItem
            };

            bool exito = logica.Modificar(actividad);
            if (exito)
            {
                MessageBox.Show("Actividad modificada correctamente.");
                CargarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo modificar la actividad.");
            }
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new MenuAdActividades().Show();
            this.Close();
        }

        private void CargarDatos()
        {
            PanelActividades.DataSource = logica.MostrarLista();
        }
    }
}
