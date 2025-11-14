using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using Gentefit.db;
using Gentefit.Modelo;
using Microsoft.EntityFrameworkCore;


namespace Gentefit.Vistas.PantallasAdmin.GestionClases
{
    public partial class AnadirClase : Form
    {
        private LogicaClases logica;
        public AnadirClase()
        {
            InitializeComponent();
            logica = new LogicaClases();
            CargarCombos();
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
        private void BotonAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el usuario haya seleccionado todos los combos
                if (CajaComboActividades.SelectedItem == null ||
                    CajaComboEntrenador.SelectedItem == null ||
                    CajaComboSala.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecciona todos los campos.");
                    return;
                }

                // Obtener los valores seleccionados de los combos
                int idActividad = (int)CajaComboActividades.SelectedValue;
                int idEntrenador = (int)CajaComboEntrenador.SelectedValue;
                int idSala = (int)CajaComboSala.SelectedValue;
            
                // Obtener fecha del calendario
                DateTime fecha = Calendario.SelectionStart;

                // Obtener hora del selector de horas
                int hora = CajaHora.Value.Hour;

                // Combinar fecha + hora
                DateTime fechaHoraClase = fecha.AddHours(hora);

                // Crear nueva clase
                Clase nuevaClase = new Clase
                {
                    idActividad = idActividad,
                    idEntrenador = idEntrenador,
                    idSala = idSala,
                    horario = fechaHoraClase,
                    plazasLibres = 16,
                    enEspera = 0,
                    reservas = new List<Reserva>()
                };

                // Guardar en BD
                logica.GuardarClase(nuevaClase);

                MessageBox.Show("Clase añadida correctamente.");
            }

            catch (DbUpdateException dbEx)
            {
                // Mostrar error específico de EF Core / MySQL
                MessageBox.Show("Error al guardar en la base de datos: " + dbEx.InnerException?.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir la clase: " + ex.Message);
            }
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new ClasesAdmin().Show();
            this.Hide();
        }
    }
}
