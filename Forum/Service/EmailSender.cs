using System.Net;
using System.Net.Mail;

namespace Forum.Service
{
    public class EmailSender
    {
        public bool SendMail(string email, string message1)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtpClient = new SmtpClient();
            message.From = new MailAddress("rybiarze@email.com");
            message.To.Add(email);
            message.Subject = "Confir your Email";
            message.IsBodyHtml = true;
            message.Body = "<a href='" + message1 + "'>Click here to confirm your email</a>";

            smtpClient.Port = 587;
            smtpClient.Host = "sandbox.smtp.mailtrap.io";
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("edc6cddc1e2802", "822df5a285b77a");
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Send(message);
            return true;
        }
    }
}
