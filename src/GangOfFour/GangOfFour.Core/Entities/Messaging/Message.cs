namespace GangOfFour.Core.Entities.Messaging
{
    public class Message
    {
        public string From { get; set; }

        public string To { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public string Priority { get; set; }
    }
}