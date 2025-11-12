namespace Gentefit.Vistas.PantallasCliente.PantallasActividadesCliente
{
    partial class Yoga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yoga));
            BotonVolver = new Button();
            ImagenYoga = new PictureBox();
            EtiquetaYoga = new Label();
            TextoYoga = new Label();
            ((System.ComponentModel.ISupportInitialize)ImagenYoga).BeginInit();
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
            // ImagenYoga
            // 
            ImagenYoga.Image = Properties.Resources.Yoga;
            ImagenYoga.Location = new Point(156, 17);
            ImagenYoga.Name = "ImagenYoga";
            ImagenYoga.Size = new Size(492, 257);
            ImagenYoga.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenYoga.TabIndex = 20;
            ImagenYoga.TabStop = false;
            // 
            // EtiquetaYoga
            // 
            EtiquetaYoga.AutoSize = true;
            EtiquetaYoga.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            EtiquetaYoga.Location = new Point(51, 275);
            EtiquetaYoga.Name = "EtiquetaYoga";
            EtiquetaYoga.Size = new Size(70, 32);
            EtiquetaYoga.TabIndex = 18;
            EtiquetaYoga.Text = "Yoga";
            // 
            // TextoYoga
            // 
            TextoYoga.AutoSize = true;
            TextoYoga.Location = new Point(52, 317);
            TextoYoga.MaximumSize = new Size(700, 0);
            TextoYoga.Name = "TextoYoga";
            TextoYoga.Size = new Size(698, 60);
            TextoYoga.TabIndex = 26;
            TextoYoga.Text = resources.GetString("TextoYoga.Text");
            // 
            // Yoga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(TextoYoga);
            Controls.Add(BotonVolver);
            Controls.Add(ImagenYoga);
            Controls.Add(EtiquetaYoga);
            Name = "Yoga";
            Text = "Yoga";
            ((System.ComponentModel.ISupportInitialize)ImagenYoga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonVolver;
        private PictureBox ImagenYoga;
        private Label EtiquetaYoga;
        private Label TextoYoga;
    }
}