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

namespace Gentefit.Vistas.Admin.GestiEntrenadores
{
    public partial class AnadirEntrenador : Form
    {
        public AnadirEntrenador()
        {
            InitializeComponent();
        }

        private void BotonAnadir_Click(object sender, EventArgs e)
        {
            Entrenador entrenador = new Entrenador
            {
                nombre = CajaTextoNombre.Text,
                apellidos = CajaTextoApellidos.Text,
                dni = CajaTextoDNI.Text,
            };

            var logica = new LogicaEntrenadores();
            logica.AnadirEntrenador(entrenador);

            MessageBox.Show("Entrenador añadido correctamente.");
            this.Close();
            new MenuAdEntrenadores().Show();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new MenuAdEntrenadores().Show();
            this.Close();
        }
    }
}
