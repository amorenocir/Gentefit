namespace Gentefit.Vistas.PantallasAdmin.GestionReservas
{
    partial class AnadirReserva
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
            DgvClases = new DataGridView();
            DgvClases.AutoGenerateColumns = true;
            DgvClientes = new DataGridView();
            BotonReservar = new Button();
            BotonVolver = new Button();
            AnadirEntrenadores = new Label();
            txtIdClase = new TextBox();
            id_clase = new Label();
            txtIdCliente = new TextBox();
            id_cliente = new Label();
            button1 = new Button();
            BotonBuscarClase = new Button();
            BotonBuscarCliente = new Button();
            txtBuscarCliente = new TextBox();
            txtBuscarClase = new TextBox();
            txtNombreCliente = new TextBox();
            txtActividad = new TextBox();
            label1 = new Label();
            txtDia = new TextBox();
            label2 = new Label();
            txtHora = new TextBox();
            label3 = new Label();
            label4 = new Label();
            BotonVerTodos = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvClases).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvClientes).BeginInit();
            SuspendLayout();
            // 
            // DgvClases
            // 
            DgvClases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvClases.Location = new Point(600, 363);
            DgvClases.Name = "DgvClases";
            DgvClases.RowHeadersWidth = 51;
            DgvClases.Size = new Size(566, 310);
            DgvClases.TabIndex = 0;
            // 
            // DgvClientes
            // 
            DgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvClientes.Location = new Point(29, 363);
            DgvClientes.Name = "DgvClientes";
            DgvClientes.RowHeadersWidth = 51;
            DgvClientes.Size = new Size(538, 310);
            DgvClientes.TabIndex = 1;
            // 
            // BotonReservar
            // 
            BotonReservar.BackColor = Color.DarkOrange;
            BotonReservar.Location = new Point(482, 696);
            BotonReservar.Margin = new Padding(3, 4, 3, 4);
            BotonReservar.Name = "BotonReservar";
            BotonReservar.Size = new Size(77, 44);
            BotonReservar.TabIndex = 26;
            BotonReservar.Text = "Reservar";
            BotonReservar.UseVisualStyleBackColor = false;
            BotonReservar.Click += BotonReservar_Click_1;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(591, 700);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(98, 37);
            BotonVolver.TabIndex = 27;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // AnadirEntrenadores
            // 
            AnadirEntrenadores.AutoSize = true;
            AnadirEntrenadores.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            AnadirEntrenadores.ForeColor = Color.DarkSlateGray;
            AnadirEntrenadores.Location = new Point(42, 9);
            AnadirEntrenadores.Name = "AnadirEntrenadores";
            AnadirEntrenadores.Size = new Size(306, 46);
            AnadirEntrenadores.TabIndex = 34;
            AnadirEntrenadores.Text = "AÑADIR RESERVA";
            // 
            // txtIdClase
            // 
            txtIdClase.Location = new Point(414, 123);
            txtIdClase.Margin = new Padding(3, 4, 3, 4);
            txtIdClase.Name = "txtIdClase";
            txtIdClase.Size = new Size(259, 27);
            txtIdClase.TabIndex = 31;
            // 
            // id_clase
            // 
            id_clase.AutoSize = true;
            id_clase.Location = new Point(414, 99);
            id_clase.Name = "id_clase";
            id_clase.Size = new Size(63, 20);
            id_clase.TabIndex = 30;
            id_clase.Text = "ID Clase";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(42, 123);
            txtIdCliente.Margin = new Padding(3, 4, 3, 4);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(259, 27);
            txtIdCliente.TabIndex = 29;
            // 
            // id_cliente
            // 
            id_cliente.AutoSize = true;
            id_cliente.Location = new Point(42, 90);
            id_cliente.Name = "id_cliente";
            id_cliente.Size = new Size(74, 20);
            id_cliente.TabIndex = 28;
            id_cliente.Text = "ID Cliente";
            // 
            // button1
            // 
            button1.Location = new Point(446, 312);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 35;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // BotonBuscarClase
            // 
            BotonBuscarClase.BackColor = Color.DarkOrange;
            BotonBuscarClase.Location = new Point(918, 308);
            BotonBuscarClase.Margin = new Padding(3, 4, 3, 4);
            BotonBuscarClase.Name = "BotonBuscarClase";
            BotonBuscarClase.Size = new Size(114, 35);
            BotonBuscarClase.TabIndex = 36;
            BotonBuscarClase.Text = "Buscar Clase";
            BotonBuscarClase.UseVisualStyleBackColor = false;
            BotonBuscarClase.Click += BotonBuscarClase_Click;
            // 
            // BotonBuscarCliente
            // 
            BotonBuscarCliente.BackColor = Color.DarkOrange;
            BotonBuscarCliente.Location = new Point(29, 308);
            BotonBuscarCliente.Margin = new Padding(3, 4, 3, 4);
            BotonBuscarCliente.Name = "BotonBuscarCliente";
            BotonBuscarCliente.Size = new Size(117, 35);
            BotonBuscarCliente.TabIndex = 37;
            BotonBuscarCliente.Text = "Buscar Cliente";
            BotonBuscarCliente.UseVisualStyleBackColor = false;
            BotonBuscarCliente.Click += BotonBuscarCliente_Click_1;
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Location = new Point(166, 312);
            txtBuscarCliente.Margin = new Padding(3, 4, 3, 4);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(118, 27);
            txtBuscarCliente.TabIndex = 38;
            // 
            // txtBuscarClase
            // 
            txtBuscarClase.Location = new Point(1051, 312);
            txtBuscarClase.Margin = new Padding(3, 4, 3, 4);
            txtBuscarClase.Name = "txtBuscarClase";
            txtBuscarClase.Size = new Size(115, 27);
            txtBuscarClase.TabIndex = 39;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(42, 198);
            txtNombreCliente.Margin = new Padding(3, 4, 3, 4);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(259, 27);
            txtNombreCliente.TabIndex = 40;
            // 
            // txtActividad
            // 
            txtActividad.Location = new Point(414, 198);
            txtActividad.Margin = new Padding(3, 4, 3, 4);
            txtActividad.Name = "txtActividad";
            txtActividad.Size = new Size(259, 27);
            txtActividad.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 174);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 42;
            label1.Text = "Nombre Cliente";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(414, 261);
            txtDia.Margin = new Padding(3, 4, 3, 4);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(99, 27);
            txtDia.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(414, 174);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 44;
            label2.Text = "Actividad";
            // 
            // txtHora
            // 
            txtHora.Location = new Point(574, 261);
            txtHora.Margin = new Padding(3, 4, 3, 4);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(99, 27);
            txtHora.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(414, 237);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 46;
            label3.Text = "Dia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(574, 237);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 47;
            label4.Text = "Hora";
            // 
            // BotonVerTodos
            // 
            BotonVerTodos.BackColor = Color.DarkOrange;
            BotonVerTodos.Location = new Point(522, 312);
            BotonVerTodos.Margin = new Padding(3, 4, 3, 4);
            BotonVerTodos.Name = "BotonVerTodos";
            BotonVerTodos.Size = new Size(117, 35);
            BotonVerTodos.TabIndex = 48;
            BotonVerTodos.Text = "Buscar todos";
            BotonVerTodos.UseVisualStyleBackColor = false;
            BotonVerTodos.Click += BotonVerTodos_Click_1;
            // 
            // AnadirReserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1255, 745);
            Controls.Add(BotonVerTodos);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtHora);
            Controls.Add(label2);
            Controls.Add(txtDia);
            Controls.Add(label1);
            Controls.Add(txtActividad);
            Controls.Add(txtNombreCliente);
            Controls.Add(txtBuscarClase);
            Controls.Add(txtBuscarCliente);
            Controls.Add(BotonBuscarCliente);
            Controls.Add(BotonBuscarClase);
            Controls.Add(button1);
            Controls.Add(AnadirEntrenadores);
            Controls.Add(txtIdClase);
            Controls.Add(id_clase);
            Controls.Add(txtIdCliente);
            Controls.Add(id_cliente);
            Controls.Add(BotonVolver);
            Controls.Add(BotonReservar);
            Controls.Add(DgvClientes);
            Controls.Add(DgvClases);
            Name = "AnadirReserva";
            Text = "Add Reserva Admin";
            ((System.ComponentModel.ISupportInitialize)DgvClases).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView DgvClases;
        private DataGridView DgvClientes;
        private Button BotonReservar;
        private Button BotonVolver;
        private Label AnadirEntrenadores;
        private TextBox txtIdClase;
        private Label id_clase;
        private TextBox txtIdCliente;
        private Label id_cliente;
        private Button button1;
        private Button BotonBuscarClase;
        private Button BotonBuscarCliente;
        private TextBox txtBuscarCliente;
        private TextBox txtBuscarClase;
        private TextBox txtNombreCliente;
        private TextBox txtActividad;
        private Label label1;
        private TextBox txtDia;
        private Label label2;
        private TextBox txtHora;
        private Label label3;
        private Label label4;
        private Button BotonVerTodos;
    }
}