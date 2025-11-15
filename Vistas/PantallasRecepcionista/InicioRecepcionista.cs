using Gentefit.Vistas.PantallasAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gentefit.Vistas.PantallasRecepcionista
{
    public partial class InicioRecepcionista : Form
    {
        public InicioRecepcionista()
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
            new Login().Show();
            this.Hide();
        }
    }
}
