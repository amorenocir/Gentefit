using Gentefit.Controlador;
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

namespace Gentefit.Vistas.Admin.GestActividades.GestClases
{
    public partial class AnadirClase : Form
    {
        private int idActividad;
        public AnadirClase(int idActividad)
        {
            InitializeComponent();
            this.idActividad = idActividad;
            DespleDia.DataSource = Enum.GetValues(typeof(Dia));
        }

        private void BotonSiguiente_Click(object sender, EventArgs e)
        {
            TimeOnly horaApertura = new TimeOnly(7, 0);
            TimeOnly horaCierre = new TimeOnly(22, 0);
            if(!TimeOnly.TryParse(CajaTextoHora.Text, out TimeOnly horaDada))
            {
                MessageBox.Show("Introduce una hora correcta.");
                return;
            }
            else if (horaDada < horaApertura || horaDada > horaCierre)
            {
                MessageBox.Show("El gimnasio solo abre de 8:00 a 22:00.");
                return;
            }

            Clase nuevaClase = new Clase
            {
                hora = horaDada,
                dia = (Dia)DespleDia.SelectedItem,
                idActividad = idActividad
            };
            
            new AnadirClaseEntrenador(nuevaClase, idActividad).Show();
            this.Close();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new MenuAdClases(idActividad).Show();
            this.Close();
        }
    }
}
