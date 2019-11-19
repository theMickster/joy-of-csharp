using System;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Core.Entities.Messaging
{
    /// <summary>
    /// The 'Concrete Implementor' class in the bridge pattern.
    /// Demonstrates how concrete implementor classes can vary independent from the concrete abstractions.
    /// </summary>
    public class SmsSender : IMessageSender
    {
        private readonly string _smsSenderAddress;

        public SmsSender(string smsSenderAddress)
        {
            _smsSenderAddress = smsSenderAddress;
        }

        public void SendMessage(Message message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Sending SSMS via {_smsSenderAddress}....");
            Console.WriteLine($"To:{message.To} {Environment.NewLine}From: {message.From} {Environment.NewLine}Subject {message.Subject} {Environment.NewLine}Body {message.Body}");
            Console.WriteLine($"Message  Sent....");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}