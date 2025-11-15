namespace Gentefit.Vistas.Admin.GestActividades.GestClases
{
    partial class EliminarClase
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
            Titulo = new Label();
            PanelClases = new DataGridView();
            BotonVolver = new Button();
            BotonEliminar = new Button();
            BotonVerTodos = new Button();
            BotonBuscar = new Button();
            CajaTextoBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PanelClases).BeginInit();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Titulo.ForeColor = Color.DarkSlateGray;
            Titulo.Location = new Point(76, 39);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(161, 37);
            Titulo.TabIndex = 68;
            Titulo.Text = "TEMPORAL";
            // 
            // PanelClases
            // 
            PanelClases.Location = new Point(76, 154);
            PanelClases.Name = "PanelClases";
            PanelClases.Size = new Size(632, 186);
            PanelClases.TabIndex = 67;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(659, 363);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(71, 34);
            BotonVolver.TabIndex = 70;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // BotonEliminar
            // 
            BotonEliminar.BackColor = Color.DarkOrange;
            BotonEliminar.Location = new Point(561, 363);
            BotonEliminar.Name = "BotonEliminar";
            BotonEliminar.Size = new Size(77, 34);
            BotonEliminar.TabIndex = 69;
            BotonEliminar.Text = "Eliminar";
            BotonEliminar.UseVisualStyleBackColor = false;
            BotonEliminar.Click += BotonEliminar_Click;
            // 
            // BotonVerTodos
            // 
            BotonVerTodos.BackColor = Color.DarkOrange;
            BotonVerTodos.Location = new Point(359, 89);
            BotonVerTodos.Name = "BotonVerTodos";
            BotonVerTodos.Size = new Size(82, 34);
            BotonVerTodos.TabIndex = 73;
            BotonVerTodos.Text = "Ver todos";
            BotonVerTodos.UseVisualStyleBackColor = false;
            BotonVerTodos.Click += BotonVerTodos_Click;
            // 
            // BotonBuscar
            // 
            BotonBuscar.BackColor = Color.DarkOrange;
            BotonBuscar.Location = new Point(272, 89);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(70, 34);
            BotonBuscar.TabIndex = 72;
            BotonBuscar.Text = "Buscar";
            BotonBuscar.UseVisualStyleBackColor = false;
            BotonBuscar.Click += BotonBuscar_Click;
            // 
            // CajaTextoBuscar
            // 
            CajaTextoBuscar.Location = new Point(77, 96);
            CajaTextoBuscar.Name = "CajaTextoBuscar";
            CajaTextoBuscar.Size = new Size(180, 23);
            CajaTextoBuscar.TabIndex = 71;
            // 
            // EliminarClase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonVerTodos);
            Controls.Add(BotonBuscar);
            Controls.Add(CajaTextoBuscar);
            Controls.Add(BotonVolver);
            Controls.Add(BotonEliminar);
            Controls.Add(Titulo);
            Controls.Add(PanelClases);
            Name = "EliminarClase";
            Text = "EliminarClase";
            Load += EliminarClase_Load;
            ((System.ComponentModel.ISupportInitialize)PanelClases).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private DataGridView PanelClases;
        private Button BotonVolver;
        private Button BotonEliminar;
        private Button BotonVerTodos;
        private Button BotonBuscar;
        private TextBox CajaTextoBuscar;
    }
}