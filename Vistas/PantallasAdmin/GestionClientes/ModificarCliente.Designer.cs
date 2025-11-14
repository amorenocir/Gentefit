namespace Gentefit.Vistas.PantallasAdmin
{
    partial class ModificarCliente
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
            pictureBox1 = new PictureBox();
            CajaTextoTelefono = new TextBox();
            EtiquetaTelefono = new Label();
            CajaTextoContrasena = new TextBox();
            EtiquetaContrasena = new Label();
            CajaTextoEmail = new TextBox();
            EtiquetaEmail = new Label();
            CajaTextoDNI = new TextBox();
            EtiquetaDni = new Label();
            CajaTextoApellidos = new TextBox();
            EtiquetaApellidos = new Label();
            CajaTextoNombre = new TextBox();
            EtiquetaNombre = new Label();
            BotonVolver = new Button();
            BotonGuardar = new Button();
            CajaTextoBuscar = new TextBox();
            PanelClientes = new DataGridView();
            CajaTextoId = new TextBox();
            EtiquetaID = new Label();
            BotonBuscar = new Button();
            BotonVerTodos = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PanelClientes).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Perfil;
            pictureBox1.Location = new Point(579, -13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 343);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // CajaTextoTelefono
            // 
            CajaTextoTelefono.Location = new Point(301, 59);
            CajaTextoTelefono.Margin = new Padding(3, 4, 3, 4);
            CajaTextoTelefono.Name = "CajaTextoTelefono";
            CajaTextoTelefono.Size = new Size(210, 27);
            CajaTextoTelefono.TabIndex = 31;
            // 
            // EtiquetaTelefono
            // 
            EtiquetaTelefono.AutoSize = true;
            EtiquetaTelefono.Location = new Point(301, 35);
            EtiquetaTelefono.Name = "EtiquetaTelefono";
            EtiquetaTelefono.Size = new Size(67, 20);
            EtiquetaTelefono.TabIndex = 30;
            EtiquetaTelefono.Text = "Teléfono";
            // 
            // CajaTextoContrasena
            // 
            CajaTextoContrasena.Location = new Point(301, 204);
            CajaTextoContrasena.Margin = new Padding(3, 4, 3, 4);
            CajaTextoContrasena.Name = "CajaTextoContrasena";
            CajaTextoContrasena.Size = new Size(210, 27);
            CajaTextoContrasena.TabIndex = 29;
            // 
            // EtiquetaContrasena
            // 
            EtiquetaContrasena.AutoSize = true;
            EtiquetaContrasena.Location = new Point(301, 180);
            EtiquetaContrasena.Name = "EtiquetaContrasena";
            EtiquetaContrasena.Size = new Size(83, 20);
            EtiquetaContrasena.TabIndex = 28;
            EtiquetaContrasena.Text = "Contraseña";
            // 
            // CajaTextoEmail
            // 
            CajaTextoEmail.Location = new Point(301, 135);
            CajaTextoEmail.Margin = new Padding(3, 4, 3, 4);
            CajaTextoEmail.Name = "CajaTextoEmail";
            CajaTextoEmail.Size = new Size(210, 27);
            CajaTextoEmail.TabIndex = 27;
            // 
            // EtiquetaEmail
            // 
            EtiquetaEmail.AutoSize = true;
            EtiquetaEmail.Location = new Point(301, 111);
            EtiquetaEmail.Name = "EtiquetaEmail";
            EtiquetaEmail.Size = new Size(46, 20);
            EtiquetaEmail.TabIndex = 26;
            EtiquetaEmail.Text = "Email";
            // 
            // CajaTextoDNI
            // 
            CajaTextoDNI.Location = new Point(43, 273);
            CajaTextoDNI.Margin = new Padding(3, 4, 3, 4);
            CajaTextoDNI.Name = "CajaTextoDNI";
            CajaTextoDNI.Size = new Size(210, 27);
            CajaTextoDNI.TabIndex = 25;
            // 
            // EtiquetaDni
            // 
            EtiquetaDni.AutoSize = true;
            EtiquetaDni.Location = new Point(43, 249);
            EtiquetaDni.Name = "EtiquetaDni";
            EtiquetaDni.Size = new Size(135, 20);
            EtiquetaDni.TabIndex = 24;
            EtiquetaDni.Text = "DNI/NIE/Pasaporte";
            // 
            // CajaTextoApellidos
            // 
            CajaTextoApellidos.Location = new Point(43, 204);
            CajaTextoApellidos.Margin = new Padding(3, 4, 3, 4);
            CajaTextoApellidos.Name = "CajaTextoApellidos";
            CajaTextoApellidos.Size = new Size(210, 27);
            CajaTextoApellidos.TabIndex = 23;
            // 
            // EtiquetaApellidos
            // 
            EtiquetaApellidos.AutoSize = true;
            EtiquetaApellidos.Location = new Point(43, 180);
            EtiquetaApellidos.Name = "EtiquetaApellidos";
            EtiquetaApellidos.Size = new Size(72, 20);
            EtiquetaApellidos.TabIndex = 22;
            EtiquetaApellidos.Text = "Apellidos";
            // 
            // CajaTextoNombre
            // 
            CajaTextoNombre.Location = new Point(43, 128);
            CajaTextoNombre.Margin = new Padding(3, 4, 3, 4);
            CajaTextoNombre.Name = "CajaTextoNombre";
            CajaTextoNombre.Size = new Size(210, 27);
            CajaTextoNombre.TabIndex = 21;
            // 
            // EtiquetaNombre
            // 
            EtiquetaNombre.AutoSize = true;
            EtiquetaNombre.Location = new Point(43, 104);
            EtiquetaNombre.Name = "EtiquetaNombre";
            EtiquetaNombre.Size = new Size(64, 20);
            EtiquetaNombre.TabIndex = 20;
            EtiquetaNombre.Text = "Nombre";
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(799, 528);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(81, 45);
            BotonVolver.TabIndex = 33;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // BotonGuardar
            // 
            BotonGuardar.BackColor = Color.DarkOrange;
            BotonGuardar.Location = new Point(713, 528);
            BotonGuardar.Margin = new Padding(3, 4, 3, 4);
            BotonGuardar.Name = "BotonGuardar";
            BotonGuardar.Size = new Size(80, 45);
            BotonGuardar.TabIndex = 32;
            BotonGuardar.Text = "Guardar";
            BotonGuardar.UseVisualStyleBackColor = false;
            BotonGuardar.Click += BotonGuardar_Click;
            // 
            // CajaTextoBuscar
            // 
            CajaTextoBuscar.Location = new Point(489, 323);
            CajaTextoBuscar.Margin = new Padding(3, 4, 3, 4);
            CajaTextoBuscar.Name = "CajaTextoBuscar";
            CajaTextoBuscar.Size = new Size(205, 27);
            CajaTextoBuscar.TabIndex = 35;
            // 
            // PanelClientes
            // 
            PanelClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelClientes.Location = new Point(43, 359);
            PanelClientes.Margin = new Padding(3, 4, 3, 4);
            PanelClientes.Name = "PanelClientes";
            PanelClientes.RowHeadersWidth = 51;
            PanelClientes.Size = new Size(837, 161);
            PanelClientes.TabIndex = 36;
            PanelClientes.CellClick += PanelClientes_CellClick;
            // 
            // CajaTextoId
            // 
            CajaTextoId.Location = new Point(43, 63);
            CajaTextoId.Margin = new Padding(3, 4, 3, 4);
            CajaTextoId.Name = "CajaTextoId";
            CajaTextoId.Size = new Size(210, 27);
            CajaTextoId.TabIndex = 38;
            // 
            // EtiquetaID
            // 
            EtiquetaID.AutoSize = true;
            EtiquetaID.Location = new Point(43, 39);
            EtiquetaID.Name = "EtiquetaID";
            EtiquetaID.Size = new Size(24, 20);
            EtiquetaID.TabIndex = 37;
            EtiquetaID.Text = "ID";
            // 
            // BotonBuscar
            // 
            BotonBuscar.BackColor = Color.DarkOrange;
            BotonBuscar.Location = new Point(700, 320);
            BotonBuscar.Margin = new Padding(3, 4, 3, 4);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(80, 32);
            BotonBuscar.TabIndex = 39;
            BotonBuscar.Text = "Buscar";
            BotonBuscar.UseVisualStyleBackColor = false;
            BotonBuscar.Click += BotonBuscar_Click;
            // 
            // BotonVerTodos
            // 
            BotonVerTodos.BackColor = Color.DarkOrange;
            BotonVerTodos.Location = new Point(786, 320);
            BotonVerTodos.Margin = new Padding(3, 4, 3, 4);
            BotonVerTodos.Name = "BotonVerTodos";
            BotonVerTodos.Size = new Size(94, 32);
            BotonVerTodos.TabIndex = 45;
            BotonVerTodos.Text = "Ver todos";
            BotonVerTodos.UseVisualStyleBackColor = false;
            BotonVerTodos.Click += BotonVerTodos_Click;
            // 
            // ModificarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(BotonVerTodos);
            Controls.Add(BotonBuscar);
            Controls.Add(CajaTextoId);
            Controls.Add(EtiquetaID);
            Controls.Add(PanelClientes);
            Controls.Add(CajaTextoBuscar);
            Controls.Add(BotonVolver);
            Controls.Add(BotonGuardar);
            Controls.Add(CajaTextoTelefono);
            Controls.Add(EtiquetaTelefono);
            Controls.Add(CajaTextoContrasena);
            Controls.Add(EtiquetaContrasena);
            Controls.Add(CajaTextoEmail);
            Controls.Add(EtiquetaEmail);
            Controls.Add(CajaTextoDNI);
            Controls.Add(EtiquetaDni);
            Controls.Add(CajaTextoApellidos);
            Controls.Add(EtiquetaApellidos);
            Controls.Add(CajaTextoNombre);
            Controls.Add(EtiquetaNombre);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ModificarCliente";
            Text = "ModificarCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PanelClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
        private TextBox CajaTextoTelefono;
        private Label EtiquetaTelefono;
        private TextBox CajaTextoContrasena;
        private Label EtiquetaContrasena;
        private TextBox CajaTextoEmail;
        private Label EtiquetaEmail;
        private TextBox CajaTextoDNI;
        private Label EtiquetaDni;
        private TextBox CajaTextoApellidos;
        private Label EtiquetaApellidos;
        private TextBox CajaTextoNombre;
        private Label EtiquetaNombre;
        private Button BotonVolver;
        private Button BotonGuardar;
        private TextBox CajaTextoBuscar;
        private DataGridView PanelClientes;
        private Label EtiquetaID;
        private Button BotonBuscar;
        private TextBox CajaTextoId;
        private Button BotonVerTodos;
    }
}