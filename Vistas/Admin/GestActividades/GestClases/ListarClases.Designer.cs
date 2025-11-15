namespace Gentefit.Vistas.Admin.GestActividades.GestClases
{
    partial class ListarClases
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
            Titulo = new Label();
            PanelClases = new DataGridView();
            Tituloo = new Label();
            ((System.ComponentModel.ISupportInitialize)PanelClases).BeginInit();
            SuspendLayout();
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(669, 393);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(75, 23);
            BotonVolver.TabIndex = 25;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // Titulo
            // 
            Titulo.Location = new Point(0, 0);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(100, 23);
            Titulo.TabIndex = 26;
            // 
            // PanelClases
            // 
            PanelClases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelClases.Location = new Point(56, 92);
            PanelClases.Name = "PanelClases";
            PanelClases.Size = new Size(688, 285);
            PanelClases.TabIndex = 23;
            // 
            // Tituloo
            // 
            Tituloo.AutoSize = true;
            Tituloo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Tituloo.ForeColor = Color.DarkSlateGray;
            Tituloo.Location = new Point(56, 23);
            Tituloo.Name = "Tituloo";
            Tituloo.Size = new Size(262, 37);
            Tituloo.TabIndex = 27;
            Tituloo.Text = "TÍTULO TEMPORAL";
            // 
            // ListarClases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Tituloo);
            Controls.Add(BotonVolver);
            Controls.Add(Titulo);
            Controls.Add(PanelClases);
            Name = "ListarClases";
            Text = "ListarClases";
            Load += ListarClases_Load;
            ((System.ComponentModel.ISupportInitialize)PanelClases).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonVolver;
        private Label Titulo;
        private DataGridView PanelClases;
        private Label Tituloo;
    }
}