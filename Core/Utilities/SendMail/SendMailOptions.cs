using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.SendMail
{
    public class SendMailOptions
    {
        public string Sender { get; set; }
        public string Alias { get; set; }
        public string Password { get; set; }
        public string ToAdd { get; set; }
        public string MailHost { get; set; }
        public int MailPort { get; set; }

    }
}
