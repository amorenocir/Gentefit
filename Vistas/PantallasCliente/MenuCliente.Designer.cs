namespace Gentefit.Vistas
{
    partial class MenuCliente
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
            ImagenPerfil = new PictureBox();
            ImagenMensajes = new PictureBox();
            pictureBox1 = new PictureBox();
            FechaYHora = new Label();
            label1 = new Label();
            BotonSalir = new Button();
            BotonHorarios = new Button();
            BotonReservas = new Button();
            BotonActividades = new Button();
            BotonInicio = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)ImagenPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImagenMensajes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ImagenPerfil
            // 
            ImagenPerfil.Image = Properties.Resources.Perfil;
            ImagenPerfil.Location = new Point(190, 17);
            ImagenPerfil.Name = "ImagenPerfil";
            ImagenPerfil.Size = new Size(106, 82);
            ImagenPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenPerfil.TabIndex = 2;
            ImagenPerfil.TabStop = false;
            // 
            // ImagenMensajes
            // 
            ImagenMensajes.Image = Properties.Resources.Mensajes;
            ImagenMensajes.Location = new Point(501, 12);
            ImagenMensajes.Name = "ImagenMensajes";
            ImagenMensajes.Size = new Size(115, 88);
            ImagenMensajes.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenMensajes.TabIndex = 3;
            ImagenMensajes.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Texto;
            pictureBox1.Location = new Point(318, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FechaYHora
            // 
            FechaYHora.AutoSize = true;
            FechaYHora.Location = new Point(344, 84);
            FechaYHora.Name = "FechaYHora";
            FechaYHora.Size = new Size(117, 15);
            FechaYHora.TabIndex = 5;
            FechaYHora.Text = "HH:MM DD-MM-AA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(368, 160);
            label1.Name = "label1";
            label1.Size = new Size(82, 30);
            label1.TabIndex = 6;
            label1.Text = "INICIO";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BotonSalir
            // 
            BotonSalir.Location = new Point(541, 359);
            BotonSalir.Name = "BotonSalir";
            BotonSalir.Size = new Size(75, 23);
            BotonSalir.TabIndex = 14;
            BotonSalir.Text = "Salir";
            BotonSalir.UseVisualStyleBackColor = true;
            BotonSalir.Click += BotonSalir_Click;
            // 
            // BotonHorarios
            // 
            BotonHorarios.BackColor = Color.DarkOrange;
            BotonHorarios.Location = new Point(422, 106);
            BotonHorarios.Name = "BotonHorarios";
            BotonHorarios.Size = new Size(87, 33);
            BotonHorarios.TabIndex = 27;
            BotonHorarios.Text = "Horarios";
            BotonHorarios.UseVisualStyleBackColor = false;
            BotonHorarios.Click += BotonHorarios_Click;
            // 
            // BotonReservas
            // 
            BotonReservas.BackColor = Color.DarkOrange;
            BotonReservas.Location = new Point(529, 106);
            BotonReservas.Name = "BotonReservas";
            BotonReservas.Size = new Size(87, 33);
            BotonReservas.TabIndex = 26;
            BotonReservas.Text = "Reservas";
            BotonReservas.UseVisualStyleBackColor = false;
            BotonReservas.Click += BotonReservas_Click;
            // 
            // BotonActividades
            // 
            BotonActividades.BackColor = Color.DarkOrange;
            BotonActividades.Location = new Point(307, 106);
            BotonActividades.Name = "BotonActividades";
            BotonActividades.Size = new Size(87, 33);
            BotonActividades.TabIndex = 25;
            BotonActividades.Text = "Actividades";
            BotonActividades.UseVisualStyleBackColor = false;
            BotonActividades.Click += BotonActividades_Click;
            // 
            // BotonInicio
            // 
            BotonInicio.BackColor = Color.Wheat;
            BotonInicio.Location = new Point(190, 106);
            BotonInicio.Name = "BotonInicio";
            BotonInicio.Size = new Size(87, 33);
            BotonInicio.TabIndex = 24;
            BotonInicio.Text = "Inicio";
            BotonInicio.UseVisualStyleBackColor = false;
            // 
            // MenuCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonHorarios);
            Controls.Add(BotonReservas);
            Controls.Add(BotonActividades);
            Controls.Add(BotonInicio);
            Controls.Add(BotonSalir);
            Controls.Add(label1);
            Controls.Add(FechaYHora);
            Controls.Add(pictureBox1);
            Controls.Add(ImagenMensajes);
            Controls.Add(ImagenPerfil);
            Name = "MenuCliente";
            Text = "MenuCliente";
            ((System.ComponentModel.ISupportInitialize)ImagenPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImagenMensajes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ImagenPerfil;
        private PictureBox ImagenMensajes;
        private PictureBox pictureBox1;
        private Label FechaYHora;
        private Label label1;
        private Button BotonSalir;
        private Button BotonHorarios;
        private Button BotonReservas;
        private Button BotonActividades;
        private Button BotonInicio;
        private System.Windows.Forms.Timer timer2;
    }
}