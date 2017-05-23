using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class confmail
    {

        public MailMessage definir_correo(String de, String para, String asunto, String cuerpo)
        {

            //Configuraremos el correo.
            MailMessage correo = new MailMessage();
            correo.To.Add(new MailAddress(de));
            correo.From = (new MailAddress(para));
            correo.Subject = asunto;
            correo.Body = cuerpo;
            correo.IsBodyHtml = true;
            correo.Priority = MailPriority.Normal;

            return correo;

        }


        public SmtpClient smtpConfig(int puerto, String host, String correo, String password)
        {
            SmtpClient confmail = new SmtpClient();
            confmail.Host = host;
            confmail.Port = puerto;
            confmail.EnableSsl = false;
            confmail.UseDefaultCredentials = false;
            confmail.Credentials = new System.Net.NetworkCredential(correo, password);

            return confmail;


        }
    }
}
