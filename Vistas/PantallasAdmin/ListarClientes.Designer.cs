namespace Gentefit.Vistas.PantallasAdmin { 
    partial class ListarClientes
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
            PanelClientes = new DataGridView();
            Actividades = new Label();
            BotonVolver = new Button();
            BotonExportarXml = new Button();
            BotonImportarXml = new Button();
            ((System.ComponentModel.ISupportInitialize)PanelClientes).BeginInit();
            SuspendLayout();
            // 
            // PanelClientes
            // 
            PanelClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelClientes.Location = new Point(59, 95);
            PanelClientes.Name = "PanelClientes";
            PanelClientes.Size = new Size(688, 285);
            PanelClientes.TabIndex = 0;
            // 
            // Actividades
            // 
            Actividades.AutoSize = true;
            Actividades.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Actividades.ForeColor = Color.DarkSlateGray;
            Actividades.Location = new Point(237, 39);
            Actividades.Name = "Actividades";
            Actividades.Size = new Size(327, 37);
            Actividades.TabIndex = 7;
            Actividades.Text = "CLIENTES REGISTRADOS";
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(672, 396);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(75, 23);
            BotonVolver.TabIndex = 14;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // BotonExportarXml
            // 
            BotonExportarXml.BackColor = Color.DarkOrange;
            BotonExportarXml.Location = new Point(559, 396);
            BotonExportarXml.Name = "BotonExportarXml";
            BotonExportarXml.Size = new Size(97, 23);
            BotonExportarXml.TabIndex = 15;
            BotonExportarXml.Text = "Exportar XML";
            BotonExportarXml.UseVisualStyleBackColor = false;
            BotonExportarXml.Click += BotonExportarXml_Click;
            // 
            // BotonImportarXml
            // 
            BotonImportarXml.BackColor = Color.DarkOrange;
            BotonImportarXml.Location = new Point(444, 396);
            BotonImportarXml.Name = "BotonImportarXml";
            BotonImportarXml.Size = new Size(97, 23);
            BotonImportarXml.TabIndex = 16;
            BotonImportarXml.Text = "Importar XML";
            BotonImportarXml.UseVisualStyleBackColor = false;
            BotonImportarXml.Click += BotonImportarXml_Click;
            // 
            // ListarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonImportarXml);
            Controls.Add(BotonExportarXml);
            Controls.Add(BotonVolver);
            Controls.Add(Actividades);
            Controls.Add(PanelClientes);
            Name = "ListarClientes";
            Text = "ListarClientes";
            ((System.ComponentModel.ISupportInitialize)PanelClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();




        }

        #endregion

        private DataGridView PanelClientes;
        private Label Actividades;
        private Button BotonVolver;
        private Button BotonExportarXml;
        private Button BotonImportarXml;
    }
}