using Gentefit.Modelo;
using Gentefit.Vistas.PantallasAdmin;
using Gentefit.Vistas.PantallasCliente;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gentefit.Vistas
{
    public partial class InicioCliente : Form
    {
        private Cliente clienteLogeado;

        public InicioCliente(Cliente cliente)
        {
            InitializeComponent();
            clienteLogeado = cliente;
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            FechaYHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void BotonActividades_Click(object sender, EventArgs e)
        {
            new ActividadesCliente(clienteLogeado).Show();
            this.Hide();
        }
        private void BotonHorarios_Click(object sender, EventArgs e)
        {
            new HorariosCliente(clienteLogeado).Show();
            this.Hide();
        }
        private void BotonReservas_Click(object sender, EventArgs e)
        {
            new ReservasCliente(clienteLogeado).Show();
            this.Hide();
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
        private void ImagenPerfil_Click(object sender, EventArgs e)
        {
            PerfilCliente perfil = new PerfilCliente(clienteLogeado);
            perfil.Show();
            this.Hide();
        }

    }
}
