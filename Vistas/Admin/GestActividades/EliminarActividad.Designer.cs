namespace Gentefit.Vistas.Admin.GestActividades
{
    partial class EliminarActividad
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
            EliminarClientes = new Label();
            BotonVerTodos = new Button();
            BotonVolver = new Button();
            BotonEliminar = new Button();
            BotonBuscar = new Button();
            CajaTextoBuscar = new TextBox();
            PanelActividades = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PanelActividades).BeginInit();
            SuspendLayout();
            // 
            // EliminarClientes
            // 
            EliminarClientes.AutoSize = true;
            EliminarClientes.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            EliminarClientes.ForeColor = Color.DarkSlateGray;
            EliminarClientes.Location = new Point(69, 44);
            EliminarClientes.Name = "EliminarClientes";
            EliminarClientes.Size = new Size(301, 37);
            EliminarClientes.TabIndex = 52;
            EliminarClientes.Text = "ELIMINAR ACTIVIDAD";
            // 
            // BotonVerTodos
            // 
            BotonVerTodos.BackColor = Color.DarkOrange;
            BotonVerTodos.Location = new Point(351, 99);
            BotonVerTodos.Name = "BotonVerTodos";
            BotonVerTodos.Size = new Size(82, 34);
            BotonVerTodos.TabIndex = 51;
            BotonVerTodos.Text = "Ver todos";
            BotonVerTodos.UseVisualStyleBackColor = false;
            BotonVerTodos.Click += BotonVerTodos_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(661, 373);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(71, 34);
            BotonVolver.TabIndex = 50;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // BotonEliminar
            // 
            BotonEliminar.BackColor = Color.DarkOrange;
            BotonEliminar.Location = new Point(578, 373);
            BotonEliminar.Name = "BotonEliminar";
            BotonEliminar.Size = new Size(70, 34);
            BotonEliminar.TabIndex = 49;
            BotonEliminar.Text = "Eliminar";
            BotonEliminar.UseVisualStyleBackColor = false;
            BotonEliminar.Click += BotonEliminar_Click;
            // 
            // BotonBuscar
            // 
            BotonBuscar.BackColor = Color.DarkOrange;
            BotonBuscar.Location = new Point(264, 99);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(70, 34);
            BotonBuscar.TabIndex = 48;
            BotonBuscar.Text = "Buscar";
            BotonBuscar.UseVisualStyleBackColor = false;
            BotonBuscar.Click += BotonBuscar_Click;
            // 
            // CajaTextoBuscar
            // 
            CajaTextoBuscar.Location = new Point(69, 106);
            CajaTextoBuscar.Name = "CajaTextoBuscar";
            CajaTextoBuscar.Size = new Size(180, 23);
            CajaTextoBuscar.TabIndex = 47;
            // 
            // PanelActividades
            // 
            PanelActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelActividades.Location = new Point(69, 151);
            PanelActividades.Name = "PanelActividades";
            PanelActividades.Size = new Size(662, 216);
            PanelActividades.TabIndex = 46;
            // 
            // EliminarActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EliminarClientes);
            Controls.Add(BotonVerTodos);
            Controls.Add(BotonVolver);
            Controls.Add(BotonEliminar);
            Controls.Add(BotonBuscar);
            Controls.Add(CajaTextoBuscar);
            Controls.Add(PanelActividades);
            Name = "EliminarActividad";
            Text = "EliminarActividad";
            Load += EliminarActividad_Load;
            ((System.ComponentModel.ISupportInitialize)PanelActividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EliminarClientes;
        private Button BotonVerTodos;
        private Button BotonVolver;
        private Button BotonEliminar;
        private Button BotonBuscar;
        private TextBox CajaTextoBuscar;
        private DataGridView PanelActividades;
    }
}