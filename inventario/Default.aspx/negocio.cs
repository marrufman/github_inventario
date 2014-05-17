using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace Default.aspx
{
    public class negocio
    {
        public void email(string asunto,string destino,string Mensaje)
        {
            //Configurando el cliente SMTP
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("inventarioejercicio@gmail.com", "1nv3nt4r1o");

            //Enviando correo
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("inventarioejercicio@gmail.com");
            mail.To.Add(new MailAddress(destino));
            mail.Subject = asunto;
            mail.IsBodyHtml = true;
            mail.Body = Mensaje;
            client.Send(mail);
        }
    }
}