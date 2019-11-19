using System;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Core.Entities.Messaging
{
    /// <summary>
    /// The 'Concrete Implementor' class in the bridge pattern.
    /// Demonstrates how concrete implementor classes can vary independent from the concrete abstractions.
    /// </summary>
    public class WebServiceSender : IMessageSender
    {
        private readonly string _webServiceAddress;

        public WebServiceSender(string webServiceAddress)
        {
            _webServiceAddress = webServiceAddress;
        }
        public void SendMessage(Message message)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Connecting to Web Service {_webServiceAddress}....");
            Console.WriteLine($"Sending message through the web service....");
            Console.WriteLine($"To:{message.To} {Environment.NewLine}From: {message.From} {Environment.NewLine}Subject {message.Subject} {Environment.NewLine}Body {message.Body}");
            Console.WriteLine($"Message Sent....");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}