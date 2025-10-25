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

            message.Body = new TextPart("html")
            {
                Text = $@"
        <html>
        <body style='font-family: Arial, sans-serif; background-color: #f9fafc; padding: 20px;'>
            <div style='max-width: 600px; margin: auto; background: white; border-radius: 10px; box-shadow: 0 2px 8px rgba(0,0,0,0.1); padding: 20px;'>
                <h2 style='color: #0066cc; text-align: center;'>🏐 Volleyball PMS Notification 🏐</h2>
                <p style='font-size: 16px; color: #333;'>Hello <strong>{playerName}</strong>,</p>
                <p style='font-size: 16px; color: #333;'>
                    Welcome to the team! We’re excited to play with you! 👱🏻‍♀️👩🏻‍🦰👩🏻👧🏽👧🏾.
                </p>
                <p style='font-size: 15px; color: #555;'>
                    Your profile has been successfully added to our Volleyball Player Management System.
                </p>
                <hr style='margin: 20px 0; border: none; border-top: 1px solid #ddd;' />
                <p style='font-size: 14px; color: #888; text-align: center;'>
                    &copy; 2025 Volleyball PMS | Do not reply to this automated email.
                </p>
            </div>
        </body>
        </html>"
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
