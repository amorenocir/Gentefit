using Gentefit.Modelo;
using Gentefit.Vistas.PantallasAdmin.GestionReservas;
using Gentefit.Vistas.PantallasEncargado;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gentefit.Vistas.PantallasAdmin
{
    public partial class ReservasAdmin : Form
    {
        public ReservasAdmin()
        {
            InitializeComponent();
            this.Text = "GenteFit";
        }

        private void BotonAnadir_Click(object sender, EventArgs e)
        {
            new AnadirReserva().Show();
            this.Hide();
        }
        private void BotonListar_Click(object sender, EventArgs e)
        {
            new ListarReservas().Show();
            //new EscogerListaReservas().Show();
            this.Hide();
        }
        private void BotonModificar_Click(object sender, EventArgs e)
        {
            new ModificarReserva().Show();
            this.Hide();
        }
        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            new EliminarReserva().Show();
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
