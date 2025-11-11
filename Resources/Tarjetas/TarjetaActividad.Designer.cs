namespace Gentefit.Vistas.PantallasCliente
{
    partial class TarjetaActividad
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            ImagenTarjeta = new PictureBox();
            EtiquetaTarjeta = new Label();
            ((System.ComponentModel.ISupportInitialize)ImagenTarjeta).BeginInit();
            SuspendLayout();
            // 
            // ImagenTarjeta
            // 
            ImagenTarjeta.BackColor = Color.White;
            ImagenTarjeta.Dock = DockStyle.Top;
            ImagenTarjeta.Location = new Point(0, 0);
            ImagenTarjeta.Margin = new Padding(3, 4, 3, 4);
            ImagenTarjeta.Name = "ImagenTarjeta";
            ImagenTarjeta.Size = new Size(209, 143);
            ImagenTarjeta.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenTarjeta.TabIndex = 0;
            ImagenTarjeta.TabStop = false;
            ImagenTarjeta.Click += ImagenTarjeta_Click;
            // 
            // EtiquetaTarjeta
            // 
            EtiquetaTarjeta.BackColor = Color.Transparent;
            EtiquetaTarjeta.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            EtiquetaTarjeta.Location = new Point(3, 147);
            EtiquetaTarjeta.Name = "EtiquetaTarjeta";
            EtiquetaTarjeta.Size = new Size(203, 32);
            EtiquetaTarjeta.TabIndex = 1;
            EtiquetaTarjeta.Text = "Actividad";
            EtiquetaTarjeta.TextAlign = ContentAlignment.TopCenter;
            EtiquetaTarjeta.Click += EtiquetaTarjeta_Click;
            // 
            // TarjetaActividad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(EtiquetaTarjeta);
            Controls.Add(ImagenTarjeta);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TarjetaActividad";
            Size = new Size(209, 185);
            Load += TarjetaActividad_Load;
            ((System.ComponentModel.ISupportInitialize)ImagenTarjeta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ImagenTarjeta;
        private Label EtiquetaTarjeta;
    }
}
