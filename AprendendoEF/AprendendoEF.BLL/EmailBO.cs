using System;
using System.Collections;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Text.RegularExpressions;
using System.Net.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AprendendoEF.BLL
{
    public class EmailBO
    {
        public void Enviar(string to, string subject, string body)
        {
            try
            {
                var emailNome = ConfigurationManager.AppSettings["EmailNome"].ToString();
                var emailEndereco = ConfigurationManager.AppSettings["EmailEndereco"].ToString();
                var emailSenha = ConfigurationManager.AppSettings["EmailSenha"].ToString();
                var smtpHost = ConfigurationManager.AppSettings["SmtpHost"].ToString();
                var smtpPort = ConfigurationManager.AppSettings["SmtpPort"].ToString();
                var smtpSsl = ConfigurationManager.AppSettings["SmtpEnableSsl"].ToString();

                var smtpPortInt = 0;
                int.TryParse(smtpPort, out smtpPortInt);

                var smtpSslBool = false;
                bool.TryParse(smtpSsl, out smtpSslBool);

                using (var servidor = new SmtpClient(smtpHost))
                {
                    var email = new MailMessage
                    {
                        From = new MailAddress(emailEndereco, emailNome),
                        Subject = subject,
                        Body = body
                    };

                    email.To.Add(to);

                    servidor.Port = smtpPortInt;
                    servidor.Credentials = new NetworkCredential(emailEndereco, emailSenha);
                    servidor.EnableSsl = smtpSslBool;
                    servidor.Send(email);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Enviar(string to, string subject, string body, List<Attachment> attachments)
        {
            try
            {
                var emailNome = ConfigurationManager.AppSettings["EmailNome"].ToString();
                var emailEndereco = ConfigurationManager.AppSettings["EmailEndereco"].ToString();
                var emailSenha = ConfigurationManager.AppSettings["EmailSenha"].ToString();
                var smtpHost = ConfigurationManager.AppSettings["SmtpHost"].ToString();
                var smtpPort = ConfigurationManager.AppSettings["SmtpPort"].ToString();
                var smtpSsl = ConfigurationManager.AppSettings["SmtpEnableSsl"].ToString();

                var smtpPortInt = 0;
                int.TryParse(smtpPort, out smtpPortInt);

                var smtpSslBool = false;
                bool.TryParse(smtpSsl, out smtpSslBool);

                using (var servidor = new SmtpClient(smtpHost))
                {
                    var email = new MailMessage
                    {
                        From = new MailAddress(emailEndereco, emailNome),
                        Subject = subject,
                        Body = body
                    };

                    email.To.Add(to);

                    foreach (var attach in attachments)
                    {
                        email.Attachments.Add(attach);
                    }

                    servidor.Port = smtpPortInt;
                    servidor.Credentials = new NetworkCredential(emailEndereco, emailSenha);
                    servidor.EnableSsl = smtpSslBool;
                    servidor.Send(email);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

