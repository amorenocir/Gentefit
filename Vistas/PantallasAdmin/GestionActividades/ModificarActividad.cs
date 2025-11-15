using Gentefit.Modelo;
using Gentefit.Vistas.PantallasAdmin.GestionActividades.PantallasActividadesAdmin;
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
using Gentefit.Modelo.Enums;

namespace Gentefit.Vistas.PantallasAdmin.GestionActividades
{
    public partial class ModificarActividad : Form
    {
        private readonly LogicaActividades logica = new LogicaActividades();
        public ModificarActividad()
        {
            InitializeComponent();
            this.Load += (s, e) => CargarDatos();
            PanelActividades.CellClick += PanelActividades_CellClick;
            CajaTextoId.ReadOnly = true;

        }

        private void PanelActividades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = PanelActividades.Rows[e.RowIndex];

            CajaTextoId.Text = fila.Cells["idActividad"].Value.ToString();
            CajaTextoNombre.Text = fila.Cells["nombre"].Value.ToString();
            CajaTextoDuracion.Text = fila.Cells["duracion"].Value.ToString();
            CajaComboIntensidad.Text = ((Intensidad)fila.Cells["intensidad"].Value).ToString();
            CajaTextoDescripcion.Text = fila.Cells["descripcion"].Value.ToString();
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(CajaTextoId.Text, out int id)) return;

            var actividad = new Actividad
            {
                idActividad = id,
                nombre = CajaTextoNombre.Text,
                duracion = int.TryParse(CajaTextoDuracion.Text, out int dur) ? dur : 0,
                intensidad = Enum.Parse<Intensidad>(CajaComboIntensidad.Text),
                descripcion = CajaTextoDescripcion.Text,

            };

            bool exito = logica.Modificar(actividad);
            if (exito)
            {
                MessageBox.Show("Cliente modificado correctamente");
                CargarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el cliente.");
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
            PanelActividades.DataSource = resultados;
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new ActividadesAdmin().Show();
            this.Hide();
        }
        private void BotonVerTodos_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            PanelActividades.DataSource = logica.ObtenerTodos();
        }
    }
}
