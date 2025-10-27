namespace Gentefit.Vistas
{
    partial class Login
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
            BotonEntrar = new Button();
            CajaTextoContrasena = new TextBox();
            TextoContraseña = new Label();
            TextoEmail = new Label();
            CajaTextoEmail = new TextBox();
            Logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // BotonEntrar
            // 
            BotonEntrar.BackColor = Color.DarkOrange;
            BotonEntrar.FlatStyle = FlatStyle.Popup;
            BotonEntrar.ForeColor = Color.White;
            BotonEntrar.Location = new Point(514, 340);
            BotonEntrar.Name = "BotonEntrar";
            BotonEntrar.Size = new Size(89, 38);
            BotonEntrar.TabIndex = 0;
            BotonEntrar.Text = "Entrar";
            BotonEntrar.UseVisualStyleBackColor = false;
            BotonEntrar.UseWaitCursor = true;
            BotonEntrar.Click += BotonEntrar_Click;
            // 
            // CajaTextoContrasena
            // 
            CajaTextoContrasena.BackColor = SystemColors.Menu;
            CajaTextoContrasena.Location = new Point(294, 258);
            CajaTextoContrasena.Name = "CajaTextoContrasena";
            CajaTextoContrasena.PasswordChar = '*';
            CajaTextoContrasena.Size = new Size(218, 23);
            CajaTextoContrasena.TabIndex = 1;
            // 
            // TextoContraseña
            // 
            TextoContraseña.AutoSize = true;
            TextoContraseña.BackColor = Color.White;
            TextoContraseña.Location = new Point(294, 235);
            TextoContraseña.Name = "TextoContraseña";
            TextoContraseña.Size = new Size(67, 15);
            TextoContraseña.TabIndex = 2;
            TextoContraseña.Text = "Contraseña";
            // 
            // TextoEmail
            // 
            TextoEmail.AutoSize = true;
            TextoEmail.BackColor = Color.White;
            TextoEmail.Location = new Point(294, 174);
            TextoEmail.Name = "TextoEmail";
            TextoEmail.Size = new Size(36, 15);
            TextoEmail.TabIndex = 4;
            TextoEmail.Text = "Email";
            // 
            // CajaTextoEmail
            // 
            CajaTextoEmail.BackColor = SystemColors.Menu;
            CajaTextoEmail.Location = new Point(294, 197);
            CajaTextoEmail.Name = "CajaTextoEmail";
            CajaTextoEmail.Size = new Size(218, 23);
            CajaTextoEmail.TabIndex = 3;
            // 
            // Logo
            // 
            Logo.BackColor = Color.White;
            Logo.Image = Properties.Resources.LogoTexto;
            Logo.Location = new Point(326, 62);
            Logo.Name = "Logo";
            Logo.Size = new Size(155, 99);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 5;
            Logo.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(794, 446);
            Controls.Add(Logo);
            Controls.Add(TextoEmail);
            Controls.Add(CajaTextoEmail);
            Controls.Add(TextoContraseña);
            Controls.Add(CajaTextoContrasena);
            Controls.Add(BotonEntrar);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonEntrar;
        private TextBox CajaTextoContrasena;
        private Label TextoContraseña;
        private Label TextoEmail;
        private TextBox CajaTextoEmail;
        private PictureBox Logo;
    }
}