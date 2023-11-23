using System;

namespace GangOfFour.Application.Mediators
{
    /// <summary>
    /// A 'ConcreteColleague' class in the mediator design pattern.
    /// </summary>
    public class BaseballWriter : ChatParticipant
    {
        public BaseballWriter(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write("To a Baseball Writer: ");
            base.Receive(from, message);
        }
    }
}