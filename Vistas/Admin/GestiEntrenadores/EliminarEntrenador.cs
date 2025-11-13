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

namespace Gentefit.Vistas.Admin.GestiEntrenadores
{
    public partial class EliminarEntrenador : Form
    {
        private LogicaEntrenadores logica = new LogicaEntrenadores();
        public EliminarEntrenador()
        {
            InitializeComponent();
            this.Load += (s, e) => CargarDatos();
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(CajaTextoBuscar.Text, out int idBuscado))
            {
                MessageBox.Show("Introduce un ID válido.");
                return;
            }
            PanelEntrenadores.DataSource = logica.BuscarPorId(idBuscado);
        }

        private void BotonVerTodos_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            if(PanelEntrenadores == null)
            {
                MessageBox.Show("Por favor selecciona un entrenador para eliminar.");
                return;
            }

            int idEntrenador = (int)PanelEntrenadores.CurrentRow.Cells["idEntrenador"].Value;
            var confirmacion = MessageBox.Show(
                "¿Seguro que quieres eliminar este entrenador?",
                "Confirmar eliminación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if(confirmacion == DialogResult.Yes)
            {
                if (logica.EliminarEntrenador(idEntrenador))
                {
                    MessageBox.Show("Entrenador eliminado correctamente");
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("No se encontró el entrenador en la base de datos.");
                }
            }
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new MenuAdEntrenadores().Show();
            this.Close();
        }

        public void CargarDatos()
        {
            PanelEntrenadores.DataSource = logica.ListarEntrenadores();
        }
    }
}
