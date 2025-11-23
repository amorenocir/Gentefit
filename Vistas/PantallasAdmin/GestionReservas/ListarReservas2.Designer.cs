namespace Gentefit.Vistas.PantallasAdmin.GestionReservas
{
    partial class ListarReservas2
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
            Titulo = new Label();
            PanelReservas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PanelReservas).BeginInit();
            SuspendLayout();
            // 
            // BotonImportarXml
            // 
            BotonImportarXml.BackColor = Color.DarkOrange;
            BotonImportarXml.Location = new Point(438, 394);
            BotonImportarXml.Name = "BotonImportarXml";
            BotonImportarXml.Size = new Size(97, 23);
            BotonImportarXml.TabIndex = 29;
            BotonImportarXml.Text = "Importar XML";
            BotonImportarXml.UseVisualStyleBackColor = false;
            BotonImportarXml.Click += BotonImportarXml_Click;
            // 
            // BotonExportarXml
            // 
            BotonExportarXml.BackColor = Color.DarkOrange;
            BotonExportarXml.Location = new Point(553, 394);
            BotonExportarXml.Name = "BotonExportarXml";
            BotonExportarXml.Size = new Size(97, 23);
            BotonExportarXml.TabIndex = 28;
            BotonExportarXml.Text = "Exportar XML";
            BotonExportarXml.UseVisualStyleBackColor = false;
            BotonExportarXml.Click += BotonExportarXml_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(669, 394);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(75, 23);
            BotonVolver.TabIndex = 27;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Titulo.ForeColor = Color.DarkSlateGray;
            Titulo.Location = new Point(56, 34);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(161, 37);
            Titulo.TabIndex = 26;
            Titulo.Text = "TEMPORAL";
            // 
            // PanelReservas
            // 
            PanelReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelReservas.Location = new Point(56, 93);
            PanelReservas.Name = "PanelReservas";
            PanelReservas.RowHeadersWidth = 51;
            PanelReservas.Size = new Size(688, 285);
            PanelReservas.TabIndex = 25;
            // 
            // ListarReservas2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonImportarXml);
            Controls.Add(BotonExportarXml);
            Controls.Add(BotonVolver);
            Controls.Add(Titulo);
            Controls.Add(PanelReservas);
            Name = "ListarReservas2";
            Text = "ListarReservas2";
            ((System.ComponentModel.ISupportInitialize)PanelReservas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonImportarXml;
        private Button BotonExportarXml;
        private Button BotonVolver;
        private Label Titulo;
        private DataGridView PanelReservas;
    }
}