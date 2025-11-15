namespace Gentefit.Vistas.Admin.GestActividades.GestClases
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
            ID.Location = new Point(89, 329);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 65;
            ID.Text = "ID";
            // 
            // CajaTextoID
            // 
            CajaTextoID.Location = new Point(89, 347);
            CajaTextoID.Name = "CajaTextoID";
            CajaTextoID.ReadOnly = true;
            CajaTextoID.Size = new Size(184, 23);
            CajaTextoID.TabIndex = 64;
            // 
            // DespleDia
            // 
            DespleDia.FormattingEnabled = true;
            DespleDia.Location = new Point(330, 347);
            DespleDia.Name = "DespleDia";
            DespleDia.Size = new Size(184, 23);
            DespleDia.TabIndex = 62;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(701, 371);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(71, 34);
            BotonVolver.TabIndex = 61;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // BotonSiguiente
            // 
            BotonSiguiente.BackColor = Color.DarkOrange;
            BotonSiguiente.Location = new Point(603, 371);
            BotonSiguiente.Name = "BotonSiguiente";
            BotonSiguiente.Size = new Size(77, 34);
            BotonSiguiente.TabIndex = 60;
            BotonSiguiente.Text = "Siguiente";
            BotonSiguiente.UseVisualStyleBackColor = false;
            BotonSiguiente.Click += BotonSiguiente_Click;
            // 
            // CajaTextoHora
            // 
            CajaTextoHora.Location = new Point(89, 402);
            CajaTextoHora.Name = "CajaTextoHora";
            CajaTextoHora.Size = new Size(184, 23);
            CajaTextoHora.TabIndex = 59;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 384);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 58;
            label3.Text = "Hora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 329);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 55;
            label2.Text = "Día";
            // 
            // PanelClases
            // 
            PanelClases.Location = new Point(89, 94);
            PanelClases.Name = "PanelClases";
            PanelClases.Size = new Size(632, 213);
            PanelClases.TabIndex = 63;
            PanelClases.CellClick += PanelClases_CellClick;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Titulo.ForeColor = Color.DarkSlateGray;
            Titulo.Location = new Point(89, 34);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(161, 37);
            Titulo.TabIndex = 66;
            Titulo.Text = "TEMPORAL";
            // 
            // ModificarClases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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