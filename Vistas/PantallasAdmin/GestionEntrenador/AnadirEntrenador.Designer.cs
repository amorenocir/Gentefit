namespace Gentefit.Vistas.PantallasAdmin
{
    partial class AnadirEntrenador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnadirEntrenador));
            Nombre = new Label();
            CajaTextoNombre = new TextBox();
            CajaTextoApellidos = new TextBox();
            label2 = new Label();
            CajaTextoDNI = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            BotonAnadir = new Button();
            BotonVolver = new Button();
            AnadirEntrenadores = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(125, 89);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(64, 20);
            Nombre.TabIndex = 0;
            Nombre.Text = "Nombre";
            // 
            // CajaTextoNombre
            // 
            CajaTextoNombre.Location = new Point(125, 113);
            CajaTextoNombre.Margin = new Padding(3, 4, 3, 4);
            CajaTextoNombre.Name = "CajaTextoNombre";
            CajaTextoNombre.Size = new Size(259, 27);
            CajaTextoNombre.TabIndex = 1;
            // 
            // CajaTextoApellidos
            // 
            CajaTextoApellidos.Location = new Point(125, 189);
            CajaTextoApellidos.Margin = new Padding(3, 4, 3, 4);
            CajaTextoApellidos.Name = "CajaTextoApellidos";
            CajaTextoApellidos.Size = new Size(259, 27);
            CajaTextoApellidos.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 165);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Apellidos";
            // 
            // CajaTextoDNI
            // 
            CajaTextoDNI.Location = new Point(125, 267);
            CajaTextoDNI.Margin = new Padding(3, 4, 3, 4);
            CajaTextoDNI.Name = "CajaTextoDNI";
            CajaTextoDNI.Size = new Size(259, 27);
            CajaTextoDNI.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 243);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 8;
            label5.Text = "DNI/NIE/Pasaporte";
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
            BotonAnadir.Location = new Point(409, 475);
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
            BotonVolver.Location = new Point(698, 475);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(81, 45);
            BotonVolver.TabIndex = 20;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // AnadirEntrenadores
            // 
            AnadirEntrenadores.AutoSize = true;
            AnadirEntrenadores.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            AnadirEntrenadores.ForeColor = Color.DarkSlateGray;
            AnadirEntrenadores.Location = new Point(118, 27);
            AnadirEntrenadores.Name = "AnadirEntrenadores";
            AnadirEntrenadores.Size = new Size(391, 46);
            AnadirEntrenadores.TabIndex = 21;
            AnadirEntrenadores.Text = "AÑADIR ENTRENADOR";
            // 
            // AnadirEntrenador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(AnadirEntrenadores);
            Controls.Add(BotonVolver);
            Controls.Add(BotonAnadir);
            Controls.Add(CajaTextoDNI);
            Controls.Add(label5);
            Controls.Add(CajaTextoApellidos);
            Controls.Add(label2);
            Controls.Add(CajaTextoNombre);
            Controls.Add(Nombre);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AnadirEntrenador";
            Text = "AnadirEntrenador";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nombre;
        private TextBox CajaTextoNombre;
        private TextBox CajaTextoApellidos;
        private Label label2;
        private TextBox CajaTextoDNI;
        private Label label5;
        private PictureBox pictureBox1;
        private Button BotonAnadir;
        private Button BotonVolver;
        private Label AnadirEntrenadores;
    }
}