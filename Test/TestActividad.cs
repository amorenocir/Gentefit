using Gentefit.Modelo;
using Gentefit.Modelo.Enums;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gentefit.Test
{
    public partial class TestActividad : Form
    {
        private Actividad actividadPrueba;
        private List<Actividad> listaActividades = new List<Actividad>();

        public TestActividad()
        {
            InitializeComponent();
        }

        private void TestActividad_Load(object sender, EventArgs e)
        {
            MessageBox.Show("TestActividad cargado correctamente.",
                "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

 
        // TEST 1: Crear Actividad
 
        private void btnCrear_Click(object sender, EventArgs e)
        {
            actividadPrueba = new Actividad
            {
                idActividad = 1,
                nombre = "Yoga",
                duracion = 60,
                descripcion = "Clase suave de relajación",
                intensidad = Intensidad.Media,
                listaClases = new List<Clase>()
            };

            listaActividades.Add(actividadPrueba);

            MessageBox.Show("Actividad creada correctamente:\n" +
                $"- Nombre: {actividadPrueba.nombre}\n" +
                $"- Duración: {actividadPrueba.duracion} min\n" +
                $"- Intensidad: {actividadPrueba.intensidad}",
                "TEST OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

  
        // TEST 2: Modificar Actividad
 
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (actividadPrueba == null)
            {
                MessageBox.Show("Primero crea una actividad.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            actividadPrueba.nombre = "Yoga Avanzado";
            actividadPrueba.duracion = 75;

            MessageBox.Show("Actividad modificada:\n" +
                $"- Nuevo Nombre: {actividadPrueba.nombre}\n" +
                $"- Nueva Duración: {actividadPrueba.duracion}",
                "TEST OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

 
        // TEST 3: Validar duración
 
        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (actividadPrueba == null)
            {
                MessageBox.Show("Crea una actividad primero.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (actividadPrueba.duracion <= 0)
            {
                MessageBox.Show("Duración inválida.", "TEST ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Duración válida", "TEST OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

      
        // TEST 4: Validar Intensidad
     
        private void btnIntensidad_Click(object sender, EventArgs e)
        {
            if (actividadPrueba == null)
            {
                MessageBox.Show("Crea una actividad primero.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Enum.IsDefined(typeof(Intensidad), actividadPrueba.intensidad))
            {
                MessageBox.Show("Intensidad no válida ", "TEST ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Intensidad válida  ({actividadPrueba.intensidad})",
                    "TEST OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    
        // TEST 5: Reset
   
        private void btnReset_Click(object sender, EventArgs e)
        {
            actividadPrueba = null;

            MessageBox.Show("Actividad reseteada.", "RESET",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
