using FunWithAdapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithAdapters
{
    public class MessageSenderService
    {
        private IMessageSender _message;

        public MessageSenderService(IMessageSender message)
        {
            _message = message;
        }

        public void SendMessage()
        {
            _message.SendMessage();
        }
    }
}
