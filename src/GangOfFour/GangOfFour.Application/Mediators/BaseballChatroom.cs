using System.Collections.Generic;

namespace GangOfFour.Application.Mediators
{
    /// <summary>
    /// The 'ConcreteMediator' class in the mediator design pattern.
    /// </summary>
    public class BaseballChatroom : Chatroom
    {
        private Dictionary<string, IChatParticipant> _participants = new Dictionary<string, IChatParticipant>();

        public override void Register(IChatParticipant participant)
        {
            if (!_participants.ContainsValue(participant))
            {
                _participants[participant.Name] = participant;
            }

            participant.Chatroom = this;
        }

        public override void Send(string @from, string to, string message)
        {
            var participant = _participants[to];

            participant?.Receive(@from, message);
        }
    }
}