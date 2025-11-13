namespace Gentefit.Vistas.Admin.GestActividades.GestClases
{
    partial class MenuActivClases
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
            Clientes = new Label();
            PanelActividades = new DataGridView();
            BotonVolver = new Button();
            CajaTextoBusqueda = new TextBox();
            IdActividad = new Label();
            BotonGuardar = new Button();
            BotonVerTodos = new Button();
            BotonBuscar = new Button();
            BotonSeleccionar = new Button();
            ((System.ComponentModel.ISupportInitialize)PanelActividades).BeginInit();
            SuspendLayout();
            // 
            // Clientes
            // 
            Clientes.AutoSize = true;
            Clientes.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Clientes.ForeColor = Color.DarkSlateGray;
            Clientes.Location = new Point(99, 36);
            Clientes.Name = "Clientes";
            Clientes.Size = new Size(288, 37);
            Clientes.TabIndex = 18;
            Clientes.Text = "ESCOGER ACTIVIDAD";
            Clientes.Click += Clientes_Click;
            // 
            // PanelActividades
            // 
            PanelActividades.Location = new Point(99, 161);
            PanelActividades.Name = "PanelActividades";
            PanelActividades.Size = new Size(644, 200);
            PanelActividades.TabIndex = 51;
            PanelActividades.CellContentClick += PanelActividades_CellContentClick;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(668, 391);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(75, 23);
            BotonVolver.TabIndex = 52;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // CajaTextoBusqueda
            // 
            CajaTextoBusqueda.Location = new Point(99, 107);
            CajaTextoBusqueda.Name = "CajaTextoBusqueda";
            CajaTextoBusqueda.Size = new Size(184, 23);
            CajaTextoBusqueda.TabIndex = 54;
            // 
            // IdActividad
            // 
            IdActividad.AutoSize = true;
            IdActividad.Location = new Point(99, 89);
            IdActividad.Name = "IdActividad";
            IdActividad.Size = new Size(97, 15);
            IdActividad.TabIndex = 53;
            IdActividad.Text = "ID de la actividad";
            // 
            // BotonGuardar
            // 
            BotonGuardar.Location = new Point(0, 0);
            BotonGuardar.Name = "BotonGuardar";
            BotonGuardar.Size = new Size(75, 23);
            BotonGuardar.TabIndex = 58;
            // 
            // BotonVerTodos
            // 
            BotonVerTodos.BackColor = Color.DarkOrange;
            BotonVerTodos.Location = new Point(404, 100);
            BotonVerTodos.Name = "BotonVerTodos";
            BotonVerTodos.Size = new Size(82, 34);
            BotonVerTodos.TabIndex = 57;
            BotonVerTodos.Text = "Ver todos";
            BotonVerTodos.UseVisualStyleBackColor = false;
            BotonVerTodos.Click += BotonVerTodos_Click;
            // 
            // BotonBuscar
            // 
            BotonBuscar.BackColor = Color.DarkOrange;
            BotonBuscar.Location = new Point(317, 100);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(70, 34);
            BotonBuscar.TabIndex = 56;
            BotonBuscar.Text = "Buscar";
            BotonBuscar.UseVisualStyleBackColor = false;
            BotonBuscar.Click += BotonBuscar_Click;
            // 
            // BotonSeleccionar
            // 
            BotonSeleccionar.BackColor = Color.DarkOrange;
            BotonSeleccionar.Location = new Point(530, 385);
            BotonSeleccionar.Name = "BotonSeleccionar";
            BotonSeleccionar.Size = new Size(95, 34);
            BotonSeleccionar.TabIndex = 59;
            BotonSeleccionar.Text = "Seleccionar";
            BotonSeleccionar.UseVisualStyleBackColor = false;
            BotonSeleccionar.Click += BotonSeleccionar_Click;
            // 
            // MenuActivClases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonSeleccionar);
            Controls.Add(BotonVerTodos);
            Controls.Add(BotonBuscar);
            Controls.Add(BotonGuardar);
            Controls.Add(CajaTextoBusqueda);
            Controls.Add(IdActividad);
            Controls.Add(BotonVolver);
            Controls.Add(PanelActividades);
            Controls.Add(Clientes);
            Name = "MenuActivClases";
            Text = "MenuActivClases";
            ((System.ComponentModel.ISupportInitialize)PanelActividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Clientes;
        private DataGridView PanelActividades;
        private Button BotonVolver;
        private TextBox CajaTextoBusqueda;
        private Label IdActividad;
        private Button BotonGuardar;
        private Button BotonVerTodos;
        private Button BotonBuscar;
        private Button BotonSeleccionar;
    }
}