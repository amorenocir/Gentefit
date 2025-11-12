namespace Gentefit.Vistas.PantallasAdmin
{
    partial class UsuariosAdmin
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(643, 477);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(86, 31);
            BotonVolver.TabIndex = 23;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoAdmin;
            pictureBox1.Location = new Point(344, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // BotonModificar
            // 
            BotonModificar.BackColor = Color.DarkOrange;
            BotonModificar.ForeColor = Color.White;
            BotonModificar.Location = new Point(446, 266);
            BotonModificar.Margin = new Padding(3, 4, 3, 4);
            BotonModificar.Name = "BotonModificar";
            BotonModificar.Size = new Size(131, 65);
            BotonModificar.TabIndex = 21;
            BotonModificar.Text = "Modificar";
            BotonModificar.UseVisualStyleBackColor = false;
            BotonModificar.Click += BotonModificar_Click;
            // 
            // BotonEliminar
            // 
            BotonEliminar.BackColor = Color.DarkOrange;
            BotonEliminar.ForeColor = Color.White;
            BotonEliminar.Location = new Point(598, 266);
            BotonEliminar.Margin = new Padding(3, 4, 3, 4);
            BotonEliminar.Name = "BotonEliminar";
            BotonEliminar.Size = new Size(131, 65);
            BotonEliminar.TabIndex = 20;
            BotonEliminar.Text = "Eliminar";
            BotonEliminar.UseVisualStyleBackColor = false;
            BotonEliminar.Click += BotonEliminar_Click;
            // 
            // BotonListar
            // 
            BotonListar.BackColor = Color.DarkOrange;
            BotonListar.ForeColor = Color.White;
            BotonListar.Location = new Point(293, 266);
            BotonListar.Margin = new Padding(3, 4, 3, 4);
            BotonListar.Name = "BotonListar";
            BotonListar.Size = new Size(131, 65);
            BotonListar.TabIndex = 19;
            BotonListar.Text = "Listar";
            BotonListar.UseVisualStyleBackColor = false;
            BotonListar.Click += BotonListar_Click;
            // 
            // BotonAnadir
            // 
            BotonAnadir.BackColor = Color.DarkOrange;
            BotonAnadir.ForeColor = Color.White;
            BotonAnadir.Location = new Point(141, 266);
            BotonAnadir.Margin = new Padding(3, 4, 3, 4);
            BotonAnadir.Name = "BotonAnadir";
            BotonAnadir.Size = new Size(131, 65);
            BotonAnadir.TabIndex = 18;
            BotonAnadir.Text = "Añadir";
            BotonAnadir.UseVisualStyleBackColor = false;
            BotonAnadir.Click += BotonAnadir_Click;
            // 
            // Usuarios
            // 
            Clientes.AutoSize = true;
            Clientes.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Clientes.ForeColor = Color.DarkSlateGray;
            Clientes.Location = new Point(354, 148);
            Clientes.Name = "Usuarios";
            Clientes.Size = new Size(190, 46);
            Clientes.TabIndex = 17;
            Clientes.Text = "USUARIOS";
            // 
            // UsuariosAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 534);
            Controls.Add(BotonVolver);
            Controls.Add(pictureBox1);
            Controls.Add(BotonModificar);
            Controls.Add(BotonEliminar);
            Controls.Add(BotonListar);
            Controls.Add(BotonAnadir);
            Controls.Add(Clientes);
            Name = "UsuariosAdmin";
            Text = "UsuariosAdmin";
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
    }
}