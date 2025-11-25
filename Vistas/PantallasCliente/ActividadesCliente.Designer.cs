namespace Gentefit.Vistas.PantallasCliente
{
    partial class ActividadesCliente
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
            Actividades = new Label();
            Logo = new PictureBox();
            PanelActividades = new DataGridView();
            BotonReservar = new Button();
            BotonVer = new Button();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PanelActividades).BeginInit();
            SuspendLayout();
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(654, 100);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(75, 23);
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
            Actividades.Location = new Point(293, 100);
            Actividades.Name = "Actividades";
            Actividades.Size = new Size(193, 37);
            Actividades.TabIndex = 18;
            Actividades.Text = "ACTIVIDADES";
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.Texto;
            Logo.Location = new Point(310, 12);
            Logo.Name = "Logo";
            Logo.Size = new Size(155, 85);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 17;
            Logo.TabStop = false;
            // 
            // PanelActividades
            // 
            PanelActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelActividades.Location = new Point(56, 140);
            PanelActividades.Name = "PanelActividades";
            PanelActividades.RowHeadersWidth = 51;
            PanelActividades.Size = new Size(688, 285);
            PanelActividades.TabIndex = 20;
            // 
            // BotonReservar
            // 
            BotonReservar.BackColor = Color.DarkOrange;
            BotonReservar.ForeColor = Color.White;
            BotonReservar.Location = new Point(614, 53);
            BotonReservar.Name = "BotonReservar";
            BotonReservar.Size = new Size(115, 31);
            BotonReservar.TabIndex = 21;
            BotonReservar.Text = "Reservar clase";
            BotonReservar.UseVisualStyleBackColor = false;
            BotonReservar.Click += BotonReservar_Click;
            // 
            // BotonVer
            // 
            BotonVer.BackColor = Color.DarkOrange;
            BotonVer.ForeColor = Color.White;
            BotonVer.Location = new Point(614, 12);
            BotonVer.Name = "BotonVer";
            BotonVer.Size = new Size(115, 31);
            BotonVer.TabIndex = 22;
            BotonVer.Text = "Ver actividad";
            BotonVer.TextImageRelation = TextImageRelation.ImageBeforeText;
            BotonVer.UseVisualStyleBackColor = false;
            BotonVer.Click += BotonVer_Click;
            // 
            // ActividadesCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonVer);
            Controls.Add(BotonReservar);
            Controls.Add(PanelActividades);
            Controls.Add(BotonVolver);
            Controls.Add(Actividades);
            Controls.Add(Logo);
            Name = "ActividadesCliente";
            Text = "ActividadesCliente";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)PanelActividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BotonVolver;
        private Label Actividades;
        private PictureBox Logo;
        private DataGridView PanelActividades;
        private Button BotonReservar;
        private Button BotonVer;
    }
}