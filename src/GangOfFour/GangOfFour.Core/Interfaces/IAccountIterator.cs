using GangOfFour.Core.Entities;

namespace GangOfFour.Core.Interfaces
{
    /// <summary>
    /// The 'Iterator' interface used in the iterator design pattern.
    /// </summary>
    public interface IAccountIterator
    {
        bool IsDone { get; }
        
        Account CurrentItem { get; }

        Account First();
        
        Account Next();
    }
}