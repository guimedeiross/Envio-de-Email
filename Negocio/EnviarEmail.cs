using System.Net;
using System.Net.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class EnviarEmail
    {
        public static void SentEmail(Destinatario destino)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("guilherme.medeiros@globalmind.com.br");
            mail.To.Add(destino.destinatario); // para
            mail.Subject = destino.assunto; // assunto
            mail.Body = destino.mensagem; // mensagem

            // em caso de anexos
            //mail.Attachments.Add(new Attachment(@"C:\teste.txt"));

            using (var smtp = new SmtpClient("smtp.gmail.com"))
            {
                smtp.EnableSsl = true; // GMail requer SSL
                smtp.Port = 587;       // porta para SSL
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
                smtp.UseDefaultCredentials = false; // vamos utilizar credencias especificas

                // seu usuário e senha para autenticação
                smtp.Credentials = new NetworkCredential("guilherme.medeiros@globalmind.com.br", "@pple1011");

                // envia o e-mail
                smtp.Send(mail);
            }
        }
    }
}
