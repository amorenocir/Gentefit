namespace Gentefit.Vistas.PantallasAdmin
{
    partial class ModificarSala
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
            CajaTextoNombre = new TextBox();
            EtiquetaNombre = new Label();
            BotonVolver = new Button();
            BotonGuardar = new Button();
            CajaTextoBuscar = new TextBox();
            PanelSalas = new DataGridView();
            CajaTextoId = new TextBox();
            EtiquetaID = new Label();
            BotonBuscar = new Button();
            BotonVerTodos = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PanelSalas).BeginInit();
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
            // CajaTextoNombre
            // 
            CajaTextoNombre.Location = new Point(43, 196);
            CajaTextoNombre.Margin = new Padding(3, 4, 3, 4);
            CajaTextoNombre.Name = "CajaTextoNombre";
            CajaTextoNombre.Size = new Size(210, 27);
            CajaTextoNombre.TabIndex = 21;
            // 
            // EtiquetaNombre
            // 
            EtiquetaNombre.AutoSize = true;
            EtiquetaNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EtiquetaNombre.Location = new Point(43, 172);
            EtiquetaNombre.Name = "EtiquetaNombre";
            EtiquetaNombre.Size = new Size(67, 20);
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
            CajaTextoBuscar.Location = new Point(48, 320);
            CajaTextoBuscar.Margin = new Padding(3, 4, 3, 4);
            CajaTextoBuscar.Name = "CajaTextoBuscar";
            CajaTextoBuscar.Size = new Size(205, 27);
            CajaTextoBuscar.TabIndex = 35;
            CajaTextoBuscar.Text = "Buscar por ID";
            // 
            // PanelSalas
            // 
            PanelSalas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelSalas.Location = new Point(43, 359);
            PanelSalas.Margin = new Padding(3, 4, 3, 4);
            PanelSalas.Name = "PanelSalas";
            PanelSalas.RowHeadersWidth = 51;
            PanelSalas.Size = new Size(837, 161);
            PanelSalas.TabIndex = 36;
            PanelSalas.CellClick += PanelSalas_CellClick;
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
            EtiquetaID.Size = new Size(25, 20);
            EtiquetaID.TabIndex = 37;
            EtiquetaID.Text = "ID";
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
            label1.Size = new Size(271, 41);
            label1.TabIndex = 55;
            label1.Text = "MODIFICAR SALA";
            // 
            // ModificarSala
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(BotonVerTodos);
            Controls.Add(BotonBuscar);
            Controls.Add(CajaTextoId);
            Controls.Add(EtiquetaID);
            Controls.Add(PanelSalas);
            Controls.Add(CajaTextoBuscar);
            Controls.Add(BotonVolver);
            Controls.Add(BotonGuardar);
            Controls.Add(CajaTextoNombre);
            Controls.Add(EtiquetaNombre);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ModificarSala";
            Text = "ModificarSala";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PanelSalas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
        private TextBox CajaTextoNombre;
        private Label EtiquetaNombre;
        private Button BotonVolver;
        private Button BotonGuardar;
        private TextBox CajaTextoBuscar;
        private DataGridView PanelSalas;
        private Label EtiquetaID;
        private Button BotonBuscar;
        private TextBox CajaTextoId;
        private Button BotonVerTodos;
        private Label label1;
    }
}