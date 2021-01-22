using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithAdapters.Interfaces
{
    public interface IMessageSenderTelegram
    {
        public void SendTelegramMessage(string txt);
    }
}
