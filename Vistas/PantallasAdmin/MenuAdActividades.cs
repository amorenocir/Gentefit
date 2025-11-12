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
    public partial class MenuAdActividades : Form
    {
        public MenuAdActividades()
        {
            InitializeComponent();
        }

        private void ImagenAnadir_Click(object sender, EventArgs e)
        {
            //Añadir una actividad
        }

        private void BotonBodyPump_Click(object sender, EventArgs e)
        {
            //Abrir actividad
        }
        private void BotonBodyCombat_Click(object sender, EventArgs e)
        {
            //Abrir actividad
        }
        private void BotonCore_Click(object sender, EventArgs e)
        {
            //Abrir actividad
        }
        private void BotonYoga_Click(object sender, EventArgs e)
        {
            //Abrir actividad
        }
        private void BotonSpinning_Click(object sender, EventArgs e)
        {
            //Abrir actividad
        }
        private void BotonZumba_Click(object sender, EventArgs e)
        {
            //Abrir actividad
        }
        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Gentefit.Vistas.PantallasAdmin.MenuAdmin().Show();
        }
    }
}
