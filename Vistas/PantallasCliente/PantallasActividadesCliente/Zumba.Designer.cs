namespace Gentefit.Vistas.PantallasCliente.PantallasActividadesCliente
{
    partial class Zumba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zumba));
            BotonVolver = new Button();
            ImagenZumba = new PictureBox();
            EtiquetaZumba = new Label();
            TextoZumba = new Label();
            ((System.ComponentModel.ISupportInitialize)ImagenZumba).BeginInit();
            SuspendLayout();
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(664, 402);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(86, 31);
            BotonVolver.TabIndex = 21;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // ImagenZumba
            // 
            ImagenZumba.Image = Properties.Resources.Zumba;
            ImagenZumba.Location = new Point(156, 17);
            ImagenZumba.Name = "ImagenZumba";
            ImagenZumba.Size = new Size(492, 257);
            ImagenZumba.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenZumba.TabIndex = 20;
            ImagenZumba.TabStop = false;
            // 
            // EtiquetaZumba
            // 
            EtiquetaZumba.AutoSize = true;
            EtiquetaZumba.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            EtiquetaZumba.Location = new Point(51, 275);
            EtiquetaZumba.Name = "EtiquetaZumba";
            EtiquetaZumba.Size = new Size(94, 32);
            EtiquetaZumba.TabIndex = 18;
            EtiquetaZumba.Text = "Zumba";
            // 
            // TextoZumba
            // 
            TextoZumba.AutoSize = true;
            TextoZumba.Location = new Point(51, 318);
            TextoZumba.MaximumSize = new Size(700, 0);
            TextoZumba.Name = "TextoZumba";
            TextoZumba.Size = new Size(684, 60);
            TextoZumba.TabIndex = 27;
            TextoZumba.Text = resources.GetString("TextoZumba.Text");
            // 
            // Zumba
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(TextoZumba);
            Controls.Add(BotonVolver);
            Controls.Add(ImagenZumba);
            Controls.Add(EtiquetaZumba);
            Name = "Zumba";
            Text = "Zumba";
            ((System.ComponentModel.ISupportInitialize)ImagenZumba).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonVolver;
        private PictureBox ImagenZumba;
        private Label EtiquetaZumba;
        private Label TextoZumba;
    }
}