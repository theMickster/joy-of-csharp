using System.Collections;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Application.Iterators
{
    public class AccountCollection : IAccountCollection
    {
        private ArrayList _accounts = new ArrayList();

        public IAccountIterator CreateIterator()
        {
            return new AccountIterator(this);
        }

        public int Count
        {
            get { return _accounts.Count; }
        }

        public object this[int index]
        {
            get => _accounts[index];
            set => _accounts.Add(value);
        }
    }
}