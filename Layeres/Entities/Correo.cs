using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SINAC.Layeres.Entities
{
    class Correo
    {
        public static void Enviar(string rutaXml)
        {
            try
            {
                MailMessage mensaje = new MailMessage();

                mensaje.IsBodyHtml = true;
                mensaje.Subject = "Reservación";
                mensaje.Body = "Documento Xml con datos de la reservación";
                mensaje.From = new MailAddress("micuenta@gmail.com");
                mensaje.To.Add("destinatario@utn.ac.cr");

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("micuenta@gmail.com", "12345678");
                smtp.EnableSsl = true;

                Attachment attachment = new Attachment(rutaXml);
                mensaje.Attachments.Add(attachment);
                smtp.Send(mensaje);
            }
            catch (SmtpException)
            {

            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
