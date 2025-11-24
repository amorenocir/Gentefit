using Gentefit.Controlador;
using Gentefit.Modelo;
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

namespace Gentefit.Vistas.PantallasCliente
{
    public partial class ActividadesCliente : Form
    {
        private Cliente clienteLogeado;
        private LogicaActividades logicaActividades = new LogicaActividades();
        public ActividadesCliente(Cliente cliente)
        {
            InitializeComponent();
            clienteLogeado = cliente;
            this.Load += (s, e) => PanelActividades.DataSource = logicaActividades.ObtenerTodos();
        }

        private void BotonReservar_Click(object sender, EventArgs e)
        {
            if (PanelActividades.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona una actividad para reservar.");
                return;
            }
            int idActividad = (int)PanelActividades.CurrentRow.Cells["idActividad"].Value;
            new ReservarCliente(clienteLogeado, idActividad).Show();
            this.Hide();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new InicioCliente(clienteLogeado).Show();
            this.Close();
        }

        private void BotonVer_Click(object sender, EventArgs e)
        {
            if(PanelActividades.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona una actividad para ver.");
                return;
            }
            int idActividad = (int)PanelActividades.CurrentRow.Cells["idActividad"].Value;

            new VerActividadCliente(clienteLogeado, idActividad).Show();
            this.Hide();
        }
    }
}
