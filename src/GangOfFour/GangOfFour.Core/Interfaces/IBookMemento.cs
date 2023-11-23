using System;

namespace GangOfFour.Core.Interfaces
{
    /// <summary>
    /// The Memento interface provides a way to retrieve the memento's metadata.
    /// However, it doesn't expose the Originator's state.
    /// </summary>
    public interface IBookMemento
    {
        string Isbn { get;}
        string Title { get;}
        string Author { get;}
        DateTime LastEdited { get;}

        string GetState();
    }
}