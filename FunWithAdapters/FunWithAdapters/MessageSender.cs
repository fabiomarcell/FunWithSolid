using FunWithAdapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithAdapters
{
    public class MessageSender : IMessageSender
    {
        public void SendMessage()
        {
            Console.WriteLine("Enviado via serviço padrão de mensagens: 'Email'");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
