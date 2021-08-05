using System.Net.Mail;

namespace PROG3_T9.Data
{
    public class MailSender
    {
        public string Message { get; set; }
        public string MailSennder { get; set; }
        public string MailReciver { get; set; }
        public string Subject { get; set; }
        public string Pass { get; set; }
        public string Body { get; set; }
        
        public MailSender(string MailSennder, string MailReciver, string Pass, string Body)
        {
            this.MailSennder = MailSennder;
            this.MailReciver = MailReciver;
            // En este caso el subject de es fijo, pero lo almaceno en una variable por si se quiere variar.
            Subject = "Para vacunación en casa";
            this.Pass = Pass;
            this.Body = Body;
        }
        
        public void SendMail()
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(MailSennder);
                mail.To.Add(MailReciver);
                mail.Subject = Subject;
                mail.Body = Body;
                mail.IsBodyHtml = true;
                
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new System.Net.NetworkCredential(MailSennder, Pass);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                    Message = "Mensaje enviado";
                };
            }
        }
    }
}