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
            FlowLayoutPanel PanelFlow;
            BotonHorarios = new Button();
            BotonReservas = new Button();
            BotonActividades = new Button();
            BotonInicio = new Button();
            FechaHora = new Label();
            TituloActividades = new Label();
            pictureBox1 = new PictureBox();
            ImagenMensajes = new PictureBox();
            ImagenPerfil = new PictureBox();
            BotonVolver = new Button();
            PanelFlow = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImagenMensajes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImagenPerfil).BeginInit();
            SuspendLayout();
            // 
            // PanelFlow
            // 
            PanelFlow.AutoScroll = true;
            PanelFlow.Location = new Point(36, 200);
            PanelFlow.Margin = new Padding(3, 2, 3, 2);
            PanelFlow.Name = "PanelFlow";
            PanelFlow.Size = new Size(753, 218);
            PanelFlow.TabIndex = 0;
            PanelFlow.WrapContents = false;
            // 
            // BotonHorarios
            // 
            BotonHorarios.BackColor = Color.DarkOrange;
            BotonHorarios.Location = new Point(421, 105);
            BotonHorarios.Margin = new Padding(3, 2, 3, 2);
            BotonHorarios.Name = "BotonHorarios";
            BotonHorarios.Size = new Size(87, 33);
            BotonHorarios.TabIndex = 1;
            BotonHorarios.Text = "Horarios";
            BotonHorarios.UseVisualStyleBackColor = false;
            BotonHorarios.Click += BotonHorarios_Click;
            // 
            // BotonReservas
            // 
            BotonReservas.BackColor = Color.DarkOrange;
            BotonReservas.Location = new Point(528, 105);
            BotonReservas.Margin = new Padding(3, 2, 3, 2);
            BotonReservas.Name = "BotonReservas";
            BotonReservas.Size = new Size(87, 33);
            BotonReservas.TabIndex = 2;
            BotonReservas.Text = "Reservas";
            BotonReservas.UseVisualStyleBackColor = false;
            BotonReservas.Click += BotonReservas_Click;
            // 
            // BotonActividades
            // 
            BotonActividades.BackColor = Color.Wheat;
            BotonActividades.Location = new Point(306, 105);
            BotonActividades.Margin = new Padding(3, 2, 3, 2);
            BotonActividades.Name = "BotonActividades";
            BotonActividades.Size = new Size(87, 33);
            BotonActividades.TabIndex = 3;
            BotonActividades.Text = "Actividades";
            BotonActividades.UseVisualStyleBackColor = false;
            // 
            // BotonInicio
            // 
            BotonInicio.BackColor = Color.DarkOrange;
            BotonInicio.Location = new Point(189, 105);
            BotonInicio.Margin = new Padding(3, 2, 3, 2);
            BotonInicio.Name = "BotonInicio";
            BotonInicio.Size = new Size(87, 33);
            BotonInicio.TabIndex = 4;
            BotonInicio.Text = "Inicio";
            BotonInicio.UseVisualStyleBackColor = false;
            BotonInicio.Click += BotonInicio_Click;
            // 
            // FechaHora
            // 
            FechaHora.AutoSize = true;
            FechaHora.Location = new Point(341, 83);
            FechaHora.Name = "FechaHora";
            FechaHora.Size = new Size(117, 15);
            FechaHora.TabIndex = 5;
            FechaHora.Text = "HH:MM DD-MM-AA";
            // 
            // TituloActividades
            // 
            TituloActividades.AutoSize = true;
            TituloActividades.BackColor = Color.Transparent;
            TituloActividades.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            TituloActividades.Location = new Point(325, 154);
            TituloActividades.Name = "TituloActividades";
            TituloActividades.Size = new Size(155, 30);
            TituloActividades.TabIndex = 6;
            TituloActividades.Text = "ACTIVIDADES";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Texto;
            pictureBox1.Location = new Point(317, 12);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // ImagenMensajes
            // 
            ImagenMensajes.Image = Properties.Resources.Mensajes;
            ImagenMensajes.Location = new Point(500, 12);
            ImagenMensajes.Margin = new Padding(3, 2, 3, 2);
            ImagenMensajes.Name = "ImagenMensajes";
            ImagenMensajes.Size = new Size(115, 88);
            ImagenMensajes.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenMensajes.TabIndex = 8;
            ImagenMensajes.TabStop = false;
            // 
            // ImagenPerfil
            // 
            ImagenPerfil.Image = Properties.Resources.Perfil;
            ImagenPerfil.Location = new Point(189, 17);
            ImagenPerfil.Margin = new Padding(3, 2, 3, 2);
            ImagenPerfil.Name = "ImagenPerfil";
            ImagenPerfil.Size = new Size(106, 82);
            ImagenPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenPerfil.TabIndex = 9;
            ImagenPerfil.TabStop = false;
            ImagenPerfil.Click += ImagenPerfil_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(685, 115);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(75, 23);
            BotonVolver.TabIndex = 53;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // ActividadesCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(794, 450);
            Controls.Add(BotonVolver);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private Button BotonVolver;
    }
}

