namespace Gentefit.Test
{
    partial class TestValidacionesUsuario
    {
        private System.ComponentModel.IContainer components = null;

        private Button btnValidarEmail;
        private Button btnValidarContrasena;
        private Button btnValidarNombre;
        private Button btnValidarRol;
        private Button btnValidarCompleto;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnValidarEmail = new Button();
            btnValidarContrasena = new Button();
            btnValidarNombre = new Button();
            btnValidarRol = new Button();
            btnValidarCompleto = new Button();
            SuspendLayout();
            // 
            // btnValidarEmail
            // 
            btnValidarEmail.Location = new Point(40, 30);
            btnValidarEmail.Name = "btnValidarEmail";
            btnValidarEmail.Size = new Size(250, 40);
            btnValidarEmail.TabIndex = 0;
            btnValidarEmail.Text = "Validar Email";
            btnValidarEmail.Click += btnValidarEmail_Click;
            // 
            // btnValidarContrasena
            // 
            btnValidarContrasena.Location = new Point(40, 90);
            btnValidarContrasena.Name = "btnValidarContrasena";
            btnValidarContrasena.Size = new Size(250, 40);
            btnValidarContrasena.TabIndex = 1;
            btnValidarContrasena.Text = "Validar Contraseña";
            btnValidarContrasena.Click += btnValidarContrasena_Click;
            // 
            // btnValidarNombre
            // 
            btnValidarNombre.Location = new Point(40, 150);
            btnValidarNombre.Name = "btnValidarNombre";
            btnValidarNombre.Size = new Size(250, 40);
            btnValidarNombre.TabIndex = 2;
            btnValidarNombre.Text = "Validar Nombre";
            btnValidarNombre.Click += btnValidarNombre_Click;
            // 
            // btnValidarRol
            // 
            btnValidarRol.Location = new Point(40, 210);
            btnValidarRol.Name = "btnValidarRol";
            btnValidarRol.Size = new Size(250, 40);
            btnValidarRol.TabIndex = 3;
            btnValidarRol.Text = "Validar Rol";
            btnValidarRol.Click += btnValidarRol_Click;
            // 
            // btnValidarCompleto
            // 
            btnValidarCompleto.Location = new Point(40, 270);
            btnValidarCompleto.Name = "btnValidarCompleto";
            btnValidarCompleto.Size = new Size(250, 40);
            btnValidarCompleto.TabIndex = 4;
            btnValidarCompleto.Text = "Validar Usuario Completo";
            btnValidarCompleto.Click += btnValidarCompleto_Click;
            // 
            // TestValidacionesUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 360);
            Controls.Add(btnValidarEmail);
            Controls.Add(btnValidarContrasena);
            Controls.Add(btnValidarNombre);
            Controls.Add(btnValidarRol);
            Controls.Add(btnValidarCompleto);
            Name = "TestValidacionesUsuario";
            Text = "Test Validaciones Usuario";
            Load += TestValidacionesUsuario_Load_1;
            ResumeLayout(false);
        }
    }
}
