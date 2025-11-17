namespace Gentefit.Vistas.PantallasAdmin
{
    partial class ModificarClases
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
            ID = new Label();
            CajaTextoID = new TextBox();
            DespleDia = new ComboBox();
            BotonVolver = new Button();
            BotonSiguiente = new Button();
            CajaTextoHora = new TextBox();
            label3 = new Label();
            label2 = new Label();
            PanelClases = new DataGridView();
            Titulo = new Label();
            ((System.ComponentModel.ISupportInitialize)PanelClases).BeginInit();
            SuspendLayout();
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(102, 439);
            ID.Name = "ID";
            ID.Size = new Size(24, 20);
            ID.TabIndex = 65;
            ID.Text = "ID";
            // 
            // CajaTextoID
            // 
            CajaTextoID.Location = new Point(102, 463);
            CajaTextoID.Margin = new Padding(3, 4, 3, 4);
            CajaTextoID.Name = "CajaTextoID";
            CajaTextoID.ReadOnly = true;
            CajaTextoID.Size = new Size(210, 27);
            CajaTextoID.TabIndex = 64;
            // 
            // DespleDia
            // 
            DespleDia.FormattingEnabled = true;
            DespleDia.Location = new Point(377, 463);
            DespleDia.Margin = new Padding(3, 4, 3, 4);
            DespleDia.Name = "DespleDia";
            DespleDia.Size = new Size(210, 28);
            DespleDia.TabIndex = 62;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(801, 495);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(81, 45);
            BotonVolver.TabIndex = 61;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // BotonSiguiente
            // 
            BotonSiguiente.BackColor = Color.DarkOrange;
            BotonSiguiente.Location = new Point(689, 495);
            BotonSiguiente.Margin = new Padding(3, 4, 3, 4);
            BotonSiguiente.Name = "BotonSiguiente";
            BotonSiguiente.Size = new Size(88, 45);
            BotonSiguiente.TabIndex = 60;
            BotonSiguiente.Text = "Siguiente";
            BotonSiguiente.UseVisualStyleBackColor = false;
            BotonSiguiente.Click += BotonSiguiente_Click;
            // 
            // CajaTextoHora
            // 
            CajaTextoHora.Location = new Point(102, 536);
            CajaTextoHora.Margin = new Padding(3, 4, 3, 4);
            CajaTextoHora.Name = "CajaTextoHora";
            CajaTextoHora.Size = new Size(210, 27);
            CajaTextoHora.TabIndex = 59;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 512);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 58;
            label3.Text = "Hora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 439);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 55;
            label2.Text = "Día";
            // 
            // PanelClases
            // 
            PanelClases.ColumnHeadersHeight = 29;
            PanelClases.Location = new Point(102, 125);
            PanelClases.Margin = new Padding(3, 4, 3, 4);
            PanelClases.Name = "PanelClases";
            PanelClases.RowHeadersWidth = 51;
            PanelClases.Size = new Size(722, 284);
            PanelClases.TabIndex = 63;
            PanelClases.CellClick += PanelClases_CellClick;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Titulo.ForeColor = Color.DarkSlateGray;
            Titulo.Location = new Point(102, 45);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(320, 46);
            Titulo.TabIndex = 66;
            Titulo.Text = "MODIFICAR CLASE";
            // 
            // ModificarClases
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(Titulo);
            Controls.Add(ID);
            Controls.Add(CajaTextoID);
            Controls.Add(DespleDia);
            Controls.Add(BotonVolver);
            Controls.Add(BotonSiguiente);
            Controls.Add(CajaTextoHora);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PanelClases);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ModificarClases";
            Text = "ModificarClases";
            Load += ModificarClases_Load;
            ((System.ComponentModel.ISupportInitialize)PanelClases).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ID;
        private TextBox CajaTextoID;
        private ComboBox DespleDia;
        private Button BotonVolver;
        private Button BotonSiguiente;
        private TextBox CajaTextoHora;
        private Label label3;
        private Label label2;
        private DataGridView PanelClases;
        private Label Titulo;
    }
}