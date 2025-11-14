namespace Gentefit.Vistas.PantallasAdmin.GestionClases
{
    partial class AnadirClase
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
            Fecha = new Label();
            label5 = new Label();
            label2 = new Label();
            Nombre = new Label();
            CajaComboActividades = new ComboBox();
            CajaComboEntrenador = new ComboBox();
            CajaComboSala = new ComboBox();
            Calendario = new MonthCalendar();
            CajaHora = new DateTimePicker();
            label1 = new Label();
            SuspendLayout();
            // 
            // AnadirClientes
            // 
            AnadirClientes.AutoSize = true;
            AnadirClientes.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            AnadirClientes.ForeColor = Color.DarkSlateGray;
            AnadirClientes.Location = new Point(55, 46);
            AnadirClientes.Name = "AnadirClientes";
            AnadirClientes.Size = new Size(262, 46);
            AnadirClientes.TabIndex = 37;
            AnadirClientes.Text = "AÑADIR CLASE";
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(689, 493);
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
            BotonAnadir.Location = new Point(603, 493);
            BotonAnadir.Margin = new Padding(3, 4, 3, 4);
            BotonAnadir.Name = "BotonAnadir";
            BotonAnadir.Size = new Size(80, 45);
            BotonAnadir.TabIndex = 35;
            BotonAnadir.Text = "Añadir";
            BotonAnadir.UseVisualStyleBackColor = false;
            BotonAnadir.Click += BotonAnadir_Click;
            // 
            // Fecha
            // 
            Fecha.AutoSize = true;
            Fecha.Location = new Point(492, 174);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(47, 20);
            Fecha.TabIndex = 32;
            Fecha.Text = "Fecha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(189, 296);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 26;
            label5.Text = "Sala";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 235);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 24;
            label2.Text = "Entrenador";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(189, 174);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(72, 20);
            Nombre.TabIndex = 22;
            Nombre.Text = "Actividad";
            // 
            // CajaComboActividades
            // 
            CajaComboActividades.FormattingEnabled = true;
            CajaComboActividades.Location = new Point(189, 197);
            CajaComboActividades.Name = "CajaComboActividades";
            CajaComboActividades.Size = new Size(259, 28);
            CajaComboActividades.TabIndex = 38;
            // 
            // CajaComboEntrenador
            // 
            CajaComboEntrenador.FormattingEnabled = true;
            CajaComboEntrenador.Location = new Point(189, 258);
            CajaComboEntrenador.Name = "CajaComboEntrenador";
            CajaComboEntrenador.Size = new Size(259, 28);
            CajaComboEntrenador.TabIndex = 39;
            // 
            // CajaComboSala
            // 
            CajaComboSala.FormattingEnabled = true;
            CajaComboSala.Location = new Point(189, 319);
            CajaComboSala.Name = "CajaComboSala";
            CajaComboSala.Size = new Size(259, 28);
            CajaComboSala.TabIndex = 40;
            // 
            // Calendario
            // 
            Calendario.Location = new Point(492, 197);
            Calendario.Name = "Calendario";
            Calendario.TabIndex = 41;
            // 
            // CajaHora
            // 
            CajaHora.Format = DateTimePickerFormat.Custom;
            CajaHora.CustomFormat = "HH:00";
            CajaHora.ShowUpDown = true;
            CajaHora.Location = new Point(189, 377);
            CajaHora.Name = "CajaHora";
            CajaHora.Size = new Size(259, 27);
            CajaHora.TabIndex = 42;
            // 
            // Hora
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 354);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 43;
            label1.Text = "Hora";
            // 
            // AnadirClase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 583);
            Controls.Add(label1);
            Controls.Add(CajaHora);
            Controls.Add(Calendario);
            Controls.Add(CajaComboSala);
            Controls.Add(CajaComboEntrenador);
            Controls.Add(CajaComboActividades);
            Controls.Add(AnadirClientes);
            Controls.Add(BotonVolver);
            Controls.Add(BotonAnadir);
            Controls.Add(Fecha);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(Nombre);
            Name = "AnadirClase";
            Text = "AnadirClase";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label AnadirClientes;
        private Button BotonVolver;
        private Button BotonAnadir;
        private Label Fecha;
        private Label label5;
        private Label label2;
        private Label Nombre;
        private ComboBox CajaComboActividades;
        private ComboBox CajaComboEntrenador;
        private ComboBox CajaComboSala;
        private MonthCalendar Calendario;
        private DateTimePicker CajaHora;
        private Label label1;
    }
}