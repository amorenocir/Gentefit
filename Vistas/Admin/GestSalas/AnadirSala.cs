using Gentefit.Controlador;
using Gentefit.db;
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

namespace Gentefit.Vistas.Admin.GestSalas
{
    public partial class AnadirSala : Form
    {
        public AnadirSala()
        {
            InitializeComponent();
        }

        private void CajaTextoNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonAnadir_Click(object sender, EventArgs e)
        {
            Sala sala = new Sala
            {
                nombre = CajaTextoNombre.Text,
            };
            var logica = new LogicaSala();
            logica.AnadirSala(sala);

            MessageBox.Show("Sala añadida correctamente.");
            this.Close();
            new MenuAdSalas().Show();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new MenuAdSalas().Show();
            this.Close();
        }
    }
}
