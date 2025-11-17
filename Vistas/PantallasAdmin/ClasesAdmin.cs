using Gentefit.Logica;
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
    public partial class ClasesAdmin : Form
    {
        LogicaActividades logica = new LogicaActividades();
        public ClasesAdmin()
        {
            InitializeComponent();
            this.Load += (s, e) => CargarDatos();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new InicioAdmin().Show();
            this.Close();
        }

        private void PanelActividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(CajaTextoBusqueda.Text, out int idBuscado))
            {
                MessageBox.Show("Introduce un ID válido.");
            }
            PanelActividades.DataSource = logica.BuscarPorId(idBuscado);
        }

        private void BotonVerTodos_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public void CargarDatos()
        {
            PanelActividades.DataSource = logica.ObtenerTodos();
        }

        private void BotonSeleccionar_Click(object sender, EventArgs e)
        {
            if (PanelActividades.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona una actividad.");
                return;
            }
            int id = (int)PanelActividades.CurrentRow.Cells["idActividad"].Value;
            new MenuAdClases(id).Show();
            this.Hide();
        }

        private void Clientes_Click(object sender, EventArgs e)
        {

        }
    }
}
