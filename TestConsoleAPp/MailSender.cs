using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CryptoSerice
{
    public class MailSender
    {
        public void SendGraph(string to, string path)
        {
            SmtpClient client = new SmtpClient();
            Console.WriteLine("client set");
            MailMessage message = new MailMessage(new MailAddress("p.heinz@email.cz", "Petr Heinz"), new MailAddress(to));
            message.Subject = "CryptoApp - Bitcoin price list for the day";
            message.Attachments.Add(new Attachment(path));
            //await client.SendAsync(message);
            Console.WriteLine("message set");
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Host = "smtp.seznam.cz";
            client.Credentials = new System.Net.NetworkCredential("username", "password");
            client.Send(message);
            Console.WriteLine("Sent.");
        }
    }
}
