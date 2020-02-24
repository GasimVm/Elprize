using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;


namespace Prize.Utilities
{
    public static class SendMesaj
    {

        public static async Task<string> SendMesssage(string email, string subject, string body)
        {
            try
            {
                var from = new MailAddress("elpircee@gmail.com", "elpirce");
                var fromPass = "hesen1995";

                var to = new MailAddress(email);
                SmtpClient client = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    UseDefaultCredentials = false,

                    EnableSsl = true,
                    Credentials = new NetworkCredential(from.Address, fromPass),

                    DeliveryMethod = SmtpDeliveryMethod.Network
                };

                var message = new MailMessage(from, to)
                {
                    IsBodyHtml = true,
                    Subject = subject,
                    Body = body
                };


                await client.SendMailAsync(message);
                return "send";

            }
            catch (Exception ex)
            {

                return ex.ToString();

            }
        }
    }
}
