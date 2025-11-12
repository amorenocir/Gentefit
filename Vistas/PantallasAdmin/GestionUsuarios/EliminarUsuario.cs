using Gentefit.db;
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

namespace Gentefit.Vistas.PantallasAdmin.GestionUsuarios
{
    public partial class EliminarUsuario : Form
    {
        private LogicaUsuarios logica;

        public EliminarUsuario()
        {
            InitializeComponent();
            this.Load += EliminarUsuario_Load;
        }

        private void EliminarUsuario_Load(object sender, EventArgs e)
        {
            using var contexto = new GentefitContext();
            logica = new LogicaUsuarios();
            PanelUsuarios.DataSource = logica.ObtenerTodos();
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(CajaTextoBuscar.Text, out int idBuscado))
            {
                MessageBox.Show("Por favor introduce un ID válido.");
                return;
            }
            PanelUsuarios.DataSource = logica.BuscarPorId(idBuscado);
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (PanelUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona un usuario para eliminar.");
                return;
            }

            int idCliente = (int)PanelUsuarios.CurrentRow.Cells["idUsuario"].Value;

            var confirmacion = MessageBox.Show(
                "¿Seguro que deseas eliminar este usuario?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                if (logica.EliminarUsuario(idCliente))
                {
                    MessageBox.Show("Usuario eliminado correctamente.");
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario en la base de datos.");
                }
            }
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UsuariosAdmin().Show();
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
