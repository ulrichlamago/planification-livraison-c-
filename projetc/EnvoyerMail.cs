using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;
namespace projetc
{
    class EnvoyerMail
    {
        public void SendMail(string email, string password)
        {
            try
            {
                string mdp = "Godofwar3";
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587);

                mail.From = new MailAddress("ulrichkamajong@gmail.com");
                mail.To.Add(email);
                mail.Subject = "mots de passe oublier";

                mail.IsBodyHtml = true;
                string htmlBody;

                htmlBody = "votre mot de passe "+password;

                mail.Body = htmlBody;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("ulrichkamajong@gmail.com", mdp);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("message envoyer avec succès");
               
            }
            catch (Exception ex) { MessageBox.Show("erreur de l'envoi"); }
        }
    }
}
