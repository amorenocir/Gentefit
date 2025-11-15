namespace Gentefit.Vistas.Admin.GestActividades.GestClases
{
    partial class ModificarClases2
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
            PanelSalas = new DataGridView();
            BotonVolver = new Button();
            BotonGuardar = new Button();
            BotonCancelar = new Button();
            Titulo = new Label();
            ((System.ComponentModel.ISupportInitialize)PanelEntrenadores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PanelSalas).BeginInit();
            SuspendLayout();
            // 
            // PanelEntrenadores
            // 
            PanelEntrenadores.Location = new Point(54, 93);
            PanelEntrenadores.Name = "PanelEntrenadores";
            PanelEntrenadores.Size = new Size(577, 144);
            PanelEntrenadores.TabIndex = 64;
            PanelEntrenadores.SelectionChanged += PanelEntrenadores_SelectionChanged;
            // 
            // PanelSalas
            // 
            PanelSalas.Location = new Point(54, 281);
            PanelSalas.Name = "PanelSalas";
            PanelSalas.Size = new Size(577, 140);
            PanelSalas.TabIndex = 65;
            PanelSalas.SelectionChanged += PanelSalas_SelectionChanged;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(682, 220);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(71, 34);
            BotonVolver.TabIndex = 67;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // BotonGuardar
            // 
            BotonGuardar.BackColor = Color.DarkOrange;
            BotonGuardar.Location = new Point(683, 130);
            BotonGuardar.Name = "BotonGuardar";
            BotonGuardar.Size = new Size(70, 34);
            BotonGuardar.TabIndex = 66;
            BotonGuardar.Text = "Guardar";
            BotonGuardar.UseVisualStyleBackColor = false;
            BotonGuardar.Click += BotonGuardar_Click;
            // 
            // BotonCancelar
            // 
            BotonCancelar.Location = new Point(683, 315);
            BotonCancelar.Name = "BotonCancelar";
            BotonCancelar.Size = new Size(71, 34);
            BotonCancelar.TabIndex = 68;
            BotonCancelar.Text = "Cancelar";
            BotonCancelar.UseVisualStyleBackColor = true;
            BotonCancelar.Click += BotonCancelar_Click;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Titulo.ForeColor = Color.DarkSlateGray;
            Titulo.Location = new Point(54, 24);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(161, 37);
            Titulo.TabIndex = 69;
            Titulo.Text = "TEMPORAL";
            // 
            // ModificarClases2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Titulo);
            Controls.Add(BotonCancelar);
            Controls.Add(BotonVolver);
            Controls.Add(BotonGuardar);
            Controls.Add(PanelSalas);
            Controls.Add(PanelEntrenadores);
            Name = "ModificarClases2";
            Text = "ModificarClases2";
            Load += ModificarClases2_Load;
            ((System.ComponentModel.ISupportInitialize)PanelEntrenadores).EndInit();
            ((System.ComponentModel.ISupportInitialize)PanelSalas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView PanelEntrenadores;
        private DataGridView PanelSalas;
        private Button BotonVolver;
        private Button BotonGuardar;
        private Button BotonCancelar;
        private Label Titulo;
    }
}