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

namespace Gentefit.Vistas.PantallasAdmin
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            timer1.Start();
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
            new MenuAdActividades().Show();
            this.Hide();
        }

        private void BotonReservas_Click(object sender, EventArgs e)
        {
            //Abrir Menu Reservas

        }

        private void BotonMonitores_Click(object sender, EventArgs e)
        {
            //Abrir Menu Monitores

        }

        private void BotonClientes_Click(object sender, EventArgs e)
        {
            new MenuAdClientes().Show();
            this.Hide();
        }

        private void BotonUsuarios_Click(object sender, EventArgs e)
        {
            //Abrir Menu Usuarios

        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
