using FunWithAdapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithAdapters.MessageSenderAdapter
{
    public class MessageSenderAdapterSMS : IMessageSender
    {
        private IMessageSenderFacadeSMS _sms;

        public MessageSenderAdapterSMS(IMessageSenderFacadeSMS sms)
        {
            _sms = sms;
        }
        public void SendMessage()
        {
            _sms.EnviarSms();
        }
    }
}
