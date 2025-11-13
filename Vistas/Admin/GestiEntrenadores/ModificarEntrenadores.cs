using Gentefit.Controlador;
using Gentefit.Modelo;

namespace Gentefit.Vistas.Admin.GestiEntrenadores
{
    public partial class ModificarEntrenadores : Form
    {
        private readonly LogicaEntrenadores logica = new LogicaEntrenadores();
        public ModificarEntrenadores()
        {
            InitializeComponent();
            this.Load += (s, e) => CargarDatos();
        }

        private void ModificarEntrenadores_Load(object sender, EventArgs e)
        {

        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            Entrenador entrenador = new Entrenador
            {
                idEntrenador = int.Parse(CajaTextoID.Text),
                nombre = CajaTextoNombre.Text,
                apellidos = CajaTextoApellidos.Text,
                dni = CajaTextoDNI.Text,
            };

            bool exito = logica.ModificarEntrenador(entrenador);
            if (exito)
            {
                MessageBox.Show("Entrenador modificado correctamente.");
                CargarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el entrenador.");
            }
        }

        public void CargarDatos()
        {
            PanelEntrenadores.DataSource = logica.ListarEntrenadores();
        }

        private void PanelEntrenadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = PanelEntrenadores.Rows[e.RowIndex];

            CajaTextoID.Text = fila.Cells["idEntrenador"].Value.ToString();
            CajaTextoNombre.Text = fila.Cells["nombre"].Value.ToString();
            CajaTextoApellidos.Text = fila.Cells["apellidos"].Value.ToString();
            CajaTextoDNI.Text = fila.Cells["dni"].Value.ToString();
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(CajaTextoBuscar.Text, out int idBuscado))
            {
                MessageBox.Show("Por favor introduzca un ID válido.");
                return;
            }

            var resultado = logica.BuscarPorId(idBuscado);
            PanelEntrenadores.DataSource = resultado;
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            new MenuAdEntrenadores().Show();
        }
    }
}
