namespace Gentefit.Vistas.PantallasAdmin.GestionActividades
{
    partial class ModificarActividad
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
            ModificarActividadTitulo = new Label();
            BotonVerTodos = new Button();
            BotonBuscar = new Button();
            CajaTextoId = new TextBox();
            EtiquetaID = new Label();
            PanelActividades = new DataGridView();
            CajaTextoBuscar = new TextBox();
            BotonVolver = new Button();
            BotonGuardar = new Button();
            CajaTextoDescripcion = new TextBox();
            EtiquetaTelefono = new Label();
            EtiquetaDni = new Label();
            CajaTextoDuracion = new TextBox();
            EtiquetaApellidos = new Label();
            CajaTextoNombre = new TextBox();
            EtiquetaNombre = new Label();
            pictureBox1 = new PictureBox();
            CajaComboIntensidad = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)PanelActividades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ModificarActividadTitulo
            // 
            ModificarActividadTitulo.AutoSize = true;
            ModificarActividadTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            ModificarActividadTitulo.ForeColor = Color.DarkSlateGray;
            ModificarActividadTitulo.Location = new Point(31, 21);
            ModificarActividadTitulo.Name = "ModificarActividadTitulo";
            ModificarActividadTitulo.Size = new Size(402, 46);
            ModificarActividadTitulo.TabIndex = 65;
            ModificarActividadTitulo.Text = "MODIFICAR ACTIVIDAD";
            // 
            // BotonVerTodos
            // 
            BotonVerTodos.BackColor = Color.DarkOrange;
            BotonVerTodos.Location = new Point(782, 325);
            BotonVerTodos.Margin = new Padding(3, 4, 3, 4);
            BotonVerTodos.Name = "BotonVerTodos";
            BotonVerTodos.Size = new Size(94, 32);
            BotonVerTodos.TabIndex = 86;
            BotonVerTodos.Text = "Ver todos";
            BotonVerTodos.UseVisualStyleBackColor = false;
            BotonVerTodos.Click += BotonVerTodos_Click;
            // 
            // BotonBuscar
            // 
            BotonBuscar.BackColor = Color.DarkOrange;
            BotonBuscar.Location = new Point(696, 325);
            BotonBuscar.Margin = new Padding(3, 4, 3, 4);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(80, 32);
            BotonBuscar.TabIndex = 85;
            BotonBuscar.Text = "Buscar";
            BotonBuscar.UseVisualStyleBackColor = false;
            BotonBuscar.Click += BotonBuscar_Click;
            // 
            // CajaTextoId
            // 
            CajaTextoId.Location = new Point(39, 114);
            CajaTextoId.Margin = new Padding(3, 4, 3, 4);
            CajaTextoId.Name = "CajaTextoId";
            CajaTextoId.Size = new Size(210, 27);
            CajaTextoId.TabIndex = 84;
            // 
            // EtiquetaID
            // 
            EtiquetaID.AutoSize = true;
            EtiquetaID.Location = new Point(39, 90);
            EtiquetaID.Name = "EtiquetaID";
            EtiquetaID.Size = new Size(24, 20);
            EtiquetaID.TabIndex = 83;
            EtiquetaID.Text = "ID";
            // 
            // PanelActividades
            // 
            PanelActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelActividades.Location = new Point(39, 364);
            PanelActividades.Margin = new Padding(3, 4, 3, 4);
            PanelActividades.Name = "PanelActividades";
            PanelActividades.RowHeadersWidth = 51;
            PanelActividades.Size = new Size(837, 161);
            PanelActividades.TabIndex = 82;
            // 
            // CajaTextoBuscar
            // 
            CajaTextoBuscar.Location = new Point(575, 330);
            CajaTextoBuscar.Margin = new Padding(3, 4, 3, 4);
            CajaTextoBuscar.Name = "CajaTextoBuscar";
            CajaTextoBuscar.Size = new Size(115, 27);
            CajaTextoBuscar.TabIndex = 81;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(795, 533);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(81, 45);
            BotonVolver.TabIndex = 80;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // BotonGuardar
            // 
            BotonGuardar.BackColor = Color.DarkOrange;
            BotonGuardar.Location = new Point(709, 533);
            BotonGuardar.Margin = new Padding(3, 4, 3, 4);
            BotonGuardar.Name = "BotonGuardar";
            BotonGuardar.Size = new Size(80, 45);
            BotonGuardar.TabIndex = 79;
            BotonGuardar.Text = "Guardar";
            BotonGuardar.UseVisualStyleBackColor = false;
            BotonGuardar.Click += BotonGuardar_Click;
            // 
            // CajaTextoDescripcion
            // 
            CajaTextoDescripcion.Location = new Point(297, 114);
            CajaTextoDescripcion.Margin = new Padding(3, 4, 3, 4);
            CajaTextoDescripcion.Multiline = true;
            CajaTextoDescripcion.Name = "CajaTextoDescripcion";
            CajaTextoDescripcion.Size = new Size(272, 206);
            CajaTextoDescripcion.TabIndex = 78;
            // 
            // EtiquetaTelefono
            // 
            EtiquetaTelefono.AutoSize = true;
            EtiquetaTelefono.Location = new Point(297, 90);
            EtiquetaTelefono.Name = "EtiquetaTelefono";
            EtiquetaTelefono.Size = new Size(87, 20);
            EtiquetaTelefono.TabIndex = 77;
            EtiquetaTelefono.Text = "Descripción";
            // 
            // EtiquetaDni
            // 
            EtiquetaDni.AutoSize = true;
            EtiquetaDni.Location = new Point(39, 269);
            EtiquetaDni.Name = "EtiquetaDni";
            EtiquetaDni.Size = new Size(78, 20);
            EtiquetaDni.TabIndex = 71;
            EtiquetaDni.Text = "Intensidad";
            // 
            // CajaTextoDuracion
            // 
            CajaTextoDuracion.Location = new Point(39, 236);
            CajaTextoDuracion.Margin = new Padding(3, 4, 3, 4);
            CajaTextoDuracion.Name = "CajaTextoDuracion";
            CajaTextoDuracion.Size = new Size(210, 27);
            CajaTextoDuracion.TabIndex = 70;
            // 
            // EtiquetaApellidos
            // 
            EtiquetaApellidos.AutoSize = true;
            EtiquetaApellidos.Location = new Point(39, 212);
            EtiquetaApellidos.Name = "EtiquetaApellidos";
            EtiquetaApellidos.Size = new Size(69, 20);
            EtiquetaApellidos.TabIndex = 69;
            EtiquetaApellidos.Text = "Duración";
            // 
            // CajaTextoNombre
            // 
            CajaTextoNombre.Location = new Point(39, 173);
            CajaTextoNombre.Margin = new Padding(3, 4, 3, 4);
            CajaTextoNombre.Name = "CajaTextoNombre";
            CajaTextoNombre.Size = new Size(210, 27);
            CajaTextoNombre.TabIndex = 68;
            // 
            // EtiquetaNombre
            // 
            EtiquetaNombre.AutoSize = true;
            EtiquetaNombre.Location = new Point(39, 149);
            EtiquetaNombre.Name = "EtiquetaNombre";
            EtiquetaNombre.Size = new Size(64, 20);
            EtiquetaNombre.TabIndex = 67;
            EtiquetaNombre.Text = "Nombre";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Perfil;
            pictureBox1.Location = new Point(575, -8);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 343);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 66;
            pictureBox1.TabStop = false;
            // 
            // CajaComboIntensidad
            // 
            CajaComboIntensidad.FormattingEnabled = true;
            CajaComboIntensidad.Items.AddRange(new object[] { "Alta", "Media", "Baja" });
            CajaComboIntensidad.Location = new Point(39, 292);
            CajaComboIntensidad.Name = "CajaComboIntensidad";
            CajaComboIntensidad.Size = new Size(210, 28);
            CajaComboIntensidad.TabIndex = 87;
            // 
            // ModificarActividad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 588);
            Controls.Add(CajaComboIntensidad);
            Controls.Add(BotonVerTodos);
            Controls.Add(BotonBuscar);
            Controls.Add(CajaTextoId);
            Controls.Add(EtiquetaID);
            Controls.Add(PanelActividades);
            Controls.Add(CajaTextoBuscar);
            Controls.Add(BotonVolver);
            Controls.Add(BotonGuardar);
            Controls.Add(CajaTextoDescripcion);
            Controls.Add(EtiquetaTelefono);
            Controls.Add(EtiquetaDni);
            Controls.Add(CajaTextoDuracion);
            Controls.Add(EtiquetaApellidos);
            Controls.Add(CajaTextoNombre);
            Controls.Add(EtiquetaNombre);
            Controls.Add(pictureBox1);
            Controls.Add(ModificarActividadTitulo);
            Name = "ModificarActividad";
            Text = "ModificarActividad";
            ((System.ComponentModel.ISupportInitialize)PanelActividades).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label ModificarActividadTitulo;
        private Button BotonVerTodos;
        private Button BotonBuscar;
        private TextBox CajaTextoId;
        private Label EtiquetaID;
        private DataGridView PanelActividades;
        private TextBox CajaTextoBuscar;
        private Button BotonVolver;
        private Button BotonGuardar;
        private TextBox CajaTextoDescripcion;
        private Label EtiquetaTelefono;
        private TextBox CajaTextoContrasena;
        private Label EtiquetaContrasena;
        private TextBox CajaTextoEmail;
        private Label EtiquetaEmail;
        private Label EtiquetaDni;
        private TextBox CajaTextoDuracion;
        private Label EtiquetaApellidos;
        private TextBox CajaTextoNombre;
        private Label EtiquetaNombre;
        private PictureBox pictureBox1;
        private ComboBox CajaComboIntensidad;
    }
}