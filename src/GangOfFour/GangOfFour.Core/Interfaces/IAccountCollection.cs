namespace GangOfFour.Core.Interfaces
{
    /// <summary>
    /// The 'Aggregate' interface used in the iterator design pattern.
    /// </summary>
    public interface IAccountCollection
    {
        IAccountIterator CreateIterator();
    }
}