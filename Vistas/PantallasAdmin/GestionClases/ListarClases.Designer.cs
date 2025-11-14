namespace Gentefit.Vistas.PantallasAdmin.GestionClases
{
    partial class ListarClases
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
            BotonImportarXml = new Button();
            BotonExportarXml = new Button();
            BotonVolver = new Button();
            Actividades = new Label();
            PanelClases = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PanelClases).BeginInit();
            SuspendLayout();
            // 
            // BotonImportarXml
            // 
            BotonImportarXml.BackColor = Color.DarkOrange;
            BotonImportarXml.Location = new Point(505, 497);
            BotonImportarXml.Margin = new Padding(3, 4, 3, 4);
            BotonImportarXml.Name = "BotonImportarXml";
            BotonImportarXml.Size = new Size(111, 31);
            BotonImportarXml.TabIndex = 21;
            BotonImportarXml.Text = "Importar XML";
            BotonImportarXml.UseVisualStyleBackColor = false;
            BotonImportarXml.Click += BotonImportarXml_Click;
            // 
            // BotonExportarXml
            // 
            BotonExportarXml.BackColor = Color.DarkOrange;
            BotonExportarXml.Location = new Point(637, 497);
            BotonExportarXml.Margin = new Padding(3, 4, 3, 4);
            BotonExportarXml.Name = "BotonExportarXml";
            BotonExportarXml.Size = new Size(111, 31);
            BotonExportarXml.TabIndex = 20;
            BotonExportarXml.Text = "Exportar XML";
            BotonExportarXml.UseVisualStyleBackColor = false;
            BotonExportarXml.Click += BotonExportarXml_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(766, 497);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(86, 31);
            BotonVolver.TabIndex = 19;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // Actividades
            // 
            Actividades.AutoSize = true;
            Actividades.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Actividades.ForeColor = Color.DarkSlateGray;
            Actividades.Location = new Point(277, 25);
            Actividades.Name = "Actividades";
            Actividades.Size = new Size(375, 46);
            Actividades.TabIndex = 18;
            Actividades.Text = "CLASES REGISTRADAS";
            // 
            // PanelClases
            // 
            PanelClases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelClases.Location = new Point(65, 96);
            PanelClases.Margin = new Padding(3, 4, 3, 4);
            PanelClases.Name = "PanelClases";
            PanelClases.RowHeadersWidth = 51;
            PanelClases.Size = new Size(786, 380);
            PanelClases.TabIndex = 17;
            // 
            // ListarClases
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 546);
            Controls.Add(BotonImportarXml);
            Controls.Add(BotonExportarXml);
            Controls.Add(BotonVolver);
            Controls.Add(Actividades);
            Controls.Add(PanelClases);
            Name = "ListarClases";
            Text = "ListarClases";
            ((System.ComponentModel.ISupportInitialize)PanelClases).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button BotonImportarXml;
        private Button BotonExportarXml;
        private Button BotonVolver;
        private Label Actividades;
        private DataGridView PanelClases;
    }
}