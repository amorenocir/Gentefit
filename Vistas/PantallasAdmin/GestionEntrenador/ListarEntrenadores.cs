using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Gentefit.db;
using Gentefit.ModeloXml;
using Gentefit.Modelo;

namespace Gentefit.Vistas.PantallasAdmin
{
    public partial class ListarEntrenadores : Form
    {
        private readonly LogicaEntrenadores logicaCl = new LogicaEntrenadores();

        public ListarEntrenadores()
        {
            InitializeComponent();
            this.Load += (s, e) => PanelEntrenadores.DataSource = logicaCl.ObtenerTodos();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new EntrenadoresAdmin().Show();
            this.Hide();
        }

        private void BotonExportarXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivos XML|*.xml",
                Title = "Exportar Entrenadores a XML"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                logicaCl.ExportarXml(saveFileDialog.FileName);
                MessageBox.Show("Entrenadores exportados correctamente.");
            }
        }

        private void BotonImportarXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos XML|*.xml",
                Title = "Importar Entrenadores desde XML"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                logicaCl.ImportarXml(openFileDialog.FileName);
                MessageBox.Show("Entrenadores importados correctamente.");
                PanelEntrenadores.DataSource = logicaCl.ObtenerTodos();

            }
        }

        public static ClienteXml ConvertirAXml(Cliente cliente)
        {
            return new ClienteXml
            {
                Id = cliente.idCliente,
                Nombre = cliente.nombre,
                Apellidos = cliente.apellidos,
                Dni = cliente.dni,
                Telefono = cliente.telefono,
                Email = cliente.email,
                Contrasena = cliente.contrasena,
            };
        }

        public static Cliente ConvertirAEntidad(ClienteXml clienteXml)
        {
            return new Cliente
            {
                // Si el Id es autoincremental en la BD, podemos dejarlo en 0.
                idCliente = clienteXml.Id,
                nombre = clienteXml.Nombre,
                apellidos = clienteXml.Apellidos,
                dni = clienteXml.Dni,
                telefono = clienteXml.Telefono,
                email = clienteXml.Email,
                contrasena = clienteXml.Contrasena,
            };
        }
    }
}
