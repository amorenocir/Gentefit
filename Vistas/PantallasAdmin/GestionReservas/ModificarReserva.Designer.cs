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
            pictureBox1.Location = new Point(579, -13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 343);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // CajaTextoIdClase
            // 
            CajaTextoIdClase.Location = new Point(43, 196);
            CajaTextoIdClase.Margin = new Padding(3, 4, 3, 4);
            CajaTextoIdClase.Name = "CajaTextoIdClase";
            CajaTextoIdClase.Size = new Size(210, 27);
            CajaTextoIdClase.TabIndex = 21;
            // 
            // EtiquetaNombre
            // 
            EtiquetaNombre.AutoSize = true;
            EtiquetaNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EtiquetaNombre.Location = new Point(43, 172);
            EtiquetaNombre.Name = "EtiquetaNombre";
            EtiquetaNombre.Size = new Size(65, 20);
            EtiquetaNombre.TabIndex = 20;
            EtiquetaNombre.Text = "ID Clase";
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
            CajaTextoBuscar.Location = new Point(48, 320);
            CajaTextoBuscar.Margin = new Padding(3, 4, 3, 4);
            CajaTextoBuscar.Name = "CajaTextoBuscar";
            CajaTextoBuscar.Size = new Size(205, 27);
            CajaTextoBuscar.TabIndex = 35;
            CajaTextoBuscar.Text = "Buscar por ID";
            // 
            // PanelReservas
            // 
            PanelReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelReservas.Location = new Point(43, 359);
            PanelReservas.Margin = new Padding(3, 4, 3, 4);
            PanelReservas.Name = "PanelReservas";
            PanelReservas.RowHeadersWidth = 51;
            PanelReservas.Size = new Size(837, 161);
            PanelReservas.TabIndex = 36;
            PanelReservas.CellClick += PanelReservas_CellClick;
            // 
            // CajaTextoId
            // 
            CajaTextoId.Location = new Point(43, 131);
            CajaTextoId.Margin = new Padding(3, 4, 3, 4);
            CajaTextoId.Name = "CajaTextoId";
            CajaTextoId.Size = new Size(210, 27);
            CajaTextoId.TabIndex = 38;
            // 
            // EtiquetaID
            // 
            EtiquetaID.AutoSize = true;
            EtiquetaID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EtiquetaID.Location = new Point(43, 107);
            EtiquetaID.Name = "EtiquetaID";
            EtiquetaID.Size = new Size(85, 20);
            EtiquetaID.TabIndex = 37;
            EtiquetaID.Text = "ID Reserva";
            // 
            // BotonBuscar
            // 
            BotonBuscar.BackColor = Color.DarkOrange;
            BotonBuscar.Location = new Point(270, 319);
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
            BotonVerTodos.Location = new Point(366, 320);
            BotonVerTodos.Margin = new Padding(3, 4, 3, 4);
            BotonVerTodos.Name = "BotonVerTodos";
            BotonVerTodos.Size = new Size(94, 32);
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
            label1.Location = new Point(43, 22);
            label1.Name = "label1";
            label1.Size = new Size(324, 41);
            label1.TabIndex = 55;
            label1.Text = "MODIFICAR RESERVA";
            // 
            // CajaTextoIdCliente
            // 
            CajaTextoIdCliente.Location = new Point(301, 131);
            CajaTextoIdCliente.Margin = new Padding(3, 4, 3, 4);
            CajaTextoIdCliente.Name = "CajaTextoIdCliente";
            CajaTextoIdCliente.Size = new Size(210, 27);
            CajaTextoIdCliente.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(301, 107);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 57;
            label2.Text = "ID Cliente";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Location = new Point(301, 195);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(202, 28);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
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
            Margin = new Padding(3, 4, 3, 4);
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