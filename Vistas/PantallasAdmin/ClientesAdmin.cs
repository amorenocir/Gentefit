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
using Microsoft.EntityFrameworkCore;

namespace Gentefit.Vistas.PantallasAdmin
{
    public partial class ClientesAdmin : Form
    {
        public ClientesAdmin()
        {
            InitializeComponent();
        }

        private void BotonAnadir_Click(object sender, EventArgs e)
        {
            new AnadirCliente().Show();
            this.Hide();
        }
        private void BotonListar_Click(object sender, EventArgs e)
        {
            new ListarClientes().Show();
            this.Hide();
        }
        private void BotonModificar_Click(object sender, EventArgs e)
        {
            new ModificarCliente().Show();
            this.Hide();
        }
        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            new EliminarCliente().Show();
            this.Hide();
        }
        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new InicioAdmin().Show();
            this.Hide();
        }

        private void Actividades_Click(object sender, EventArgs e)
        {

        }
    }
}
