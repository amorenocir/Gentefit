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

namespace Gentefit.Vistas.Admin.GestActividades.GestClases
{
    public partial class MenuAdClases : Form
    {
        private int idActividad;
        LogicaActividades logica = new LogicaActividades();
        public MenuAdClases(int idActividad)
        {
            InitializeComponent();
            this.idActividad = idActividad;
            List<Actividad> listaActividades = logica.BuscarPorID(idActividad);
            if(listaActividades.Count <= 0)
            {
                MessageBox.Show("No se ha encontrado la actividad en la base de datos.");
                new MenuActivClases().Show();
                this.Close();
            }
            else
            {
                Actividad actividadSeleccionada = listaActividades[0];
                string tituloMin = "Clases de " + actividadSeleccionada.nombre;
                Titulo.Text = tituloMin.ToUpper();
            }
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new MenuActivClases().Show();
            this.Close();
        }

        private void BotonAnadir_Click(object sender, EventArgs e)
        {
            new AnadirClase(idActividad).Show();
            this.Hide();
        }

        private void BotonListar_Click(object sender, EventArgs e)
        {
            new ListarClases(idActividad).Show();
            this.Hide();
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            new ModificarClases(idActividad).Show();
            this.Hide();
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            new EliminarClase(idActividad).Show();
            this.Hide();
        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }
    }
}
