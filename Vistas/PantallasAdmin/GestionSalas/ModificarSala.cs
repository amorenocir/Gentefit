using Gentefit.Modelo;
using Gentefit.db;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Gentefit.Vistas.PantallasAdmin
{
    public partial class ModificarSala : Form
    {
        private readonly LogicaSalas logica = new LogicaSalas();

        public ModificarSala()
        {
            InitializeComponent();
            this.Load += (s, e) => CargarDatos();
            CajaTextoId.ReadOnly = true;
        }

        private void PanelSalas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = PanelSalas.Rows[e.RowIndex];

            CajaTextoId.Text = fila.Cells["idSala"].Value.ToString();
            CajaTextoNombre.Text = fila.Cells["nombre"].Value.ToString();
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(CajaTextoId.Text, out int id)) return;

            var Sala = new Sala
            {
                idSala = id,
                nombre = CajaTextoNombre.Text,
            };

            bool exito = logica.Modificar(Sala);
            if (exito)
            {
                MessageBox.Show("Sala modificado correctamente");
                CargarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el Sala.");
            }
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(CajaTextoBuscar.Text, out int idBuscado))
            {
                MessageBox.Show("Por favor introduce un ID válido.");
                return;
            }

            var resultados = logica.BuscarPorId(idBuscado);
            PanelSalas.DataSource = resultados;
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new SalasAdmin().Show();
            this.Hide();
        }
        private void BotonVerTodos_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            PanelSalas.DataSource = logica.ObtenerTodos();
        }
    }
}


