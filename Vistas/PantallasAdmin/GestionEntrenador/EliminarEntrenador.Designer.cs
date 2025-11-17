namespace Gentefit.Vistas.PantallasAdmin
{
    partial class EliminarEntrenador
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
            PanelEntrenadores = new DataGridView();
            BotonBuscar = new Button();
            CajaTextoBuscar = new TextBox();
            BotonVolver = new Button();
            BotonEliminar = new Button();
            BotonVerTodos = new Button();
            EliminarEntrenadores = new Label();
            ((System.ComponentModel.ISupportInitialize)PanelEntrenadores).BeginInit();
            SuspendLayout();
            // 
            // PanelEntrenadores
            // 
            PanelEntrenadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelEntrenadores.Location = new Point(90, 184);
            PanelEntrenadores.Margin = new Padding(3, 4, 3, 4);
            PanelEntrenadores.Name = "PanelEntrenadores";
            PanelEntrenadores.RowHeadersWidth = 51;
            PanelEntrenadores.Size = new Size(757, 288);
            PanelEntrenadores.TabIndex = 37;
            // 
            // BotonBuscar
            // 
            BotonBuscar.BackColor = Color.DarkOrange;
            BotonBuscar.Location = new Point(313, 115);
            BotonBuscar.Margin = new Padding(3, 4, 3, 4);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(80, 45);
            BotonBuscar.TabIndex = 41;
            BotonBuscar.Text = "Buscar";
            BotonBuscar.UseVisualStyleBackColor = false;
            BotonBuscar.Click += BotonBuscar_Click;
            // 
            // CajaTextoBuscar
            // 
            CajaTextoBuscar.Location = new Point(90, 124);
            CajaTextoBuscar.Margin = new Padding(3, 4, 3, 4);
            CajaTextoBuscar.Name = "CajaTextoBuscar";
            CajaTextoBuscar.Size = new Size(205, 27);
            CajaTextoBuscar.TabIndex = 40;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(767, 480);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(81, 45);
            BotonVolver.TabIndex = 43;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // BotonEliminar
            // 
            BotonEliminar.BackColor = Color.DarkOrange;
            BotonEliminar.Location = new Point(672, 480);
            BotonEliminar.Margin = new Padding(3, 4, 3, 4);
            BotonEliminar.Name = "BotonEliminar";
            BotonEliminar.Size = new Size(80, 45);
            BotonEliminar.TabIndex = 42;
            BotonEliminar.Text = "Eliminar";
            BotonEliminar.UseVisualStyleBackColor = false;
            BotonEliminar.Click += BotonEliminar_Click;
            // 
            // BotonVerTodos
            // 
            BotonVerTodos.BackColor = Color.DarkOrange;
            BotonVerTodos.Location = new Point(413, 115);
            BotonVerTodos.Margin = new Padding(3, 4, 3, 4);
            BotonVerTodos.Name = "BotonVerTodos";
            BotonVerTodos.Size = new Size(94, 45);
            BotonVerTodos.TabIndex = 44;
            BotonVerTodos.Text = "Ver todos";
            BotonVerTodos.UseVisualStyleBackColor = false;
            BotonVerTodos.Click += BotonVerTodos_Click;
            // 
            // EliminarEntrenadores
            // 
            EliminarEntrenadores.AutoSize = true;
            EliminarEntrenadores.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            EliminarEntrenadores.ForeColor = Color.DarkSlateGray;
            EliminarEntrenadores.Location = new Point(90, 41);
            EliminarEntrenadores.Name = "EliminarEntrenadores";
            EliminarEntrenadores.Size = new Size(458, 46);
            EliminarEntrenadores.TabIndex = 45;
            EliminarEntrenadores.Text = "ELIMINAR ENTRENADORES";
            // 
            // EliminarEntrenador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(EliminarEntrenadores);
            Controls.Add(BotonVerTodos);
            Controls.Add(BotonVolver);
            Controls.Add(BotonEliminar);
            Controls.Add(BotonBuscar);
            Controls.Add(CajaTextoBuscar);
            Controls.Add(PanelEntrenadores);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EliminarEntrenador";
            Text = "EliminarEntrenadores";
            ((System.ComponentModel.ISupportInitialize)PanelEntrenadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView PanelEntrenadores;
        private Button BotonBuscar;
        private TextBox CajaTextoBuscar;
        private Button BotonVolver;
        private Button BotonEliminar;
        private Button BotonVerTodos;
        private Label EliminarEntrenadores;
    }
}