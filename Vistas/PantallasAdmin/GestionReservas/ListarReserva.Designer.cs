namespace Gentefit.Vistas.PantallasAdmin { 
    partial class ListarReservas
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
            PanelReservas = new DataGridView();
            Actividades = new Label();
            BotonVolver = new Button();
            BotonExportarXml = new Button();
            BotonImportarXml = new Button();
            ((System.ComponentModel.ISupportInitialize)PanelReservas).BeginInit();
            SuspendLayout();
            // 
            // PanelReservas
            // 
            PanelReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelReservas.Location = new Point(54, 121);
            PanelReservas.Margin = new Padding(3, 4, 3, 4);
            PanelReservas.Name = "PanelReservas";
            PanelReservas.RowHeadersWidth = 51;
            PanelReservas.Size = new Size(1225, 383);
            PanelReservas.TabIndex = 0;
            // 
            // Actividades
            // 
            Actividades.AutoSize = true;
            Actividades.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Actividades.ForeColor = Color.DarkSlateGray;
            Actividades.Location = new Point(445, 51);
            Actividades.Name = "Actividades";
            Actividades.Size = new Size(419, 46);
            Actividades.TabIndex = 7;
            Actividades.Text = "RESERVAS REGISTRADAS";
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(768, 528);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(86, 31);
            BotonVolver.TabIndex = 14;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // BotonExportarXml
            // 
            BotonExportarXml.BackColor = Color.DarkOrange;
            BotonExportarXml.Location = new Point(639, 528);
            BotonExportarXml.Margin = new Padding(3, 4, 3, 4);
            BotonExportarXml.Name = "BotonExportarXml";
            BotonExportarXml.Size = new Size(111, 31);
            BotonExportarXml.TabIndex = 15;
            BotonExportarXml.Text = "Exportar XML";
            BotonExportarXml.UseVisualStyleBackColor = false;
            BotonExportarXml.Click += BotonExportarXml_Click;
            // 
            // BotonImportarXml
            // 
            BotonImportarXml.BackColor = Color.DarkOrange;
            BotonImportarXml.Location = new Point(507, 528);
            BotonImportarXml.Margin = new Padding(3, 4, 3, 4);
            BotonImportarXml.Name = "BotonImportarXml";
            BotonImportarXml.Size = new Size(111, 31);
            BotonImportarXml.TabIndex = 16;
            BotonImportarXml.Text = "Importar XML";
            BotonImportarXml.UseVisualStyleBackColor = false;
            BotonImportarXml.Click += BotonImportarXml_Click;
            // 
            // ListarReservas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1357, 676);
            Controls.Add(BotonImportarXml);
            Controls.Add(BotonExportarXml);
            Controls.Add(BotonVolver);
            Controls.Add(Actividades);
            Controls.Add(PanelReservas);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ListarReservas";
            Text = "ListarReservas";
            ((System.ComponentModel.ISupportInitialize)PanelReservas).EndInit();
            ResumeLayout(false);
            PerformLayout();




        }

        #endregion

        private DataGridView PanelReservas;
        private Label Actividades;
        private Button BotonVolver;
        private Button BotonExportarXml;
        private Button BotonImportarXml;
    }
}