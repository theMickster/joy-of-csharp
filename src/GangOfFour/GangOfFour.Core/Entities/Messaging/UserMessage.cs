using GangOfFour.Core.Interfaces;

namespace GangOfFour.Core.Entities.Messaging
{
    public class UserMessage : ApplicationMessage

    {
        public UserMessage(IMessageSender messageSender, Message message) : base(messageSender)
        {
            Message = message;
        }

        public override void SendMessage()
        {
            if (!Message.Subject.StartsWith("*User Message*"))
                Message.Subject = "*User Message* " + Message.Subject;

            MessageSender.SendMessage(Message);
        }
    }
}