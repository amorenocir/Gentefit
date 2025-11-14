namespace Gentefit.Vistas
{
    partial class HorariosCliente
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
            BotonHorarios = new Button();
            BotonReservas = new Button();
            BotonActividades = new Button();
            BotonInicio = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ImagenMensajes = new PictureBox();
            ImagenPerfil = new PictureBox();
            PanelHorarios = new DataGridView();
            BotonReservar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImagenMensajes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImagenPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PanelHorarios).BeginInit();
            SuspendLayout();
            // 
            // BotonHorarios
            // 
            BotonHorarios.BackColor = Color.Wheat;
            BotonHorarios.Location = new Point(478, 140);
            BotonHorarios.Margin = new Padding(3, 4, 3, 4);
            BotonHorarios.Name = "BotonHorarios";
            BotonHorarios.Size = new Size(99, 44);
            BotonHorarios.TabIndex = 23;
            BotonHorarios.Text = "Horarios";
            BotonHorarios.UseVisualStyleBackColor = false;
            // 
            // BotonReservas
            // 
            BotonReservas.BackColor = Color.DarkOrange;
            BotonReservas.Location = new Point(600, 140);
            BotonReservas.Margin = new Padding(3, 4, 3, 4);
            BotonReservas.Name = "BotonReservas";
            BotonReservas.Size = new Size(99, 44);
            BotonReservas.TabIndex = 22;
            BotonReservas.Text = "Reservas";
            BotonReservas.UseVisualStyleBackColor = false;
            BotonReservas.Click += BotonReservas_Click;
            // 
            // BotonActividades
            // 
            BotonActividades.BackColor = Color.DarkOrange;
            BotonActividades.Location = new Point(346, 140);
            BotonActividades.Margin = new Padding(3, 4, 3, 4);
            BotonActividades.Name = "BotonActividades";
            BotonActividades.Size = new Size(99, 44);
            BotonActividades.TabIndex = 21;
            BotonActividades.Text = "Actividades";
            BotonActividades.UseVisualStyleBackColor = false;
            BotonActividades.Click += BotonActividades_Click;
            // 
            // BotonInicio
            // 
            BotonInicio.BackColor = Color.DarkOrange;
            BotonInicio.Location = new Point(213, 140);
            BotonInicio.Margin = new Padding(3, 4, 3, 4);
            BotonInicio.Name = "BotonInicio";
            BotonInicio.Size = new Size(99, 44);
            BotonInicio.TabIndex = 20;
            BotonInicio.Text = "Inicio";
            BotonInicio.UseVisualStyleBackColor = false;
            BotonInicio.Click += BotonInicio_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(386, 111);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 19;
            label2.Text = "HH:MM DD-MM-AA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(390, 205);
            label1.Name = "label1";
            label1.Size = new Size(157, 37);
            label1.TabIndex = 18;
            label1.Text = "HORARIOS";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Texto;
            pictureBox1.Location = new Point(359, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // ImagenMensajes
            // 
            ImagenMensajes.Image = Properties.Resources.Mensajes;
            ImagenMensajes.Location = new Point(568, 16);
            ImagenMensajes.Margin = new Padding(3, 4, 3, 4);
            ImagenMensajes.Name = "ImagenMensajes";
            ImagenMensajes.Size = new Size(131, 117);
            ImagenMensajes.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenMensajes.TabIndex = 16;
            ImagenMensajes.TabStop = false;
            // 
            // ImagenPerfil
            // 
            ImagenPerfil.Image = Properties.Resources.Perfil;
            ImagenPerfil.Location = new Point(213, 23);
            ImagenPerfil.Margin = new Padding(3, 4, 3, 4);
            ImagenPerfil.Name = "ImagenPerfil";
            ImagenPerfil.Size = new Size(121, 109);
            ImagenPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenPerfil.TabIndex = 15;
            ImagenPerfil.TabStop = false;
            ImagenPerfil.Click += ImagenPerfil_Click;
            // 
            // PanelHorarios
            // 
            PanelHorarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelHorarios.Location = new Point(81, 262);
            PanelHorarios.Margin = new Padding(3, 4, 3, 4);
            PanelHorarios.Name = "PanelHorarios";
            PanelHorarios.RowHeadersWidth = 51;
            PanelHorarios.Size = new Size(805, 383);
            PanelHorarios.TabIndex = 24;
            // 
            // BotonReservar
            // 
            BotonReservar.BackColor = Color.DarkOrange;
            BotonReservar.Location = new Point(892, 601);
            BotonReservar.Margin = new Padding(3, 4, 3, 4);
            BotonReservar.Name = "BotonReservar";
            BotonReservar.Size = new Size(77, 44);
            BotonReservar.TabIndex = 25;
            BotonReservar.Text = "Reservar";
            BotonReservar.UseVisualStyleBackColor = false;
            BotonReservar.Click += BotonReservar_Click;
            // 
            // HorariosCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 711);
            Controls.Add(BotonReservar);
            Controls.Add(PanelHorarios);
            Controls.Add(BotonHorarios);
            Controls.Add(BotonReservas);
            Controls.Add(BotonActividades);
            Controls.Add(BotonInicio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(ImagenMensajes);
            Controls.Add(ImagenPerfil);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HorariosCliente";
            Text = "Horarios";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImagenMensajes).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImagenPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)PanelHorarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonHorarios;
        private Button BotonReservas;
        private Button BotonActividades;
        private Button BotonInicio;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox ImagenMensajes;
        private PictureBox ImagenPerfil;
        private DataGridView PanelHorarios;
        private Button BotonReservar;
    }
}