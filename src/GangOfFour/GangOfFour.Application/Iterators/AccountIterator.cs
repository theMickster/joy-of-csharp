using GangOfFour.Core.Entities;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Application.Iterators
{
    public class AccountIterator : IAccountIterator
    {
        private readonly AccountCollection _accountCollection;
        
        private int _current = 0;
        
        private int _step = 1;

        public AccountIterator(AccountCollection accountCollection)
        {
            _accountCollection = accountCollection;
        }

        public Account First()
        {
            _current = 0;
            return _accountCollection[_current] as Account;
        }

        public Account Next()
        {
            _current += _step;
            if (!IsDone)
                return _accountCollection[_current] as Account;
            else

                return null;
        }

        public int Step
        {
            get => _step;
            set => _step = value;
        }

        public Account CurrentItem => _accountCollection[_current] as Account;

        public bool IsDone => _current >= _accountCollection.Count;
    }
}