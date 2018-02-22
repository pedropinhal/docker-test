
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace netcoreapp3.Controllers
{
    [Route("api/[controller]")]
    public class EmailController : Controller
    {
        private int MAIL_PORT = 1025;
        private string MAIL_HOST = "mail";

        // GET api/email
        [HttpGet]
        public string Get()
        {
            return "email";
        }

        // POST api/email
        [HttpPost]
        public async Task Post([FromBody]string value)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Api", "api@api.com"));
            message.To.Add(new MailboxAddress("", "test@fake.com"));
            message.Subject = "Sent from the API!";
            message.Body = new TextPart("plain") { Text = "Here is your message!" };

            using (var mailClient = new SmtpClient())
            {
                await mailClient.ConnectAsync(MAIL_HOST, MAIL_PORT, SecureSocketOptions.None);
                await mailClient.SendAsync(message);
                await mailClient.DisconnectAsync(true);
            }
        }
    }
}
