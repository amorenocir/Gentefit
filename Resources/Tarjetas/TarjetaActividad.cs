using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gentefit.Vistas.PantallasCliente
{
    public partial class TarjetaActividad : UserControl
    {
        public TarjetaActividad()
        {
            InitializeComponent();
            // Añadir el click de todos los elementos al click de la tarjeta general
            AnadirClickAHijos(this);
        }
        private void AnadirClickAHijos(Control padre)
        {
            foreach (Control hijo in padre.Controls)
            {
                hijo.Click += (s, e) => this.OnClick(e);
                if (hijo.HasChildren)
                {
                    AnadirClickAHijos(hijo);
                }
            }
        }
        public Image Imagen
        {
            get => ImagenTarjeta.Image;
            set => ImagenTarjeta.Image = value;
        }

        public string Texto
        {
            get => EtiquetaTarjeta.Text;
            set
            {
                EtiquetaTarjeta.Text = value;
                EtiquetaTarjeta.TextAlign = ContentAlignment.TopCenter;
            }
        }
    }
}
