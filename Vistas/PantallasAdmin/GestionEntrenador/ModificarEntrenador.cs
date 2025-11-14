using Gentefit.Modelo;
using Gentefit.db;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Gentefit.Vistas.PantallasAdmin
{
    public partial class ModificarEntrenador : Form
    {
        private readonly LogicaEntrenadores logica = new LogicaEntrenadores();

        public ModificarEntrenador()
        {
            InitializeComponent();
            this.Load += (s, e) => CargarDatos();
            CajaTextoId.ReadOnly = true;
        }

        private void PanelEntrenadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = PanelEntrenadores.Rows[e.RowIndex];

            CajaTextoId.Text = fila.Cells["idEntrenador"].Value.ToString();
            CajaTextoNombre.Text = fila.Cells["nombre"].Value.ToString();
            CajaTextoApellidos.Text = fila.Cells["apellidos"].Value.ToString();
            CajaTextoDNI.Text = fila.Cells["dni"].Value.ToString();

        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(CajaTextoId.Text, out int id)) return;

            var Entrenador = new Entrenador
            {
                idEntrenador = id,
                nombre = CajaTextoNombre.Text,
                apellidos = CajaTextoApellidos.Text,
                dni = CajaTextoDNI.Text,
            };

            bool exito = logica.Modificar(Entrenador);
            if (exito)
            {
                MessageBox.Show("Entrenador modificado correctamente");
                CargarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el Entrenador.");
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
            PanelEntrenadores.DataSource = resultados;
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new EntrenadoresAdmin().Show();
            this.Hide();
        }
        private void BotonVerTodos_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            PanelEntrenadores.DataSource = logica.ObtenerTodos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


