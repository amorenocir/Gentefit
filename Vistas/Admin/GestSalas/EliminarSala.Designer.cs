namespace Gentefit.Vistas.Admin.GestiEntrenadores
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
            EliminarEntrenadores = new Label();
            BotonVolver = new Button();
            BotonEliminar = new Button();
            PanelSalas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PanelSalas).BeginInit();
            SuspendLayout();
            // 
            // EliminarEntrenadores
            // 
            EliminarEntrenadores.AutoSize = true;
            EliminarEntrenadores.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            EliminarEntrenadores.ForeColor = Color.DarkSlateGray;
            EliminarEntrenadores.Location = new Point(69, 44);
            EliminarEntrenadores.Name = "EliminarEntrenadores";
            EliminarEntrenadores.Size = new Size(222, 37);
            EliminarEntrenadores.TabIndex = 59;
            EliminarEntrenadores.Text = "ELIMINAR SALA";
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(661, 373);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(71, 34);
            BotonVolver.TabIndex = 57;
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
            BotonEliminar.TabIndex = 56;
            BotonEliminar.Text = "Eliminar";
            BotonEliminar.UseVisualStyleBackColor = false;
            BotonEliminar.Click += BotonEliminar_Click;
            // 
            // PanelSalas
            // 
            PanelSalas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelSalas.Location = new Point(69, 118);
            PanelSalas.Name = "PanelSalas";
            PanelSalas.Size = new Size(662, 249);
            PanelSalas.TabIndex = 53;
            // 
            // EliminarSala
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EliminarEntrenadores);
            Controls.Add(BotonVolver);
            Controls.Add(BotonEliminar);
            Controls.Add(PanelSalas);
            Name = "EliminarSala";
            Text = "EliminarSala";
            ((System.ComponentModel.ISupportInitialize)PanelSalas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EliminarEntrenadores;
        private Button BotonVolver;
        private Button BotonEliminar;
        private DataGridView PanelSalas;
    }
}