namespace Gentefit.Vistas.Admin
{
    partial class AnadirCliente
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
            Nombre = new Label();
            CajaTextoNombre = new TextBox();
            CajaTextoApellidos = new TextBox();
            label2 = new Label();
            CajaTextoDNI = new TextBox();
            label5 = new Label();
            CajaTextoEmail = new TextBox();
            label7 = new Label();
            CajaTextoContrasena = new TextBox();
            label8 = new Label();
            CajaTextoTelefono = new TextBox();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            BotonAnadir = new Button();
            BotonVolver = new Button();
            AnadirClientes = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(109, 67);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 0;
            Nombre.Text = "Nombre";
            // 
            // CajaTextoNombre
            // 
            CajaTextoNombre.Location = new Point(109, 85);
            CajaTextoNombre.Name = "CajaTextoNombre";
            CajaTextoNombre.Size = new Size(227, 23);
            CajaTextoNombre.TabIndex = 1;
            // 
            // CajaTextoApellidos
            // 
            CajaTextoApellidos.Location = new Point(109, 142);
            CajaTextoApellidos.Name = "CajaTextoApellidos";
            CajaTextoApellidos.Size = new Size(227, 23);
            CajaTextoApellidos.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 124);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellidos";
            // 
            // CajaTextoDNI
            // 
            CajaTextoDNI.Location = new Point(109, 200);
            CajaTextoDNI.Name = "CajaTextoDNI";
            CajaTextoDNI.Size = new Size(227, 23);
            CajaTextoDNI.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(109, 182);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 8;
            label5.Text = "DNI/NIE/Pasaporte";
            // 
            // CajaTextoEmail
            // 
            CajaTextoEmail.Location = new Point(109, 311);
            CajaTextoEmail.Name = "CajaTextoEmail";
            CajaTextoEmail.Size = new Size(227, 23);
            CajaTextoEmail.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(109, 293);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 12;
            label7.Text = "Email";
            // 
            // CajaTextoContrasena
            // 
            CajaTextoContrasena.Location = new Point(109, 368);
            CajaTextoContrasena.Name = "CajaTextoContrasena";
            CajaTextoContrasena.Size = new Size(227, 23);
            CajaTextoContrasena.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(109, 350);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 14;
            label8.Text = "Contraseña";
            // 
            // CajaTextoTelefono
            // 
            CajaTextoTelefono.Location = new Point(109, 254);
            CajaTextoTelefono.Name = "CajaTextoTelefono";
            CajaTextoTelefono.Size = new Size(227, 23);
            CajaTextoTelefono.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(109, 236);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 16;
            label9.Text = "Teléfono";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Perfil;
            pictureBox1.Location = new Point(434, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // BotonAnadir
            // 
            BotonAnadir.BackColor = Color.DarkOrange;
            BotonAnadir.Location = new Point(358, 356);
            BotonAnadir.Name = "BotonAnadir";
            BotonAnadir.Size = new Size(70, 34);
            BotonAnadir.TabIndex = 7;
            BotonAnadir.Text = "Añadir";
            BotonAnadir.UseVisualStyleBackColor = false;
            BotonAnadir.Click += BotonAnadir_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(611, 356);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(71, 34);
            BotonVolver.TabIndex = 8;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // AnadirClientes
            // 
            AnadirClientes.AutoSize = true;
            AnadirClientes.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            AnadirClientes.ForeColor = Color.DarkSlateGray;
            AnadirClientes.Location = new Point(109, 20);
            AnadirClientes.Name = "AnadirClientes";
            AnadirClientes.Size = new Size(235, 37);
            AnadirClientes.TabIndex = 21;
            AnadirClientes.Text = "AÑADIR CLIENTE";
            AnadirClientes.Click += Actividades_Click;
            // 
            // AnadirCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(AnadirClientes);
            Controls.Add(BotonVolver);
            Controls.Add(BotonAnadir);
            Controls.Add(CajaTextoTelefono);
            Controls.Add(label9);
            Controls.Add(CajaTextoContrasena);
            Controls.Add(label8);
            Controls.Add(CajaTextoEmail);
            Controls.Add(label7);
            Controls.Add(CajaTextoDNI);
            Controls.Add(label5);
            Controls.Add(CajaTextoApellidos);
            Controls.Add(label2);
            Controls.Add(CajaTextoNombre);
            Controls.Add(Nombre);
            Controls.Add(pictureBox1);
            Name = "AnadirCliente";
            Text = "AnadirCliente";
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
        private TextBox CajaTextoEmail;
        private Label label7;
        private TextBox CajaTextoContrasena;
        private Label label8;
        private TextBox CajaTextoTelefono;
        private Label label9;
        private PictureBox pictureBox1;
        private Button BotonAnadir;
        private Button BotonVolver;
        private Label AnadirClientes;
    }
}