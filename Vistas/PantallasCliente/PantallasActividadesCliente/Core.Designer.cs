namespace Gentefit.Vistas.PantallasCliente.PantallasActividadesCliente
{
    partial class Core
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Core));
            EtiquetaCore = new Label();
            ImagenCore = new PictureBox();
            BotonVolver = new Button();
            TextoCore = new Label();
            ((System.ComponentModel.ISupportInitialize)ImagenCore).BeginInit();
            SuspendLayout();
            // 
            // EtiquetaCore
            // 
            EtiquetaCore.AutoSize = true;
            EtiquetaCore.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            EtiquetaCore.Location = new Point(60, 270);
            EtiquetaCore.Name = "EtiquetaCore";
            EtiquetaCore.Size = new Size(67, 32);
            EtiquetaCore.TabIndex = 7;
            EtiquetaCore.Text = "Core";
            // 
            // ImagenCore
            // 
            ImagenCore.Image = Properties.Resources.Core;
            ImagenCore.Location = new Point(165, 12);
            ImagenCore.Name = "ImagenCore";
            ImagenCore.Size = new Size(492, 257);
            ImagenCore.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenCore.TabIndex = 9;
            ImagenCore.TabStop = false;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(673, 397);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(86, 31);
            BotonVolver.TabIndex = 17;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // TextoCore
            // 
            TextoCore.AutoSize = true;
            TextoCore.Location = new Point(60, 302);
            TextoCore.MaximumSize = new Size(700, 0);
            TextoCore.Name = "TextoCore";
            TextoCore.Size = new Size(660, 60);
            TextoCore.TabIndex = 24;
            TextoCore.Text = resources.GetString("TextoCore.Text");
            // 
            // Core
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(TextoCore);
            Controls.Add(BotonVolver);
            Controls.Add(ImagenCore);
            Controls.Add(EtiquetaCore);
            Name = "Core";
            Text = "Core";
            ((System.ComponentModel.ISupportInitialize)ImagenCore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label EtiquetaCore;
        private PictureBox ImagenCore;
        private Button BotonVolver;
        private Label TextoCore;
    }
}