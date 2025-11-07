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
using Gentefit.db;

namespace Gentefit.Test
{
    public partial class TestConexion : Form
    {
        public TestConexion()
        {
            InitializeComponent();
            CargarDatos();
        }
        private void CargarDatos()
        {
            using (var contexto = new GentefitContext())
            {
                // Mostrar todos los clientes en el DataGridView
                dataGridView1.AutoGenerateColumns = true; // Genera columnas automáticamente
                dataGridView1.DataSource = contexto.Clientes.ToList();
                // Ocultar columnas de navegación
                if (dataGridView1.Columns["GimnasioNavigation"] != null)
                    dataGridView1.Columns["GimnasioNavigation"].Visible = false;

                if (dataGridView1.Columns["Reservas"] != null)
                    dataGridView1.Columns["Reservas"].Visible = false;
            }
        }
    }
}
