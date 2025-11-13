namespace Gentefit.Vistas.Admin.GestiEntrenadores
{
    partial class ModificarEntrenadores
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
            BotonBuscar = new Button();
            PanelEntrenadores = new DataGridView();
            CajaTextoBuscar = new TextBox();
            BotonVolver = new Button();
            BotonGuardar = new Button();
            CajaTextoDNI = new TextBox();
            label5 = new Label();
            CajaTextoApellidos = new TextBox();
            label2 = new Label();
            CajaTextoNombre = new TextBox();
            Nombre = new Label();
            ((System.ComponentModel.ISupportInitialize)PanelEntrenadores).BeginInit();
            SuspendLayout();
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(536, 67);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 61;
            ID.Text = "ID";
            // 
            // CajaTextoID
            // 
            CajaTextoID.Location = new Point(536, 85);
            CajaTextoID.Name = "CajaTextoID";
            CajaTextoID.ReadOnly = true;
            CajaTextoID.Size = new Size(184, 23);
            CajaTextoID.TabIndex = 60;
            // 
            // BotonBuscar
            // 
            BotonBuscar.BackColor = Color.DarkOrange;
            BotonBuscar.Location = new Point(223, 67);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(70, 34);
            BotonBuscar.TabIndex = 59;
            BotonBuscar.Text = "Buscar";
            BotonBuscar.UseVisualStyleBackColor = false;
            BotonBuscar.Click += BotonBuscar_Click;
            // 
            // PanelEntrenadores
            // 
            PanelEntrenadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelEntrenadores.Location = new Point(28, 133);
            PanelEntrenadores.Name = "PanelEntrenadores";
            PanelEntrenadores.Size = new Size(438, 285);
            PanelEntrenadores.TabIndex = 58;
            PanelEntrenadores.CellClick += PanelEntrenadores_CellClick;
            // 
            // CajaTextoBuscar
            // 
            CajaTextoBuscar.Location = new Point(28, 74);
            CajaTextoBuscar.Name = "CajaTextoBuscar";
            CajaTextoBuscar.Size = new Size(180, 23);
            CajaTextoBuscar.TabIndex = 57;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(649, 356);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(71, 34);
            BotonVolver.TabIndex = 56;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // BotonGuardar
            // 
            BotonGuardar.BackColor = Color.DarkOrange;
            BotonGuardar.Location = new Point(558, 356);
            BotonGuardar.Name = "BotonGuardar";
            BotonGuardar.Size = new Size(70, 34);
            BotonGuardar.TabIndex = 55;
            BotonGuardar.Text = "Guardar";
            BotonGuardar.UseVisualStyleBackColor = false;
            BotonGuardar.Click += BotonGuardar_Click;
            // 
            // CajaTextoDNI
            // 
            CajaTextoDNI.Location = new Point(536, 261);
            CajaTextoDNI.Name = "CajaTextoDNI";
            CajaTextoDNI.Size = new Size(184, 23);
            CajaTextoDNI.TabIndex = 48;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(536, 243);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 47;
            label5.Text = "DNI/NIE/Pasaporte";
            // 
            // CajaTextoApellidos
            // 
            CajaTextoApellidos.Location = new Point(536, 203);
            CajaTextoApellidos.Name = "CajaTextoApellidos";
            CajaTextoApellidos.Size = new Size(184, 23);
            CajaTextoApellidos.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(536, 185);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 45;
            label2.Text = "Apellidos";
            // 
            // CajaTextoNombre
            // 
            CajaTextoNombre.Location = new Point(536, 146);
            CajaTextoNombre.Name = "CajaTextoNombre";
            CajaTextoNombre.Size = new Size(184, 23);
            CajaTextoNombre.TabIndex = 44;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(536, 128);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 43;
            Nombre.Text = "Nombre";
            // 
            // ModificarEntrenadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ID);
            Controls.Add(CajaTextoID);
            Controls.Add(BotonBuscar);
            Controls.Add(PanelEntrenadores);
            Controls.Add(CajaTextoBuscar);
            Controls.Add(BotonVolver);
            Controls.Add(BotonGuardar);
            Controls.Add(CajaTextoDNI);
            Controls.Add(label5);
            Controls.Add(CajaTextoApellidos);
            Controls.Add(label2);
            Controls.Add(CajaTextoNombre);
            Controls.Add(Nombre);
            Name = "ModificarEntrenadores";
            Text = "ModificarEntrenadores";
            Load += ModificarEntrenadores_Load;
            ((System.ComponentModel.ISupportInitialize)PanelEntrenadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ID;
        private TextBox CajaTextoID;
        private Button BotonBuscar;
        private DataGridView PanelEntrenadores;
        private TextBox CajaTextoBuscar;
        private Button BotonVolver;
        private Button BotonGuardar;
        private TextBox CajaTextoDNI;
        private Label label5;
        private TextBox CajaTextoApellidos;
        private Label label2;
        private TextBox CajaTextoNombre;
        private Label Nombre;
    }
}