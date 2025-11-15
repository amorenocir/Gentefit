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
            AnadirClientes.Location = new Point(121, 25);
            AnadirClientes.Name = "AnadirClientes";
            AnadirClientes.Size = new Size(313, 46);
            AnadirClientes.TabIndex = 37;
            AnadirClientes.Text = "AÑADIR USUARIO";
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(701, 473);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(81, 45);
            BotonVolver.TabIndex = 36;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // BotonAnadir
            // 
            BotonAnadir.BackColor = Color.DarkOrange;
            BotonAnadir.Location = new Point(412, 473);
            BotonAnadir.Margin = new Padding(3, 4, 3, 4);
            BotonAnadir.Name = "BotonAnadir";
            BotonAnadir.Size = new Size(80, 45);
            BotonAnadir.TabIndex = 35;
            BotonAnadir.Text = "Añadir";
            BotonAnadir.UseVisualStyleBackColor = false;
            BotonAnadir.Click += BotonAnadir_Click;
            // 
            // CajaTextoEmail
            // 
            CajaTextoEmail.Location = new Point(121, 271);
            CajaTextoEmail.Margin = new Padding(3, 4, 3, 4);
            CajaTextoEmail.Name = "CajaTextoEmail";
            CajaTextoEmail.Size = new Size(259, 27);
            CajaTextoEmail.TabIndex = 33;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(121, 247);
            Email.Name = "Email";
            Email.Size = new Size(46, 20);
            Email.TabIndex = 32;
            Email.Text = "Email";
            // 
            // Rol
            // 
            Rol.AutoSize = true;
            Rol.Location = new Point(121, 399);
            Rol.Name = "Rol";
            Rol.Size = new Size(31, 20);
            Rol.TabIndex = 30;
            Rol.Text = "Rol";
            // 
            // CajaTextoContrasena
            // 
            CajaTextoContrasena.Location = new Point(121, 347);
            CajaTextoContrasena.Margin = new Padding(3, 4, 3, 4);
            CajaTextoContrasena.Name = "CajaTextoContrasena";
            CajaTextoContrasena.Size = new Size(259, 27);
            CajaTextoContrasena.TabIndex = 29;
            // 
            // Contrasena
            // 
            Contrasena.AutoSize = true;
            Contrasena.Location = new Point(121, 323);
            Contrasena.Name = "Contrasena";
            Contrasena.Size = new Size(83, 20);
            Contrasena.TabIndex = 28;
            Contrasena.Text = "Contraseña";
            // 
            // CajaTextoApellidos
            // 
            CajaTextoApellidos.Location = new Point(121, 199);
            CajaTextoApellidos.Margin = new Padding(3, 4, 3, 4);
            CajaTextoApellidos.Name = "CajaTextoApellidos";
            CajaTextoApellidos.Size = new Size(259, 27);
            CajaTextoApellidos.TabIndex = 27;
            // 
            // Apellidos
            // 
            Apellidos.AutoSize = true;
            Apellidos.Location = new Point(121, 175);
            Apellidos.Name = "Apellidos";
            Apellidos.Size = new Size(72, 20);
            Apellidos.TabIndex = 26;
            Apellidos.Text = "Apellidos";
            // 
            // CajaTextoNombre
            // 
            CajaTextoNombre.Location = new Point(121, 121);
            CajaTextoNombre.Margin = new Padding(3, 4, 3, 4);
            CajaTextoNombre.Name = "CajaTextoNombre";
            CajaTextoNombre.Size = new Size(259, 27);
            CajaTextoNombre.TabIndex = 25;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(121, 97);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(64, 20);
            Nombre.TabIndex = 24;
            Nombre.Text = "Nombre";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Perfil;
            pictureBox1.Location = new Point(499, 25);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 343);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // ComboOpcionesRol
            // 
            ComboOpcionesRol.DrawMode = DrawMode.Normal;
            ComboOpcionesRol.FormattingEnabled = true;
            ComboOpcionesRol.Items.AddRange(new object[] { "Admin", "Encargado", "Recepcionista" });
            ComboOpcionesRol.Location = new Point(121, 422);
            ComboOpcionesRol.Name = "ComboOpcionesRol";
            ComboOpcionesRol.Size = new Size(259, 28);
            ComboOpcionesRol.TabIndex = 38;
            ComboOpcionesRol.SelectedIndexChanged += ComboOpcionesRol_SelectedIndexChanged;
            // 
            // AnadirUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(893, 544);
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