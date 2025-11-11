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
        }
        public Image Imagen
        {
            get => ImagenTarjeta.Image;
            set => ImagenTarjeta.Image = value;
        }

        private void ImagenTarjeta_Click(object sender, EventArgs e)
        {

        }

        private void TarjetaActividad_Load(object sender, EventArgs e)
        {

        }

        private void EtiquetaTarjeta_Click(object sender, EventArgs e)
        {

        }

        public string Texto
        {
            get => EtiquetaTarjeta.Text;
            set
            {
                EtiquetaTarjeta.Text = value;
                EtiquetaTarjeta.TextAlign = ContentAlignment.TopCenter; // centra el texto
            }
        }
    }
}
