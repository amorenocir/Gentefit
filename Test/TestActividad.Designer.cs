namespace Gentefit.Test
{
    partial class TestActividad
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnCrear;
        private Button btnModificar;
        private Button btnValidar;
        private Button btnIntensidad;
        private Button btnReset;

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
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnIntensidad = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(50, 40);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(200, 40);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear Actividad";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(50, 100);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(200, 40);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar Actividad";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(50, 160);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(200, 40);
            this.btnValidar.TabIndex = 2;
            this.btnValidar.Text = "Validar Datos";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnIntensidad
            // 
            this.btnIntensidad.Location = new System.Drawing.Point(50, 220);
            this.btnIntensidad.Name = "btnIntensidad";
            this.btnIntensidad.Size = new System.Drawing.Size(200, 40);
            this.btnIntensidad.TabIndex = 3;
            this.btnIntensidad.Text = "Comprobar Intensidad";
            this.btnIntensidad.UseVisualStyleBackColor = true;
            this.btnIntensidad.Click += new System.EventHandler(this.btnIntensidad_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(50, 280);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(200, 40);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Resetear Actividad";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // TestActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 360);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnIntensidad);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCrear);
            this.Name = "TestActividad";
            this.Text = "TestActividad";
            this.Load += new System.EventHandler(this.TestActividad_Load);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
