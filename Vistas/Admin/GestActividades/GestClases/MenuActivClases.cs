using Gentefit.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gentefit.Vistas.Admin.GestActividades.GestClases
{
    public partial class MenuActivClases : Form
    {
        LogicaActividades logica = new LogicaActividades();
        public MenuActivClases()
        {
            InitializeComponent();
            this.Load += (s, e) => CargarDatos();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new MenuAdActividades().Show();
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
            PanelActividades.DataSource = logica.BuscarPorID(idBuscado);
        }

        private void BotonVerTodos_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public void CargarDatos()
        {
            PanelActividades.DataSource = logica.MostrarLista();
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
