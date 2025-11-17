namespace Gentefit.Vistas.PantallasAdmin
{
    partial class InicioAdmin
    {
        private System.ComponentModel.IContainer components = null;

       protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioAdmin));
            LogoAdmin = new PictureBox();
            ImagenPerfil = new PictureBox();
            ImagenMensajes = new PictureBox();
            Inicio = new Label();
            FechaHora = new Label();
            BotonActividades = new Button();
            BotonReservas = new Button();
            BotonEntrenadores = new Button();
            BotonClientes = new Button();
            BotonUsuarios = new Button();
            BotonVolver = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            BotonClases = new Button();
            BotonSalas = new Button();
            ((System.ComponentModel.ISupportInitialize)LogoAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImagenPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImagenMensajes).BeginInit();
            SuspendLayout();
            // 
            // LogoAdmin
            // 
            LogoAdmin.Image = (Image)resources.GetObject("LogoAdmin.Image");
            LogoAdmin.Location = new Point(390, 29);
            LogoAdmin.Margin = new Padding(3, 4, 3, 4);
            LogoAdmin.Name = "LogoAdmin";
            LogoAdmin.Size = new Size(167, 113);
            LogoAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            LogoAdmin.TabIndex = 0;
            LogoAdmin.TabStop = false;
            // 
            // ImagenPerfil
            // 
            ImagenPerfil.Image = Properties.Resources.Perfil;
            ImagenPerfil.Location = new Point(197, 29);
            ImagenPerfil.Margin = new Padding(3, 4, 3, 4);
            ImagenPerfil.Name = "ImagenPerfil";
            ImagenPerfil.Size = new Size(121, 109);
            ImagenPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenPerfil.TabIndex = 1;
            ImagenPerfil.TabStop = false;
            // 
            // ImagenMensajes
            // 
            ImagenMensajes.Image = Properties.Resources.Mensajes;
            ImagenMensajes.Location = new Point(635, 29);
            ImagenMensajes.Margin = new Padding(3, 4, 3, 4);
            ImagenMensajes.Name = "ImagenMensajes";
            ImagenMensajes.Size = new Size(131, 117);
            ImagenMensajes.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenMensajes.TabIndex = 2;
            ImagenMensajes.TabStop = false;
            // 
            // Inicio
            // 
            Inicio.AutoSize = true;
            Inicio.BackColor = Color.Transparent;
            Inicio.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            Inicio.ForeColor = SystemColors.ControlText;
            Inicio.Location = new Point(429, 184);
            Inicio.Name = "Inicio";
            Inicio.Size = new Size(102, 37);
            Inicio.TabIndex = 3;
            Inicio.Text = "INICIO";
            Inicio.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FechaHora
            // 
            FechaHora.AutoSize = true;
            FechaHora.Location = new Point(407, 224);
            FechaHora.Name = "FechaHora";
            FechaHora.Size = new Size(144, 20);
            FechaHora.TabIndex = 4;
            FechaHora.Text = "HH:MM DD-MM-AA";
            // 
            // BotonActividades
            // 
            BotonActividades.BackColor = Color.DarkOrange;
            BotonActividades.ForeColor = Color.White;
            BotonActividades.Location = new Point(174, 281);
            BotonActividades.Margin = new Padding(3, 4, 3, 4);
            BotonActividades.Name = "BotonActividades";
            BotonActividades.Size = new Size(129, 53);
            BotonActividades.TabIndex = 5;
            BotonActividades.Text = "Actividades";
            BotonActividades.UseVisualStyleBackColor = false;
            BotonActividades.Click += BotonActividades_Click;
            // 
            // BotonReservas
            // 
            BotonReservas.BackColor = Color.DarkOrange;
            BotonReservas.ForeColor = Color.White;
            BotonReservas.Location = new Point(485, 281);
            BotonReservas.Margin = new Padding(3, 4, 3, 4);
            BotonReservas.Name = "BotonReservas";
            BotonReservas.Size = new Size(129, 53);
            BotonReservas.TabIndex = 6;
            BotonReservas.Text = "Reservas";
            BotonReservas.UseVisualStyleBackColor = false;
            BotonReservas.Click += BotonReservas_Click;
            // 
            // BotonEntrenadores
            // 
            BotonEntrenadores.AllowDrop = true;
            BotonEntrenadores.BackColor = Color.DarkOrange;
            BotonEntrenadores.ForeColor = Color.White;
            BotonEntrenadores.Location = new Point(556, 355);
            BotonEntrenadores.Margin = new Padding(3, 4, 3, 4);
            BotonEntrenadores.Name = "BotonEntrenadores";
            BotonEntrenadores.RightToLeft = RightToLeft.Yes;
            BotonEntrenadores.Size = new Size(129, 53);
            BotonEntrenadores.TabIndex = 7;
            BotonEntrenadores.Text = "Entrenadores";
            BotonEntrenadores.UseVisualStyleBackColor = false;
            BotonEntrenadores.Click += BotonEntrenadores_Click;
            // 
            // BotonClientes
            // 
            BotonClientes.BackColor = Color.DarkOrange;
            BotonClientes.ForeColor = Color.White;
            BotonClientes.Location = new Point(245, 355);
            BotonClientes.Margin = new Padding(3, 4, 3, 4);
            BotonClientes.Name = "BotonClientes";
            BotonClientes.Size = new Size(129, 53);
            BotonClientes.TabIndex = 8;
            BotonClientes.Text = "Clientes";
            BotonClientes.UseVisualStyleBackColor = false;
            BotonClientes.Click += BotonClientes_Click;
            // 
            // BotonUsuarios
            // 
            BotonUsuarios.BackColor = Color.DarkOrange;
            BotonUsuarios.ForeColor = Color.White;
            BotonUsuarios.Location = new Point(402, 355);
            BotonUsuarios.Margin = new Padding(3, 4, 3, 4);
            BotonUsuarios.Name = "BotonUsuarios";
            BotonUsuarios.Size = new Size(129, 53);
            BotonUsuarios.TabIndex = 9;
            BotonUsuarios.Text = "Usuarios";
            BotonUsuarios.UseVisualStyleBackColor = false;
            BotonUsuarios.Click += BotonUsuarios_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(757, 497);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(86, 31);
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
            // BotonClases
            // 
            BotonClases.BackColor = Color.DarkOrange;
            BotonClases.ForeColor = Color.White;
            BotonClases.Location = new Point(331, 281);
            BotonClases.Margin = new Padding(3, 4, 3, 4);
            BotonClases.Name = "BotonClases";
            BotonClases.Size = new Size(129, 53);
            BotonClases.TabIndex = 14;
            BotonClases.Text = "Clases";
            BotonClases.UseVisualStyleBackColor = false;
            BotonClases.Click += BotonClases_Click;
            // 
            // BotonSalas
            // 
            BotonSalas.BackColor = Color.DarkOrange;
            BotonSalas.ForeColor = Color.White;
            BotonSalas.Location = new Point(634, 281);
            BotonSalas.Margin = new Padding(3, 4, 3, 4);
            BotonSalas.Name = "BotonSalas";
            BotonSalas.Size = new Size(129, 53);
            BotonSalas.TabIndex = 15;
            BotonSalas.Text = "Salas";
            BotonSalas.UseVisualStyleBackColor = false;
            BotonSalas.Click += BotonSalas_Click;
            // 
            // InicioAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(914, 600);
            Controls.Add(BotonSalas);
            Controls.Add(BotonClases);
            Controls.Add(BotonVolver);
            Controls.Add(BotonUsuarios);
            Controls.Add(BotonClientes);
            Controls.Add(BotonEntrenadores);
            Controls.Add(BotonReservas);
            Controls.Add(BotonActividades);
            Controls.Add(FechaHora);
            Controls.Add(Inicio);
            Controls.Add(ImagenMensajes);
            Controls.Add(ImagenPerfil);
            Controls.Add(LogoAdmin);
            Margin = new Padding(3, 4, 3, 4);
            Name = "InicioAdmin";
            Text = "MenuAdmin";
            Load += timer1_Tick;
            ((System.ComponentModel.ISupportInitialize)LogoAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImagenPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImagenMensajes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox LogoAdmin;
        private PictureBox ImagenPerfil;
        private PictureBox ImagenMensajes;
        private Label Inicio;
        private Label FechaHora;
        private Button BotonActividades;
        private Button BotonReservas;
        private Button BotonEntrenadores;
        private Button BotonClientes;
        private Button BotonUsuarios;
        private Button BotonVolver;
        private System.Windows.Forms.Timer timer1;
        private Button BotonClases;
        private Button BotonSalas;
    }
}