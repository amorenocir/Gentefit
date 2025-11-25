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

namespace Gentefit.Vistas.PantallasCliente
{
    public partial class ListarReservasCliente : Form
    {
        private Cliente clienteLogeado;
        LogicaReservas logicaRes = new LogicaReservas();
        LogicaActividades logicaAct = new LogicaActividades();
        LogicaClases logicaClases = new LogicaClases();
        public ListarReservasCliente(Cliente cliente)
        {
            InitializeComponent();
            this.Text = "GenteFit";
            clienteLogeado = cliente;
            Titulo.Text = "Reservas de " + cliente.nombre + " " + cliente.apellidos;
            this.Load += (s, e) => CrearPanelReservas(cliente);
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (PanelReservas.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona una reserva para eliminar.");
                return;
            }
            int idRes = (int)PanelReservas.CurrentRow.Cells["idReserva"].Value;
            
            var confirmacion = MessageBox.Show(
                "¿Seguro que deseas eliminar esta reserva?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if(confirmacion == DialogResult.Yes)
            {
                if (logicaRes.EliminarReserva(idRes))
                {
                    MessageBox.Show("Reserva eliminada correctamente.");
                    CrearPanelReservas(clienteLogeado);
                }
                else
                {
                    MessageBox.Show("No se encontró la reserva en la base de datos.");
                }
            }           
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new InicioCliente(clienteLogeado).Show();
            this.Close();
        }

        private void CrearPanelReservas(Cliente cliente)
        {
            List<Reserva> todasRes = logicaRes.ObtenerTodos();
            List<Reserva> resDelCliente = new List<Reserva>();
            foreach(Reserva reserva in todasRes)
            {
                if(reserva.idCliente == cliente.idCliente)
                {
                    resDelCliente.Add(reserva);
                }
            }
            PanelReservas.DataSource = resDelCliente;
            PanelReservas.Columns["cliente"].Visible = false;
            PanelReservas.Columns["idCliente"].Visible = false;
            PanelReservas.Columns["idClase"].Visible = false;
            PanelReservas.Columns["clase"].Visible = false;
            PanelReservas.Columns["idReserva"].HeaderText = "ID de reserva";
            PanelReservas.Columns["idCliente"].HeaderText = "ID de cliente";
            PanelReservas.Columns["estado"].HeaderText = "Estado";
            PanelReservas.Columns["fechaClase"].HeaderText = "Fecha y hora de clase";
            PanelReservas.Columns["fechaReserva"].HeaderText = "Fecha y hora de reserva";
            if (!PanelReservas.Columns.Contains("nombreActividad"))
            {
                PanelReservas.Columns.Add("nombreActividad", "Actividad");
            }
            foreach(DataGridViewRow fila in PanelReservas.Rows)
            {
                Reserva reserva = fila.DataBoundItem as Reserva;

                Clase clase = logicaClases.BuscarPorId(reserva.idClase).FirstOrDefault();
                Actividad actividad = logicaAct.BuscarPorId(clase.idActividad).FirstOrDefault();
                fila.Cells["nombreActividad"].Value = actividad.nombre;
            }
        }
    }
}
