using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.Text;
using Microsoft.Extensions.Options;
using Core.Utilities.Results;

namespace Core.Utilities.SendMail
{
    public class SendMail : ISendMail
    {
        public void Send(SendMailOptions _sendMailOptions, string MailIcerik)
        {

                System.Net.NetworkCredential cred = new System.Net.NetworkCredential(_sendMailOptions.Sender, _sendMailOptions.Password);
                // mail göndermek için oturum açtık

                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage(); // yeni mail oluşturduk
                mail.From = new System.Net.Mail.MailAddress(_sendMailOptions.Sender, _sendMailOptions.Alias); // maili gönderecek hesabı belirttik
                mail.To.Add(_sendMailOptions.ToAdd); // mail gönderilecek adresi belirledik
                mail.Subject = "<->  Sistem Performansı <->"; // mailin konusu

                mail.Body = MailIcerik; // mailin içeriği


                // göndereceğimiz maili hazırladık.

                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient(_sendMailOptions.MailHost, Convert.ToInt32(_sendMailOptions.MailPort)); // smtp servere bağlandık
                smtp.UseDefaultCredentials = false; // varsayılan girişi kullanmadık
                smtp.EnableSsl = true; // ssl kullanımına izin verdik
                smtp.Credentials = cred; // server üzerindeki oturumumuzu yukarıda belirttiğimiz NetworkCredential üzerinden sağladık.
                smtp.Send(mail); // mailimizi gönderdik.


                return ;
           
        }

        
    }
}
