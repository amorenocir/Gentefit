namespace Gentefit.Test
{
    partial class TestClase
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnCrear;
        private Button btnModificar;
        private Button btnValidarPlazas;
        private Button btnValidarHorario;
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
            this.btnCrear = new Button();
            this.btnModificar = new Button();
            this.btnValidarPlazas = new Button();
            this.btnValidarHorario = new Button();
            this.btnReset = new Button();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new Point(40, 30);
            this.btnCrear.Size = new Size(220, 40);
            this.btnCrear.Text = "Crear Clase";
            this.btnCrear.Click += new EventHandler(this.btnCrear_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new Point(40, 90);
            this.btnModificar.Size = new Size(220, 40);
            this.btnModificar.Text = "Modificar Clase";
            this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
            // 
            // btnValidarPlazas
            // 
            this.btnValidarPlazas.Location = new Point(40, 150);
            this.btnValidarPlazas.Size = new Size(220, 40);
            this.btnValidarPlazas.Text = "Validar Plazas";
            this.btnValidarPlazas.Click += new EventHandler(this.btnValidarPlazas_Click);
            // 
            // btnValidarHorario
            // 
            this.btnValidarHorario.Location = new Point(40, 210);
            this.btnValidarHorario.Size = new Size(220, 40);
            this.btnValidarHorario.Text = "Validar Día y Hora";
            this.btnValidarHorario.Click += new EventHandler(this.btnValidarHorario_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new Point(40, 270);
            this.btnReset.Size = new Size(220, 40);
            this.btnReset.Text = "Resetear Clase";
            this.btnReset.Click += new EventHandler(this.btnReset_Click);
            // 
            // TestClase
            // 
            this.ClientSize = new Size(300, 350);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnValidarHorario);
            this.Controls.Add(this.btnValidarPlazas);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCrear);
            this.Name = "TestClase";
            this.Text = "TestClase";
            this.Load += new EventHandler(this.TestClase_Load);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
