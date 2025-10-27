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
using Gentefit.Vistas;

namespace Gentefit.Vistas.Admin
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void ImagenPerfil_Click(object sender, EventArgs e)
        {
            //Abrir Menu Actividades
            //new MenuAd...().Show();
        }

        private void ImagenMensajes_Click(object sender, EventArgs e)
        {
            //Abrir Menu Actividades
           
        }

        private void BotonActividades_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuAdActividades().Show();
        }

        private void BotonReservas_Click(object sender, EventArgs e)
        {
            //Abrir Menu X
         
        }

        private void BotonMonitores_Click(object sender, EventArgs e)
        {
            //Abrir Menu X
           
        }

        private void BotonClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuAdClientes().Show();
        }

        private void BotonUsuarios_Click(object sender, EventArgs e)
        {
            //Abrir Menu X
           
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            new Login();
        }
    }
}
