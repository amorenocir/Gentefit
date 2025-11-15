namespace Gentefit.Vistas.Admin.GestActividades.GestClases
{
    partial class AnadirClase
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
            DespleDia = new ComboBox();
            BotonVolver = new Button();
            AnadirClientes = new Label();
            BotonSiguiente = new Button();
            CajaTextoHora = new TextBox();
            EtiquetaDia = new Label();
            EtiquetaHora = new Label();
            SuspendLayout();
            // 
            // DespleDia
            // 
            DespleDia.DropDownStyle = ComboBoxStyle.DropDownList;
            DespleDia.FormattingEnabled = true;
            DespleDia.Location = new Point(123, 229);
            DespleDia.Name = "DespleDia";
            DespleDia.Size = new Size(227, 23);
            DespleDia.TabIndex = 38;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(606, 370);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(71, 34);
            BotonVolver.TabIndex = 41;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // AnadirClientes
            // 
            AnadirClientes.AutoSize = true;
            AnadirClientes.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            AnadirClientes.ForeColor = Color.DarkSlateGray;
            AnadirClientes.Location = new Point(123, 41);
            AnadirClientes.Name = "AnadirClientes";
            AnadirClientes.Size = new Size(210, 37);
            AnadirClientes.TabIndex = 45;
            AnadirClientes.Text = "AÑADIR CLASE";
            // 
            // BotonSiguiente
            // 
            BotonSiguiente.BackColor = Color.DarkOrange;
            BotonSiguiente.Location = new Point(378, 376);
            BotonSiguiente.Name = "BotonSiguiente";
            BotonSiguiente.Size = new Size(70, 34);
            BotonSiguiente.TabIndex = 40;
            BotonSiguiente.Text = "Siguiente";
            BotonSiguiente.UseVisualStyleBackColor = false;
            BotonSiguiente.Click += BotonSiguiente_Click;
            // 
            // CajaTextoHora
            // 
            CajaTextoHora.Location = new Point(123, 159);
            CajaTextoHora.Name = "CajaTextoHora";
            CajaTextoHora.Size = new Size(227, 23);
            CajaTextoHora.TabIndex = 36;
            // 
            // EtiquetaDia
            // 
            EtiquetaDia.AutoSize = true;
            EtiquetaDia.Location = new Point(123, 211);
            EtiquetaDia.Name = "EtiquetaDia";
            EtiquetaDia.Size = new Size(24, 15);
            EtiquetaDia.TabIndex = 46;
            EtiquetaDia.Text = "Día";
            // 
            // EtiquetaHora
            // 
            EtiquetaHora.AutoSize = true;
            EtiquetaHora.Location = new Point(123, 127);
            EtiquetaHora.Name = "EtiquetaHora";
            EtiquetaHora.Size = new Size(83, 15);
            EtiquetaHora.TabIndex = 47;
            EtiquetaHora.Text = "Hora (hh:mm)";
            // 
            // AnadirClase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EtiquetaHora);
            Controls.Add(EtiquetaDia);
            Controls.Add(DespleDia);
            Controls.Add(BotonVolver);
            Controls.Add(AnadirClientes);
            Controls.Add(BotonSiguiente);
            Controls.Add(CajaTextoHora);
            Name = "AnadirClase";
            Text = "AnadirClase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox DespleDia;
        private Button BotonVolver;
        private Label AnadirClientes;
        private Button BotonSiguiente;
        private TextBox CajaTextoDescripcion;
        private Label label5;
        private TextBox CajaTextoDuracion;
        private Label label2;
        private TextBox CajaTextoHora;
        private Label Nombre;
        private Label EtiquetaDia;
        private Label EtiquetaHora;
    }
}