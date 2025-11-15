namespace Gentefit.Vistas.PantallasAdmin.GestionActividades.PantallasActividadesAdmin
{
    partial class BodyCombat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BodyCombat));
            BotonVolver = new Button();
            EtiquetaBodyCombat = new Label();
            ImagenBodyCombat = new PictureBox();
            TextoBodyCombat = new Label();
            ((System.ComponentModel.ISupportInitialize)ImagenBodyCombat).BeginInit();
            SuspendLayout();
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(658, 403);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(86, 31);
            BotonVolver.TabIndex = 21;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // EtiquetaBodyCombat
            // 
            EtiquetaBodyCombat.AutoSize = true;
            EtiquetaBodyCombat.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            EtiquetaBodyCombat.Location = new Point(56, 276);
            EtiquetaBodyCombat.Name = "EtiquetaBodyCombat";
            EtiquetaBodyCombat.Size = new Size(168, 32);
            EtiquetaBodyCombat.TabIndex = 19;
            EtiquetaBodyCombat.Text = "Body Combat";
            // 
            // ImagenBodyCombat
            // 
            ImagenBodyCombat.Image = Properties.Resources.BodyCombat;
            ImagenBodyCombat.Location = new Point(166, 16);
            ImagenBodyCombat.Name = "ImagenBodyCombat";
            ImagenBodyCombat.Size = new Size(492, 257);
            ImagenBodyCombat.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenBodyCombat.TabIndex = 18;
            ImagenBodyCombat.TabStop = false;
            // 
            // TextoBodyCombat
            // 
            TextoBodyCombat.AutoSize = true;
            TextoBodyCombat.Location = new Point(63, 318);
            TextoBodyCombat.MaximumSize = new Size(700, 0);
            TextoBodyCombat.Name = "TextoBodyCombat";
            TextoBodyCombat.Size = new Size(681, 60);
            TextoBodyCombat.TabIndex = 22;
            TextoBodyCombat.Text = resources.GetString("TextoBodyCombat.Text");
            // 
            // BodyCombat
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(810, 478);
            Controls.Add(TextoBodyCombat);
            Controls.Add(BotonVolver);
            Controls.Add(EtiquetaBodyCombat);
            Controls.Add(ImagenBodyCombat);
            Name = "BodyCombat";
            Text = "BodyCombat";
            ((System.ComponentModel.ISupportInitialize)ImagenBodyCombat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonVolver;
        private TextBox TextoBodycombat;
        private Label EtiquetaBodyCombat;
        private PictureBox ImagenBodyCombat;
        private Label TextoBodyCombat;
    }
}