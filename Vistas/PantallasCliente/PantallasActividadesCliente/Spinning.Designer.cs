namespace Gentefit.Vistas.PantallasCliente.PantallasActividadesCliente
{
    partial class Spinning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spinning));
            BotonVolver = new Button();
            ImagenSpinning = new PictureBox();
            EtiquetaSpinning = new Label();
            TextoSpinning = new Label();
            ((System.ComponentModel.ISupportInitialize)ImagenSpinning).BeginInit();
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
            // ImagenSpinning
            // 
            ImagenSpinning.Image = Properties.Resources.Spining;
            ImagenSpinning.Location = new Point(156, 17);
            ImagenSpinning.Name = "ImagenSpinning";
            ImagenSpinning.Size = new Size(492, 257);
            ImagenSpinning.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenSpinning.TabIndex = 20;
            ImagenSpinning.TabStop = false;
            // 
            // EtiquetaSpinning
            // 
            EtiquetaSpinning.AutoSize = true;
            EtiquetaSpinning.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            EtiquetaSpinning.Location = new Point(51, 275);
            EtiquetaSpinning.Name = "EtiquetaSpinning";
            EtiquetaSpinning.Size = new Size(116, 32);
            EtiquetaSpinning.TabIndex = 18;
            EtiquetaSpinning.Text = "Spinning";
            // 
            // TextoSpinning
            // 
            TextoSpinning.AutoSize = true;
            TextoSpinning.Location = new Point(51, 320);
            TextoSpinning.MaximumSize = new Size(700, 0);
            TextoSpinning.Name = "TextoSpinning";
            TextoSpinning.Size = new Size(688, 60);
            TextoSpinning.TabIndex = 25;
            TextoSpinning.Text = resources.GetString("TextoSpinning.Text");
            TextoSpinning.Click += TextoCore_Click;
            // 
            // Spinning
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(TextoSpinning);
            Controls.Add(BotonVolver);
            Controls.Add(ImagenSpinning);
            Controls.Add(EtiquetaSpinning);
            Name = "Spinning";
            Text = "Spinning";
            ((System.ComponentModel.ISupportInitialize)ImagenSpinning).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonVolver;
        private PictureBox ImagenSpinning;
        private TextBox TextoSpinnig;
        private Label EtiquetaSpinning;
        private Label TextoSpinning;
    }
}