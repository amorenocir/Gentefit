namespace Gentefit.Vistas.PantallasAdmin.GestionUsuarios
{
    partial class ModificarUsuario
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
            BotonBuscar = new Button();
            CajaTextoId = new TextBox();
            EtiquetaID = new Label();
            PanelUsuarios = new DataGridView();
            CajaTextoBuscar = new TextBox();
            BotonVolver = new Button();
            BotonGuardar = new Button();
            CajaTextoContrasena = new TextBox();
            EtiquetaContrasena = new Label();
            CajaTextoEmail = new TextBox();
            EtiquetaEmail = new Label();
            CajaTextoApellidos = new TextBox();
            EtiquetaApellidos = new Label();
            CajaTextoNombre = new TextBox();
            EtiquetaNombre = new Label();
            pictureBox1 = new PictureBox();
            Rol = new Label();
            CajaOpcionesRol = new ComboBox();
            BotonVerTodos = new Button();
            ((System.ComponentModel.ISupportInitialize)PanelUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BotonBuscar
            // 
            BotonBuscar.BackColor = Color.DarkOrange;
            BotonBuscar.Location = new Point(301, 278);
            BotonBuscar.Margin = new Padding(3, 4, 3, 4);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(80, 30);
            BotonBuscar.TabIndex = 59;
            BotonBuscar.Text = "Buscar";
            BotonBuscar.UseVisualStyleBackColor = false;
            BotonBuscar.Click += BotonBuscar_Click;
            // 
            // CajaTextoId
            // 
            CajaTextoId.Location = new Point(55, 75);
            CajaTextoId.Margin = new Padding(3, 4, 3, 4);
            CajaTextoId.Name = "CajaTextoId";
            CajaTextoId.Size = new Size(210, 27);
            CajaTextoId.TabIndex = 58;
            // 
            // EtiquetaID
            // 
            EtiquetaID.AutoSize = true;
            EtiquetaID.Location = new Point(55, 51);
            EtiquetaID.Name = "EtiquetaID";
            EtiquetaID.Size = new Size(24, 20);
            EtiquetaID.TabIndex = 57;
            EtiquetaID.Text = "ID";
            // 
            // PanelUsuarios
            // 
            PanelUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelUsuarios.Location = new Point(55, 327);
            PanelUsuarios.Margin = new Padding(3, 4, 3, 4);
            PanelUsuarios.Name = "PanelUsuarios";
            PanelUsuarios.RowHeadersWidth = 51;
            PanelUsuarios.Size = new Size(823, 175);
            PanelUsuarios.TabIndex = 56;
            PanelUsuarios.CellClick += PanelUsuarios_CellClick;
            // 
            // CajaTextoBuscar
            // 
            CajaTextoBuscar.Location = new Point(55, 278);
            CajaTextoBuscar.Margin = new Padding(3, 4, 3, 4);
            CajaTextoBuscar.Name = "CajaTextoBuscar";
            CajaTextoBuscar.Size = new Size(240, 27);
            CajaTextoBuscar.TabIndex = 55;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(797, 510);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(81, 45);
            BotonVolver.TabIndex = 54;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // BotonGuardar
            // 
            BotonGuardar.BackColor = Color.DarkOrange;
            BotonGuardar.Location = new Point(699, 510);
            BotonGuardar.Margin = new Padding(3, 4, 3, 4);
            BotonGuardar.Name = "BotonGuardar";
            BotonGuardar.Size = new Size(80, 45);
            BotonGuardar.TabIndex = 53;
            BotonGuardar.Text = "Guardar";
            BotonGuardar.UseVisualStyleBackColor = false;
            BotonGuardar.Click += BotonGuardar_Click;
            // 
            // CajaTextoContrasena
            // 
            CajaTextoContrasena.Location = new Point(310, 140);
            CajaTextoContrasena.Margin = new Padding(3, 4, 3, 4);
            CajaTextoContrasena.Name = "CajaTextoContrasena";
            CajaTextoContrasena.Size = new Size(210, 27);
            CajaTextoContrasena.TabIndex = 50;
            // 
            // EtiquetaContrasena
            // 
            EtiquetaContrasena.AutoSize = true;
            EtiquetaContrasena.Location = new Point(310, 116);
            EtiquetaContrasena.Name = "EtiquetaContrasena";
            EtiquetaContrasena.Size = new Size(83, 20);
            EtiquetaContrasena.TabIndex = 49;
            EtiquetaContrasena.Text = "Contraseña";
            // 
            // CajaTextoEmail
            // 
            CajaTextoEmail.Location = new Point(310, 75);
            CajaTextoEmail.Margin = new Padding(3, 4, 3, 4);
            CajaTextoEmail.Name = "CajaTextoEmail";
            CajaTextoEmail.Size = new Size(210, 27);
            CajaTextoEmail.TabIndex = 48;
            // 
            // EtiquetaEmail
            // 
            EtiquetaEmail.AutoSize = true;
            EtiquetaEmail.Location = new Point(310, 51);
            EtiquetaEmail.Name = "EtiquetaEmail";
            EtiquetaEmail.Size = new Size(46, 20);
            EtiquetaEmail.TabIndex = 47;
            EtiquetaEmail.Text = "Email";
            // 
            // CajaTextoApellidos
            // 
            CajaTextoApellidos.Location = new Point(55, 211);
            CajaTextoApellidos.Margin = new Padding(3, 4, 3, 4);
            CajaTextoApellidos.Name = "CajaTextoApellidos";
            CajaTextoApellidos.Size = new Size(210, 27);
            CajaTextoApellidos.TabIndex = 44;
            // 
            // EtiquetaApellidos
            // 
            EtiquetaApellidos.AutoSize = true;
            EtiquetaApellidos.Location = new Point(55, 187);
            EtiquetaApellidos.Name = "EtiquetaApellidos";
            EtiquetaApellidos.Size = new Size(72, 20);
            EtiquetaApellidos.TabIndex = 43;
            EtiquetaApellidos.Text = "Apellidos";
            // 
            // CajaTextoNombre
            // 
            CajaTextoNombre.Location = new Point(55, 140);
            CajaTextoNombre.Margin = new Padding(3, 4, 3, 4);
            CajaTextoNombre.Name = "CajaTextoNombre";
            CajaTextoNombre.Size = new Size(210, 27);
            CajaTextoNombre.TabIndex = 42;
            // 
            // EtiquetaNombre
            // 
            EtiquetaNombre.AutoSize = true;
            EtiquetaNombre.Location = new Point(55, 116);
            EtiquetaNombre.Name = "EtiquetaNombre";
            EtiquetaNombre.Size = new Size(64, 20);
            EtiquetaNombre.TabIndex = 41;
            EtiquetaNombre.Text = "Nombre";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Perfil;
            pictureBox1.Location = new Point(611, 3);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 343);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // Rol
            // 
            Rol.AutoSize = true;
            Rol.Location = new Point(310, 188);
            Rol.Name = "Rol";
            Rol.Size = new Size(31, 20);
            Rol.TabIndex = 60;
            Rol.Text = "Rol";
            // 
            // CajaOpcionesRol
            // 
            CajaOpcionesRol.FormattingEnabled = true;
            CajaOpcionesRol.Items.AddRange(new object[] { "Admin", "Encargado", "Recepcionista" });
            CajaOpcionesRol.Location = new Point(310, 211);
            CajaOpcionesRol.Name = "CajaOpcionesRol";
            CajaOpcionesRol.Size = new Size(210, 28);
            CajaOpcionesRol.TabIndex = 62;
            // 
            // BotonVerTodos
            // 
            BotonVerTodos.BackColor = Color.DarkOrange;
            BotonVerTodos.Location = new Point(387, 278);
            BotonVerTodos.Margin = new Padding(3, 4, 3, 4);
            BotonVerTodos.Name = "BotonVerTodos";
            BotonVerTodos.Size = new Size(94, 30);
            BotonVerTodos.TabIndex = 63;
            BotonVerTodos.Text = "Ver todos";
            BotonVerTodos.UseVisualStyleBackColor = false;
            BotonVerTodos.Click += BotonVerTodos_Click;
            // 
            // ModificarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 568);
            Controls.Add(BotonVerTodos);
            Controls.Add(CajaOpcionesRol);
            Controls.Add(Rol);
            Controls.Add(BotonBuscar);
            Controls.Add(CajaTextoId);
            Controls.Add(EtiquetaID);
            Controls.Add(PanelUsuarios);
            Controls.Add(CajaTextoBuscar);
            Controls.Add(BotonVolver);
            Controls.Add(BotonGuardar);
            Controls.Add(CajaTextoContrasena);
            Controls.Add(EtiquetaContrasena);
            Controls.Add(CajaTextoEmail);
            Controls.Add(EtiquetaEmail);
            Controls.Add(CajaTextoApellidos);
            Controls.Add(EtiquetaApellidos);
            Controls.Add(CajaTextoNombre);
            Controls.Add(EtiquetaNombre);
            Controls.Add(pictureBox1);
            Name = "ModificarUsuario";
            Text = "ModificarUsuarios";
            ((System.ComponentModel.ISupportInitialize)PanelUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button BotonBuscar;
        private TextBox CajaTextoId;
        private Label EtiquetaID;
        private DataGridView PanelUsuarios;
        private TextBox CajaTextoBuscar;
        private Button BotonVolver;
        private Button BotonGuardar;
        private TextBox CajaTextoContrasena;
        private Label EtiquetaContrasena;
        private TextBox CajaTextoEmail;
        private Label EtiquetaEmail;
        private TextBox CajaTextoApellidos;
        private Label EtiquetaApellidos;
        private TextBox CajaTextoNombre;
        private Label EtiquetaNombre;
        private PictureBox pictureBox1;
        private Label Rol;
        private ComboBox CajaOpcionesRol;
        private Button BotonVerTodos;
    }
}