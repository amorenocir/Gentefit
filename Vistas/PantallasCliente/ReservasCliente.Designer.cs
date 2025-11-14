namespace Gentefit.Vistas
{
    partial class ReservasCliente
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
            pictureBox1 = new PictureBox();
            ImagenMensajes = new PictureBox();
            ImagenPerfil = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            PanelReservas = new DataGridView();
            BotonInicio = new Button();
            BotonActividades = new Button();
            BotonReservas = new Button();
            BotonHorarios = new Button();
            EtiquetaCliente = new Label();
            BotonCancelarReserva = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImagenMensajes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImagenPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PanelReservas).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Texto;
            pictureBox1.Location = new Point(316, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // ImagenMensajes
            // 
            ImagenMensajes.Image = Properties.Resources.Mensajes;
            ImagenMensajes.Location = new Point(499, 12);
            ImagenMensajes.Name = "ImagenMensajes";
            ImagenMensajes.Size = new Size(115, 88);
            ImagenMensajes.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenMensajes.TabIndex = 6;
            ImagenMensajes.TabStop = false;
            // 
            // ImagenPerfil
            // 
            ImagenPerfil.Image = Properties.Resources.Perfil;
            ImagenPerfil.Location = new Point(188, 17);
            ImagenPerfil.Name = "ImagenPerfil";
            ImagenPerfil.Size = new Size(106, 82);
            ImagenPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenPerfil.TabIndex = 5;
            ImagenPerfil.TabStop = false;
            ImagenPerfil.Click += ImagenPerfil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(343, 154);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 8;
            label1.Text = "RESERVAS";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 83);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 9;
            label2.Text = "HH:MM DD-MM-AA";
            // 
            // PanelReservas
            // 
            PanelReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelReservas.Location = new Point(135, 200);
            PanelReservas.Name = "PanelReservas";
            PanelReservas.Size = new Size(544, 215);
            PanelReservas.TabIndex = 10;
            // 
            // BotonInicio
            // 
            BotonInicio.BackColor = Color.DarkOrange;
            BotonInicio.Location = new Point(188, 105);
            BotonInicio.Name = "BotonInicio";
            BotonInicio.Size = new Size(87, 33);
            BotonInicio.TabIndex = 11;
            BotonInicio.Text = "Inicio";
            BotonInicio.UseVisualStyleBackColor = false;
            BotonInicio.Click += BotonInicio_Click;
            // 
            // BotonActividades
            // 
            BotonActividades.BackColor = Color.DarkOrange;
            BotonActividades.Location = new Point(305, 105);
            BotonActividades.Name = "BotonActividades";
            BotonActividades.Size = new Size(87, 33);
            BotonActividades.TabIndex = 12;
            BotonActividades.Text = "Actividades";
            BotonActividades.UseVisualStyleBackColor = false;
            BotonActividades.Click += BotonActividades_Click;
            // 
            // BotonReservas
            // 
            BotonReservas.BackColor = Color.Wheat;
            BotonReservas.Location = new Point(527, 105);
            BotonReservas.Name = "BotonReservas";
            BotonReservas.Size = new Size(87, 33);
            BotonReservas.TabIndex = 13;
            BotonReservas.Text = "Reservas";
            BotonReservas.UseVisualStyleBackColor = false;
            // 
            // BotonHorarios
            // 
            BotonHorarios.BackColor = Color.DarkOrange;
            BotonHorarios.Location = new Point(420, 105);
            BotonHorarios.Name = "BotonHorarios";
            BotonHorarios.Size = new Size(87, 33);
            BotonHorarios.TabIndex = 14;
            BotonHorarios.Text = "Horarios";
            BotonHorarios.UseVisualStyleBackColor = false;
            BotonHorarios.Click += BotonHorarios_Click;
            // 
            // EtiquetaCliente
            // 
            EtiquetaCliente.AutoSize = true;
            EtiquetaCliente.Location = new Point(106, 178);
            EtiquetaCliente.Name = "EtiquetaCliente";
            EtiquetaCliente.Size = new Size(0, 15);
            EtiquetaCliente.TabIndex = 15;
            // 
            // BotonCancelarReserva
            // 
            BotonCancelarReserva.BackColor = Color.DarkOrange;
            BotonCancelarReserva.Location = new Point(685, 373);
            BotonCancelarReserva.Name = "BotonCancelarReserva";
            BotonCancelarReserva.Size = new Size(87, 42);
            BotonCancelarReserva.TabIndex = 16;
            BotonCancelarReserva.Text = "Cancelar reserva";
            BotonCancelarReserva.UseVisualStyleBackColor = false;
            BotonCancelarReserva.Click += BotonCancelarReserva_Click;
            // 
            // ReservasCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonCancelarReserva);
            Controls.Add(EtiquetaCliente);
            Controls.Add(BotonHorarios);
            Controls.Add(BotonReservas);
            Controls.Add(BotonActividades);
            Controls.Add(BotonInicio);
            Controls.Add(PanelReservas);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(ImagenMensajes);
            Controls.Add(ImagenPerfil);
            ForeColor = SystemColors.ControlText;
            Name = "ReservasCliente";
            Text = "ReservasCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImagenMensajes).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImagenPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)PanelReservas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox ImagenMensajes;
        private PictureBox ImagenPerfil;
        private Label label1;
        private Label label2;
        private DataGridView PanelReservas;
        private Button BotonInicio;
        private Button BotonActividades;
        private Button BotonReservas;
        private Button BotonHorarios;
        private Label EtiquetaCliente;
        private Button BotonCancelarReserva;
    }
}