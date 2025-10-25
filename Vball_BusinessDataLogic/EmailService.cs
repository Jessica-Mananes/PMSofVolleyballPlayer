using MailKit.Net.Smtp;
using MimeKit;
using Microsoft.Extensions.Configuration;
using MailKit.Security;

namespace Vball_BusinessDataLogic.Services
{
    public class EmailService
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void SendEmail(string playerName, string recipientEmail)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(
                _configuration["EmailSettings:FromName"],
                _configuration["EmailSettings:FromAddress"]
            ));

            message.To.Add(new MailboxAddress(playerName, recipientEmail));
            message.Subject = "Player Profile Notification";

            message.Body = new TextPart("plain")
            {
                Text = $"Hello {playerName},\n\nYour profile has been updated in Volleyball PMS.\n\n"
            };

            using (var client = new SmtpClient())
            {
                client.Connect(
                    _configuration["EmailSettings:SmtpHost"],
                    int.Parse(_configuration["EmailSettings:SmtpPort"]),
                    SecureSocketOptions.StartTls
                );

                client.Authenticate(
                    _configuration["EmailSettings:SmtpUsername"],
                    _configuration["EmailSettings:SmtpPassword"]
                );

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
