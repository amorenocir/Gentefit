namespace Gentefit.Vistas.Admin.GestActividades
{
    partial class GestBodyPump
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
            Logo = new PictureBox();
            Actividades = new Label();
            BotonAdd = new Button();
            BotonVolver = new Button();
            BotonModificar = new Button();
            BotonListar = new Button();
            BotonEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.LogoAdmin;
            Logo.Location = new Point(327, 24);
            Logo.Name = "Logo";
            Logo.Size = new Size(155, 85);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 1;
            Logo.TabStop = false;
            Logo.Click += Logo_Click;
            // 
            // Actividades
            // 
            Actividades.AutoSize = true;
            Actividades.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Actividades.ForeColor = Color.DarkSlateGray;
            Actividades.Location = new Point(311, 141);
            Actividades.Name = "Actividades";
            Actividades.Size = new Size(177, 37);
            Actividades.TabIndex = 6;
            Actividades.Text = "BODY PUMP";
            // 
            // BotonAdd
            // 
            BotonAdd.BackColor = Color.DarkOrange;
            BotonAdd.ForeColor = Color.White;
            BotonAdd.Location = new Point(120, 230);
            BotonAdd.Name = "BotonAdd";
            BotonAdd.Size = new Size(115, 49);
            BotonAdd.TabIndex = 1;
            BotonAdd.Text = "Añadir clase";
            BotonAdd.UseVisualStyleBackColor = false;
            BotonAdd.Click += BotonAdd_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(612, 379);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(75, 23);
            BotonVolver.TabIndex = 5;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // BotonModificar
            // 
            BotonModificar.BackColor = Color.DarkOrange;
            BotonModificar.ForeColor = Color.White;
            BotonModificar.Location = new Point(420, 230);
            BotonModificar.Name = "BotonModificar";
            BotonModificar.Size = new Size(115, 49);
            BotonModificar.TabIndex = 3;
            BotonModificar.Text = "Modificar clase";
            BotonModificar.UseVisualStyleBackColor = false;
            BotonModificar.Click += BotonModificar_Click;
            // 
            // BotonListar
            // 
            BotonListar.BackColor = Color.DarkOrange;
            BotonListar.ForeColor = Color.White;
            BotonListar.Location = new Point(271, 230);
            BotonListar.Name = "BotonListar";
            BotonListar.Size = new Size(115, 49);
            BotonListar.TabIndex = 2;
            BotonListar.Text = "Listar clases";
            BotonListar.UseVisualStyleBackColor = false;
            BotonListar.Click += BotonListar_Click;
            // 
            // BotonEliminar
            // 
            BotonEliminar.BackColor = Color.DarkOrange;
            BotonEliminar.ForeColor = Color.White;
            BotonEliminar.Location = new Point(572, 230);
            BotonEliminar.Name = "BotonEliminar";
            BotonEliminar.Size = new Size(115, 49);
            BotonEliminar.TabIndex = 4;
            BotonEliminar.Text = "Eliminar clase";
            BotonEliminar.UseVisualStyleBackColor = false;
            BotonEliminar.Click += BotonEliminar_Click;
            // 
            // GestBodyPump
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonEliminar);
            Controls.Add(BotonListar);
            Controls.Add(BotonModificar);
            Controls.Add(BotonVolver);
            Controls.Add(BotonAdd);
            Controls.Add(Actividades);
            Controls.Add(Logo);
            Name = "GestBodyPump";
            Text = "GestBodyPump";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Logo;
        private Label Actividades;
        private Button BotonAdd;
        private Button BotonVolver;
        private Button BotonModificar;
        private Button BotonListar;
        private Button BotonEliminar;
    }
}