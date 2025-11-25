namespace Gentefit.Vistas.PantallasCliente
{
    partial class CalendarioClientes
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
            PanelCalendario = new DataGridView();
            BotonVolver = new Button();
            Titulo = new Label();
            ((System.ComponentModel.ISupportInitialize)PanelCalendario).BeginInit();
            SuspendLayout();
            // 
            // PanelCalendario
            // 
            PanelCalendario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelCalendario.Location = new Point(69, 117);
            PanelCalendario.Name = "PanelCalendario";
            PanelCalendario.RowHeadersWidth = 51;
            PanelCalendario.Size = new Size(662, 298);
            PanelCalendario.TabIndex = 38;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(660, 41);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(71, 34);
            BotonVolver.TabIndex = 44;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Titulo.ForeColor = Color.DarkSlateGray;
            Titulo.Location = new Point(69, 38);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(331, 37);
            Titulo.TabIndex = 46;
            Titulo.Text = "CALENDARIO DE CLASES";
            Titulo.UseMnemonic = false;
            Titulo.UseWaitCursor = true;
            // 
            // CalendarioClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Titulo);
            Controls.Add(BotonVolver);
            Controls.Add(PanelCalendario);
            Name = "CalendarioClientes";
            Text = "CalendarioClientes";
            Load += CalendarioClientes_Load;
            ((System.ComponentModel.ISupportInitialize)PanelCalendario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView PanelCalendario;
        private Button BotonVolver;
        private Label Titulo;
    }
}