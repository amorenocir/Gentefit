namespace Gentefit.Vistas.PantallasAdmin.GestionUsuarios
{
    partial class AnadirUsuario
    {
         private System.ComponentModel.IContainer components = null;

         protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            AnadirClientes = new Label();
            BotonVolver = new Button();
            BotonAnadir = new Button();
            CajaTextoEmail = new TextBox();
            Email = new Label();
            Rol = new Label();
            CajaTextoContrasena = new TextBox();
            Contrasena = new Label();
            CajaTextoApellidos = new TextBox();
            Apellidos = new Label();
            CajaTextoNombre = new TextBox();
            Nombre = new Label();
            pictureBox1 = new PictureBox();
            ComboOpcionesRol = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AnadirClientes
            // 
            AnadirClientes.AutoSize = true;
            AnadirClientes.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            AnadirClientes.ForeColor = Color.DarkSlateGray;
            AnadirClientes.Location = new Point(106, 19);
            AnadirClientes.Name = "AnadirClientes";
            AnadirClientes.Size = new Size(250, 37);
            AnadirClientes.TabIndex = 37;
            AnadirClientes.Text = "AÑADIR USUARIO";
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(613, 355);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(71, 34);
            BotonVolver.TabIndex = 7;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // BotonAnadir
            // 
            BotonAnadir.BackColor = Color.DarkOrange;
            BotonAnadir.Location = new Point(360, 355);
            BotonAnadir.Name = "BotonAnadir";
            BotonAnadir.Size = new Size(70, 34);
            BotonAnadir.TabIndex = 6;
            BotonAnadir.Text = "Añadir";
            BotonAnadir.UseVisualStyleBackColor = false;
            BotonAnadir.Click += BotonAnadir_Click;
            // 
            // CajaTextoEmail
            // 
            CajaTextoEmail.Location = new Point(106, 203);
            CajaTextoEmail.Name = "CajaTextoEmail";
            CajaTextoEmail.Size = new Size(227, 23);
            CajaTextoEmail.TabIndex = 3;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(106, 185);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 32;
            Email.Text = "Email";
            // 
            // Rol
            // 
            Rol.AutoSize = true;
            Rol.Location = new Point(106, 299);
            Rol.Name = "Rol";
            Rol.Size = new Size(24, 15);
            Rol.TabIndex = 30;
            Rol.Text = "Rol";
            // 
            // CajaTextoContrasena
            // 
            CajaTextoContrasena.Location = new Point(106, 260);
            CajaTextoContrasena.Name = "CajaTextoContrasena";
            CajaTextoContrasena.Size = new Size(227, 23);
            CajaTextoContrasena.TabIndex = 4;
            // 
            // Contrasena
            // 
            Contrasena.AutoSize = true;
            Contrasena.Location = new Point(106, 242);
            Contrasena.Name = "Contrasena";
            Contrasena.Size = new Size(67, 15);
            Contrasena.TabIndex = 28;
            Contrasena.Text = "Contraseña";
            // 
            // CajaTextoApellidos
            // 
            CajaTextoApellidos.Location = new Point(106, 149);
            CajaTextoApellidos.Name = "CajaTextoApellidos";
            CajaTextoApellidos.Size = new Size(227, 23);
            CajaTextoApellidos.TabIndex = 2;
            // 
            // Apellidos
            // 
            Apellidos.AutoSize = true;
            Apellidos.Location = new Point(106, 131);
            Apellidos.Name = "Apellidos";
            Apellidos.Size = new Size(56, 15);
            Apellidos.TabIndex = 26;
            Apellidos.Text = "Apellidos";
            // 
            // CajaTextoNombre
            // 
            CajaTextoNombre.Location = new Point(106, 91);
            CajaTextoNombre.Name = "CajaTextoNombre";
            CajaTextoNombre.Size = new Size(227, 23);
            CajaTextoNombre.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(106, 73);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 24;
            Nombre.Text = "Nombre";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Perfil;
            pictureBox1.Location = new Point(437, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // ComboOpcionesRol
            // 
            ComboOpcionesRol.FormattingEnabled = true;
            ComboOpcionesRol.Items.AddRange(new object[] { "Admin", "Encargado", "Recepcionista" });
            ComboOpcionesRol.Location = new Point(106, 316);
            ComboOpcionesRol.Margin = new Padding(3, 2, 3, 2);
            ComboOpcionesRol.Name = "ComboOpcionesRol";
            ComboOpcionesRol.Size = new Size(227, 23);
            ComboOpcionesRol.TabIndex = 5;
            ComboOpcionesRol.SelectedIndexChanged += ComboOpcionesRol_SelectedIndexChanged;
            // 
            // AnadirUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(781, 408);
            Controls.Add(ComboOpcionesRol);
            Controls.Add(AnadirClientes);
            Controls.Add(BotonVolver);
            Controls.Add(BotonAnadir);
            Controls.Add(CajaTextoEmail);
            Controls.Add(Email);
            Controls.Add(Rol);
            Controls.Add(CajaTextoContrasena);
            Controls.Add(Contrasena);
            Controls.Add(CajaTextoApellidos);
            Controls.Add(Apellidos);
            Controls.Add(CajaTextoNombre);
            Controls.Add(Nombre);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AnadirUsuario";
            Text = "AnadirUsuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label AnadirClientes;
        private Button BotonVolver;
        private Button BotonAnadir;
        private TextBox CajaTextoEmail;
        private Label Email;
        private TextBox CajaTextoRol;
        private Label Rol;
        private TextBox CajaTextoContrasena;
        private Label Contrasena;
        private TextBox CajaTextoApellidos;
        private Label Apellidos;
        private TextBox CajaTextoNombre;
        private Label Nombre;
        private PictureBox pictureBox1;
        private ComboBox ComboOpcionesRol;
    }
}