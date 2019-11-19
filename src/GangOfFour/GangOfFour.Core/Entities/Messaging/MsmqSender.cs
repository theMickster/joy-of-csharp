using System;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Core.Entities.Messaging
{
    /// <summary>
    /// The 'Concrete Implementor' class in the bridge pattern.
    /// Demonstrates how concrete implementor classes can vary independent from the concrete abstractions.
    /// </summary>
    public class MsmqSender : IMessageSender
    {
        private readonly string _messageQueueAddress;

        public MsmqSender(string messageQueueAddress)
        {
            _messageQueueAddress = messageQueueAddress;
        }
        public void SendMessage(Message message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Sending to the queue {_messageQueueAddress}....");
            Console.WriteLine($"To:{message.To} {Environment.NewLine}From: {message.From} {Environment.NewLine}Subject {message.Subject} {Environment.NewLine}Body {message.Body}");
            Console.WriteLine($"Message  Sent....");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}