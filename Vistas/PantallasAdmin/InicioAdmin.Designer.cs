namespace Gentefit.Vistas.PantallasAdmin
{
    partial class InicioAdmin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioAdmin));
            pictureBox1 = new PictureBox();
            ImagenPerfil = new PictureBox();
            ImagenMensajes = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            BotonActividades = new Button();
            BotonReservas = new Button();
            BotonMonitores = new Button();
            BotonClientes = new Button();
            BotonUsuarios = new Button();
            BotonVolver = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImagenPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImagenMensajes).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(341, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ImagenPerfil
            // 
            ImagenPerfil.Image = Properties.Resources.Perfil;
            ImagenPerfil.Location = new Point(172, 22);
            ImagenPerfil.Name = "ImagenPerfil";
            ImagenPerfil.Size = new Size(106, 82);
            ImagenPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenPerfil.TabIndex = 1;
            ImagenPerfil.TabStop = false;
            // 
            // ImagenMensajes
            // 
            ImagenMensajes.Image = Properties.Resources.Mensajes;
            ImagenMensajes.Location = new Point(556, 22);
            ImagenMensajes.Name = "ImagenMensajes";
            ImagenMensajes.Size = new Size(115, 88);
            ImagenMensajes.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenMensajes.TabIndex = 2;
            ImagenMensajes.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(375, 138);
            label1.Name = "label1";
            label1.Size = new Size(82, 30);
            label1.TabIndex = 3;
            label1.Text = "INICIO";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 168);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 4;
            label2.Text = "HH:MM DD-MM-AA";
            // 
            // BotonActividades
            // 
            BotonActividades.BackColor = Color.DarkOrange;
            BotonActividades.ForeColor = Color.White;
            BotonActividades.Location = new Point(99, 228);
            BotonActividades.Name = "BotonActividades";
            BotonActividades.Size = new Size(113, 40);
            BotonActividades.TabIndex = 5;
            BotonActividades.Text = "Actividades";
            BotonActividades.UseVisualStyleBackColor = false;
            BotonActividades.Click += BotonActividades_Click;
            // 
            // BotonReservas
            // 
            BotonReservas.BackColor = Color.DarkOrange;
            BotonReservas.ForeColor = Color.White;
            BotonReservas.Location = new Point(231, 228);
            BotonReservas.Name = "BotonReservas";
            BotonReservas.Size = new Size(113, 40);
            BotonReservas.TabIndex = 6;
            BotonReservas.Text = "Reservas";
            BotonReservas.UseVisualStyleBackColor = false;
            BotonReservas.Click += BotonReservas_Click;
            // 
            // BotonMonitores
            // 
            BotonMonitores.BackColor = Color.DarkOrange;
            BotonMonitores.ForeColor = Color.White;
            BotonMonitores.Location = new Point(360, 228);
            BotonMonitores.Name = "BotonMonitores";
            BotonMonitores.Size = new Size(113, 40);
            BotonMonitores.TabIndex = 7;
            BotonMonitores.Text = "Monitores";
            BotonMonitores.UseVisualStyleBackColor = false;
            BotonMonitores.Click += BotonMonitores_Click;
            // 
            // BotonClientes
            // 
            BotonClientes.BackColor = Color.DarkOrange;
            BotonClientes.ForeColor = Color.White;
            BotonClientes.Location = new Point(493, 228);
            BotonClientes.Name = "BotonClientes";
            BotonClientes.Size = new Size(113, 40);
            BotonClientes.TabIndex = 8;
            BotonClientes.Text = "Clientes";
            BotonClientes.UseVisualStyleBackColor = false;
            BotonClientes.Click += BotonClientes_Click;
            // 
            // BotonUsuarios
            // 
            BotonUsuarios.BackColor = Color.DarkOrange;
            BotonUsuarios.ForeColor = Color.White;
            BotonUsuarios.Location = new Point(624, 228);
            BotonUsuarios.Name = "BotonUsuarios";
            BotonUsuarios.Size = new Size(113, 40);
            BotonUsuarios.TabIndex = 9;
            BotonUsuarios.Text = "Usuarios";
            BotonUsuarios.UseVisualStyleBackColor = false;
            BotonUsuarios.Click += BotonUsuarios_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(662, 373);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(75, 23);
            BotonVolver.TabIndex = 13;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // MenuAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonVolver);
            Controls.Add(BotonUsuarios);
            Controls.Add(BotonClientes);
            Controls.Add(BotonMonitores);
            Controls.Add(BotonReservas);
            Controls.Add(BotonActividades);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ImagenMensajes);
            Controls.Add(ImagenPerfil);
            Controls.Add(pictureBox1);
            Name = "MenuAdmin";
            Text = "MenuAdmin";
            Load += timer1_Tick;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImagenPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImagenMensajes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox ImagenPerfil;
        private PictureBox ImagenMensajes;
        private Label label1;
        private Label label2;
        private Button BotonActividades;
        private Button BotonReservas;
        private Button BotonMonitores;
        private Button BotonClientes;
        private Button BotonUsuarios;
        private Button BotonVolver;
        private System.Windows.Forms.Timer timer1;
    }
}