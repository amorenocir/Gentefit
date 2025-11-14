namespace Gentefit.Vistas
{
    partial class ActividadesCliente
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            PanelFlow = new FlowLayoutPanel();
            BotonHorarios = new Button();
            BotonReservas = new Button();
            BotonActividades = new Button();
            BotonInicio = new Button();
            FechaHora = new Label();
            TituloActividades = new Label();
            pictureBox1 = new PictureBox();
            ImagenMensajes = new PictureBox();
            ImagenPerfil = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImagenMensajes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImagenPerfil).BeginInit();
            SuspendLayout();
            // 
            // BotonHorarios
            // 
            BotonHorarios.BackColor = Color.DarkOrange;
            BotonHorarios.Location = new Point(481, 140);
            BotonHorarios.Name = "BotonHorarios";
            BotonHorarios.Size = new Size(99, 44);
            BotonHorarios.TabIndex = 1;
            BotonHorarios.Text = "Horarios";
            BotonHorarios.UseVisualStyleBackColor = false;
            BotonHorarios.Click += BotonHorarios_Click;
            // 
            // BotonReservas
            // 
            BotonReservas.BackColor = Color.DarkOrange;
            BotonReservas.Location = new Point(603, 140);
            BotonReservas.Name = "BotonReservas";
            BotonReservas.Size = new Size(99, 44);
            BotonReservas.TabIndex = 2;
            BotonReservas.Text = "Reservas";
            BotonReservas.UseVisualStyleBackColor = false;
            BotonReservas.Click += BotonReservas_Click;
            // 
            // BotonActividades
            // 
            BotonActividades.BackColor = Color.Wheat;
            BotonActividades.Location = new Point(350, 140);
            BotonActividades.Name = "BotonActividades";
            BotonActividades.Size = new Size(99, 44);
            BotonActividades.TabIndex = 3;
            BotonActividades.Text = "Actividades";
            BotonActividades.UseVisualStyleBackColor = false;
            // 
            // BotonInicio
            // 
            BotonInicio.BackColor = Color.DarkOrange;
            BotonInicio.Location = new Point(216, 140);
            BotonInicio.Name = "BotonInicio";
            BotonInicio.Size = new Size(99, 44);
            BotonInicio.TabIndex = 4;
            BotonInicio.Text = "Inicio";
            BotonInicio.UseVisualStyleBackColor = false;
            BotonInicio.Click += BotonInicio_Click;
            // 
            // FechaHora
            // 
            FechaHora.AutoSize = true;
            FechaHora.Location = new Point(390, 111);
            FechaHora.Name = "FechaHora";
            FechaHora.Size = new Size(144, 20);
            FechaHora.TabIndex = 5;
            FechaHora.Text = "HH:MM DD-MM-AA";
            // 
            // TituloActividades
            // 
            TituloActividades.AutoSize = true;
            TituloActividades.BackColor = Color.Transparent;
            TituloActividades.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            TituloActividades.Location = new Point(371, 205);
            TituloActividades.Name = "TituloActividades";
            TituloActividades.Size = new Size(193, 37);
            TituloActividades.TabIndex = 6;
            TituloActividades.Text = "ACTIVIDADES";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Texto;
            pictureBox1.Location = new Point(362, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // ImagenMensajes
            // 
            ImagenMensajes.Image = Properties.Resources.Mensajes;
            ImagenMensajes.Location = new Point(571, 16);
            ImagenMensajes.Name = "ImagenMensajes";
            ImagenMensajes.Size = new Size(131, 117);
            ImagenMensajes.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenMensajes.TabIndex = 8;
            ImagenMensajes.TabStop = false;
            // 
            // ImagenPerfil
            // 
            ImagenPerfil.Image = Properties.Resources.Perfil;
            ImagenPerfil.Location = new Point(216, 23);
            ImagenPerfil.Name = "ImagenPerfil";
            ImagenPerfil.Size = new Size(121, 109);
            ImagenPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenPerfil.TabIndex = 9;
            ImagenPerfil.TabStop = false;
            ImagenPerfil.Click += ImagenPerfil_Click;
            // 
            // PanelFlow
            // 
            PanelFlow.AutoScroll = true;
            PanelFlow.Location = new Point(41, 267);
            PanelFlow.Name = "PanelFlow";
            PanelFlow.Size = new Size(861, 291);
            PanelFlow.TabIndex = 0;
            PanelFlow.WrapContents = false;
            // 
            // ActividadesCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(908, 600);
            Controls.Add(PanelFlow);
            Controls.Add(BotonHorarios);
            Controls.Add(BotonReservas);
            Controls.Add(BotonActividades);
            Controls.Add(BotonInicio);
            Controls.Add(FechaHora);
            Controls.Add(TituloActividades);
            Controls.Add(pictureBox1);
            Controls.Add(ImagenMensajes);
            Controls.Add(ImagenPerfil);
            Name = "ActividadesCliente";
            Text = "ActividadesCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImagenMensajes).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImagenPerfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button BotonHorarios;
        private System.Windows.Forms.Button BotonReservas;
        private System.Windows.Forms.Button BotonActividades;
        private System.Windows.Forms.Button BotonInicio;
        private System.Windows.Forms.Label FechaHora;
        private System.Windows.Forms.Label TituloActividades;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ImagenMensajes;
        private System.Windows.Forms.PictureBox ImagenPerfil;
        private System.Windows.Forms.FlowLayoutPanel PanelFlow;
    }
}

