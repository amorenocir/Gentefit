namespace Gentefit.Vistas.Admin.GestSalas
{
    partial class ListarSalas
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
            Salas = new Label();
            PanelSalas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PanelSalas).BeginInit();
            SuspendLayout();
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(669, 392);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(75, 23);
            BotonVolver.TabIndex = 22;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // Salas
            // 
            Salas.AutoSize = true;
            Salas.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Salas.ForeColor = Color.DarkSlateGray;
            Salas.Location = new Point(267, 34);
            Salas.Name = "Salas";
            Salas.Size = new Size(289, 37);
            Salas.TabIndex = 21;
            Salas.Text = "SALAS REGISTRADAS";
            // 
            // PanelSalas
            // 
            PanelSalas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelSalas.Location = new Point(56, 91);
            PanelSalas.Name = "PanelSalas";
            PanelSalas.Size = new Size(688, 285);
            PanelSalas.TabIndex = 20;
            // 
            // ListarSalas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonVolver);
            Controls.Add(Salas);
            Controls.Add(PanelSalas);
            Name = "ListarSalas";
            Text = "ListarSalas";
            ((System.ComponentModel.ISupportInitialize)PanelSalas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonVolver;
        private Label Salas;
        private DataGridView PanelSalas;
    }
}