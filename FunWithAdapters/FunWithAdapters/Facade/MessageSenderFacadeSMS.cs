using FunWithAdapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithAdapters.Facade
{
    public class MessageSenderFacadeSMS : IMessageSenderFacadeSMS
    {
        private IMessageSenderSMS _sms;

        public MessageSenderFacadeSMS(IMessageSenderSMS sms)
        {
            _sms = sms;
        }

        public void EnviarSms()
        {
            Console.WriteLine("Obteve número do destinatário via BD, utilizando facade");
            Console.WriteLine("Obteve nome do destinatário via BD, utilizando facade");
            
            var destinatario = new Destinatario() { Name = "Destinatário", Number = "11912345678" };

            _sms.SendSms(destinatario);
        }
    }

    public class Destinatario
    {
        public string Name { get; internal set; }
        public string Number { get; internal set; }
    }
}
