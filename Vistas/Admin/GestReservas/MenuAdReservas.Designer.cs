namespace Gentefit.Vistas.Admin.GestReservas
{
    partial class MenuAdReservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdReservas));
            pictureBox1 = new PictureBox();
            Clientes = new Label();
            BotonAnadir = new Button();
            BotonListar = new Button();
            BotonModificar = new Button();
            BotonEliminar = new Button();
            BotonVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(315, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Clientes
            // 
            Clientes.AutoSize = true;
            Clientes.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Clientes.ForeColor = Color.DarkSlateGray;
            Clientes.Location = new Point(324, 113);
            Clientes.Name = "Clientes";
            Clientes.Size = new Size(147, 37);
            Clientes.TabIndex = 7;
            Clientes.Text = "RESERVAS";
            // 
            // BotonAnadir
            // 
            BotonAnadir.BackColor = Color.DarkOrange;
            BotonAnadir.ForeColor = Color.White;
            BotonAnadir.Location = new Point(137, 250);
            BotonAnadir.Name = "BotonAnadir";
            BotonAnadir.Size = new Size(115, 49);
            BotonAnadir.TabIndex = 8;
            BotonAnadir.Text = "Añadir";
            BotonAnadir.UseVisualStyleBackColor = false;
            // 
            // BotonListar
            // 
            BotonListar.BackColor = Color.DarkOrange;
            BotonListar.ForeColor = Color.White;
            BotonListar.Location = new Point(284, 250);
            BotonListar.Name = "BotonListar";
            BotonListar.Size = new Size(115, 49);
            BotonListar.TabIndex = 9;
            BotonListar.Text = "Listar";
            BotonListar.UseVisualStyleBackColor = false;
            // 
            // BotonModificar
            // 
            BotonModificar.BackColor = Color.DarkOrange;
            BotonModificar.ForeColor = Color.White;
            BotonModificar.Location = new Point(427, 250);
            BotonModificar.Name = "BotonModificar";
            BotonModificar.Size = new Size(115, 49);
            BotonModificar.TabIndex = 11;
            BotonModificar.Text = "Modificar";
            BotonModificar.UseVisualStyleBackColor = false;
            // 
            // BotonEliminar
            // 
            BotonEliminar.BackColor = Color.DarkOrange;
            BotonEliminar.ForeColor = Color.White;
            BotonEliminar.Location = new Point(568, 250);
            BotonEliminar.Name = "BotonEliminar";
            BotonEliminar.Size = new Size(115, 49);
            BotonEliminar.TabIndex = 12;
            BotonEliminar.Text = "Eliminar";
            BotonEliminar.UseVisualStyleBackColor = false;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(577, 360);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(75, 23);
            BotonVolver.TabIndex = 17;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            // 
            // MenuAdReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonVolver);
            Controls.Add(BotonEliminar);
            Controls.Add(BotonModificar);
            Controls.Add(BotonListar);
            Controls.Add(BotonAnadir);
            Controls.Add(Clientes);
            Controls.Add(pictureBox1);
            Name = "MenuAdReservas";
            Text = "MenuAdReservas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Clientes;
        private Button BotonAnadir;
        private Button BotonListar;
        private Button BotonModificar;
        private Button BotonEliminar;
        private Button BotonVolver;
    }
}