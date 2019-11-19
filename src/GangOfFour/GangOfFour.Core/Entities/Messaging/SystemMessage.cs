using GangOfFour.Core.Interfaces;

namespace GangOfFour.Core.Entities.Messaging
{
    public class SystemMessage : ApplicationMessage
    {
        public SystemMessage(IMessageSender messageSender, Message message) : base(messageSender)
        {
            Message = message;
        }

        public override void SendMessage()
        {
            if (!Message.Subject.StartsWith("*System Message*"))
                Message.Subject = "*System Message* " + Message.Subject;

            MessageSender.SendMessage(Message);
        }
    }
}