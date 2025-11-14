namespace Gentefit.Vistas.PantallasAdmin.GestionActividades
{
    partial class AnadirActividad
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
 
        private void InitializeComponent()
        {
            AnadirClientes = new Label();
            BotonVolver = new Button();
            BotonAnadir = new Button();
            CajaTextoDescripcion = new TextBox();
            label9 = new Label();
            label5 = new Label();
            CajaTextoDuracion = new TextBox();
            label2 = new Label();
            CajaTextoNombre = new TextBox();
            Nombre = new Label();
            CajaComboIntensidad = new ComboBox();
            SuspendLayout();
            // 
            // AnadirClientes
            // 
            AnadirClientes.AutoSize = true;
            AnadirClientes.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            AnadirClientes.ForeColor = Color.DarkSlateGray;
            AnadirClientes.Location = new Point(42, 37);
            AnadirClientes.Name = "AnadirClientes";
            AnadirClientes.Size = new Size(344, 46);
            AnadirClientes.TabIndex = 37;
            AnadirClientes.Text = "AÑADIR ACTIVIDAD";
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(664, 470);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(81, 45);
            BotonVolver.TabIndex = 36;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // BotonAnadir
            // 
            BotonAnadir.BackColor = Color.DarkOrange;
            BotonAnadir.Location = new Point(578, 470);
            BotonAnadir.Margin = new Padding(3, 4, 3, 4);
            BotonAnadir.Name = "BotonAnadir";
            BotonAnadir.Size = new Size(80, 45);
            BotonAnadir.TabIndex = 35;
            BotonAnadir.Text = "Añadir";
            BotonAnadir.UseVisualStyleBackColor = false;
            BotonAnadir.Click += BotonAnadir_Click;
            // 
            // CajaTextoDescripcion
            // 
            CajaTextoDescripcion.Location = new Point(486, 176);
            CajaTextoDescripcion.Margin = new Padding(3, 4, 3, 4);
            CajaTextoDescripcion.Multiline = true;
            CajaTextoDescripcion.Name = "CajaTextoDescripcion";
            CajaTextoDescripcion.Size = new Size(259, 181);
            CajaTextoDescripcion.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(486, 152);
            label9.Name = "label9";
            label9.Size = new Size(87, 20);
            label9.TabIndex = 32;
            label9.Text = "Descripción";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(137, 306);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 26;
            label5.Text = "Intensidad";
            // 
            // CajaTextoDuracion
            // 
            CajaTextoDuracion.Location = new Point(137, 252);
            CajaTextoDuracion.Margin = new Padding(3, 4, 3, 4);
            CajaTextoDuracion.Name = "CajaTextoDuracion";
            CajaTextoDuracion.Size = new Size(259, 27);
            CajaTextoDuracion.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 228);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 24;
            label2.Text = "Duración";
            // 
            // CajaTextoNombre
            // 
            CajaTextoNombre.Location = new Point(137, 176);
            CajaTextoNombre.Margin = new Padding(3, 4, 3, 4);
            CajaTextoNombre.Name = "CajaTextoNombre";
            CajaTextoNombre.Size = new Size(259, 27);
            CajaTextoNombre.TabIndex = 23;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(137, 152);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(64, 20);
            Nombre.TabIndex = 22;
            Nombre.Text = "Nombre";
            // 
            // CajaComboIntensidad
            // 
            CajaComboIntensidad.FormattingEnabled = true;
            CajaComboIntensidad.Items.AddRange(new object[] { "Alta", "Media", "Baja" });
            CajaComboIntensidad.Location = new Point(137, 329);
            CajaComboIntensidad.Name = "CajaComboIntensidad";
            CajaComboIntensidad.Size = new Size(259, 28);
            CajaComboIntensidad.TabIndex = 38;
            // 
            // AnadirActividad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 548);
            Controls.Add(CajaComboIntensidad);
            Controls.Add(AnadirClientes);
            Controls.Add(BotonVolver);
            Controls.Add(BotonAnadir);
            Controls.Add(CajaTextoDescripcion);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(CajaTextoDuracion);
            Controls.Add(label2);
            Controls.Add(CajaTextoNombre);
            Controls.Add(Nombre);
            Name = "AnadirActividad";
            Text = "AnadirActividad";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label AnadirClientes;
        private Button BotonVolver;
        private Button BotonAnadir;
        private TextBox CajaTextoDescripcion;
        private Label label9;
        private Label label5;
        private TextBox CajaTextoDuracion;
        private Label label2;
        private TextBox CajaTextoNombre;
        private Label Nombre;
        private ComboBox CajaComboIntensidad;
    }
}