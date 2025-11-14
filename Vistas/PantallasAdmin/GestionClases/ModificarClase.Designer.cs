using System.ComponentModel;

namespace Gentefit.Vistas.PantallasAdmin.GestionClases
{
    partial class ModificarClase
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
            label1 = new Label();
            CajaHora = new DateTimePicker();
            Calendario = new MonthCalendar();
            CajaComboSala = new ComboBox();
            CajaComboEntrenador = new ComboBox();
            CajaComboActividades = new ComboBox();
            AnadirClientes = new Label();
            BotonVolver = new Button();
            BotonGuardar = new Button();
            Fecha = new Label();
            label5 = new Label();
            label2 = new Label();
            Nombre = new Label();
            PanelClases = new DataGridView();
            ((ISupportInitialize)PanelClases).BeginInit();
            SuspendLayout();
            // 
            // Hora
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 256);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 56;
            label1.Text = "Hora";
            // 
            // CajaHora
            // 
            CajaHora.CustomFormat = "HH:00";
            CajaHora.Format = DateTimePickerFormat.Custom;
            CajaHora.Location = new Point(52, 279);
            CajaHora.Name = "CajaHora";
            CajaHora.ShowUpDown = true;
            CajaHora.Size = new Size(259, 27);
            CajaHora.TabIndex = 55;
            // 
            // Calendario
            // 
            Calendario.Location = new Point(346, 99);
            Calendario.Name = "Calendario";
            Calendario.TabIndex = 54;
            // 
            // CajaComboSala
            // 
            CajaComboSala.FormattingEnabled = true;
            CajaComboSala.Location = new Point(52, 221);
            CajaComboSala.Name = "CajaComboSala";
            CajaComboSala.Size = new Size(259, 28);
            CajaComboSala.TabIndex = 53;
            // 
            // CajaComboEntrenador
            // 
            CajaComboEntrenador.FormattingEnabled = true;
            CajaComboEntrenador.Location = new Point(52, 160);
            CajaComboEntrenador.Name = "CajaComboEntrenador";
            CajaComboEntrenador.Size = new Size(259, 28);
            CajaComboEntrenador.TabIndex = 52;
            // 
            // CajaComboActividades
            // 
            CajaComboActividades.FormattingEnabled = true;
            CajaComboActividades.Location = new Point(52, 99);
            CajaComboActividades.Name = "CajaComboActividades";
            CajaComboActividades.Size = new Size(259, 28);
            CajaComboActividades.TabIndex = 51;
            // 
            // Modificar clase
            // 
            AnadirClientes.AutoSize = true;
            AnadirClientes.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            AnadirClientes.ForeColor = Color.DarkSlateGray;
            AnadirClientes.Location = new Point(52, 18);
            AnadirClientes.Name = "AnadirClientes";
            AnadirClientes.Size = new Size(320, 46);
            AnadirClientes.TabIndex = 50;
            AnadirClientes.Text = "MODIFICAR CLASE";
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(769, 261);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(81, 45);
            BotonVolver.TabIndex = 49;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // BotonGuardar
            // 
            BotonGuardar.BackColor = Color.DarkOrange;
            BotonGuardar.Location = new Point(683, 261);
            BotonGuardar.Margin = new Padding(3, 4, 3, 4);
            BotonGuardar.Name = "BotonGuardar";
            BotonGuardar.Size = new Size(80, 45);
            BotonGuardar.TabIndex = 48;
            BotonGuardar.Text = "Guardar";
            BotonGuardar.UseVisualStyleBackColor = false;
            BotonGuardar.Click += BotonGuardar_Click;
            // 
            // Fecha
            // 
            Fecha.AutoSize = true;
            Fecha.Location = new Point(346, 76);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(47, 20);
            Fecha.TabIndex = 47;
            Fecha.Text = "Fecha";
            // 
            // Sala
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 198);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 46;
            label5.Text = "Sala";
            // 
            // Entrenador
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 137);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 45;
            label2.Text = "Entrenador";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(52, 76);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(72, 20);
            Nombre.TabIndex = 44;
            Nombre.Text = "Actividad";
            // 
            // PanelClases
            // 
            PanelClases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelClases.Location = new Point(52, 319);
            PanelClases.Margin = new Padding(3, 4, 3, 4);
            PanelClases.Name = "PanelClases";
            PanelClases.RowHeadersWidth = 51;
            PanelClases.Size = new Size(798, 200);
            PanelClases.TabIndex = 57;
            // 
            // ModificarClase
            // 
            ClientSize = new Size(899, 532);
            Controls.Add(PanelClases);
            Controls.Add(label1);
            Controls.Add(CajaHora);
            Controls.Add(Calendario);
            Controls.Add(CajaComboSala);
            Controls.Add(CajaComboEntrenador);
            Controls.Add(CajaComboActividades);
            Controls.Add(AnadirClientes);
            Controls.Add(BotonVolver);
            Controls.Add(BotonGuardar);
            Controls.Add(Fecha);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(Nombre);
            Name = "ModificarClase";
            ((ISupportInitialize)PanelClases).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private DateTimePicker CajaHora;
        private MonthCalendar Calendario;
        private ComboBox CajaComboSala;
        private ComboBox CajaComboEntrenador;
        private ComboBox CajaComboActividades;
        private Label ModificarClaseTitulo;
        private Button BotonVolver;
        private Button BotonGuardar;
        private Label Fecha;
        private Label label5;
        private Label label2;
        private Label Nombre;
        private DataGridView PanelClases;
        private Label AnadirClientes;
    }
}