using FunWithAdapters.Facade;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithAdapters.Interfaces
{
    public interface IMessageSenderSMS
    {
        public void SendSms(Destinatario d);
    }
}
