using System;
using System.Net;
using System.Net.Mail;

namespace VballPlayerService
{
    public class EmailService
    {
        public void SendEmail(string playerName, string playerAge, string position)
        {
            try
            {
                
                SmtpClient client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525);
                client.Credentials = new NetworkCredential("b9a887e95a7284", "47224f2dcbbb2c");
                client.EnableSsl = true;

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("noreply@vballpms.com");
                mail.To.Add("admin@example.com"); 
                mail.Subject = "New Volleyball Player Added";
                mail.Body = "---------- A new player was successfully added! ----------\n\n" +
                            "Name: " + playerName + "\n" +
                            "Age: " + playerAge + "\n" +
                            "Position: " + position + "\n\n" +
                            "---------- Sent automatically by PMS of Volleyball Player. ----------";

            
                client.Send(mail);

                Console.WriteLine("Email sent successfully to Mailtrap inbox!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Error sending email: " + ex.Message);
            }
        }
    }
}
