namespace Gentefit.Vistas.PantallasCliente
{
    partial class ListarReservasCliente
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
            BotonEliminar = new Button();
            PanelReservas = new DataGridView();
            BotonVolver = new Button();
            Titulo = new Label();
            Logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PanelReservas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // BotonEliminar
            // 
            BotonEliminar.BackColor = Color.DarkOrange;
            BotonEliminar.ForeColor = Color.White;
            BotonEliminar.Location = new Point(614, 60);
            BotonEliminar.Name = "BotonEliminar";
            BotonEliminar.Size = new Size(115, 31);
            BotonEliminar.TabIndex = 32;
            BotonEliminar.Text = "Eliminar";
            BotonEliminar.UseVisualStyleBackColor = false;
            BotonEliminar.Click += BotonEliminar_Click;
            // 
            // PanelReservas
            // 
            PanelReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelReservas.Location = new Point(56, 147);
            PanelReservas.Name = "PanelReservas";
            PanelReservas.RowHeadersWidth = 51;
            PanelReservas.Size = new Size(688, 285);
            PanelReservas.TabIndex = 31;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(654, 107);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(75, 23);
            BotonVolver.TabIndex = 30;
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
            Titulo.TabIndex = 29;
            Titulo.Text = "TEMPORAL";
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.LogoAdmin;
            Logo.Location = new Point(310, 19);
            Logo.Name = "Logo";
            Logo.Size = new Size(155, 85);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 28;
            Logo.TabStop = false;
            // 
            // ListarReservasCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonEliminar);
            Controls.Add(PanelReservas);
            Controls.Add(BotonVolver);
            Controls.Add(Titulo);
            Controls.Add(Logo);
            Name = "ListarReservasCliente";
            Text = "ListarReservasCliente";
            ((System.ComponentModel.ISupportInitialize)PanelReservas).EndInit();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonEliminar;
        private DataGridView PanelReservas;
        private Button BotonVolver;
        private Label Titulo;
        private PictureBox Logo;
    }
}