namespace Gentefit.Vistas.PantallasAdmin
{
    partial class AnadirSala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnadirSala));
            Nombre = new Label();
            CajaTextoNombre = new TextBox();
            pictureBox1 = new PictureBox();
            BotonAnadir = new Button();
            BotonVolver = new Button();
            AnadirSalas = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(128, 202);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(64, 20);
            Nombre.TabIndex = 0;
            Nombre.Text = "Nombre";
            // 
            // CajaTextoNombre
            // 
            CajaTextoNombre.Location = new Point(128, 226);
            CajaTextoNombre.Margin = new Padding(3, 4, 3, 4);
            CajaTextoNombre.Name = "CajaTextoNombre";
            CajaTextoNombre.Size = new Size(259, 27);
            CajaTextoNombre.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(548, 51);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 343);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // BotonAnadir
            // 
            BotonAnadir.BackColor = Color.DarkOrange;
            BotonAnadir.Location = new Point(128, 319);
            BotonAnadir.Margin = new Padding(3, 4, 3, 4);
            BotonAnadir.Name = "BotonAnadir";
            BotonAnadir.Size = new Size(80, 45);
            BotonAnadir.TabIndex = 19;
            BotonAnadir.Text = "Añadir";
            BotonAnadir.UseVisualStyleBackColor = false;
            BotonAnadir.Click += BotonAnadir_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(306, 319);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(81, 45);
            BotonVolver.TabIndex = 20;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // AnadirSalas
            // 
            AnadirSalas.AutoSize = true;
            AnadirSalas.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            AnadirSalas.ForeColor = Color.DarkSlateGray;
            AnadirSalas.Location = new Point(121, 140);
            AnadirSalas.Name = "AnadirSalas";
            AnadirSalas.Size = new Size(247, 46);
            AnadirSalas.TabIndex = 21;
            AnadirSalas.Text = "AÑADIR SALA";
            // 
            // AnadirSala
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(AnadirSalas);
            Controls.Add(BotonVolver);
            Controls.Add(BotonAnadir);
            Controls.Add(CajaTextoNombre);
            Controls.Add(Nombre);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AnadirSala";
            Text = "AnadirSala";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nombre;
        private TextBox CajaTextoNombre;
        private PictureBox pictureBox1;
        private Button BotonAnadir;
        private Button BotonVolver;
        private Label AnadirSalas;
    }
}