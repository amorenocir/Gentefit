namespace Gentefit.Vistas.Admin.GestActividades
{
    partial class ListarActividades
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
            PanelActividades = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PanelActividades).BeginInit();
            SuspendLayout();
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(669, 392);
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
            Actividades.Location = new Point(234, 35);
            Actividades.Name = "Actividades";
            Actividades.Size = new Size(382, 37);
            Actividades.TabIndex = 18;
            Actividades.Text = "ACTIVIDADES REGISTRADAS";
            Actividades.Click += Actividades_Click;
            // 
            // PanelActividades
            // 
            PanelActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelActividades.Location = new Point(56, 91);
            PanelActividades.Name = "PanelActividades";
            PanelActividades.Size = new Size(688, 285);
            PanelActividades.TabIndex = 17;
            PanelActividades.CellContentClick += PanelActividades_CellContentClick;
            // 
            // ListarActividades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonVolver);
            Controls.Add(Actividades);
            Controls.Add(PanelActividades);
            Name = "ListarActividades";
            Text = "ListarActividades";
            ((System.ComponentModel.ISupportInitialize)PanelActividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonVolver;
        private Label Actividades;
        private DataGridView PanelActividades;
    }
}