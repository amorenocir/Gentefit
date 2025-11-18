using Gentefit.Modelo;
using Gentefit.Modelo.Enums;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gentefit.Test
{
    public partial class TestClase : Form
    {
        private Clase clasePrueba;

        public TestClase()
        {
            InitializeComponent();
        }

        private void TestClase_Load(object sender, EventArgs e)
        {
            MessageBox.Show("TestClase cargado correctamente.",
                "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
        // TEST 1: Crear clase
      
        private void btnCrear_Click(object sender, EventArgs e)
        {
            clasePrueba = new Clase
            {
                idClase = 1,
                idActividad = 10,
                idEntrenador = 5,
                idSala = 3,
                dia = Dia.Lunes,
                hora = new TimeOnly(10, 00),
                horario = DateTime.Today.AddHours(10),
                plazasLibres = 5,
                enEspera = 0
            };

            MessageBox.Show(
                $"Clase creada:\n" +
                $"- Actividad: {clasePrueba.idActividad}\n" +
                $"- Entrenador: {clasePrueba.idEntrenador}\n" +
                $"- Sala: {clasePrueba.idSala}\n" +
                $"- Día: {clasePrueba.dia}\n" +
                $"- Hora: {clasePrueba.hora}\n" +
                $"- Plazas libres: {clasePrueba.plazasLibres}",
                "TEST OK",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

       
        // TEST 2: Modificar clase
    
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (clasePrueba == null)
            {
                MessageBox.Show("Primero debes crear una clase.", "ERROR");
                return;
            }

            clasePrueba.dia = Dia.Miercoles;
            clasePrueba.hora = new TimeOnly(18, 30);

            MessageBox.Show(
                "Clase modificada:\n" +
                $"- Nuevo día: {clasePrueba.dia}\n" +
                $"- Nueva hora: {clasePrueba.hora}",
                "TEST OK",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

       
        // TEST 3: Validar plazas libres
      
        private void btnValidarPlazas_Click(object sender, EventArgs e)
        {
            if (clasePrueba == null)
            {
                MessageBox.Show("Crea una clase primero.", "ERROR");
                return;
            }

            if (clasePrueba.plazasLibres < 0)
            {
                MessageBox.Show("ERROR: Plazas negativas ❌", "TEST ERROR");
            }
            else
            {
                MessageBox.Show("Plazas válidas ✔", "TEST OK");
            }
        }

        
        // TEST 4: Validar día y hora
       
        private void btnValidarHorario_Click(object sender, EventArgs e)
        {
            if (clasePrueba == null)
            {
                MessageBox.Show("Crea una clase primero.", "ERROR");
                return;
            }

            if (!Enum.IsDefined(typeof(Dia), clasePrueba.dia))
            {
                MessageBox.Show("Día inválido.", "TEST ERROR");
                return;
            }

            if (clasePrueba.hora.Hour < 6 || clasePrueba.hora.Hour > 22)
            {
                MessageBox.Show("Hora fuera de horario del gimnasio", "TEST ERROR");
            }
            else
            {
                MessageBox.Show("Día y hora válidos", "TEST OK");
            }
        }

       
        // TEST 5: Reset
        
        private void btnReset_Click(object sender, EventArgs e)
        {
            clasePrueba = null;
            MessageBox.Show("Clase reseteada.", "RESET");
        }
    }
}
