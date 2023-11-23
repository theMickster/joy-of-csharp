namespace GangOfFour.Application.Mediators
{
    /// <summary>
    /// The 'Mediator' abstract class in the mediator design pattern.
    /// </summary>
    public abstract class Chatroom : IChatroom
    {
        public abstract void Register(IChatParticipant participant);

        public abstract void Send(string from, string to, string message);
    }
}