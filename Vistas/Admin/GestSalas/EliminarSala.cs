using Gentefit.Controlador;
using Gentefit.Vistas.Admin.GestSalas;
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
    public partial class EliminarSala : Form
    {
        LogicaSala logica = new LogicaSala();
        public EliminarSala()
        {
            InitializeComponent();
            this.Load += (s, e) => CargarDatos();
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (PanelSalas == null)
            {
                MessageBox.Show("Por favor seleccione una sala para eliminar.");
                return;
            }
            int idSala = (int)PanelSalas.CurrentRow.Cells["idSala"].Value;
            var confirmacion = MessageBox.Show(
                "¿Seguro que quieres eliminar esta sala?",
                "Confirmación eliminación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                if (logica.EliminarSala(idSala))
                {
                    MessageBox.Show("Sala eliminada correctamente.");
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("No se encontró la sala en la base de datos.");
                }
            }
        }

        public void CargarDatos()
        {
            PanelSalas.DataSource = logica.ListarSalas();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new MenuAdSalas().Show();
            this.Close();
        }
    }
}
