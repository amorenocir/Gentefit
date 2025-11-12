using Gentefit.Modelo;
using Gentefit.Vistas.PantallasCliente;
using System;
using System.Drawing;
using System.Windows.Forms;

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
            PerfilCliente perfil = new PerfilCliente(clienteLogeado);
            perfil.Show();
            this.Hide();
        }

        private void BotonInicio_Click(object sender, EventArgs e)
        {
            new MenuCliente(clienteLogeado).Show();
            this.Hide();
        }

        private void BotonHorarios_Click(object sender, EventArgs e)
        {
            new HorariosCliente(clienteLogeado).Show();
            this.Hide();
        }

        private void BotonReservas_Click(object sender, EventArgs e)
        {
            new ReservasCliente(clienteLogeado).Show();
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
                TarjetaActividad tarjeta = new TarjetaActividad();
                tarjeta.Size = new Size(200, 220);
                tarjeta.Imagen = imagenes[i];
                tarjeta.Texto = actividades[i];
                PanelFlow.Controls.Add(tarjeta);
            }
        }
    }
}

