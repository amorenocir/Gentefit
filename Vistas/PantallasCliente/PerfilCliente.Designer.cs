namespace Gentefit.Vistas.PantallasCliente
{
    partial class PerfilCliente
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
            label3 = new Label();
            BotonVolver = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label2 = new Label();
            Nombre = new Label();
            pictureBox1 = new PictureBox();
            IDCliente = new Label();
            NombreCliente = new Label();
            ApellidosCliente = new Label();
            DNICliente = new Label();
            EmailCliente = new Label();
            telefonoCliente = new Label();
            ContraseñaCliente = new Label();
            Botoneditar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 70);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 54;
            label3.Text = "ID";
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(591, 457);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(81, 45);
            BotonVolver.TabIndex = 53;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(149, 286);
            label9.Name = "label9";
            label9.Size = new Size(67, 20);
            label9.TabIndex = 50;
            label9.Text = "Teléfono";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(149, 391);
            label8.Name = "label8";
            label8.Size = new Size(83, 20);
            label8.TabIndex = 48;
            label8.Text = "Contraseña";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(149, 339);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 46;
            label7.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(148, 232);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 44;
            label5.Text = "DNI/NIE/Pasaporte";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 179);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 42;
            label2.Text = "Apellidos";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(149, 125);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(64, 20);
            Nombre.TabIndex = 40;
            Nombre.Text = "Nombre";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Perfil;
            pictureBox1.Location = new Point(389, 39);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 343);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // IDCliente
            // 
            IDCliente.AutoSize = true;
            IDCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            IDCliente.Location = new Point(148, 94);
            IDCliente.Name = "IDCliente";
            IDCliente.Size = new Size(73, 20);
            IDCliente.TabIndex = 55;
            IDCliente.Text = "IDCliente";
            // 
            // NombreCliente
            // 
            NombreCliente.AutoSize = true;
            NombreCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            NombreCliente.Location = new Point(149, 145);
            NombreCliente.Name = "NombreCliente";
            NombreCliente.Size = new Size(115, 20);
            NombreCliente.TabIndex = 56;
            NombreCliente.Text = "NombreCliente";
            // 
            // ApellidosCliente
            // 
            ApellidosCliente.AutoSize = true;
            ApellidosCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ApellidosCliente.Location = new Point(149, 199);
            ApellidosCliente.Name = "ApellidosCliente";
            ApellidosCliente.Size = new Size(122, 20);
            ApellidosCliente.TabIndex = 57;
            ApellidosCliente.Text = "ApellidosCliente";
            // 
            // DNICliente
            // 
            DNICliente.AutoSize = true;
            DNICliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DNICliente.Location = new Point(148, 252);
            DNICliente.Name = "DNICliente";
            DNICliente.Size = new Size(85, 20);
            DNICliente.TabIndex = 58;
            DNICliente.Text = "DNICliente";
            // 
            // EmailCliente
            // 
            EmailCliente.AutoSize = true;
            EmailCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EmailCliente.Location = new Point(149, 359);
            EmailCliente.Name = "EmailCliente";
            EmailCliente.Size = new Size(95, 20);
            EmailCliente.TabIndex = 59;
            EmailCliente.Text = "EmailCliente";
            // 
            // telefonoCliente
            // 
            telefonoCliente.AutoSize = true;
            telefonoCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            telefonoCliente.Location = new Point(149, 306);
            telefonoCliente.Name = "telefonoCliente";
            telefonoCliente.Size = new Size(118, 20);
            telefonoCliente.TabIndex = 60;
            telefonoCliente.Text = "TeléfonoCliente";
            // 
            // ContraseñaCliente
            // 
            ContraseñaCliente.AutoSize = true;
            ContraseñaCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ContraseñaCliente.Location = new Point(148, 411);
            ContraseñaCliente.Name = "ContraseñaCliente";
            ContraseñaCliente.Size = new Size(136, 20);
            ContraseñaCliente.TabIndex = 61;
            ContraseñaCliente.Text = "ContraseñaCliente";
            // 
            // Botoneditar
            // 
            Botoneditar.BackColor = Color.DarkOrange;
            Botoneditar.Location = new Point(493, 457);
            Botoneditar.Margin = new Padding(3, 4, 3, 4);
            Botoneditar.Name = "Botoneditar";
            Botoneditar.Size = new Size(81, 45);
            Botoneditar.TabIndex = 62;
            Botoneditar.Text = "Editar";
            Botoneditar.UseVisualStyleBackColor = false;
            Botoneditar.Click += BotonEditar_Click;
            // 
            // PerfilCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 529);
            Controls.Add(Botoneditar);
            Controls.Add(ContraseñaCliente);
            Controls.Add(telefonoCliente);
            Controls.Add(EmailCliente);
            Controls.Add(DNICliente);
            Controls.Add(ApellidosCliente);
            Controls.Add(NombreCliente);
            Controls.Add(IDCliente);
            Controls.Add(label3);
            Controls.Add(BotonVolver);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(Nombre);
            Controls.Add(pictureBox1);
            Name = "PerfilCliente";
            Text = "PerfilCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Button BotonVolver;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label2;
        private Label Nombre;
        private PictureBox pictureBox1;
        private Label IDCliente;
        private Label NombreCliente;
        private Label ApellidosCliente;
        private Label DNICliente;
        private Label EmailCliente;
        private Label telefonoCliente;
        private Label ContraseñaCliente;
        private Button Botoneditar;
    }
}