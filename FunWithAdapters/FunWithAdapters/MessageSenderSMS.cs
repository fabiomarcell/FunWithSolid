using FunWithAdapters.Facade;
using FunWithAdapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithAdapters
{
    public class MessageSenderSMS : IMessageSenderSMS
    {
        public void SendSms(Destinatario destinatario)
        {
            Console.WriteLine("Enviado via serviço padrão de mensagens: 'SMS'");
            Console.WriteLine($"{destinatario.Name}, {destinatario.Number}");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
