namespace Gentefit.Vistas.Admin.GestiEntrenadores
{
    partial class ListarEntrenadores
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
            BotonVolver = new Button();
            Entrenadores = new Label();
            PanelEntrenadores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PanelEntrenadores).BeginInit();
            SuspendLayout();
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(669, 392);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(75, 23);
            BotonVolver.TabIndex = 19;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // Entrenadores
            // 
            Entrenadores.AutoSize = true;
            Entrenadores.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Entrenadores.ForeColor = Color.DarkSlateGray;
            Entrenadores.Location = new Point(234, 35);
            Entrenadores.Name = "Entrenadores";
            Entrenadores.Size = new Size(417, 37);
            Entrenadores.TabIndex = 18;
            Entrenadores.Text = "ENTRENADORES REGISTRADOS";
            // 
            // PanelEntrenadores
            // 
            PanelEntrenadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelEntrenadores.Location = new Point(56, 91);
            PanelEntrenadores.Name = "PanelEntrenadores";
            PanelEntrenadores.Size = new Size(688, 285);
            PanelEntrenadores.TabIndex = 17;
            // 
            // ListarEntrenadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonVolver);
            Controls.Add(Entrenadores);
            Controls.Add(PanelEntrenadores);
            Name = "ListarEntrenadores";
            Text = "ListarEntrenadores";
            ((System.ComponentModel.ISupportInitialize)PanelEntrenadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonVolver;
        private Label Entrenadores;
        private DataGridView PanelEntrenadores;
    }
}