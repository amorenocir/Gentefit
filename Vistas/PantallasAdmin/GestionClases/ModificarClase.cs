using Gentefit.db;
using Gentefit.Modelo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gentefit.Vistas.PantallasAdmin.GestionClases
{
    public partial class ModificarClase : Form
    {
        private readonly LogicaClases logicaClases = new LogicaClases();
        public ModificarClase()
        {
            InitializeComponent();
            CargarCombos();
            this.Load += (s, e) => CargarDatos();
            PanelClases.CellClick += PanelClases_CellClick;
        }


        private void CargarCombos()
        {
            using var db = new GentefitContext();

            // Actividades
            CajaComboActividades.DataSource = db.Actividades.ToList();
            CajaComboActividades.DisplayMember = "nombre";
            CajaComboActividades.ValueMember = "idActividad";

            // Entrenadores
            CajaComboEntrenador.DataSource = db.Entrenadores.ToList();
            CajaComboEntrenador.DisplayMember = "nombre";  // puedes poner nombre + apellido si quieres
            CajaComboEntrenador.ValueMember = "idEntrenador";

            // Salas
            CajaComboSala.DataSource = db.Salas.ToList();
            CajaComboSala.DisplayMember = "nombre";
            CajaComboSala.ValueMember = "idSala";
        }

        private DateTime FechaHoraSeleccionada()
        {
            DateTime fecha = Calendario.SelectionStart;
            DateTime hora = CajaHora.Value;
            return fecha.Date.AddHours(hora.Hour).AddMinutes(hora.Minute);
        }

        private void PanelClases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = PanelClases.Rows[e.RowIndex];
            var claseSeleccionada = fila.DataBoundItem as LogicaClases.ClaseDTO;
            if (claseSeleccionada == null) return;

            // Actualizar combos según la fila seleccionada
            CajaComboActividades.SelectedIndex = CajaComboActividades
                .FindStringExact(claseSeleccionada.NombreActividad);

            CajaComboEntrenador.SelectedIndex = CajaComboEntrenador
                .FindStringExact(claseSeleccionada.NombreEntrenador);

            CajaComboSala.SelectedIndex = CajaComboSala
                .FindStringExact(claseSeleccionada.NombreSala);

            // Actualizar fecha y hora
            Calendario.SetDate(claseSeleccionada.Horario.Date);
            CajaHora.Value = claseSeleccionada.Horario;
        }


        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            if (PanelClases.CurrentRow == null) return;

            // Obtener la clase seleccionada del grid
            var claseSeleccionada = PanelClases.CurrentRow.DataBoundItem as LogicaClases.ClaseDTO;
            if (claseSeleccionada == null) return;

            var clase = new Clase
            {
                idClase = claseSeleccionada.IdClase,
                idActividad = (int)CajaComboActividades.SelectedValue,
                actividad = (Actividad)CajaComboActividades.SelectedItem,
                idEntrenador = (int)CajaComboEntrenador.SelectedValue,
                entrenador = (Entrenador)CajaComboEntrenador.SelectedItem,
                idSala = (int)CajaComboSala.SelectedValue,
                sala = (Sala)CajaComboSala.SelectedItem,
                horario = FechaHoraSeleccionada(),
                plazasLibres = 16,
                enEspera = 0,
            };

            bool exito = logicaClases.ModificarClase(clase);

            if (exito)
            {
                MessageBox.Show("Clase modificada correctamente");
                // Actualizar la instancia en la lista local
                var dto = listaClases.FirstOrDefault(c => c.IdClase == clase.idClase);
                if (dto != null)
                {
                    dto.NombreActividad = clase.actividad.nombre;
                    dto.NombreEntrenador = clase.entrenador.nombre;
                    dto.NombreSala = clase.sala.nombre;
                    dto.Horario = clase.horario;
                    dto.PlazasLibres = clase.plazasLibres;
                }

                PanelClases.Refresh();

            }
            else
            {
                MessageBox.Show("No se pudo modificar la clase.");
            }
        }


        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new ClasesAdmin().Show();
            this.Hide();
        }
        private List<LogicaClases.ClaseDTO> listaClases;
        private void CargarDatos()
        {
            listaClases = logicaClases.ObtenerClasesDisponibles();
            PanelClases.DataSource = listaClases;
        }
    }
}
