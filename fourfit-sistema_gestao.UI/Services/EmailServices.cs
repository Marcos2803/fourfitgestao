﻿using fourfit_sistema_gestao.UI.Models.Account;
using System.Net.Mail;
using System.Text;

namespace fourfit_sistema_gestao.UI.Services
{
    public class EmailServices : EmailPasswordAccountViewModel
    {
        private const string Smtp = "smtp.mail.yahoo.com";
        private const int Port = 587;
        private const string UserEmail = "edinaldolemos@yahoo.com.br";


        public async Task SendEmailAsync(EmailAddressViewModel EmailServices)
        {
            try
            {
                using (var msgMail = new MailMessage())
                {
                    msgMail.From = new MailAddress(UserEmail);
                    msgMail.To.Add(EmailServices.To);
                    msgMail.Subject = EmailServices.Subject;
                    msgMail.Body = EmailServices.Body;
                    msgMail.IsBodyHtml = true;
                    msgMail.SubjectEncoding = Encoding.GetEncoding("ISO-8859-1");
                    msgMail.BodyEncoding = Encoding.GetEncoding("ISO-8859-1");

                    using (var smtpClient = new SmtpClient())
                    {
                        smtpClient.EnableSsl = true;
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.Credentials = new System.Net.NetworkCredential(UserEmail, Password);
                        smtpClient.Host = Smtp;
                        smtpClient.Port = Port;
                        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtpClient.Timeout = 20_000;
                        await smtpClient.SendMailAsync(msgMail);
                    }

                }
            }
            catch (SmtpException ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
