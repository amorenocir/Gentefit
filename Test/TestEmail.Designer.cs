using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace Gentefit.Test
{
    public partial class TestEmail : Form
    {
        public TestEmail()
        {
            InitializeComponent();
        }

        private void TestEmail_Load(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("ERROR: El email está vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                MailAddress mail = new MailAddress(email);
                MessageBox.Show("Email válido", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Email inválido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTestEnvio_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("ERROR: El email está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                MailAddress mail = new MailAddress(email);
            }
            catch
            {
                MessageBox.Show("Email no válido. No se puede simular el envío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(
                $"Simulación de envío exitosa.\n\nA: {email}\nAsunto: Test Email\nMensaje: 'Esto es un test ficticio'",
                "Simulación OK",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
