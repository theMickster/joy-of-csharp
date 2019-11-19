using GangOfFour.Core.Entities;
using GangOfFour.Core.Entities.Messaging;

namespace GangOfFour.Core.Interfaces
{
    /// <summary>
    /// The 'Bridge/Implementor' interface in the bridge pattern.
    /// </summary>
    public interface IMessageSender
    {
        void SendMessage(Message message);
    }
}