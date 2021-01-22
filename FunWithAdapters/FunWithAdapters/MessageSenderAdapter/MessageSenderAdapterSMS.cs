using FunWithAdapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithAdapters.MessageSenderAdapter
{
    public class MessageSenderAdapterSMS : IMessageSender
    {
        private IMessageSenderSMS _sms;

        public MessageSenderAdapterSMS(IMessageSenderSMS sms)
        {
            _sms = sms;
        }
        public void SendMessage()
        {
            _sms.SendSms();
        }
    }
}
