namespace Gentefit.Test
{
    partial class TestEmail
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnTestEnvio;

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
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnTestEnvio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 30);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(110, 20);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Introduce Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(30, 60);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 27);
            this.txtEmail.TabIndex = 1;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(30, 110);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(130, 40);
            this.btnValidar.TabIndex = 2;
            this.btnValidar.Text = "Validar Email";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnTestEnvio
            // 
            this.btnTestEnvio.Location = new System.Drawing.Point(180, 110);
            this.btnTestEnvio.Name = "btnTestEnvio";
            this.btnTestEnvio.Size = new System.Drawing.Size(130, 40);
            this.btnTestEnvio.TabIndex = 3;
            this.btnTestEnvio.Text = "Simular Envío";
            this.btnTestEnvio.UseVisualStyleBackColor = true;
            this.btnTestEnvio.Click += new System.EventHandler(this.btnTestEnvio_Click);
            // 
            // TestEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.btnTestEnvio);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Name = "TestEmail";
            this.Text = "TestEmail";
            this.Load += new System.EventHandler(this.TestEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
