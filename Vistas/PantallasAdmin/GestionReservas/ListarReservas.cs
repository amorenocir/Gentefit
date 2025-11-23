using Gentefit.Controlador;
using Gentefit.Modelo;
using Gentefit.Vistas.PantallasEncargado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gentefit.Vistas.PantallasAdmin.GestionReservas
{
    public partial class ListarReservas : Form
    {
        private LogicaClientes logicaClientes = new LogicaClientes();
        private LogicaClases logicaClases = new LogicaClases();
        private LogicaReservas logicaReservas = new LogicaReservas();
        public ListarReservas()
        {
            InitializeComponent();
            this.Load += (s, e) => CargarDatos();
            CajaTextoBuscarCli.PlaceholderText = "Buscar por ID";
            CajaTextoBuscarCla.PlaceholderText = "Buscar por ID";
        }

        private void BotonTodo_Click(object sender, EventArgs e)
        {
            List<Reserva> lista = logicaReservas.ObtenerTodos();
            new ListarReservas2(lista, null, null).Show();
            this.Hide();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new ReservasAdmin().Show();
            this.Close();
        }

        private void BotonBuscarCli_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(CajaTextoBuscarCli.Text, out int idBuscado))
            {
                MessageBox.Show("Por favor introduce un ID válido.");
                return;
            }
            var resultados = logicaClientes.BuscarPorId(idBuscado);
            PanelClientes.DataSource = resultados;
        }

        private void BotonVerTodosCli_Click(object sender, EventArgs e)
        {
            CargarDatosClientes();
        }

        private void BotonBuscarCla_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(CajaTextoBuscarCla.Text, out int idBuscado))
            {
                MessageBox.Show("Por favor introduce un ID válido.");
                return;
            }
            var resultados = logicaClases.BuscarPorId(idBuscado);
            PanelClases.DataSource = resultados;
        }

        private void BotonVerTodosCla_Click(object sender, EventArgs e)
        {
            CargarDatosClases();
        }

        private void BotonSelecCli_Click(object sender, EventArgs e)
        {
            if (PanelClientes.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona un cliente.");
                return;
            }
            int idCliente = (int)PanelClientes.CurrentRow.Cells["idCliente"].Value;
            List<Cliente> posiblesCli = logicaClientes.BuscarPorId(idCliente);
            Cliente cliente = posiblesCli[0];

            List<Reserva> todasReservas = logicaReservas.ObtenerTodos();
            List<Reserva> lista = new List<Reserva>();
            foreach (Reserva r in todasReservas)
            {
                if (r.idCliente == idCliente)
                {
                    lista.Add(r);
                }
            }
            new ListarReservas2(lista, cliente, null).Show();
            this.Hide();
        }

        private void BotonSelecCla_Click(object sender, EventArgs e)
        {
            if (PanelClases.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona una clase.");
                return;
            }
            int idClase = (int)PanelClases.CurrentRow.Cells["idClase"].Value;
            List<Clase> posiblesCla = logicaClases.BuscarPorId(idClase);
            Clase clase = posiblesCla[0];

            List<Reserva> todasReservas = logicaReservas.ObtenerTodos();
            List<Reserva> lista = new List<Reserva>();
            foreach (Reserva r in todasReservas)
            {
                if (r.idClase == idClase)
                {
                    lista.Add(r);
                }
            }
            new ListarReservas2(lista, null, clase).Show();
            this.Hide();
        }
        private void CargarDatos()
        {
            CargarDatosClientes();
            CargarDatosClases();
        }

        private void CargarDatosClientes()
        {
            PanelClientes.DataSource = logicaClientes.ObtenerTodos();
            PanelClientes.Columns["idCliente"].HeaderText = "ID de cliente";
            PanelClientes.Columns["nombre"].HeaderText = "Nombre";
            PanelClientes.Columns["apellidos"].HeaderText = "Apellidos";
            PanelClientes.Columns["dni"].HeaderText = "DNI";
            PanelClientes.Columns["nombre"].HeaderText = "Nombre";
            PanelClientes.Columns["contrasena"].HeaderText = "Contraseña";
            PanelClientes.Columns["telefono"].HeaderText = "Teléfono";
        }

        private void CargarDatosClases()
        {
            PanelClases.DataSource = logicaClases.ObtenerClasesDisponibles();
            PanelClases.Columns["horario"].Visible = false;
            PanelClases.Columns["idActividad"].Visible = false;
            PanelClases.Columns["nombreActividad"].HeaderText = "Actividad";
            PanelClases.Columns["idClase"].HeaderText = "ID de clase";
            PanelClases.Columns["nombreEntrenador"].HeaderText = "Entrenador";
            PanelClases.Columns["nombreSala"].HeaderText = "Sala";
            PanelClases.Columns["PlazasLibres"].HeaderText = "Plazas libres";
            PanelClases.Columns["EnEspera"].HeaderText = "En espera";
        }
    }
}
