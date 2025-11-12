namespace Gentefit.Vistas.PantallasAdmin.GestionUsuarios
{
    partial class EliminarUsuario
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
            EliminarUsuarios = new Label();
            BotonVerTodos = new Button();
            BotonVolver = new Button();
            BotonEliminar = new Button();
            BotonBuscar = new Button();
            CajaTextoBuscar = new TextBox();
            PanelUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PanelUsuarios).BeginInit();
            SuspendLayout();
            // 
            // EliminarUsuarios
            // 
            EliminarUsuarios.AutoSize = true;
            EliminarUsuarios.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            EliminarUsuarios.ForeColor = Color.DarkSlateGray;
            EliminarUsuarios.Location = new Point(84, 41);
            EliminarUsuarios.Name = "EliminarUsuarios";
            EliminarUsuarios.Size = new Size(362, 46);
            EliminarUsuarios.TabIndex = 52;
            EliminarUsuarios.Text = "ELIMINAR USUARIOS";
            // 
            // BotonVerTodos
            // 
            BotonVerTodos.BackColor = Color.DarkOrange;
            BotonVerTodos.Location = new Point(407, 115);
            BotonVerTodos.Margin = new Padding(3, 4, 3, 4);
            BotonVerTodos.Name = "BotonVerTodos";
            BotonVerTodos.Size = new Size(94, 45);
            BotonVerTodos.TabIndex = 51;
            BotonVerTodos.Text = "Ver todos";
            BotonVerTodos.UseVisualStyleBackColor = false;
            BotonVerTodos.Click += BotonVerTodos_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(761, 480);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(81, 45);
            BotonVolver.TabIndex = 50;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // BotonEliminar
            // 
            BotonEliminar.BackColor = Color.DarkOrange;
            BotonEliminar.Location = new Point(666, 480);
            BotonEliminar.Margin = new Padding(3, 4, 3, 4);
            BotonEliminar.Name = "BotonEliminar";
            BotonEliminar.Size = new Size(80, 45);
            BotonEliminar.TabIndex = 49;
            BotonEliminar.Text = "Eliminar";
            BotonEliminar.UseVisualStyleBackColor = false;
            BotonEliminar.Click += BotonEliminar_Click;
            // 
            // BotonBuscar
            // 
            BotonBuscar.BackColor = Color.DarkOrange;
            BotonBuscar.Location = new Point(307, 115);
            BotonBuscar.Margin = new Padding(3, 4, 3, 4);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(80, 45);
            BotonBuscar.TabIndex = 48;
            BotonBuscar.Text = "Buscar";
            BotonBuscar.UseVisualStyleBackColor = false;
            BotonBuscar.Click += BotonBuscar_Click;
            // 
            // CajaTextoBuscar
            // 
            CajaTextoBuscar.Location = new Point(84, 124);
            CajaTextoBuscar.Margin = new Padding(3, 4, 3, 4);
            CajaTextoBuscar.Name = "CajaTextoBuscar";
            CajaTextoBuscar.Size = new Size(205, 27);
            CajaTextoBuscar.TabIndex = 47;
            // 
            // PanelUsuarios
            // 
            PanelUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelUsuarios.Location = new Point(84, 184);
            PanelUsuarios.Margin = new Padding(3, 4, 3, 4);
            PanelUsuarios.Name = "PanelUsuarios";
            PanelUsuarios.RowHeadersWidth = 51;
            PanelUsuarios.Size = new Size(757, 288);
            PanelUsuarios.TabIndex = 46;
            // 
            // EliminarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 566);
            Controls.Add(EliminarUsuarios);
            Controls.Add(BotonVerTodos);
            Controls.Add(BotonVolver);
            Controls.Add(BotonEliminar);
            Controls.Add(BotonBuscar);
            Controls.Add(CajaTextoBuscar);
            Controls.Add(PanelUsuarios);
            Name = "EliminarUsuario";
            Text = "EliminarUsuario";
            ((System.ComponentModel.ISupportInitialize)PanelUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EliminarUsuarios;
        private Button BotonVerTodos;
        private Button BotonVolver;
        private Button BotonEliminar;
        private Button BotonBuscar;
        private TextBox CajaTextoBuscar;
        private DataGridView PanelUsuarios;
    }
}