using System;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Core.Entities
{
    public class Book
    {
        private string _isbn;
        private string _title;
        private string _author;

        public string Isbn
        {
            get => _isbn;
            set
            {
                _isbn = value;
                SetLastEdited();
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                SetLastEdited();
            }
        }

        public string Author
        {
            get => _author;
            set
            {
                _author = value;
                SetLastEdited();
            }
        }

        public DateTime LastEdited { get; private set; }

        public Book()
        {
            SetLastEdited();
        }

        private void SetLastEdited()
        {
            LastEdited = DateTime.UtcNow;
        }

        public IBookMemento Save()
        {
            return new BookMomento(_isbn, _title, _author, LastEdited);
        }

        public void Restore(IBookMemento memento)
        {
            if (!(memento is BookMomento))
            {
                throw new Exception("Unknown memento class " + memento.ToString());
            }

            _isbn = memento.Isbn;
            _author = memento.Author;
            _title = memento.Title;
            LastEdited = memento.LastEdited;
        }
    }
}