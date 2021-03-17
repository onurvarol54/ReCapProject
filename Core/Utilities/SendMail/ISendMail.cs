using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.SendMail
{
    public interface ISendMail
    {
        void Send(SendMailOptions _sendMailOptions, string MailIcerik);
        
    }
}
