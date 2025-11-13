namespace Gentefit.Vistas.Admin.GestActividades
{
    partial class MenuAdActividades
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
            BotonVolver = new Button();
            pictureBox1 = new PictureBox();
            BotonModificar = new Button();
            BotonEliminar = new Button();
            BotonListar = new Button();
            BotonAnadir = new Button();
            Clientes = new Label();
            GestionarClases = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(583, 388);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(75, 23);
            BotonVolver.TabIndex = 6;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoAdmin;
            pictureBox1.Location = new Point(321, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // BotonModificar
            // 
            BotonModificar.BackColor = Color.DarkOrange;
            BotonModificar.ForeColor = Color.White;
            BotonModificar.Location = new Point(410, 201);
            BotonModificar.Name = "BotonModificar";
            BotonModificar.Size = new Size(115, 49);
            BotonModificar.TabIndex = 3;
            BotonModificar.Text = "Modificar";
            BotonModificar.UseVisualStyleBackColor = false;
            BotonModificar.Click += BotonModificar_Click;
            // 
            // BotonEliminar
            // 
            BotonEliminar.BackColor = Color.DarkOrange;
            BotonEliminar.ForeColor = Color.White;
            BotonEliminar.Location = new Point(543, 201);
            BotonEliminar.Name = "BotonEliminar";
            BotonEliminar.Size = new Size(115, 49);
            BotonEliminar.TabIndex = 4;
            BotonEliminar.Text = "Eliminar";
            BotonEliminar.UseVisualStyleBackColor = false;
            BotonEliminar.Click += BotonEliminar_Click;
            // 
            // BotonListar
            // 
            BotonListar.BackColor = Color.DarkOrange;
            BotonListar.ForeColor = Color.White;
            BotonListar.Location = new Point(276, 201);
            BotonListar.Name = "BotonListar";
            BotonListar.Size = new Size(115, 49);
            BotonListar.TabIndex = 2;
            BotonListar.Text = "Listar";
            BotonListar.UseVisualStyleBackColor = false;
            BotonListar.Click += BotonListar_Click;
            // 
            // BotonAnadir
            // 
            BotonAnadir.BackColor = Color.DarkOrange;
            BotonAnadir.ForeColor = Color.White;
            BotonAnadir.Location = new Point(143, 201);
            BotonAnadir.Name = "BotonAnadir";
            BotonAnadir.Size = new Size(115, 49);
            BotonAnadir.TabIndex = 1;
            BotonAnadir.Text = "Añadir";
            BotonAnadir.UseVisualStyleBackColor = false;
            BotonAnadir.Click += BotonAnadir_Click;
            // 
            // Clientes
            // 
            Clientes.AutoSize = true;
            Clientes.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Clientes.ForeColor = Color.DarkSlateGray;
            Clientes.Location = new Point(302, 138);
            Clientes.Name = "Clientes";
            Clientes.Size = new Size(193, 37);
            Clientes.TabIndex = 17;
            Clientes.Text = "ACTIVIDADES";
            // 
            // GestionarClases
            // 
            GestionarClases.BackColor = Color.DarkOrange;
            GestionarClases.ForeColor = Color.White;
            GestionarClases.Location = new Point(344, 296);
            GestionarClases.Name = "GestionarClases";
            GestionarClases.Size = new Size(115, 49);
            GestionarClases.TabIndex = 5;
            GestionarClases.Text = "Gestionar clases";
            GestionarClases.UseVisualStyleBackColor = false;
            GestionarClases.Click += GestionarClases_Click;
            // 
            // MenuAdActividades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GestionarClases);
            Controls.Add(BotonVolver);
            Controls.Add(pictureBox1);
            Controls.Add(BotonModificar);
            Controls.Add(BotonEliminar);
            Controls.Add(BotonListar);
            Controls.Add(BotonAnadir);
            Controls.Add(Clientes);
            Name = "MenuAdActividades";
            Text = "MenuAdActividades";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonVolver;
        private PictureBox pictureBox1;
        private Button BotonModificar;
        private Button BotonEliminar;
        private Button BotonListar;
        private Button BotonAnadir;
        private Label Clientes;
        private Button GestionarClases;
    }
}