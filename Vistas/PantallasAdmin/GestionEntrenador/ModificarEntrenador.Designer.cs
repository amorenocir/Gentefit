namespace Gentefit.Vistas.PantallasAdmin
{
    partial class ModificarEntrenador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarEntrenador));
            BotonVolver = new Button();
            BotonGuardar = new Button();
            CajaTextoBuscar = new TextBox();
            PanelEntrenadores = new DataGridView();
            BotonBuscar = new Button();
            BotonVerTodos = new Button();
            pictureBox1 = new PictureBox();
            CajaTextoId = new TextBox();
            label1 = new Label();
            EtiquetaID = new Label();
            EtiquetaNombre = new Label();
            CajaTextoNombre = new TextBox();
            CajaTextoApellidos = new TextBox();
            EtiquetaApellidos = new Label();
            EtiquetaDni = new Label();
            CajaTextoDNI = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PanelEntrenadores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BotonVolver
            // 
            BotonVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonVolver.Location = new Point(802, 554);
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
            BotonGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonGuardar.ForeColor = Color.White;
            BotonGuardar.Location = new Point(716, 554);
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
            CajaTextoBuscar.Location = new Point(492, 349);
            CajaTextoBuscar.Margin = new Padding(3, 4, 3, 4);
            CajaTextoBuscar.Name = "CajaTextoBuscar";
            CajaTextoBuscar.Size = new Size(205, 27);
            CajaTextoBuscar.TabIndex = 35;
            CajaTextoBuscar.Text = "Buscar por ID";
            // 
            // PanelEntrenadores
            // 
            PanelEntrenadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelEntrenadores.Location = new Point(46, 385);
            PanelEntrenadores.Margin = new Padding(3, 4, 3, 4);
            PanelEntrenadores.Name = "PanelEntrenadores";
            PanelEntrenadores.RowHeadersWidth = 51;
            PanelEntrenadores.Size = new Size(837, 161);
            PanelEntrenadores.TabIndex = 36;
            PanelEntrenadores.CellClick += PanelEntrenadores_CellClick;
            // 
            // BotonBuscar
            // 
            BotonBuscar.BackColor = Color.DarkOrange;
            BotonBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BotonBuscar.ForeColor = Color.White;
            BotonBuscar.Location = new Point(703, 346);
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
            BotonVerTodos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BotonVerTodos.ForeColor = Color.White;
            BotonVerTodos.Location = new Point(789, 346);
            BotonVerTodos.Margin = new Padding(3, 4, 3, 4);
            BotonVerTodos.Name = "BotonVerTodos";
            BotonVerTodos.Size = new Size(94, 32);
            BotonVerTodos.TabIndex = 45;
            BotonVerTodos.Text = "Ver todos";
            BotonVerTodos.UseVisualStyleBackColor = false;
            BotonVerTodos.Click += BotonVerTodos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(655, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 269);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // CajaTextoId
            // 
            CajaTextoId.Location = new Point(46, 116);
            CajaTextoId.Margin = new Padding(3, 4, 3, 4);
            CajaTextoId.Name = "CajaTextoId";
            CajaTextoId.Size = new Size(210, 27);
            CajaTextoId.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(46, 25);
            label1.Name = "label1";
            label1.Size = new Size(400, 41);
            label1.TabIndex = 54;
            label1.Text = "MODIFICAR ENTRENADOR";
            // 
            // EtiquetaID
            // 
            EtiquetaID.AutoSize = true;
            EtiquetaID.BackColor = Color.White;
            EtiquetaID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EtiquetaID.Location = new Point(46, 92);
            EtiquetaID.Name = "EtiquetaID";
            EtiquetaID.Size = new Size(25, 20);
            EtiquetaID.TabIndex = 52;
            EtiquetaID.Text = "ID";
            // 
            // EtiquetaNombre
            // 
            EtiquetaNombre.AutoSize = true;
            EtiquetaNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EtiquetaNombre.Location = new Point(46, 147);
            EtiquetaNombre.Name = "EtiquetaNombre";
            EtiquetaNombre.Size = new Size(67, 20);
            EtiquetaNombre.TabIndex = 46;
            EtiquetaNombre.Text = "Nombre";
            // 
            // CajaTextoNombre
            // 
            CajaTextoNombre.Location = new Point(46, 171);
            CajaTextoNombre.Margin = new Padding(3, 4, 3, 4);
            CajaTextoNombre.Name = "CajaTextoNombre";
            CajaTextoNombre.Size = new Size(210, 27);
            CajaTextoNombre.TabIndex = 47;
            // 
            // CajaTextoApellidos
            // 
            CajaTextoApellidos.Location = new Point(46, 235);
            CajaTextoApellidos.Margin = new Padding(3, 4, 3, 4);
            CajaTextoApellidos.Name = "CajaTextoApellidos";
            CajaTextoApellidos.Size = new Size(210, 27);
            CajaTextoApellidos.TabIndex = 49;
            // 
            // EtiquetaApellidos
            // 
            EtiquetaApellidos.AutoSize = true;
            EtiquetaApellidos.BackColor = Color.White;
            EtiquetaApellidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EtiquetaApellidos.Location = new Point(46, 211);
            EtiquetaApellidos.Name = "EtiquetaApellidos";
            EtiquetaApellidos.Size = new Size(74, 20);
            EtiquetaApellidos.TabIndex = 48;
            EtiquetaApellidos.Text = "Apellidos";
            // 
            // EtiquetaDni
            // 
            EtiquetaDni.AutoSize = true;
            EtiquetaDni.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EtiquetaDni.Location = new Point(46, 279);
            EtiquetaDni.Name = "EtiquetaDni";
            EtiquetaDni.Size = new Size(146, 20);
            EtiquetaDni.TabIndex = 50;
            EtiquetaDni.Text = "DNI/NIE/Pasaporte";
            // 
            // CajaTextoDNI
            // 
            CajaTextoDNI.Location = new Point(46, 303);
            CajaTextoDNI.Margin = new Padding(3, 4, 3, 4);
            CajaTextoDNI.Name = "CajaTextoDNI";
            CajaTextoDNI.Size = new Size(210, 27);
            CajaTextoDNI.TabIndex = 51;
            // 
            // ModificarEntrenador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(944, 642);
            Controls.Add(CajaTextoId);
            Controls.Add(label1);
            Controls.Add(EtiquetaID);
            Controls.Add(EtiquetaNombre);
            Controls.Add(CajaTextoNombre);
            Controls.Add(CajaTextoApellidos);
            Controls.Add(EtiquetaApellidos);
            Controls.Add(EtiquetaDni);
            Controls.Add(CajaTextoDNI);
            Controls.Add(PanelEntrenadores);
            Controls.Add(BotonVolver);
            Controls.Add(BotonGuardar);
            Controls.Add(BotonBuscar);
            Controls.Add(BotonVerTodos);
            Controls.Add(CajaTextoBuscar);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ModificarEntrenador";
            Text = "ModificarEntrenador";
            ((System.ComponentModel.ISupportInitialize)PanelEntrenadores).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Button BotonVolver;
        private Button BotonGuardar;
        private TextBox CajaTextoBuscar;
        private DataGridView PanelEntrenadores;
        private Button BotonBuscar;
        private Button BotonVerTodos;
        private PictureBox pictureBox1;
        private TextBox CajaTextoId;
        private Label label1;
        private Label EtiquetaID;
        private Label EtiquetaNombre;
        private TextBox CajaTextoNombre;
        private TextBox CajaTextoApellidos;
        private Label EtiquetaApellidos;
        private Label EtiquetaDni;
        private TextBox CajaTextoDNI;
    }
}