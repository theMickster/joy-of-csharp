using System;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Core.Entities.Messaging
{
    /// <summary>
    /// The 'Concrete Implementor' class in the bridge pattern.
    /// Demonstrates how concrete implementor classes can vary independent from the concrete abstractions.
    /// </summary>
    public class EmailSender : IMessageSender
    {
        private readonly string _emailServer;

        public EmailSender(string emailServer)
        {
            _emailServer = emailServer;
        }

        public void SendMessage(Message message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Connecting to Mail Server {_emailServer}....");
            Console.WriteLine($"Sending message via email....");
            Console.WriteLine($"To:{message.To} {Environment.NewLine}From: {message.From} {Environment.NewLine}Subject {message.Subject} {Environment.NewLine}Body {message.Body}");
            Console.WriteLine($"Message  Sent....");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}