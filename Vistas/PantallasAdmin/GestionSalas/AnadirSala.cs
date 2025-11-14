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

namespace Gentefit.Vistas.PantallasAdmin 
{
    public partial class AnadirSala : Form
    {
        public AnadirSala()
        {
            InitializeComponent();
        }

        private void BotonAnadir_Click(object sender, EventArgs e)
        {
            // Recoger los datos del formulario
            Sala nuevoSala = new Sala
            {
                nombre = CajaTextoNombre.Text,
            };

            // Insertar en la base de datos usando EF Core
            using (var contexto = new GentefitContext())
            {
                var logica = new LogicaSalas();
                logica.AnadirSala(nuevoSala);
            }

            MessageBox.Show("Sala añadida correctamente");
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SalasAdmin().Show();

        }
    }
}
