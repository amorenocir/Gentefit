namespace Gentefit.Vistas.PantallasCliente
{
    partial class ReservarCliente
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
            BotonReservar = new Button();
            PanelClases = new DataGridView();
            BotonVolver = new Button();
            Titulo = new Label();
            Logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PanelClases).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // BotonReservar
            // 
            BotonReservar.BackColor = Color.DarkOrange;
            BotonReservar.ForeColor = Color.White;
            BotonReservar.Location = new Point(614, 60);
            BotonReservar.Name = "BotonReservar";
            BotonReservar.Size = new Size(115, 31);
            BotonReservar.TabIndex = 27;
            BotonReservar.Text = "Reservar";
            BotonReservar.UseVisualStyleBackColor = false;
            BotonReservar.Click += BotonReservar_Click;
            // 
            // PanelClases
            // 
            PanelClases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelClases.Location = new Point(56, 147);
            PanelClases.Name = "PanelClases";
            PanelClases.RowHeadersWidth = 51;
            PanelClases.Size = new Size(688, 285);
            PanelClases.TabIndex = 26;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(654, 107);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(75, 23);
            BotonVolver.TabIndex = 25;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Titulo.ForeColor = Color.DarkSlateGray;
            Titulo.Location = new Point(56, 93);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(161, 37);
            Titulo.TabIndex = 24;
            Titulo.Text = "TEMPORAL";
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.LogoAdmin;
            Logo.Location = new Point(310, 19);
            Logo.Name = "Logo";
            Logo.Size = new Size(155, 85);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 23;
            Logo.TabStop = false;
            // 
            // ReservarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonReservar);
            Controls.Add(PanelClases);
            Controls.Add(BotonVolver);
            Controls.Add(Titulo);
            Controls.Add(Logo);
            Name = "ReservarCliente";
            Text = "ReservarCliente";
            ((System.ComponentModel.ISupportInitialize)PanelClases).EndInit();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonReservar;
        private DataGridView PanelClases;
        private Button BotonVolver;
        private Label Titulo;
        private PictureBox Logo;
    }
}