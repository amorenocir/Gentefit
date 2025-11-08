using System.Windows.Forms;

namespace Gentefit.Vistas.PantallasAdmin
{
    partial class MenuAdClientes
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
            BotonAnadir = new Button();
            BotonListar = new Button();
            BotonEliminar = new Button();
            BotonModificar = new Button();
            pictureBox1 = new PictureBox();
            BotonVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Clientes
            // 
            Clientes.AutoSize = true;
            Clientes.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Clientes.ForeColor = Color.DarkSlateGray;
            Clientes.Location = new Point(324, 113);
            Clientes.Name = "Clientes";
            Clientes.Size = new Size(137, 37);
            Clientes.TabIndex = 6;
            Clientes.Text = "CLIENTES";
            Clientes.Click += Actividades_Click;
            // 
            // BotonAnadir
            // 
            BotonAnadir.BackColor = Color.DarkOrange;
            BotonAnadir.ForeColor = Color.White;
            BotonAnadir.Location = new Point(137, 202);
            BotonAnadir.Name = "BotonAnadir";
            BotonAnadir.Size = new Size(115, 49);
            BotonAnadir.TabIndex = 7;
            BotonAnadir.Text = "Añadir";
            BotonAnadir.UseVisualStyleBackColor = false;
            BotonAnadir.Click += BotonAnadir_Click;
            // 
            // BotonListar
            // 
            BotonListar.BackColor = Color.DarkOrange;
            BotonListar.ForeColor = Color.White;
            BotonListar.Location = new Point(270, 202);
            BotonListar.Name = "BotonListar";
            BotonListar.Size = new Size(115, 49);
            BotonListar.TabIndex = 8;
            BotonListar.Text = "Listar";
            BotonListar.UseVisualStyleBackColor = false;
            BotonListar.Click += BotonListar_Click;
            // 
            // BotonEliminar
            // 
            BotonEliminar.BackColor = Color.DarkOrange;
            BotonEliminar.ForeColor = Color.White;
            BotonEliminar.Location = new Point(537, 202);
            BotonEliminar.Name = "BotonEliminar";
            BotonEliminar.Size = new Size(115, 49);
            BotonEliminar.TabIndex = 9;
            BotonEliminar.Text = "Eliminar";
            BotonEliminar.UseVisualStyleBackColor = false;
            BotonEliminar.Click += BotonEliminar_Click;
            // 
            // BotonModificar
            // 
            BotonModificar.BackColor = Color.DarkOrange;
            BotonModificar.ForeColor = Color.White;
            BotonModificar.Location = new Point(404, 202);
            BotonModificar.Name = "BotonModificar";
            BotonModificar.Size = new Size(115, 49);
            BotonModificar.TabIndex = 10;
            BotonModificar.Text = "Modificar";
            BotonModificar.UseVisualStyleBackColor = false;
            BotonModificar.Click += BotonModificar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoAdmin;
            pictureBox1.Location = new Point(315, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(577, 360);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(75, 23);
            BotonVolver.TabIndex = 16;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // MenuAdClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonVolver);
            Controls.Add(pictureBox1);
            Controls.Add(BotonModificar);
            Controls.Add(BotonEliminar);
            Controls.Add(BotonListar);
            Controls.Add(BotonAnadir);
            Controls.Add(Clientes);
            Name = "MenuAdClientes";
            Text = "MenuClientes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Clientes;
        private Button BotonAnadir;
        private Button BotonListar;
        private Button BotonEliminar;
        private Button BotonModificar;
        private PictureBox pictureBox1;
        private Button BotonVolver;
    }
}