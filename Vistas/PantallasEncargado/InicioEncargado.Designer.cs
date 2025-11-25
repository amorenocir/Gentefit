namespace Gentefit.Vistas.PantallasEncargado
{
    partial class InicioEncargado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioEncargado));
            BotonVerClientes = new Button();
            BotonVerReservas = new Button();
            label2 = new Label();
            label1 = new Label();
            ImagenMensajes = new PictureBox();
            ImagenPerfil = new PictureBox();
            pictureBox1 = new PictureBox();
            BotonVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)ImagenMensajes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImagenPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BotonVerClientes
            // 
            BotonVerClientes.BackColor = Color.DarkOrange;
            BotonVerClientes.ForeColor = Color.White;
            BotonVerClientes.Location = new Point(266, 227);
            BotonVerClientes.Name = "BotonVerClientes";
            BotonVerClientes.Size = new Size(113, 40);
            BotonVerClientes.TabIndex = 23;
            BotonVerClientes.Text = "Ver Clientes";
            BotonVerClientes.UseVisualStyleBackColor = false;
            BotonVerClientes.Click += BotonVerClientes_Click;
            // 
            // BotonVerReservas
            // 
            BotonVerReservas.BackColor = Color.DarkOrange;
            BotonVerReservas.ForeColor = Color.White;
            BotonVerReservas.Location = new Point(422, 227);
            BotonVerReservas.Name = "BotonVerReservas";
            BotonVerReservas.Size = new Size(113, 40);
            BotonVerReservas.TabIndex = 21;
            BotonVerReservas.Text = "Ver Reservas";
            BotonVerReservas.UseVisualStyleBackColor = false;
            BotonVerReservas.Click += BotonVerReservas_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 187);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 19;
            label2.Text = "HH:MM DD-MM-AA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(358, 157);
            label1.Name = "label1";
            label1.Size = new Size(82, 30);
            label1.TabIndex = 18;
            label1.Text = "INICIO";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ImagenMensajes
            // 
            ImagenMensajes.Image = Properties.Resources.Mensajes;
            ImagenMensajes.Location = new Point(538, 40);
            ImagenMensajes.Name = "ImagenMensajes";
            ImagenMensajes.Size = new Size(115, 88);
            ImagenMensajes.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenMensajes.TabIndex = 17;
            ImagenMensajes.TabStop = false;
            // 
            // ImagenPerfil
            // 
            ImagenPerfil.Image = Properties.Resources.Perfil;
            ImagenPerfil.Location = new Point(155, 40);
            ImagenPerfil.Name = "ImagenPerfil";
            ImagenPerfil.Size = new Size(106, 82);
            ImagenPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenPerfil.TabIndex = 16;
            ImagenPerfil.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(329, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(523, 331);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(75, 23);
            BotonVolver.TabIndex = 24;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // InicioEncargado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 425);
            Controls.Add(BotonVolver);
            Controls.Add(BotonVerClientes);
            Controls.Add(BotonVerReservas);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ImagenMensajes);
            Controls.Add(ImagenPerfil);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "InicioEncargado";
            Text = "MenuEncargado";
            ((System.ComponentModel.ISupportInitialize)ImagenMensajes).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImagenPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button BotonVerClientes;
        private Button BotonVerReservas;
        private Label label2;
        private Label label1;
        private PictureBox ImagenMensajes;
        private PictureBox ImagenPerfil;
        private PictureBox pictureBox1;
        private Button BotonVolver;
    }
}