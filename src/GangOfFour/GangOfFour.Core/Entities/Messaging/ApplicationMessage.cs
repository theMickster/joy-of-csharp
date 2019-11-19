using GangOfFour.Core.Interfaces;

namespace GangOfFour.Core.Entities.Messaging
{
    /// <summary>
    /// The 'Abstraction' class in the bridge pattern.
    /// </summary>
    public abstract class ApplicationMessage
    {
        protected IMessageSender MessageSender;

        protected Message Message;

        protected ApplicationMessage(IMessageSender messageSender)
        {
            MessageSender = messageSender;
        }

        public abstract void SendMessage();

        public void UpdateMessageSender(IMessageSender messageSender)
        {
            MessageSender = messageSender;
        }
    }
}