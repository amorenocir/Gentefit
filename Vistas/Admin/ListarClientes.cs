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
using System.Xml.Serialization;

namespace Gentefit.Vistas.Admin
{
    public partial class ListarClientes : Form
    {
        public ListarClientes()
        {
            InitializeComponent();
            this.Load += cargarDatos;
        }

        private void cargarDatos(object sender, EventArgs e)
        {
            using var context = new GentefitContext();
            var clientes = context.Clientes.ToList(); // Obtiene los clientes
            PanelClientes.DataSource = clientes; // Asigna la lista al grid

        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new MenuAdClientes().Show();
            this.Hide();
        }

        private void BotonExportarXml_Click(object sender, EventArgs e)
        {
            using (var context = new GentefitContext())
            {
                var clientes = context.Clientes.ToList();
                var clientesXml = clientes.Select(c => ConvertirAXml(c)).ToList();

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos XML|*.xml";
                saveFileDialog.Title = "Exportar clientes a XML";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<ClienteXml>));
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        serializer.Serialize(fs, clientesXml);
                    }

                    MessageBox.Show("Clientes exportados correctamente.");
                }
            }
        }

        private void BotonImportarXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos XML|*.xml";
            openFileDialog.Title = "Importar clientes desde XML";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<ClienteXml>));
                using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    List<ClienteXml> clientesXml = (List<ClienteXml>)serializer.Deserialize(fs);
                    List<Cliente> clientes = clientesXml.Select(x =>
                    {
                        var c = ConvertirAEntidad(x);
                        c.Id = 0; // Ignoramos el ID del XML
                        return c;
                    }).ToList();

                    using (var context = new GentefitContext())
                    {
                        context.Clientes.AddRange(clientes);
                        context.SaveChanges();
                    }

                    MessageBox.Show("Clientes importados correctamente.");
                    cargarDatos(sender, e); // Actualiza el grid
                }
            }
        }

        public static ClienteXml ConvertirAXml(Cliente cliente)
        {
            return new ClienteXml
            {
                Id = cliente.Id,
                Nombre = cliente.Nombre,
                Apellidos = cliente.Apellidos,
                Dni = cliente.Dni,
                Telefono = cliente.Telefono,
                Email = cliente.Email,
                Contrasena = cliente.Contrasena,
                Gimnasio = cliente.Gimnasio
            };
        }

        public static Cliente ConvertirAEntidad(ClienteXml clienteXml)
        {
            return new Cliente
            {
                // Si el Id es autoincremental en la BD, podemos dejarlo en 0.
                Id = clienteXml.Id,
                Nombre = clienteXml.Nombre,
                Apellidos = clienteXml.Apellidos,
                Dni = clienteXml.Dni,
                Telefono = clienteXml.Telefono,
                Email = clienteXml.Email,
                Contrasena = clienteXml.Contrasena,
                Gimnasio = clienteXml.Gimnasio
            };
        }
    }
}
