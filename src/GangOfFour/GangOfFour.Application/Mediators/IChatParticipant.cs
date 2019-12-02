namespace GangOfFour.Application.Mediators
{
    public interface IChatParticipant
    {
        string Name { get; }

        Chatroom Chatroom { get; set; }

        void Send(string to, string message);

        void Receive(string from, string message);
    }
}