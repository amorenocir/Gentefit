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
            this.BotonHorarios = new System.Windows.Forms.Button();
            this.BotonReservas = new System.Windows.Forms.Button();
            this.BotonActividades = new System.Windows.Forms.Button();
            this.BotonInicio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ImagenMensajes = new System.Windows.Forms.PictureBox();
            this.ImagenPerfil = new System.Windows.Forms.PictureBox();
            this.PanelFlow = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenMensajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonHorarios
            // 
            this.BotonHorarios.BackColor = System.Drawing.Color.DarkOrange;
            this.BotonHorarios.Location = new System.Drawing.Point(481, 140);
            this.BotonHorarios.Name = "BotonHorarios";
            this.BotonHorarios.Size = new System.Drawing.Size(99, 44);
            this.BotonHorarios.Text = "Horarios";
            this.BotonHorarios.UseVisualStyleBackColor = false;
            this.BotonHorarios.Click += new System.EventHandler(this.BotonHorarios_Click);
            // 
            // BotonReservas
            // 
            this.BotonReservas.BackColor = System.Drawing.Color.DarkOrange;
            this.BotonReservas.Location = new System.Drawing.Point(603, 140);
            this.BotonReservas.Name = "BotonReservas";
            this.BotonReservas.Size = new System.Drawing.Size(99, 44);
            this.BotonReservas.Text = "Reservas";
            this.BotonReservas.UseVisualStyleBackColor = false;
            this.BotonReservas.Click += new System.EventHandler(this.BotonReservas_Click);
            // 
            // BotonActividades
            // 
            this.BotonActividades.BackColor = System.Drawing.Color.Wheat;
            this.BotonActividades.Location = new System.Drawing.Point(350, 140);
            this.BotonActividades.Name = "BotonActividades";
            this.BotonActividades.Size = new System.Drawing.Size(99, 44);
            this.BotonActividades.Text = "Actividades";
            this.BotonActividades.UseVisualStyleBackColor = false;
            // 
            // BotonInicio
            // 
            this.BotonInicio.BackColor = System.Drawing.Color.DarkOrange;
            this.BotonInicio.Location = new System.Drawing.Point(216, 140);
            this.BotonInicio.Name = "BotonInicio";
            this.BotonInicio.Size = new System.Drawing.Size(99, 44);
            this.BotonInicio.Text = "Inicio";
            this.BotonInicio.UseVisualStyleBackColor = false;
            this.BotonInicio.Click += new System.EventHandler(this.BotonInicio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 111);
            this.label2.Text = "HH:MM DD-MM-AA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(371, 205);
            this.label1.Text = "ACTIVIDADES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gentefit.Properties.Resources.Texto;
            this.pictureBox1.Location = new System.Drawing.Point(362, 16);
            this.pictureBox1.Size = new System.Drawing.Size(186, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabStop = false;
            // 
            // ImagenMensajes
            // 
            this.ImagenMensajes.Image = global::Gentefit.Properties.Resources.Mensajes;
            this.ImagenMensajes.Location = new System.Drawing.Point(571, 16);
            this.ImagenMensajes.Size = new System.Drawing.Size(131, 117);
            this.ImagenMensajes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagenMensajes.TabStop = false;
            // 
            // ImagenPerfil
            // 
            this.ImagenPerfil.Image = global::Gentefit.Properties.Resources.Perfil;
            this.ImagenPerfil.Location = new System.Drawing.Point(216, 23);
            this.ImagenPerfil.Size = new System.Drawing.Size(121, 109);
            this.ImagenPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagenPerfil.TabStop = false;
            // 
            // PanelFlow
            // 
            this.PanelFlow.AutoScroll = true;
            this.PanelFlow.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight; // horizontal
            this.PanelFlow.WrapContents = false;
            this.PanelFlow.Location = new System.Drawing.Point(41, 267);
            this.PanelFlow.Size = new System.Drawing.Size(861, 291);
            this.PanelFlow.Name = "PanelFlow";
            // 
            // ActividadesCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 600);
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PanelFlow);
            this.Controls.Add(this.BotonHorarios);
            this.Controls.Add(this.BotonReservas);
            this.Controls.Add(this.BotonActividades);
            this.Controls.Add(this.BotonInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ImagenMensajes);
            this.Controls.Add(this.ImagenPerfil);
            this.Name = "ActividadesCliente";
            this.Text = "ActividadesCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenMensajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button BotonHorarios;
        private System.Windows.Forms.Button BotonReservas;
        private System.Windows.Forms.Button BotonActividades;
        private System.Windows.Forms.Button BotonInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ImagenMensajes;
        private System.Windows.Forms.PictureBox ImagenPerfil;
        private System.Windows.Forms.FlowLayoutPanel PanelFlow;
    }
}

