namespace Gentefit.Vistas.Admin.GestActividades
{
    partial class AnadirActividad
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
            AnadirClientes = new Label();
            BotonAnadir = new Button();
            label9 = new Label();
            CajaTextoDescripcion = new TextBox();
            label5 = new Label();
            CajaTextoDuracion = new TextBox();
            label2 = new Label();
            CajaTextoNombre = new TextBox();
            Nombre = new Label();
            BotonVolver = new Button();
            DespleIntesidad = new ComboBox();
            SuspendLayout();
            // 
            // AnadirClientes
            // 
            AnadirClientes.AutoSize = true;
            AnadirClientes.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            AnadirClientes.ForeColor = Color.DarkSlateGray;
            AnadirClientes.Location = new Point(108, 36);
            AnadirClientes.Name = "AnadirClientes";
            AnadirClientes.Size = new Size(277, 37);
            AnadirClientes.TabIndex = 35;
            AnadirClientes.Text = "AÑADIR ACTIVIDAD";
            // 
            // BotonAnadir
            // 
            BotonAnadir.BackColor = Color.DarkOrange;
            BotonAnadir.Location = new Point(363, 371);
            BotonAnadir.Name = "BotonAnadir";
            BotonAnadir.Size = new Size(70, 34);
            BotonAnadir.TabIndex = 5;
            BotonAnadir.Text = "Añadir";
            BotonAnadir.UseVisualStyleBackColor = false;
            BotonAnadir.Click += BotonAnadir_Click;
            // 
            // label9
            // 
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 38;
            // 
            // CajaTextoDescripcion
            // 
            CajaTextoDescripcion.Location = new Point(108, 286);
            CajaTextoDescripcion.Multiline = true;
            CajaTextoDescripcion.Name = "CajaTextoDescripcion";
            CajaTextoDescripcion.Size = new Size(227, 64);
            CajaTextoDescripcion.TabIndex = 4;
            CajaTextoDescripcion.TextChanged += CajaTextoDescripcion_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(108, 268);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 31;
            label5.Text = "Descripción";
            // 
            // CajaTextoDuracion
            // 
            CajaTextoDuracion.Location = new Point(108, 163);
            CajaTextoDuracion.Name = "CajaTextoDuracion";
            CajaTextoDuracion.Size = new Size(227, 23);
            CajaTextoDuracion.TabIndex = 2;
            CajaTextoDuracion.TextChanged += CajaTextoDuracion_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 145);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 25;
            label2.Text = "Duración";
            // 
            // CajaTextoNombre
            // 
            CajaTextoNombre.Location = new Point(108, 106);
            CajaTextoNombre.Name = "CajaTextoNombre";
            CajaTextoNombre.Size = new Size(227, 23);
            CajaTextoNombre.TabIndex = 1;
            CajaTextoNombre.TextChanged += CajaTextoNombre_TextChanged;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(108, 88);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 22;
            Nombre.Text = "Nombre";
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(591, 365);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(71, 34);
            BotonVolver.TabIndex = 6;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // DespleIntesidad
            // 
            DespleIntesidad.DropDownStyle = ComboBoxStyle.DropDownList;
            DespleIntesidad.FormattingEnabled = true;
            DespleIntesidad.Location = new Point(108, 224);
            DespleIntesidad.Name = "DespleIntesidad";
            DespleIntesidad.Size = new Size(227, 23);
            DespleIntesidad.TabIndex = 3;
            DespleIntesidad.SelectedIndexChanged += DespleIntesidad_SelectedIndexChanged;
            // 
            // AnadirActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DespleIntesidad);
            Controls.Add(BotonVolver);
            Controls.Add(AnadirClientes);
            Controls.Add(BotonAnadir);
            Controls.Add(label9);
            Controls.Add(CajaTextoDescripcion);
            Controls.Add(label5);
            Controls.Add(CajaTextoDuracion);
            Controls.Add(label2);
            Controls.Add(CajaTextoNombre);
            Controls.Add(Nombre);
            Name = "AnadirActividad";
            Text = "AnadirActividad";
            Load += FormAnadirCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AnadirClientes;
        private Button BotonAnadir;
        private Label label9;
        private TextBox CajaTextoDescripcion;
        private Label label5;
        private TextBox CajaTextoDuracion;
        private Label label2;
        private TextBox CajaTextoNombre;
        private Label Nombre;
        private Button BotonVolver;
        private ComboBox DespleIntesidad;
    }
}