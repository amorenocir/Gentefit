namespace Gentefit.Vistas.PantallasCliente.PantallasActividadesCliente
{
    partial class BodyPump
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BodyPump));
            EtiquetaBodyPump = new Label();
            ImagenBodyPump = new PictureBox();
            BotonVolver = new Button();
            TextoBodyPump = new Label();
            ((System.ComponentModel.ISupportInitialize)ImagenBodyPump).BeginInit();
            SuspendLayout();
            // 
            // EtiquetaBodyPump
            // 
            EtiquetaBodyPump.AutoSize = true;
            EtiquetaBodyPump.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            EtiquetaBodyPump.Location = new Point(54, 272);
            EtiquetaBodyPump.Name = "EtiquetaBodyPump";
            EtiquetaBodyPump.Size = new Size(146, 32);
            EtiquetaBodyPump.TabIndex = 4;
            EtiquetaBodyPump.Text = "Body Pump";
            // 
            // ImagenBodyPump
            // 
            ImagenBodyPump.Image = Properties.Resources.BodyPump;
            ImagenBodyPump.Location = new Point(173, 12);
            ImagenBodyPump.Name = "ImagenBodyPump";
            ImagenBodyPump.Size = new Size(492, 257);
            ImagenBodyPump.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenBodyPump.TabIndex = 3;
            ImagenBodyPump.TabStop = false;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(665, 399);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(86, 31);
            BotonVolver.TabIndex = 17;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // TextoBodyPump
            // 
            TextoBodyPump.AutoSize = true;
            TextoBodyPump.Location = new Point(54, 313);
            TextoBodyPump.MaximumSize = new Size(700, 0);
            TextoBodyPump.Name = "TextoBodyPump";
            TextoBodyPump.Size = new Size(662, 60);
            TextoBodyPump.TabIndex = 23;
            TextoBodyPump.Text = resources.GetString("TextoBodyPump.Text");
            // 
            // BodyPump
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(TextoBodyPump);
            Controls.Add(BotonVolver);
            Controls.Add(EtiquetaBodyPump);
            Controls.Add(ImagenBodyPump);
            Name = "BodyPump";
            Text = "BodyPump";
            ((System.ComponentModel.ISupportInitialize)ImagenBodyPump).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label EtiquetaBodyPump;
        private PictureBox ImagenBodyPump;
        private Button BotonVolver;
        private Label TextoBodyPump;
    }
}