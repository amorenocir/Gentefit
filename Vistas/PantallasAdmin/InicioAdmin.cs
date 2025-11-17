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
    public partial class InicioAdmin : Form
    {
        public InicioAdmin()
        {
            InitializeComponent();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void ImagenPerfil_Click(object sender, EventArgs e)
        {
            //Abrir perfil admin
            this.Hide();

        }

        private void ImagenMensajes_Click(object sender, EventArgs e)
        {
            //Abrir Mensajes
            this.Hide();

        }

        private void BotonActividades_Click(object sender, EventArgs e)
        {
            new ActividadesAdmin().Show();
            this.Hide();
        }
        private void BotonClases_Click(object sender, EventArgs e)
        {
            new ClasesAdmin().Show();
            this.Hide();
        }

        private void BotonReservas_Click(object sender, EventArgs e)
        {
            new ReservasAdmin().Show();
            this.Hide();

        }

        private void BotonClientes_Click(object sender, EventArgs e)
        {
            new ClientesAdmin().Show();
            this.Hide();
        }

        private void BotonUsuarios_Click(object sender, EventArgs e)
        {
            new UsuariosAdmin().Show();
            this.Hide();

        }

        private void BotonEntrenadores_Click(object sender, EventArgs e)
        {
            new EntrenadoresAdmin().Show();
            this.Hide();

        }
        private void BotonSalas_Click(object sender, EventArgs e)
        {
            new SalasAdmin().Show();
            this.Hide();

        }


        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
