using Gentefit.Controlador;
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

namespace Gentefit.Vistas.Admin.GestSalas
{
    public partial class ModificarSalas : Form
    {
        private LogicaSala logica = new LogicaSala();
        public ModificarSalas()
        {
            InitializeComponent();
            this.Load += (s, e) => CargarDatos();
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            Sala sala = new Sala
            {
                idSala = int.Parse(CajaTextoID.Text),
                nombre = CajaTextoNombre.Text,
            };
            bool exito = logica.ModificarSala(sala);
            if (exito)
            {
                MessageBox.Show("Sala modificada correctamente.");
                CargarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo modificar la sala");
            }
        }

        public void CargarDatos()
        {
            PanelSalas.DataSource = logica.ListarSalas();
        }

        private void PanelSalas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = PanelSalas.Rows[e.RowIndex];

            CajaTextoID.Text = fila.Cells["idSala"].Value.ToString();
            CajaTextoNombre.Text = fila.Cells["nombre"].Value.ToString();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new MenuAdSalas().Show();
            this.Close();
        }
    }
}
