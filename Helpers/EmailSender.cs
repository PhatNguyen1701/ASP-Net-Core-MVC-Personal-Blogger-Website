using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Bloger_Project_Practise.Helpers
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("testinggmail2212@gmail.com", "testing@2212")
            };

            return client.SendMailAsync(
                new MailMessage(from: "testinggmail2212@gmail.com",
                                to: email,
                                subject,
                                message
                                ));
        }
    }
}
