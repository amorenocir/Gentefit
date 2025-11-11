using Gentefit.Controlador;
using Gentefit.Modelo;
using Gentefit.Modelo.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gentefit.Vistas.Admin.GestActividades
{
    public partial class AnadirActividad : Form
    {
        public AnadirActividad()
        {
            InitializeComponent();
        }

        private void FormAnadirCliente_Load(object sender, EventArgs e)
        {
            DespleIntesidad.DataSource = Enum.GetValues(typeof(Intensidad));
        }

        private void BotonAnadir_Click(object sender, EventArgs e)
        {
            Actividad nuevaActividad = new Actividad
            {
                nombre = CajaTextoNombre.Text,
                duracion = int.Parse(CajaTextoDuracion.Text),
                descripcion = CajaTextoDescripcion.Text,
                intensidad = (Intensidad)DespleIntesidad.SelectedItem,
            };

            var logica = new LogicaActividades();
            logica.AddActividad(nuevaActividad);

            MessageBox.Show("Actividad añadida correctamente");
            this.Close();
            new MenuAdActividades().Show();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new MenuAdActividades().Show();
            this.Close();
        }

        private void CajaTextoNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void CajaTextoDuracion_TextChanged(object sender, EventArgs e)
        {

        }

        private void DespleIntesidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CajaTextoDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
