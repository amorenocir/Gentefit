namespace Gentefit.Vistas.Admin.GestActividades.GestClases
{
    partial class AnadirClaseEntrenador
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
            BotonVerTodos = new Button();
            BotonCancelar = new Button();
            BotonSeleccionar = new Button();
            BotonBuscar = new Button();
            CajaTextoBuscar = new TextBox();
            PanelEntrenadores = new DataGridView();
            EliminarClientes = new Label();
            ((System.ComponentModel.ISupportInitialize)PanelEntrenadores).BeginInit();
            SuspendLayout();
            // 
            // BotonVerTodos
            // 
            BotonVerTodos.BackColor = Color.DarkOrange;
            BotonVerTodos.Location = new Point(351, 97);
            BotonVerTodos.Name = "BotonVerTodos";
            BotonVerTodos.Size = new Size(82, 34);
            BotonVerTodos.TabIndex = 57;
            BotonVerTodos.Text = "Ver todos";
            BotonVerTodos.UseVisualStyleBackColor = false;
            BotonVerTodos.Click += BotonVerTodos_Click;
            // 
            // BotonCancelar
            // 
            BotonCancelar.Location = new Point(661, 371);
            BotonCancelar.Name = "BotonCancelar";
            BotonCancelar.Size = new Size(71, 34);
            BotonCancelar.TabIndex = 56;
            BotonCancelar.Text = "Cancelar";
            BotonCancelar.UseVisualStyleBackColor = true;
            BotonCancelar.Click += BotonCancelar_Click;
            // 
            // BotonSeleccionar
            // 
            BotonSeleccionar.BackColor = Color.DarkOrange;
            BotonSeleccionar.Location = new Point(563, 371);
            BotonSeleccionar.Name = "BotonSeleccionar";
            BotonSeleccionar.Size = new Size(85, 34);
            BotonSeleccionar.TabIndex = 55;
            BotonSeleccionar.Text = "Seleccionar";
            BotonSeleccionar.UseVisualStyleBackColor = false;
            BotonSeleccionar.Click += BotonSeleccionar_Click;
            // 
            // BotonBuscar
            // 
            BotonBuscar.BackColor = Color.DarkOrange;
            BotonBuscar.Location = new Point(264, 97);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(70, 34);
            BotonBuscar.TabIndex = 54;
            BotonBuscar.Text = "Buscar";
            BotonBuscar.UseVisualStyleBackColor = false;
            BotonBuscar.Click += BotonBuscar_Click;
            // 
            // CajaTextoBuscar
            // 
            CajaTextoBuscar.Location = new Point(69, 104);
            CajaTextoBuscar.Name = "CajaTextoBuscar";
            CajaTextoBuscar.Size = new Size(180, 23);
            CajaTextoBuscar.TabIndex = 53;
            // 
            // PanelEntrenadores
            // 
            PanelEntrenadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelEntrenadores.Location = new Point(69, 149);
            PanelEntrenadores.Name = "PanelEntrenadores";
            PanelEntrenadores.Size = new Size(662, 216);
            PanelEntrenadores.TabIndex = 52;
            // 
            // EliminarClientes
            // 
            EliminarClientes.AutoSize = true;
            EliminarClientes.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            EliminarClientes.ForeColor = Color.DarkSlateGray;
            EliminarClientes.Location = new Point(69, 44);
            EliminarClientes.Name = "EliminarClientes";
            EliminarClientes.Size = new Size(485, 37);
            EliminarClientes.TabIndex = 58;
            EliminarClientes.Text = "ESCOGER ENTRENADOR DISPONIBLE";
            // 
            // AnadirClaseEntrenador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EliminarClientes);
            Controls.Add(BotonVerTodos);
            Controls.Add(BotonCancelar);
            Controls.Add(BotonSeleccionar);
            Controls.Add(BotonBuscar);
            Controls.Add(CajaTextoBuscar);
            Controls.Add(PanelEntrenadores);
            Name = "AnadirClaseEntrenador";
            Text = "AnadirClaseEntrenador";
            Load += AnadirClaseEntrenador_Load;
            ((System.ComponentModel.ISupportInitialize)PanelEntrenadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonVerTodos;
        private Button BotonCancelar;
        private Button BotonSeleccionar;
        private Button BotonBuscar;
        private TextBox CajaTextoBuscar;
        private DataGridView PanelEntrenadores;
        private Label EliminarClientes;
    }
}