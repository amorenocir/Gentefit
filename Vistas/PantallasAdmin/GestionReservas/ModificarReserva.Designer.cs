namespace Gentefit.Vistas.PantallasAdmin
{
    partial class ModificarReserva
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            CajaTextoIdClase = new TextBox();
            EtiquetaNombre = new Label();
            BotonVolver = new Button();
            BotonGuardar = new Button();
            CajaTextoBuscar = new TextBox();
            PanelReservas = new DataGridView();
            CajaTextoId = new TextBox();
            EtiquetaID = new Label();
            BotonBuscar = new Button();
            BotonVerTodos = new Button();
            label1 = new Label();
            CajaTextoIdCliente = new TextBox();
            label2 = new Label();
            comboBoxEstado = new ComboBox();
            reservaBindingSource = new BindingSource(components);
            reservaBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PanelReservas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reservaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reservaBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Perfil;
            pictureBox1.Location = new Point(507, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // CajaTextoIdClase
            // 
            CajaTextoIdClase.Location = new Point(38, 147);
            CajaTextoIdClase.Name = "CajaTextoIdClase";
            CajaTextoIdClase.Size = new Size(184, 23);
            CajaTextoIdClase.TabIndex = 21;
            // 
            // EtiquetaNombre
            // 
            EtiquetaNombre.AutoSize = true;
            EtiquetaNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EtiquetaNombre.Location = new Point(38, 129);
            EtiquetaNombre.Name = "EtiquetaNombre";
            EtiquetaNombre.Size = new Size(51, 15);
            EtiquetaNombre.TabIndex = 20;
            EtiquetaNombre.Text = "ID Clase";
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(699, 396);
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
            BotonGuardar.Location = new Point(624, 396);
            BotonGuardar.Name = "BotonGuardar";
            BotonGuardar.Size = new Size(70, 34);
            BotonGuardar.TabIndex = 32;
            BotonGuardar.Text = "Guardar";
            BotonGuardar.UseVisualStyleBackColor = false;
            BotonGuardar.Click += BotonGuardar_Click;
            // 
            // CajaTextoBuscar
            // 
            CajaTextoBuscar.Location = new Point(42, 240);
            CajaTextoBuscar.Name = "CajaTextoBuscar";
            CajaTextoBuscar.Size = new Size(180, 23);
            CajaTextoBuscar.TabIndex = 35;
            CajaTextoBuscar.Text = "Buscar por ID";
            // 
            // PanelReservas
            // 
            PanelReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelReservas.Location = new Point(38, 269);
            PanelReservas.Name = "PanelReservas";
            PanelReservas.RowHeadersWidth = 51;
            PanelReservas.Size = new Size(732, 121);
            PanelReservas.TabIndex = 36;
            PanelReservas.CellClick += PanelReservas_CellClick;
            // 
            // CajaTextoId
            // 
            CajaTextoId.Location = new Point(38, 98);
            CajaTextoId.Name = "CajaTextoId";
            CajaTextoId.Size = new Size(184, 23);
            CajaTextoId.TabIndex = 38;
            // 
            // EtiquetaID
            // 
            EtiquetaID.AutoSize = true;
            EtiquetaID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EtiquetaID.Location = new Point(38, 80);
            EtiquetaID.Name = "EtiquetaID";
            EtiquetaID.Size = new Size(68, 15);
            EtiquetaID.TabIndex = 37;
            EtiquetaID.Text = "ID Reserva";
            // 
            // BotonBuscar
            // 
            BotonBuscar.BackColor = Color.DarkOrange;
            BotonBuscar.Location = new Point(236, 239);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(70, 24);
            BotonBuscar.TabIndex = 39;
            BotonBuscar.Text = "Buscar";
            BotonBuscar.UseVisualStyleBackColor = false;
            BotonBuscar.Click += BotonBuscar_Click;
            // 
            // BotonVerTodos
            // 
            BotonVerTodos.BackColor = Color.DarkOrange;
            BotonVerTodos.Location = new Point(320, 240);
            BotonVerTodos.Name = "BotonVerTodos";
            BotonVerTodos.Size = new Size(82, 24);
            BotonVerTodos.TabIndex = 45;
            BotonVerTodos.Text = "Ver todos";
            BotonVerTodos.UseVisualStyleBackColor = false;
            BotonVerTodos.Click += BotonVerTodos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(38, 16);
            label1.Name = "label1";
            label1.Size = new Size(259, 32);
            label1.TabIndex = 55;
            label1.Text = "MODIFICAR RESERVA";
            // 
            // CajaTextoIdCliente
            // 
            CajaTextoIdCliente.Location = new Point(263, 98);
            CajaTextoIdCliente.Name = "CajaTextoIdCliente";
            CajaTextoIdCliente.Size = new Size(184, 23);
            CajaTextoIdCliente.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(263, 80);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 57;
            label2.Text = "ID Cliente";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Location = new Point(263, 146);
            comboBoxEstado.Margin = new Padding(3, 2, 3, 2);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(177, 23);
            comboBoxEstado.TabIndex = 58;
            // 
            // reservaBindingSource
            // 
            reservaBindingSource.DataSource = typeof(Modelo.Reserva);
            // 
            // reservaBindingSource1
            // 
            reservaBindingSource1.DataSource = typeof(Modelo.Reserva);
            // 
            // ModificarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxEstado);
            Controls.Add(label2);
            Controls.Add(CajaTextoIdCliente);
            Controls.Add(label1);
            Controls.Add(BotonVerTodos);
            Controls.Add(BotonBuscar);
            Controls.Add(CajaTextoId);
            Controls.Add(EtiquetaID);
            Controls.Add(PanelReservas);
            Controls.Add(CajaTextoBuscar);
            Controls.Add(BotonVolver);
            Controls.Add(BotonGuardar);
            Controls.Add(CajaTextoIdClase);
            Controls.Add(EtiquetaNombre);
            Controls.Add(pictureBox1);
            Name = "ModificarReserva";
            Text = "ModificarReserva";
            Load += FormModificarReserva_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PanelReservas).EndInit();
            ((System.ComponentModel.ISupportInitialize)reservaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)reservaBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
        private TextBox CajaTextoIdClase;
        private Label EtiquetaNombre;
        private Button BotonVolver;
        private Button BotonGuardar;
        private TextBox CajaTextoBuscar;
        private DataGridView PanelReservas;
        private Label EtiquetaID;
        private Button BotonBuscar;
        private TextBox CajaTextoId;
        private Button BotonVerTodos;
        private Label label1;
        private TextBox CajaTextoIdCliente;
        private Label label2;
        private ComboBox comboBoxEstado;
        private BindingSource reservaBindingSource;
        private BindingSource reservaBindingSource1;
    }
}