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
            this.Text = "GenteFit";
            clienteLogeado = cliente;
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }
     
        private void BotonActividades_Click(object sender, EventArgs e)
        {
            //new ActividadesCliente(clienteLogeado.Clone()).Show();
            new ActividadesCliente(clienteLogeado).Show();
            this.Hide();
        }
        private void BotonHorarios_Click(object sender, EventArgs e)
        {
            new CalendarioClientes(clienteLogeado).Show();
            this.Hide();
        }
        private void BotonReservas_Click(object sender, EventArgs e)
        {
            new ListarReservasCliente(clienteLogeado).Show();
            this.Hide();
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }
        private void ImagenPerfil_Click(object sender, EventArgs e)
        {
            PerfilCliente perfil = new PerfilCliente(clienteLogeado);
            perfil.Show();
            this.Hide();
        }

        private void InicioCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
