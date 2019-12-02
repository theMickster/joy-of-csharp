using System;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Core.Entities
{
    /// <summary>
    /// The Concrete Memento contains the infrastructure for storing the Originator's state.
    /// </summary>
    public class BookMomento : IBookMemento
    {
        public string Isbn { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public DateTime LastEdited { get; private set; }

        public BookMomento(string isbn, string title, string author, DateTime lastEdited)
        {
            Isbn = isbn;
            Title = title;
            Author = author;
            LastEdited = lastEdited;
        }

        public string GetState()
        {
            return $"Book Details => {Title} {Author} {Isbn} {LastEdited} ";
        }
    }
}