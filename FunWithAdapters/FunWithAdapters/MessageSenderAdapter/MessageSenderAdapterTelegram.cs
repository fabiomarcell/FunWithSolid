using FunWithAdapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithAdapters.MessageSenderAdapter
{
    class MessageSenderAdapterTelegram : IMessageSender
    {
        private IMessageSenderTelegram _telegram;

        public MessageSenderAdapterTelegram(IMessageSenderTelegram telegram)
        {
            _telegram = telegram;
        }

        public void SendMessage()
        {
            _telegram.SendTelegramMessage("VooDoo é pra jacú");
        }
    }
}
