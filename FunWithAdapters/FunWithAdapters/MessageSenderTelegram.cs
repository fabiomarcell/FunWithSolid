using FunWithAdapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithAdapters
{
    public class MessageSenderTelegram : IMessageSenderTelegram
    {
        public void SendTelegramMessage(string txt)
        {
            Console.WriteLine("Enviado via serviço padrão de mensagens: 'Telegram'");
            Console.WriteLine(txt);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
