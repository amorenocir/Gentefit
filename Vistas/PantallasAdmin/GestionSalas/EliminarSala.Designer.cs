namespace Gentefit.Vistas.PantallasAdmin
{
    partial class EliminarSala
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
            PanelSalas = new DataGridView();
            BotonBuscar = new Button();
            CajaTextoBuscar = new TextBox();
            BotonVolver = new Button();
            BotonEliminar = new Button();
            BotonVerTodos = new Button();
            EliminarSalas = new Label();
            ((System.ComponentModel.ISupportInitialize)PanelSalas).BeginInit();
            SuspendLayout();
            // 
            // PanelSalas
            // 
            PanelSalas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelSalas.Location = new Point(90, 184);
            PanelSalas.Margin = new Padding(3, 4, 3, 4);
            PanelSalas.Name = "PanelSalas";
            PanelSalas.RowHeadersWidth = 51;
            PanelSalas.Size = new Size(757, 288);
            PanelSalas.TabIndex = 37;
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
            // EliminarSalas
            // 
            EliminarSalas.AutoSize = true;
            EliminarSalas.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            EliminarSalas.ForeColor = Color.DarkSlateGray;
            EliminarSalas.Location = new Point(90, 41);
            EliminarSalas.Name = "EliminarSalas";
            EliminarSalas.Size = new Size(296, 46);
            EliminarSalas.TabIndex = 45;
            EliminarSalas.Text = "ELIMINAR SALAS";
            // 
            // EliminarSala
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(EliminarSalas);
            Controls.Add(BotonVerTodos);
            Controls.Add(BotonVolver);
            Controls.Add(BotonEliminar);
            Controls.Add(BotonBuscar);
            Controls.Add(CajaTextoBuscar);
            Controls.Add(PanelSalas);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EliminarSala";
            Text = "EliminarSala";
            ((System.ComponentModel.ISupportInitialize)PanelSalas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView PanelSalas;
        private Button BotonBuscar;
        private TextBox CajaTextoBuscar;
        private Button BotonVolver;
        private Button BotonEliminar;
        private Button BotonVerTodos;
        private Label EliminarSalas;
    }
}