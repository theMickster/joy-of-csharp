namespace GangOfFour.Application.Mediators
{
    public interface IChatroom
    {
        void Register(IChatParticipant participant);

        void Send(string from, string to, string message);
    }
}