using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Gentefit.Logica
{
    internal class EnviarCorreo
    {
        // Enviar un correo al cliente
        public static void Notificar(string destinatario, string asunto, string cuerpo)
        {
            try
            {
                MailMessage mensaje = new MailMessage();
                mensaje.From = new MailAddress("davidzurge@gmail.com", "GENTEFIT 🏋️‍♂️");
                mensaje.To.Add(destinatario);
                mensaje.Subject = asunto;
                mensaje.Body = cuerpo;
                mensaje.IsBodyHtml = true;

                // Configuración SMTP (usa clave de aplicación)
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("davidzurge@gmail.com", "webk uxms lagl ptak");
                smtp.EnableSsl = true;

                smtp.Send(mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudo enviar el correo:\n{ex.Message}",
                    "Error al enviar notificación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}

