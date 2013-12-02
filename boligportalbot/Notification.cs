using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boligportalbot
{
    public class Notification
    {
        public Notification(string offer, TextBox system_message_txt, MainForm author_object)
        {
            try
            {
                string baseUrl = "http://www.boligportal.dk";
                System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
                message.To.Add("sandramalchrowicz@gmail.com, maxkrag@gmail.com");
                message.Subject = "New apartment offer found!";
                message.From = new System.Net.Mail.MailAddress("lololol@mail.dk"); //not actually used, but it's required
                message.Body = "New offer can be seen here: " + baseUrl + offer;

                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587); //host and port
                smtp.Credentials = new NetworkCredential("clausfkrag@gmail.com", "50548288");
                smtp.EnableSsl = true;
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                CrossThreadMsg.CreateMessage(system_message_txt, "Error sending mail: " + ex);
            }
        }
    }
}
