using Gentefit.Modelo;
using Gentefit.Vistas.PantallasAdmin;
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
using Gentefit.Vistas.PantallasCliente;
using Gentefit.Logica;

namespace Gentefit.Vistas.PantallasCliente
{
    public partial class PerfilClienteEditar : Form
    {
        private readonly LogicaClientes logica = new LogicaClientes();
        private Cliente clienteLogeado;

        public PerfilClienteEditar(Cliente cliente)
        {
            InitializeComponent();
            clienteLogeado = cliente;
            this.Load += PerfilClienteEditar_Load;
        }
        private void PerfilClienteEditar_Load(object sender, EventArgs e)
        {
            CajaTextoId.Text = clienteLogeado.idCliente.ToString();
            CajaTextoNombre.Text = clienteLogeado.nombre;
            CajaTextoApellidos.Text = clienteLogeado.apellidos;
            CajaTextoDNI.Text = clienteLogeado.dni;
            CajaTextoEmail.Text = clienteLogeado.email;
            CajaTextoTelefono.Text = clienteLogeado.telefono.ToString();
            CajaTextoContrasena.Text = clienteLogeado.contrasena;
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(CajaTextoId.Text, out int id)) return;

            var cliente = new Cliente
            {
                idCliente = id,
                nombre = CajaTextoNombre.Text,
                apellidos = CajaTextoApellidos.Text,
                dni = CajaTextoDNI.Text,
                telefono = int.Parse(CajaTextoTelefono.Text),
                email = CajaTextoEmail.Text,
                contrasena = CajaTextoContrasena.Text
            };

            bool exito = logica.Modificar(cliente);
            if (exito)
            {
                // Actualizamos la referencia de clienteLogeado con los datos actualizados
                clienteLogeado = logica.BuscarPorId(clienteLogeado.idCliente).FirstOrDefault();


                // Actualizamos los campos de texto si quieres ver los cambios reflejados
                CajaTextoNombre.Text = clienteLogeado.nombre;
                CajaTextoApellidos.Text = clienteLogeado.apellidos;
                CajaTextoDNI.Text = clienteLogeado.dni;
                CajaTextoEmail.Text = clienteLogeado.email;
                CajaTextoTelefono.Text = clienteLogeado.telefono.ToString();
                CajaTextoContrasena.Text = clienteLogeado.contrasena;

                MessageBox.Show("Cliente modificado correctamente");
            
            }
            else
            {
                MessageBox.Show("No se pudo modificar el cliente.");
            }
        }
        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new PerfilCliente(clienteLogeado).Show();
            this.Hide();
        }

    }
}
