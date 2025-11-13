namespace Gentefit.Vistas.Admin.GestiEntrenadores
{
    partial class AnadirEntrenador
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
            AnadirEntrenadores = new Label();
            BotonVolver = new Button();
            BotonAnadir = new Button();
            CajaTextoDNI = new TextBox();
            label5 = new Label();
            CajaTextoApellidos = new TextBox();
            label2 = new Label();
            CajaTextoNombre = new TextBox();
            Nombre = new Label();
            SuspendLayout();
            // 
            // AnadirEntrenadores
            // 
            AnadirEntrenadores.AutoSize = true;
            AnadirEntrenadores.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            AnadirEntrenadores.ForeColor = Color.DarkSlateGray;
            AnadirEntrenadores.Location = new Point(114, 40);
            AnadirEntrenadores.Name = "AnadirEntrenadores";
            AnadirEntrenadores.Size = new Size(311, 37);
            AnadirEntrenadores.TabIndex = 37;
            AnadirEntrenadores.Text = "AÑADIR ENTRENADOR";
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(616, 376);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(71, 34);
            BotonVolver.TabIndex = 31;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // BotonAnadir
            // 
            BotonAnadir.BackColor = Color.DarkOrange;
            BotonAnadir.Location = new Point(468, 376);
            BotonAnadir.Name = "BotonAnadir";
            BotonAnadir.Size = new Size(70, 34);
            BotonAnadir.TabIndex = 30;
            BotonAnadir.Text = "Añadir";
            BotonAnadir.UseVisualStyleBackColor = false;
            BotonAnadir.Click += BotonAnadir_Click;
            // 
            // CajaTextoDNI
            // 
            CajaTextoDNI.Location = new Point(114, 293);
            CajaTextoDNI.Name = "CajaTextoDNI";
            CajaTextoDNI.Size = new Size(277, 23);
            CajaTextoDNI.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(114, 275);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 32;
            label5.Text = "DNI/NIE/Pasaporte";
            // 
            // CajaTextoApellidos
            // 
            CajaTextoApellidos.Location = new Point(114, 213);
            CajaTextoApellidos.Name = "CajaTextoApellidos";
            CajaTextoApellidos.Size = new Size(277, 23);
            CajaTextoApellidos.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 195);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 25;
            label2.Text = "Apellidos";
            // 
            // CajaTextoNombre
            // 
            CajaTextoNombre.Location = new Point(114, 140);
            CajaTextoNombre.Name = "CajaTextoNombre";
            CajaTextoNombre.Size = new Size(277, 23);
            CajaTextoNombre.TabIndex = 23;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(114, 122);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 22;
            Nombre.Text = "Nombre";
            // 
            // AnadirEntrenador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AnadirEntrenadores);
            Controls.Add(BotonVolver);
            Controls.Add(BotonAnadir);
            Controls.Add(CajaTextoDNI);
            Controls.Add(label5);
            Controls.Add(CajaTextoApellidos);
            Controls.Add(label2);
            Controls.Add(CajaTextoNombre);
            Controls.Add(Nombre);
            Name = "AnadirEntrenador";
            Text = "AnadirEntrenador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AnadirEntrenadores;
        private Button BotonVolver;
        private Button BotonAnadir;
        private TextBox CajaTextoDNI;
        private Label label5;
        private TextBox CajaTextoApellidos;
        private Label label2;
        private TextBox CajaTextoNombre;
        private Label Nombre;
    }
}