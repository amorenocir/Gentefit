namespace Gentefit.Vistas.PantallasAdmin
{
    partial class ModificarCliente
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
            pictureBox1 = new PictureBox();
            CajaTextoTelefono = new TextBox();
            label9 = new Label();
            CajaTextoContrasena = new TextBox();
            label8 = new Label();
            CajaTextoEmail = new TextBox();
            label7 = new Label();
            CajaTextoDNI = new TextBox();
            label5 = new Label();
            CajaTextoApellidos = new TextBox();
            label2 = new Label();
            CajaTextoNombre = new TextBox();
            Nombre = new Label();
            BotonVolver = new Button();
            BotonGuardar = new Button();
            CajaTextoBuscar = new TextBox();
            PanelClientes = new DataGridView();
            CajaTextoId = new TextBox();
            label3 = new Label();
            BotonBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PanelClientes).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Perfil;
            pictureBox1.Location = new Point(529, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // CajaTextoTelefono
            // 
            CajaTextoTelefono.Location = new Point(339, 268);
            CajaTextoTelefono.Name = "CajaTextoTelefono";
            CajaTextoTelefono.Size = new Size(184, 23);
            CajaTextoTelefono.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(339, 250);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 30;
            label9.Text = "Teléfono";
            // 
            // CajaTextoContrasena
            // 
            CajaTextoContrasena.Location = new Point(339, 382);
            CajaTextoContrasena.Name = "CajaTextoContrasena";
            CajaTextoContrasena.Size = new Size(184, 23);
            CajaTextoContrasena.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(339, 364);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 28;
            label8.Text = "Contraseña";
            // 
            // CajaTextoEmail
            // 
            CajaTextoEmail.Location = new Point(339, 325);
            CajaTextoEmail.Name = "CajaTextoEmail";
            CajaTextoEmail.Size = new Size(184, 23);
            CajaTextoEmail.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(339, 307);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 26;
            label7.Text = "Email";
            // 
            // CajaTextoDNI
            // 
            CajaTextoDNI.Location = new Point(339, 214);
            CajaTextoDNI.Name = "CajaTextoDNI";
            CajaTextoDNI.Size = new Size(184, 23);
            CajaTextoDNI.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(339, 196);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 24;
            label5.Text = "DNI/NIE/Pasaporte";
            // 
            // CajaTextoApellidos
            // 
            CajaTextoApellidos.Location = new Point(339, 156);
            CajaTextoApellidos.Name = "CajaTextoApellidos";
            CajaTextoApellidos.Size = new Size(184, 23);
            CajaTextoApellidos.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 138);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 22;
            label2.Text = "Apellidos";
            // 
            // CajaTextoNombre
            // 
            CajaTextoNombre.Location = new Point(339, 99);
            CajaTextoNombre.Name = "CajaTextoNombre";
            CajaTextoNombre.Size = new Size(184, 23);
            CajaTextoNombre.TabIndex = 21;
            CajaTextoNombre.TextChanged += CajaTextoNombre_TextChanged;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(339, 81);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 20;
            Nombre.Text = "Nombre";
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(665, 371);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(71, 34);
            BotonVolver.TabIndex = 33;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // BotonGuardar
            // 
            BotonGuardar.BackColor = Color.DarkOrange;
            BotonGuardar.Location = new Point(574, 371);
            BotonGuardar.Name = "BotonGuardar";
            BotonGuardar.Size = new Size(70, 34);
            BotonGuardar.TabIndex = 32;
            BotonGuardar.Text = "Guardar";
            BotonGuardar.UseVisualStyleBackColor = false;
            BotonGuardar.Click += BotonGuardar_Click;
            // 
            // CajaTextoBuscar
            // 
            CajaTextoBuscar.Location = new Point(32, 61);
            CajaTextoBuscar.Name = "CajaTextoBuscar";
            CajaTextoBuscar.Size = new Size(180, 23);
            CajaTextoBuscar.TabIndex = 35;
            // 
            // PanelClientes
            // 
            PanelClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelClientes.Location = new Point(32, 120);
            PanelClientes.Name = "PanelClientes";
            PanelClientes.Size = new Size(277, 285);
            PanelClientes.TabIndex = 36;
            PanelClientes.CellClick += PanelClientes_CellClick;
            // 
            // CajaTextoId
            // 
            CajaTextoId.Location = new Point(339, 50);
            CajaTextoId.Name = "CajaTextoId";
            CajaTextoId.Size = new Size(184, 23);
            CajaTextoId.TabIndex = 38;
            CajaTextoId.TextChanged += CajaTextoId_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(339, 32);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 37;
            label3.Text = "ID";
            // 
            // BotonBuscar
            // 
            BotonBuscar.BackColor = Color.DarkOrange;
            BotonBuscar.Location = new Point(227, 54);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(70, 34);
            BotonBuscar.TabIndex = 39;
            BotonBuscar.Text = "Buscar";
            BotonBuscar.UseVisualStyleBackColor = false;
            BotonBuscar.Click += BotonBuscar_Click;
            // 
            // ModificarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonBuscar);
            Controls.Add(CajaTextoId);
            Controls.Add(label3);
            Controls.Add(PanelClientes);
            Controls.Add(CajaTextoBuscar);
            Controls.Add(BotonVolver);
            Controls.Add(BotonGuardar);
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
            Name = "ModificarCliente";
            Text = "ModificarCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PanelClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox CajaTextoTelefono;
        private Label label9;
        private TextBox CajaTextoContrasena;
        private Label label8;
        private TextBox CajaTextoEmail;
        private Label label7;
        private TextBox CajaTextoDNI;
        private Label label5;
        private TextBox CajaTextoApellidos;
        private Label label2;
        private TextBox CajaTextoNombre;
        private Label Nombre;
        private Button BotonVolver;
        private Button BotonGuardar;
        private TextBox CajaTextoBuscar;
        private DataGridView PanelClientes;
        private Label label3;
        private Button BotonBuscar;
        private TextBox CajaTextoId;
    }
}