using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            confmail conf = new confmail(); 
           try
            {
                MailMessage config = new MailMessage(); 
                config = conf.definir_correo("correo1@correo.com", "correo2@correo.com","Test","<h1>Exito</h1>");
                SmtpClient servidor = new SmtpClient();
                servidor = conf.smtpConfig(2252, "gmail.com", "tucorreo@gmail.com", "password");

                //Intentar enviar correo

                servidor.Send(config);
                config.Dispose();
                Console.WriteLine("[[EXITO]]");
            }
            catch(Exception e)
            {
                Console.WriteLine("[[ERROR]]", e.Message);
            }

            Console.ReadKey();
        }

   
    }
}
