namespace Gentefit.Vistas.PantallasAdmin
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
            DespleDia.Location = new Point(340, 323);
            DespleDia.Margin = new Padding(3, 4, 3, 4);
            DespleDia.Name = "DespleDia";
            DespleDia.Size = new Size(259, 28);
            DespleDia.TabIndex = 38;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(756, 493);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(81, 45);
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
            AnadirClientes.Location = new Point(58, 55);
            AnadirClientes.Name = "AnadirClientes";
            AnadirClientes.Size = new Size(409, 46);
            AnadirClientes.TabIndex = 45;
            AnadirClientes.Text = "SELECCIONAR HORARIO";
            // 
            // BotonSiguiente
            // 
            BotonSiguiente.BackColor = Color.DarkOrange;
            BotonSiguiente.Location = new Point(653, 493);
            BotonSiguiente.Margin = new Padding(3, 4, 3, 4);
            BotonSiguiente.Name = "BotonSiguiente";
            BotonSiguiente.Size = new Size(80, 45);
            BotonSiguiente.TabIndex = 40;
            BotonSiguiente.Text = "Siguiente";
            BotonSiguiente.UseVisualStyleBackColor = false;
            BotonSiguiente.Click += BotonSiguiente_Click;
            // 
            // CajaTextoHora
            // 
            CajaTextoHora.Location = new Point(340, 230);
            CajaTextoHora.Margin = new Padding(3, 4, 3, 4);
            CajaTextoHora.Name = "CajaTextoHora";
            CajaTextoHora.Size = new Size(259, 27);
            CajaTextoHora.TabIndex = 36;
            // 
            // EtiquetaDia
            // 
            EtiquetaDia.AutoSize = true;
            EtiquetaDia.Location = new Point(340, 299);
            EtiquetaDia.Name = "EtiquetaDia";
            EtiquetaDia.Size = new Size(32, 20);
            EtiquetaDia.TabIndex = 46;
            EtiquetaDia.Text = "Día";
            // 
            // EtiquetaHora
            // 
            EtiquetaHora.AutoSize = true;
            EtiquetaHora.Location = new Point(340, 187);
            EtiquetaHora.Name = "EtiquetaHora";
            EtiquetaHora.Size = new Size(101, 20);
            EtiquetaHora.TabIndex = 47;
            EtiquetaHora.Text = "Hora (hh:mm)";
            // 
            // AnadirClase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(EtiquetaHora);
            Controls.Add(EtiquetaDia);
            Controls.Add(DespleDia);
            Controls.Add(BotonVolver);
            Controls.Add(AnadirClientes);
            Controls.Add(BotonSiguiente);
            Controls.Add(CajaTextoHora);
            Margin = new Padding(3, 4, 3, 4);
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