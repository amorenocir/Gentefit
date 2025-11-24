namespace Gentefit.Vistas.PantallasCliente
{
    partial class VerActividadCliente
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
            Titulo = new Label();
            Logo = new PictureBox();
            PanelHorarios = new DataGridView();
            CajaDescripcion = new TextBox();
            SubtituloDes = new Label();
            SubtituloHor = new Label();
            BotonVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PanelHorarios).BeginInit();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Titulo.ForeColor = Color.DarkSlateGray;
            Titulo.Location = new Point(49, 100);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(161, 37);
            Titulo.TabIndex = 22;
            Titulo.Text = "TEMPORAL";
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.LogoAdmin;
            Logo.Location = new Point(310, 19);
            Logo.Name = "Logo";
            Logo.Size = new Size(155, 85);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 21;
            Logo.TabStop = false;
            // 
            // PanelHorarios
            // 
            PanelHorarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelHorarios.Location = new Point(283, 208);
            PanelHorarios.Name = "PanelHorarios";
            PanelHorarios.RowHeadersWidth = 51;
            PanelHorarios.Size = new Size(461, 211);
            PanelHorarios.TabIndex = 23;
            // 
            // CajaDescripcion
            // 
            CajaDescripcion.Location = new Point(49, 208);
            CajaDescripcion.Multiline = true;
            CajaDescripcion.Name = "CajaDescripcion";
            CajaDescripcion.Size = new Size(184, 211);
            CajaDescripcion.TabIndex = 24;
            // 
            // SubtituloDes
            // 
            SubtituloDes.AutoSize = true;
            SubtituloDes.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            SubtituloDes.ForeColor = Color.DarkSlateGray;
            SubtituloDes.Location = new Point(49, 153);
            SubtituloDes.Name = "SubtituloDes";
            SubtituloDes.Size = new Size(167, 37);
            SubtituloDes.TabIndex = 25;
            SubtituloDes.Text = "Descripción";
            // 
            // SubtituloHor
            // 
            SubtituloHor.AutoSize = true;
            SubtituloHor.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            SubtituloHor.ForeColor = Color.DarkSlateGray;
            SubtituloHor.Location = new Point(283, 153);
            SubtituloHor.Name = "SubtituloHor";
            SubtituloHor.Size = new Size(238, 37);
            SubtituloHor.TabIndex = 26;
            SubtituloHor.Text = "Horarios de clase";
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(650, 100);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(75, 23);
            BotonVolver.TabIndex = 27;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // VerActividadCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonVolver);
            Controls.Add(SubtituloHor);
            Controls.Add(SubtituloDes);
            Controls.Add(CajaDescripcion);
            Controls.Add(PanelHorarios);
            Controls.Add(Titulo);
            Controls.Add(Logo);
            Name = "VerActividadCliente";
            Text = "VerActividadCliente";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)PanelHorarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private PictureBox Logo;
        private DataGridView PanelHorarios;
        private TextBox CajaDescripcion;
        private Label SubtituloDes;
        private Label SubtituloHor;
        private Button BotonVolver;
    }
}