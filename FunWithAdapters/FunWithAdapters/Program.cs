using FunWithAdapters.Facade;
using FunWithAdapters.MessageSenderAdapter;
using System;

namespace FunWithAdapters
{
    class Program
    {
        static void Main(string[] args)
        {
            new MessageSenderService(new MessageSender()).SendMessage();

            new MessageSenderService(new MessageSenderAdapterSMS(new MessageSenderFacadeSMS(new MessageSenderSMS()))).SendMessage();

            new MessageSenderService(new MessageSenderAdapterTelegram(new MessageSenderTelegram())).SendMessage();
        }
    }
}
