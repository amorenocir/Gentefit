namespace Gentefit.Test
{
    partial class TestReserva
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnReservaOK;
        private System.Windows.Forms.Button btnSinPlazas;
        private System.Windows.Forms.Button btnDuplicada;
        private System.Windows.Forms.Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnReservaOK = new Button();
            btnSinPlazas = new Button();
            btnDuplicada = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnReservaOK
            // 
            btnReservaOK.Location = new Point(40, 40);
            btnReservaOK.Name = "btnReservaOK";
            btnReservaOK.Size = new Size(250, 40);
            btnReservaOK.TabIndex = 0;
            btnReservaOK.Text = "Test 1 - Crear Reserva (OK)";
            btnReservaOK.UseVisualStyleBackColor = true;
            btnReservaOK.Click += btnReservaOK_Click;
            // 
            // btnSinPlazas
            // 
            btnSinPlazas.Location = new Point(40, 100);
            btnSinPlazas.Name = "btnSinPlazas";
            btnSinPlazas.Size = new Size(250, 40);
            btnSinPlazas.TabIndex = 1;
            btnSinPlazas.Text = "Test 2 - Sin Plazas (En Espera)";
            btnSinPlazas.UseVisualStyleBackColor = true;
            btnSinPlazas.Click += btnSinPlazas_Click;
            // 
            // btnDuplicada
            // 
            btnDuplicada.Location = new Point(40, 160);
            btnDuplicada.Name = "btnDuplicada";
            btnDuplicada.Size = new Size(250, 40);
            btnDuplicada.TabIndex = 2;
            btnDuplicada.Text = "Test 3 - Reserva Duplicada";
            btnDuplicada.UseVisualStyleBackColor = true;
            btnDuplicada.Click += btnDuplicada_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(40, 220);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(250, 40);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Test 4 - Cancelar Reserva";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // TestReserva
            // 
            ClientSize = new Size(350, 300);
            Controls.Add(btnCancelar);
            Controls.Add(btnDuplicada);
            Controls.Add(btnSinPlazas);
            Controls.Add(btnReservaOK);
            Name = "TestReserva";
            Text = "Test de Reservas - Gentefit";
            Load += TestReserva_Load;
            ResumeLayout(false);

        }
    }
}
