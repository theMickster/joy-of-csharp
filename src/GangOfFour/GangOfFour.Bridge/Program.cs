using System;
using GangOfFour.Core.Entities.Messaging;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Bridge
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Gang of Four Design Pattern - Bridge");

            IMessageSender sms = new SmsSender("871615499");
            IMessageSender email = new EmailSender("smtp.office365.com");
            IMessageSender msmq = new MsmqSender("http://my-awesome-service-bus.servicebus.windows.net/queue01/");
            IMessageSender webService = new WebServiceSender("http://fancy-application.contoso.com/");

            var firstMessage = new Message{To = "Nolan Arenado", From = "Trevor Story", Subject = "Best Rockies Defense", Body = "Hello World!"};
            var secondMessage = new Message { To = "Bud Black", From = "The System", Subject = "Scouting Report", Body = "Hello World!" };

            var userMessage = new UserMessage(sms, firstMessage);
            var systemMessage = new SystemMessage(email, secondMessage);

            userMessage.SendMessage();
            Console.WriteLine("*************************************");
            systemMessage.SendMessage();
            Console.WriteLine("*************************************");
            userMessage.UpdateMessageSender(msmq);
            userMessage.SendMessage();
            Console.WriteLine("*************************************");
            systemMessage.UpdateMessageSender(webService);
            systemMessage.SendMessage();
            Console.WriteLine("*************************************");
            Console.ReadKey();

        }
    }
}
