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
using Gentefit.db;
using Gentefit.Controlador;

namespace Gentefit.Vistas.PantallasAdmin
{
    public partial class AnadirEntrenador : Form
    {
        public AnadirEntrenador()
        {
            InitializeComponent();
            this.Text = "GenteFit";
        }

        private void BotonAnadir_Click(object sender, EventArgs e)
        {
            // Recoger los datos del formulario
            Entrenador nuevoEntrenador = new Entrenador
            {
                nombre = CajaTextoNombre.Text,
                apellidos = CajaTextoApellidos.Text,
                dni = CajaTextoDNI.Text
            };

            // Insertar en la base de datos usando EF Core
            using (var contexto = new GentefitContext())
            {
                var logica = new LogicaEntrenadores();
                logica.AnadirEntrenador(nuevoEntrenador);
            }

            MessageBox.Show("Entrenador añadido correctamente");
            new EntrenadoresAdmin().Show();
            this.Hide();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new EntrenadoresAdmin().Show();
            this.Hide();

        }
    }
}
