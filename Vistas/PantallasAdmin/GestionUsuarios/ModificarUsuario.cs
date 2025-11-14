using Gentefit.Modelo;
using Gentefit.Modelo.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gentefit.Vistas.PantallasAdmin.GestionUsuarios
{
    public partial class ModificarUsuario : Form
    {
        private readonly LogicaUsuarios logica = new LogicaUsuarios();

        public ModificarUsuario()
        {
            InitializeComponent();
            this.Load += (s, e) => CargarDatos();
            this.PanelUsuarios.CellClick += PanelUsuarios_CellClick;
            CajaTextoId.ReadOnly = true;
        }

        private void PanelUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = PanelUsuarios.Rows[e.RowIndex];

            CajaTextoId.Text = fila.Cells["idUsuario"].Value.ToString();
            CajaTextoNombre.Text = fila.Cells["nombre"].Value.ToString();
            CajaTextoApellidos.Text = fila.Cells["apellidos"].Value.ToString();
            CajaTextoEmail.Text = fila.Cells["email"].Value.ToString();
            CajaTextoContrasena.Text = fila.Cells["contrasena"].Value.ToString();
            var valorRol = fila.Cells["rol"].Value?.ToString();
            if (valorRol != null)
            {
                CajaOpcionesRol.SelectedItem = valorRol;
            }
        }

    

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(CajaTextoId.Text, out int id)) return;

            var usuario = new Usuario
            {
                idUsuario = id,
                nombre = CajaTextoNombre.Text,
                apellidos = CajaTextoApellidos.Text,
                email = CajaTextoEmail.Text,
                contrasena = CajaTextoContrasena.Text,
                rol = Enum.Parse<TipoRol>(CajaOpcionesRol.SelectedItem.ToString()),

            };

            bool exito = logica.Modificar(usuario);
            if (exito)
            {
                MessageBox.Show("Usuario modificado correctamente");
                CargarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el usuario.");
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
            PanelUsuarios.DataSource = resultados;
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new UsuariosAdmin().Show();
            this.Hide();
        }
        private void BotonVerTodos_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            PanelUsuarios.DataSource = logica.ObtenerTodos();
        }
    }
}
