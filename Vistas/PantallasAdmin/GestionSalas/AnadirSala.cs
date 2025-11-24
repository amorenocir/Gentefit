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
    public partial class AnadirSala : Form
    {
        LogicaSalas logica = new LogicaSalas();
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
            logica.AnadirSala(nuevoSala);

            MessageBox.Show("Sala añadida correctamente");
            new SalasAdmin().Show();
            this.Hide();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new SalasAdmin().Show();
            this.Hide();

        }
    }
}
