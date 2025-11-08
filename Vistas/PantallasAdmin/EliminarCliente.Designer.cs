namespace Gentefit.Vistas.PantallasAdmin
{
    partial class EliminarCliente
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
            PanelClientes = new DataGridView();
            BotonBuscar = new Button();
            CajaTextoBuscar = new TextBox();
            BotonVolver = new Button();
            BotonEliminar = new Button();
            BotonVerTodos = new Button();
            EliminarClientes = new Label();
            ((System.ComponentModel.ISupportInitialize)PanelClientes).BeginInit();
            SuspendLayout();
            // 
            // PanelClientes
            // 
            PanelClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelClientes.Location = new Point(79, 138);
            PanelClientes.Name = "PanelClientes";
            PanelClientes.Size = new Size(662, 216);
            PanelClientes.TabIndex = 37;
            // 
            // BotonBuscar
            // 
            BotonBuscar.BackColor = Color.DarkOrange;
            BotonBuscar.Location = new Point(274, 86);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(70, 34);
            BotonBuscar.TabIndex = 41;
            BotonBuscar.Text = "Buscar";
            BotonBuscar.UseVisualStyleBackColor = false;
            BotonBuscar.Click += BotonBuscar_Click;
            // 
            // CajaTextoBuscar
            // 
            CajaTextoBuscar.Location = new Point(79, 93);
            CajaTextoBuscar.Name = "CajaTextoBuscar";
            CajaTextoBuscar.Size = new Size(180, 23);
            CajaTextoBuscar.TabIndex = 40;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(671, 360);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(71, 34);
            BotonVolver.TabIndex = 43;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // BotonEliminar
            // 
            BotonEliminar.BackColor = Color.DarkOrange;
            BotonEliminar.Location = new Point(588, 360);
            BotonEliminar.Name = "BotonEliminar";
            BotonEliminar.Size = new Size(70, 34);
            BotonEliminar.TabIndex = 42;
            BotonEliminar.Text = "Eliminar";
            BotonEliminar.UseVisualStyleBackColor = false;
            BotonEliminar.Click += BotonEliminar_Click;
            // 
            // BotonVerTodos
            // 
            BotonVerTodos.BackColor = Color.DarkOrange;
            BotonVerTodos.Location = new Point(361, 86);
            BotonVerTodos.Name = "BotonVerTodos";
            BotonVerTodos.Size = new Size(82, 34);
            BotonVerTodos.TabIndex = 44;
            BotonVerTodos.Text = "Ver todos";
            BotonVerTodos.UseVisualStyleBackColor = false;
            BotonVerTodos.Click += BotonVerTodos_Click;
            // 
            // EliminarClientes
            // 
            EliminarClientes.AutoSize = true;
            EliminarClientes.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            EliminarClientes.ForeColor = Color.DarkSlateGray;
            EliminarClientes.Location = new Point(79, 31);
            EliminarClientes.Name = "EliminarClientes";
            EliminarClientes.Size = new Size(274, 37);
            EliminarClientes.TabIndex = 45;
            EliminarClientes.Text = "ELIMINAR CLIENTES";
            // 
            // EliminarCliente
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
            Controls.Add(PanelClientes);
            Name = "EliminarCliente";
            Text = "EliminarCliente";
            ((System.ComponentModel.ISupportInitialize)PanelClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView PanelClientes;
        private Button BotonBuscar;
        private TextBox CajaTextoBuscar;
        private Button BotonVolver;
        private Button BotonEliminar;
        private Button BotonVerTodos;
        private Label EliminarClientes;
    }
}