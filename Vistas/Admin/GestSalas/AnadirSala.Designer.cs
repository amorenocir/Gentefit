namespace Gentefit.Vistas.Admin.GestSalas
{
    partial class AnadirSala
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
            AnadirSalas = new Label();
            BotonVolver = new Button();
            BotonAnadir = new Button();
            CajaTextoNombre = new TextBox();
            Nombre = new Label();
            SuspendLayout();
            // 
            // AnadirSalas
            // 
            AnadirSalas.AutoSize = true;
            AnadirSalas.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            AnadirSalas.ForeColor = Color.DarkSlateGray;
            AnadirSalas.Location = new Point(114, 40);
            AnadirSalas.Name = "AnadirSalas";
            AnadirSalas.Size = new Size(198, 37);
            AnadirSalas.TabIndex = 46;
            AnadirSalas.Text = "AÑADIR SALA";
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(265, 297);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(71, 34);
            BotonVolver.TabIndex = 44;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // BotonAnadir
            // 
            BotonAnadir.BackColor = Color.DarkOrange;
            BotonAnadir.Location = new Point(117, 297);
            BotonAnadir.Name = "BotonAnadir";
            BotonAnadir.Size = new Size(70, 34);
            BotonAnadir.TabIndex = 43;
            BotonAnadir.Text = "Añadir";
            BotonAnadir.UseVisualStyleBackColor = false;
            BotonAnadir.Click += BotonAnadir_Click;
            // 
            // CajaTextoNombre
            // 
            CajaTextoNombre.Location = new Point(114, 162);
            CajaTextoNombre.Name = "CajaTextoNombre";
            CajaTextoNombre.Size = new Size(434, 23);
            CajaTextoNombre.TabIndex = 39;
            CajaTextoNombre.TextChanged += CajaTextoNombre_TextChanged;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(114, 144);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 38;
            Nombre.Text = "Nombre";
            // 
            // AnadirSala
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AnadirSalas);
            Controls.Add(BotonVolver);
            Controls.Add(BotonAnadir);
            Controls.Add(CajaTextoNombre);
            Controls.Add(Nombre);
            Name = "AnadirSala";
            Text = "AnadirSala";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AnadirSalas;
        private Button BotonVolver;
        private Button BotonAnadir;
        private TextBox CajaTextoNombre;
        private Label Nombre;
    }
}