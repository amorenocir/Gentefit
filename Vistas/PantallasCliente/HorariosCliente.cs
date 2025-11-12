using Gentefit.Modelo;
using Gentefit.Vistas.PantallasCliente;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gentefit.Vistas
{
    public partial class HorariosCliente : Form
    {
        private Cliente clienteLogeado;
        public HorariosCliente(Cliente cliente)
        {
            InitializeComponent();
            clienteLogeado = cliente;
            CargarClases();
        }
        private void ImagenPerfil_Click(object sender, EventArgs e)
        {
            PerfilCliente perfil = new PerfilCliente(clienteLogeado);
            perfil.Show();
            this.Hide();
        }
        
        private void BotonInicio_Click(object sender, EventArgs e)
        {
            new InicioCliente(clienteLogeado).Show();
            this.Hide();
        }
        private void BotonActividades_Click(object sender, EventArgs e)
        {
            new ActividadesCliente(clienteLogeado).Show();
            this.Hide();
        }
        
        private void BotonReservas_Click(object sender, EventArgs e)
        {
            new ReservasCliente(clienteLogeado).Show();
            this.Hide();
        }

        private void BotonReservar_Click(object sender, EventArgs e)
        {
            if (PanelHorarios.CurrentRow == null) return;

            var claseDTO = (LogicaClases.ClaseDTO)PanelHorarios.CurrentRow.DataBoundItem;
            int idClienteLogueado = clienteLogeado.idCliente; // tu cliente logueado

            LogicaReservas logicaReservas = new LogicaReservas();
            bool exito = logicaReservas.ReservarClase(claseDTO.IdClase, idClienteLogueado);

            if (exito)
            {
                MessageBox.Show(claseDTO.PlazasLibres > 0
                    ? "Reserva confirmada."
                    : "No quedan plazas disponibles. Te has añadido a la lista de espera.");

                // Refrescar grid de clases
                CargarClases();
            }
            else
            {
                MessageBox.Show("No se pudo realizar la reserva.");
            }
        }

        private void CargarClases()
        {
            LogicaClases logica = new LogicaClases();
            var clasesDisponibles = logica.ObtenerClasesDisponibles();

            PanelHorarios.DataSource = clasesDisponibles;

            // Ajustar nombres de columnas
            PanelHorarios.Columns["IdClase"].HeaderText = "ID";
            PanelHorarios.Columns["NombreActividad"].HeaderText = "Actividad";
            PanelHorarios.Columns["NombreEntrenador"].HeaderText = "Entrenador";
            PanelHorarios.Columns["NombreSala"].HeaderText = "Sala";
            PanelHorarios.Columns["Horario"].HeaderText = "Horario";
            PanelHorarios.Columns["PlazasLibres"].HeaderText = "Plazas libres";
            PanelHorarios.Columns["EnEspera"].HeaderText = "En espera";
        }

    }
}
