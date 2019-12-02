using System;

namespace GangOfFour.Application.Mediators
{
    /// <summary>
    /// The 'AbstractColleague' class in the mediator design pattern.
    /// </summary>
    public abstract class ChatParticipant : IChatParticipant
    {
        protected ChatParticipant(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public Chatroom Chatroom { get; set; }

        public void Send(string to, string message)
        {
            Chatroom.Send(Name, to, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'",from, Name, message);
        }

    }
}