namespace Gentefit.Vistas.Admin.GestSalas
{
    partial class ModificarSalas
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
            PanelSalas = new DataGridView();
            BotonVolver = new Button();
            BotonGuardar = new Button();
            CajaTextoNombre = new TextBox();
            Nombre = new Label();
            ((System.ComponentModel.ISupportInitialize)PanelSalas).BeginInit();
            SuspendLayout();
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(562, 95);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 74;
            ID.Text = "ID";
            // 
            // CajaTextoID
            // 
            CajaTextoID.Location = new Point(562, 113);
            CajaTextoID.Name = "CajaTextoID";
            CajaTextoID.ReadOnly = true;
            CajaTextoID.Size = new Size(184, 23);
            CajaTextoID.TabIndex = 73;
            // 
            // PanelSalas
            // 
            PanelSalas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelSalas.Location = new Point(43, 88);
            PanelSalas.Name = "PanelSalas";
            PanelSalas.Size = new Size(438, 285);
            PanelSalas.TabIndex = 71;
            PanelSalas.CellClick += PanelSalas_CellClick;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(675, 339);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(71, 34);
            BotonVolver.TabIndex = 69;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // BotonGuardar
            // 
            BotonGuardar.BackColor = Color.DarkOrange;
            BotonGuardar.Location = new Point(584, 339);
            BotonGuardar.Name = "BotonGuardar";
            BotonGuardar.Size = new Size(70, 34);
            BotonGuardar.TabIndex = 68;
            BotonGuardar.Text = "Guardar";
            BotonGuardar.UseVisualStyleBackColor = false;
            BotonGuardar.Click += BotonGuardar_Click;
            // 
            // CajaTextoNombre
            // 
            CajaTextoNombre.Location = new Point(562, 174);
            CajaTextoNombre.Name = "CajaTextoNombre";
            CajaTextoNombre.Size = new Size(184, 23);
            CajaTextoNombre.TabIndex = 63;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(562, 156);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 62;
            Nombre.Text = "Nombre";
            // 
            // ModificarSalas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ID);
            Controls.Add(CajaTextoID);
            Controls.Add(PanelSalas);
            Controls.Add(BotonVolver);
            Controls.Add(BotonGuardar);
            Controls.Add(CajaTextoNombre);
            Controls.Add(Nombre);
            Name = "ModificarSalas";
            Text = "ModificarSalas";
            ((System.ComponentModel.ISupportInitialize)PanelSalas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ID;
        private TextBox CajaTextoID;
        private DataGridView PanelSalas;
        private Button BotonVolver;
        private Button BotonGuardar;
        private TextBox CajaTextoNombre;
        private Label Nombre;
    }
}