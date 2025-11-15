using Gentefit.Modelo;
using Gentefit.Vistas.PantallasCliente;
using System;
using System.Drawing;
using System.Windows.Forms;
using Gentefit.Vistas.PantallasCliente.PantallasActividadesCliente;
namespace Gentefit.Vistas
{
    public partial class ActividadesCliente : Form
    {
        private Cliente clienteLogeado;

        public ActividadesCliente(Cliente cliente)
        {
            InitializeComponent();
            clienteLogeado = cliente;
            this.Load += ActividadesCliente_Load;
        }
        private void ImagenPerfil_Click(object sender, EventArgs e)
        {
            PerfilCliente perfil = new PerfilCliente(clienteLogeado.Clone());
            perfil.Show();
            this.Hide();
        }

        private void BotonInicio_Click(object sender, EventArgs e)
        {
            new InicioCliente(clienteLogeado.Clone()).Show();
            this.Hide();
        }

        private void BotonHorarios_Click(object sender, EventArgs e)
        {
            new HorariosCliente(clienteLogeado.Clone()).Show();
            this.Hide();
        }

        private void BotonReservas_Click(object sender, EventArgs e)
        {
            new ReservasCliente(clienteLogeado.Clone()).Show();
            this.Hide();
        }

        private void ActividadesCliente_Load(object sender, EventArgs e)
        {
            // Listado de actividades
            string[] actividades = { "BodyPump", "BodyCombat", "Zumba", "Yoga", "Spinning", "Core" };
            Image[] imagenes = { Gentefit.Properties.Resources.BodyPump,
                                 Gentefit.Properties.Resources.BodyCombat,
                                 Gentefit.Properties.Resources.Zumba,
                                 Gentefit.Properties.Resources.Yoga,
                                 Gentefit.Properties.Resources.Spining,
                                 Gentefit.Properties.Resources.Core };

            // Agregar tarjetas dinámicamente
            for (int i = 0; i < actividades.Length; i++)
            {
                string nombreActividad = actividades[i];
                TarjetaActividad tarjeta = new TarjetaActividad();
                tarjeta.Size = new Size(200, 220);
                tarjeta.Imagen = imagenes[i];
                tarjeta.Texto = actividades[i];

                tarjeta.Click += (s, args) => AbrirFormularioActividad(nombreActividad);

                PanelFlow.Controls.Add(tarjeta);
            }
        }


        // Método que abre el formulario según la actividad
        private void AbrirFormularioActividad(string actividad)
        {
            Form formularioActividad = actividad switch
            {
                "BodyPump" => new BodyPump(clienteLogeado.Clone()),
                "BodyCombat" => new BodyCombat(clienteLogeado.Clone()),
                "Zumba" => new Zumba(clienteLogeado.Clone()),
                "Yoga" => new Yoga(clienteLogeado.Clone()),
                "Spinning" => new Spinning(clienteLogeado.Clone()),
                "Core" => new Core(clienteLogeado.Clone()),
                _ => null
            };

            if (formularioActividad != null)
            {
                formularioActividad.Show();
                this.Hide();
            }
        }
    }
}

