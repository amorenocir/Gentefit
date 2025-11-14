using Gentefit.db;
using Gentefit.Logica;
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

namespace Gentefit.Vistas.PantallasAdmin.GestionActividades
{
    public partial class AnadirActividad : Form
    {
        private readonly LogicaActividades logica = new LogicaActividades();
        public AnadirActividad()
        {
            InitializeComponent();
        }
        private void BotonAnadir_Click(object sender, EventArgs e)
        {
            // Recoger los datos del formulario
            Actividad nuevaActividad = new Actividad
            {
                nombre = CajaTextoNombre.Text,
                duracion = int.Parse(CajaTextoDuracion.Text),
                intensidad = Enum.Parse<Intensidad>(CajaComboIntensidad.Text),
                descripcion = CajaTextoDescripcion.Text,
            };

            // Insertar en la base de datos usando EF Core
            using (var contexto = new GentefitContext())
            {
                var logica = new LogicaActividades();
                logica.AnadirActividad(nuevaActividad);
            }

            MessageBox.Show("Actividad añadida correctamente");
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new ActividadesAdmin().Show();
            this.Hide();
        }
    }
}
