namespace Gentefit.Vistas.Admin.GestActividades
{
    partial class ModificarActividad
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
            PanelActividades = new DataGridView();
            CajaTextoNombre = new TextBox();
            label3 = new Label();
            CajaTextoDescripcion = new TextBox();
            label5 = new Label();
            label2 = new Label();
            CajaTextoDuracion = new TextBox();
            Nombre = new Label();
            BotonVolver = new Button();
            BotonGuardar = new Button();
            DespleIntensidad = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)PanelActividades).BeginInit();
            SuspendLayout();
            // 
            // PanelActividades
            // 
            PanelActividades.Location = new Point(69, 54);
            PanelActividades.Name = "PanelActividades";
            PanelActividades.Size = new Size(363, 336);
            PanelActividades.TabIndex = 50;
            PanelActividades.CellContentClick += PanelActividades_CellContentClick;
            // 
            // CajaTextoNombre
            // 
            CajaTextoNombre.Location = new Point(502, 72);
            CajaTextoNombre.Name = "CajaTextoNombre";
            CajaTextoNombre.Size = new Size(184, 23);
            CajaTextoNombre.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(502, 54);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 45;
            label3.Text = "Nombre";
            // 
            // CajaTextoDescripcion
            // 
            CajaTextoDescripcion.Location = new Point(502, 243);
            CajaTextoDescripcion.Multiline = true;
            CajaTextoDescripcion.Name = "CajaTextoDescripcion";
            CajaTextoDescripcion.Size = new Size(184, 90);
            CajaTextoDescripcion.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(502, 225);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 43;
            label5.Text = "Descripción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(502, 160);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 41;
            label2.Text = "Intensidad";
            // 
            // CajaTextoDuracion
            // 
            CajaTextoDuracion.Location = new Point(502, 121);
            CajaTextoDuracion.Name = "CajaTextoDuracion";
            CajaTextoDuracion.Size = new Size(184, 23);
            CajaTextoDuracion.TabIndex = 40;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(502, 103);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(55, 15);
            Nombre.TabIndex = 39;
            Nombre.Text = "Duración";
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(615, 356);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(71, 34);
            BotonVolver.TabIndex = 48;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // BotonGuardar
            // 
            BotonGuardar.BackColor = Color.DarkOrange;
            BotonGuardar.Location = new Point(524, 356);
            BotonGuardar.Name = "BotonGuardar";
            BotonGuardar.Size = new Size(70, 34);
            BotonGuardar.TabIndex = 47;
            BotonGuardar.Text = "Guardar";
            BotonGuardar.UseVisualStyleBackColor = false;
            BotonGuardar.Click += BotonGuardar_Click;
            // 
            // DespleIntensidad
            // 
            DespleIntensidad.FormattingEnabled = true;
            DespleIntensidad.Location = new Point(502, 178);
            DespleIntensidad.Name = "DespleIntensidad";
            DespleIntensidad.Size = new Size(184, 23);
            DespleIntensidad.TabIndex = 49;
            // 
            // ModificarActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DespleIntensidad);
            Controls.Add(BotonVolver);
            Controls.Add(BotonGuardar);
            Controls.Add(CajaTextoNombre);
            Controls.Add(label3);
            Controls.Add(CajaTextoDescripcion);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(CajaTextoDuracion);
            Controls.Add(Nombre);
            Controls.Add(PanelActividades);
            Name = "ModificarActividad";
            Text = "ModificarActividad";
            Load += ModificarActividad_Load;
            ((System.ComponentModel.ISupportInitialize)PanelActividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView PanelActividades;
        private TextBox CajaTextoNombre;
        private Label label3;
        private TextBox CajaTextoDescripcion;
        private Label label5;
        private Label label2;
        private TextBox CajaTextoDuracion;
        private Label Nombre;
        private Button BotonVolver;
        private Button BotonGuardar;
        private ComboBox DespleIntensidad;
    }
}