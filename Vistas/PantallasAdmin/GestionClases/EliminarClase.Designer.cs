namespace Gentefit.Vistas.PantallasAdmin.GestionClases
{
    partial class EliminarClase
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
            EliminarClaseTitulo = new Label();
            BotonVerTodos = new Button();
            BotonVolver = new Button();
            BotonEliminar = new Button();
            BotonBuscar = new Button();
            CajaTextoBuscar = new TextBox();
            PanelClases = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PanelClases).BeginInit();
            SuspendLayout();
            // 
            // EliminarClaseTitulo
            // 
            EliminarClaseTitulo.AutoSize = true;
            EliminarClaseTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            EliminarClaseTitulo.ForeColor = Color.DarkSlateGray;
            EliminarClaseTitulo.Location = new Point(81, 44);
            EliminarClaseTitulo.Name = "EliminarClaseTitulo";
            EliminarClaseTitulo.Size = new Size(292, 46);
            EliminarClaseTitulo.TabIndex = 59;
            EliminarClaseTitulo.Text = "ELIMINAR CLASE";
            // 
            // BotonVerTodos
            // 
            BotonVerTodos.BackColor = Color.DarkOrange;
            BotonVerTodos.Location = new Point(404, 118);
            BotonVerTodos.Margin = new Padding(3, 4, 3, 4);
            BotonVerTodos.Name = "BotonVerTodos";
            BotonVerTodos.Size = new Size(94, 45);
            BotonVerTodos.TabIndex = 58;
            BotonVerTodos.Text = "Ver todos";
            BotonVerTodos.UseVisualStyleBackColor = false;
            BotonVerTodos.Click += BotonVerTodos_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(758, 483);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(81, 45);
            BotonVolver.TabIndex = 57;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // BotonEliminar
            // 
            BotonEliminar.BackColor = Color.DarkOrange;
            BotonEliminar.Location = new Point(663, 483);
            BotonEliminar.Margin = new Padding(3, 4, 3, 4);
            BotonEliminar.Name = "BotonEliminar";
            BotonEliminar.Size = new Size(80, 45);
            BotonEliminar.TabIndex = 56;
            BotonEliminar.Text = "Eliminar";
            BotonEliminar.UseVisualStyleBackColor = false;
            BotonEliminar.Click += BotonEliminar_Click;
            // 
            // BotonBuscar
            // 
            BotonBuscar.BackColor = Color.DarkOrange;
            BotonBuscar.Location = new Point(304, 118);
            BotonBuscar.Margin = new Padding(3, 4, 3, 4);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(80, 45);
            BotonBuscar.TabIndex = 55;
            BotonBuscar.Text = "Buscar";
            BotonBuscar.UseVisualStyleBackColor = false;
            BotonBuscar.Click += BotonBuscar_Click;
            // 
            // CajaTextoBuscar
            // 
            CajaTextoBuscar.Location = new Point(81, 127);
            CajaTextoBuscar.Margin = new Padding(3, 4, 3, 4);
            CajaTextoBuscar.Name = "CajaTextoBuscar";
            CajaTextoBuscar.Size = new Size(205, 27);
            CajaTextoBuscar.TabIndex = 54;
            // 
            // PanelClases
            // 
            PanelClases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelClases.Location = new Point(81, 187);
            PanelClases.Margin = new Padding(3, 4, 3, 4);
            PanelClases.Name = "PanelClases";
            PanelClases.RowHeadersWidth = 51;
            PanelClases.Size = new Size(757, 288);
            PanelClases.TabIndex = 53;
            // 
            // EliminarClase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 573);
            Controls.Add(EliminarClaseTitulo);
            Controls.Add(BotonVerTodos);
            Controls.Add(BotonVolver);
            Controls.Add(BotonEliminar);
            Controls.Add(BotonBuscar);
            Controls.Add(CajaTextoBuscar);
            Controls.Add(PanelClases);
            Name = "EliminarClase";
            Text = "EliminarClase";
            ((System.ComponentModel.ISupportInitialize)PanelClases).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label EliminarClaseTitulo;
        private Button BotonVerTodos;
        private Button BotonVolver;
        private Button BotonEliminar;
        private Button BotonBuscar;
        private TextBox CajaTextoBuscar;
        private DataGridView PanelClases;
    }
}