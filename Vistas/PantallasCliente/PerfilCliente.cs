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

namespace Gentefit.Vistas.PantallasCliente
{
    public partial class PerfilCliente : Form
    {
        private Cliente clienteLogeado;
        public PerfilCliente(Cliente cliente)
        {
            InitializeComponent();
            clienteLogeado = cliente;
            this.Load += PerfilCliente_Load;
        }
        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new InicioCliente(clienteLogeado).Show();
            this.Hide();
        }
        private void BotonEditar_Click(object sender, EventArgs e)
        {
            new PerfilClienteEditar(clienteLogeado).Show();
            this.Hide();
        }

        public void PerfilCliente_Load(object sender, EventArgs e)
        {
            // Asignar los datos del cliente a los labels
            IDCliente.Text = clienteLogeado.idCliente.ToString();
            NombreCliente.Text = clienteLogeado.nombre;
            ApellidosCliente.Text = clienteLogeado.apellidos;
            DNICliente.Text = clienteLogeado.dni;
            EmailCliente.Text = clienteLogeado.email;
            telefonoCliente.Text = clienteLogeado.telefono.ToString();
            ContraseñaCliente.Text = clienteLogeado.contrasena;
        }

    }
}
