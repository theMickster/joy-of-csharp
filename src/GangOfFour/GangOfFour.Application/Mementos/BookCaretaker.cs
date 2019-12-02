using System;
using System.Collections.Generic;
using System.Linq;
using GangOfFour.Core.Entities;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Application.Mementos
{
    public class BookCaretaker
    {
        private List<IBookMemento> _mementos = new List<IBookMemento>();

        private readonly Book _originator;

        public BookCaretaker(Book originator)
        {
            _originator = originator;
        }

        public void Backup()
        {
            Console.WriteLine("Caretaker: Saving Book Originator's state...");
            _mementos.Add(_originator.Save());
        }

        public void Undo()
        {
            if (_mementos.Count == 0)
            {
                return;
            }

            var memento = _mementos.Last();
            _mementos.Remove(memento);

            Console.WriteLine("Caretaker: Restoring state to: " + memento.GetState());

            try
            {
                _originator.Restore(memento);
            }
            catch (Exception)
            {
                Undo();
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: Here's the list of mementos:");

            foreach (var memento in _mementos)
            {
                Console.WriteLine(memento.GetState());
            }
        }
    }
}