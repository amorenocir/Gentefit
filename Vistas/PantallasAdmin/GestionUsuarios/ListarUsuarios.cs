using Gentefit.Modelo;
using Gentefit.Modelo.Enums;
using Gentefit.ModeloXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gentefit.Vistas.PantallasAdmin.GestionUsuarios
{
    public partial class ListarUsuarios : Form
    {
        private readonly LogicaUsuarios logicaUs = new LogicaUsuarios();
        public ListarUsuarios()
        {
            InitializeComponent();
            this.Load += (s, e) => PanelUsuarios.DataSource = logicaUs.ObtenerTodos();
        }
        
        private void BotonVolver_Click(object sender, EventArgs e)
        {
            new UsuariosAdmin().Show();
            this.Hide();
        }

        private void BotonExportarXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivos XML|*.xml",
                Title = "Exportar usuarios a XML"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                logicaUs.ExportarXml(saveFileDialog.FileName);
                MessageBox.Show("Usuarios exportados correctamente.");
            }
        }

        private void BotonImportarXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos XML|*.xml",
                Title = "Importar usuarios desde XML"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                logicaUs.ImportarXml(openFileDialog.FileName);
                MessageBox.Show("Clientes importados correctamente.");
                PanelUsuarios.DataSource = logicaUs.ObtenerTodos();

            }
        }

        public static UsuarioXml ConvertirAXml(Usuario usuario)
        {
            return new UsuarioXml
            {
                Id = usuario.idUsuario,
                Nombre = usuario.nombre,
                Apellidos = usuario.apellidos,
                Email = usuario.email,
                Contrasena = usuario.contrasena,
                Rol = usuario.rol.ToString(),
            };
        }

        public static Usuario ConvertirAEntidad(UsuarioXml usuarioXml)
        {
            return new Usuario
            {
                // Si el Id es autoincremental en la BD, podemos dejarlo en 0.
                idUsuario = usuarioXml.Id,
                nombre = usuarioXml.Nombre,
                apellidos = usuarioXml.Apellidos,
                email = usuarioXml.Email,
                contrasena = usuarioXml.Contrasena,
                rol = Enum.Parse<TipoRol>(usuarioXml.Rol),
            };
        }
    }
}
