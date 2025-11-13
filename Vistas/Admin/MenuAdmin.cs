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
using Gentefit.Vistas.Admin.GestActividades;
using Gentefit.Vistas.Admin.GestiEntrenadores;
using Gentefit.Vistas.Admin.GestSalas;

namespace Gentefit.Vistas.Admin
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
            this.Hide();
            new MenuAdActividades().Show();
        }

        private void BotonReservas_Click(object sender, EventArgs e)
        {
            //Abrir Menu X
            this.Hide();
            new MenuAdActividades().Show();
        }

        private void BotonMonitores_Click(object sender, EventArgs e)
        {
            new MenuAdEntrenadores().Show();
            this.Hide();
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
            new Login().Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void BotonSalas_Click(object sender, EventArgs e)
        {
            new MenuAdSalas().Show();
            this.Hide();
        }
    }
}
