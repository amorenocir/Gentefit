namespace Gentefit.Vistas.Admin.GestActividades.GestClases
{
    partial class ListarClases
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
            Clases = new Label();
            PanelClases = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PanelClases).BeginInit();
            SuspendLayout();
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(669, 393);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(75, 23);
            BotonVolver.TabIndex = 25;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // Clases
            // 
            Clases.AutoSize = true;
            Clases.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Clases.ForeColor = Color.DarkSlateGray;
            Clases.Location = new Point(267, 35);
            Clases.Name = "Clases";
            Clases.Size = new Size(301, 37);
            Clases.TabIndex = 24;
            Clases.Text = "CLASES REGISTRADAS";
            // 
            // PanelClases
            // 
            PanelClases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelClases.Location = new Point(56, 92);
            PanelClases.Name = "PanelClases";
            PanelClases.Size = new Size(688, 285);
            PanelClases.TabIndex = 23;
            // 
            // ListarClases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonVolver);
            Controls.Add(Clases);
            Controls.Add(PanelClases);
            Name = "ListarClases";
            Text = "ListarClases";
            Load += ListarClases_Load;
            ((System.ComponentModel.ISupportInitialize)PanelClases).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonVolver;
        private Label Clases;
        private DataGridView PanelClases;
    }
}