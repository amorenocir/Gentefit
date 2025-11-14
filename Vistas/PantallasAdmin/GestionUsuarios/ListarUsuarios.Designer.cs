namespace Gentefit.Vistas.PantallasAdmin.GestionUsuarios
{
    partial class ListarUsuarios
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
            BotonImportarXml = new Button();
            BotonExportarXml = new Button();
            BotonVolver = new Button();
            Actividades = new Label();
            PanelUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PanelUsuarios).BeginInit();
            SuspendLayout();
            // 
            // BotonImportarXml
            // 
            BotonImportarXml.BackColor = Color.DarkOrange;
            BotonImportarXml.Location = new Point(512, 499);
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
            BotonExportarXml.Location = new Point(644, 499);
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
            BotonVolver.Location = new Point(773, 499);
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
            Actividades.Location = new Point(276, 23);
            Actividades.Name = "Actividades";
            Actividades.Size = new Size(429, 46);
            Actividades.TabIndex = 18;
            Actividades.Text = "USUARIOS REGISTRADOS";
            // 
            // PanelUsuarios
            // 
            PanelUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelUsuarios.Location = new Point(72, 98);
            PanelUsuarios.Margin = new Padding(3, 4, 3, 4);
            PanelUsuarios.Name = "PanelUsuarios";
            PanelUsuarios.RowHeadersWidth = 51;
            PanelUsuarios.ShowEditingIcon = false;
            PanelUsuarios.Size = new Size(786, 380);
            PanelUsuarios.TabIndex = 17;
            // 
            // ListarUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 570);
            Controls.Add(BotonImportarXml);
            Controls.Add(BotonExportarXml);
            Controls.Add(BotonVolver);
            Controls.Add(Actividades);
            Controls.Add(PanelUsuarios);
            Name = "ListarUsuarios";
            Text = "ListarUsuarios";
            ((System.ComponentModel.ISupportInitialize)PanelUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonImportarXml;
        private Button BotonExportarXml;
        private Button BotonVolver;
        private Label Actividades;
        private DataGridView PanelUsuarios;
    }
}