using System.Net.Mail;

namespace Tasks
{
    public class MailSender : IMailSender
    {
        public bool Send()
        {
            string to = "jane@contoso.com";
            string from = "ben@contoso.com";
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Using the new SMTP client.";
            message.Body = @"Using this new feature, you can send an email message an from application very easily.";
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.UseDefaultCredentials = true;

            try
            {
                smtpClient.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2() : {0}", ex.ToString());
                return false;                
            }
        }
    }
}
