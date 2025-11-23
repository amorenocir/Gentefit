namespace Gentefit.Vistas.PantallasAdmin.GestionReservas
{
    partial class ListarReservas
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
            BotonTodo = new Button();
            BotonVolver = new Button();
            BotonSelecCla = new Button();
            BotonSelecCli = new Button();
            SubtituloClase = new Label();
            SubtituloCliente = new Label();
            BotonVerTodosCla = new Button();
            BotonBuscarCla = new Button();
            PanelClases = new DataGridView();
            CajaTextoBuscarCla = new TextBox();
            Titulo = new Label();
            BotonVerTodosCli = new Button();
            BotonBuscarCli = new Button();
            PanelClientes = new DataGridView();
            CajaTextoBuscarCli = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PanelClases).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PanelClientes).BeginInit();
            SuspendLayout();
            // 
            // BotonTodo
            // 
            BotonTodo.BackColor = Color.DarkOrange;
            BotonTodo.Location = new Point(579, 19);
            BotonTodo.Name = "BotonTodo";
            BotonTodo.Size = new Size(82, 43);
            BotonTodo.TabIndex = 86;
            BotonTodo.Text = "Todas las reservas";
            BotonTodo.UseVisualStyleBackColor = false;
            BotonTodo.Click += BotonTodo_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(689, 23);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(71, 34);
            BotonVolver.TabIndex = 87;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // BotonSelecCla
            // 
            BotonSelecCla.BackColor = Color.DarkOrange;
            BotonSelecCla.Location = new Point(680, 397);
            BotonSelecCla.Name = "BotonSelecCla";
            BotonSelecCla.Size = new Size(80, 34);
            BotonSelecCla.TabIndex = 85;
            BotonSelecCla.Text = "Seleccionar";
            BotonSelecCla.UseVisualStyleBackColor = false;
            BotonSelecCla.Click += BotonSelecCla_Click;
            // 
            // BotonSelecCli
            // 
            BotonSelecCli.BackColor = Color.DarkOrange;
            BotonSelecCli.Location = new Point(284, 397);
            BotonSelecCli.Name = "BotonSelecCli";
            BotonSelecCli.Size = new Size(80, 34);
            BotonSelecCli.TabIndex = 81;
            BotonSelecCli.Text = "Seleccionar";
            BotonSelecCli.UseVisualStyleBackColor = false;
            BotonSelecCli.Click += BotonSelecCli_Click;
            // 
            // SubtituloClase
            // 
            SubtituloClase.AutoSize = true;
            SubtituloClase.BackColor = SystemColors.Control;
            SubtituloClase.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubtituloClase.ForeColor = Color.DarkSlateGray;
            SubtituloClase.Location = new Point(417, 69);
            SubtituloClase.Name = "SubtituloClase";
            SubtituloClase.Size = new Size(116, 32);
            SubtituloClase.TabIndex = 92;
            SubtituloClase.Text = "Por clase";
            // 
            // SubtituloCliente
            // 
            SubtituloCliente.AutoSize = true;
            SubtituloCliente.BackColor = SystemColors.Control;
            SubtituloCliente.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubtituloCliente.ForeColor = Color.DarkSlateGray;
            SubtituloCliente.Location = new Point(21, 69);
            SubtituloCliente.Name = "SubtituloCliente";
            SubtituloCliente.Size = new Size(136, 32);
            SubtituloCliente.TabIndex = 91;
            SubtituloCliente.Text = "Por cliente";
            // 
            // BotonVerTodosCla
            // 
            BotonVerTodosCla.BackColor = Color.DarkOrange;
            BotonVerTodosCla.Location = new Point(697, 114);
            BotonVerTodosCla.Name = "BotonVerTodosCla";
            BotonVerTodosCla.Size = new Size(82, 24);
            BotonVerTodosCla.TabIndex = 84;
            BotonVerTodosCla.Text = "Ver todos";
            BotonVerTodosCla.UseVisualStyleBackColor = false;
            BotonVerTodosCla.Click += BotonVerTodosCla_Click;
            // 
            // BotonBuscarCla
            // 
            BotonBuscarCla.BackColor = Color.DarkOrange;
            BotonBuscarCla.Location = new Point(613, 113);
            BotonBuscarCla.Name = "BotonBuscarCla";
            BotonBuscarCla.Size = new Size(70, 24);
            BotonBuscarCla.TabIndex = 83;
            BotonBuscarCla.Text = "Buscar";
            BotonBuscarCla.UseVisualStyleBackColor = false;
            BotonBuscarCla.Click += BotonBuscarCla_Click;
            // 
            // PanelClases
            // 
            PanelClases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelClases.Location = new Point(417, 156);
            PanelClases.Name = "PanelClases";
            PanelClases.RowHeadersWidth = 51;
            PanelClases.Size = new Size(343, 219);
            PanelClases.TabIndex = 90;
            // 
            // CajaTextoBuscarCla
            // 
            CajaTextoBuscarCla.Location = new Point(417, 113);
            CajaTextoBuscarCla.Name = "CajaTextoBuscarCla";
            CajaTextoBuscarCla.Size = new Size(180, 23);
            CajaTextoBuscarCla.TabIndex = 82;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.BackColor = SystemColors.Control;
            Titulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.ForeColor = Color.DarkSlateGray;
            Titulo.Location = new Point(21, 19);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(274, 32);
            Titulo.TabIndex = 89;
            Titulo.Text = "CONSULTAR RESERVAS";
            // 
            // BotonVerTodosCli
            // 
            BotonVerTodosCli.BackColor = Color.DarkOrange;
            BotonVerTodosCli.Location = new Point(301, 114);
            BotonVerTodosCli.Name = "BotonVerTodosCli";
            BotonVerTodosCli.Size = new Size(82, 24);
            BotonVerTodosCli.TabIndex = 80;
            BotonVerTodosCli.Text = "Ver todos";
            BotonVerTodosCli.UseVisualStyleBackColor = false;
            BotonVerTodosCli.Click += BotonVerTodosCli_Click;
            // 
            // BotonBuscarCli
            // 
            BotonBuscarCli.BackColor = Color.DarkOrange;
            BotonBuscarCli.Location = new Point(217, 113);
            BotonBuscarCli.Name = "BotonBuscarCli";
            BotonBuscarCli.Size = new Size(70, 24);
            BotonBuscarCli.TabIndex = 79;
            BotonBuscarCli.Text = "Buscar";
            BotonBuscarCli.UseVisualStyleBackColor = false;
            BotonBuscarCli.Click += BotonBuscarCli_Click;
            // 
            // PanelClientes
            // 
            PanelClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelClientes.Location = new Point(21, 156);
            PanelClientes.Name = "PanelClientes";
            PanelClientes.RowHeadersWidth = 51;
            PanelClientes.Size = new Size(343, 219);
            PanelClientes.TabIndex = 88;
            // 
            // CajaTextoBuscarCli
            // 
            CajaTextoBuscarCli.Location = new Point(21, 114);
            CajaTextoBuscarCli.Name = "CajaTextoBuscarCli";
            CajaTextoBuscarCli.Size = new Size(180, 23);
            CajaTextoBuscarCli.TabIndex = 78;
            // 
            // ListarReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonTodo);
            Controls.Add(BotonVolver);
            Controls.Add(BotonSelecCla);
            Controls.Add(BotonSelecCli);
            Controls.Add(SubtituloClase);
            Controls.Add(SubtituloCliente);
            Controls.Add(BotonVerTodosCla);
            Controls.Add(BotonBuscarCla);
            Controls.Add(PanelClases);
            Controls.Add(CajaTextoBuscarCla);
            Controls.Add(Titulo);
            Controls.Add(BotonVerTodosCli);
            Controls.Add(BotonBuscarCli);
            Controls.Add(PanelClientes);
            Controls.Add(CajaTextoBuscarCli);
            Name = "ListarReservas";
            Text = "ListarReservas";
            ((System.ComponentModel.ISupportInitialize)PanelClases).EndInit();
            ((System.ComponentModel.ISupportInitialize)PanelClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonTodo;
        private Button BotonVolver;
        private Button BotonSelecCla;
        private Button BotonSelecCli;
        private Label SubtituloClase;
        private Label SubtituloCliente;
        private Button BotonVerTodosCla;
        private Button BotonBuscarCla;
        private DataGridView PanelClases;
        private TextBox CajaTextoBuscarCla;
        private Label Titulo;
        private Button BotonVerTodosCli;
        private Button BotonBuscarCli;
        private DataGridView PanelClientes;
        private TextBox CajaTextoBuscarCli;
    }
}