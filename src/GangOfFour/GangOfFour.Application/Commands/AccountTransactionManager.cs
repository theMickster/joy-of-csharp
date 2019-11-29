using System;
using System.Collections.Generic;
using System.Linq;
using GangOfFour.Core.Enumerations;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Application.Commands
{
    /// <summary>
    /// The "Invoker" class in the command design pattern.
    /// It holds the Command objects, and tries to perform the Execute.
    /// </summary>
    public class AccountTransactionManager : IAccountTransactionManager
    {
        private readonly List<IAccountTransaction> _transactions = new List<IAccountTransaction>();

        public bool HasPendingTransactions
        {
            get
            {
                return _transactions.Any(x =>
                    x.Status == AccountCommandState.Unprocessed ||
                    x.Status == AccountCommandState.ExecuteFailed);
            }
        }

        public void AddTransaction(IAccountTransaction transaction)
        {
            _transactions.Add(transaction);
        }

        public void ProcessPendingTransactions()
        {
            foreach (IAccountTransaction transaction in _transactions.Where(x =>
                x.Status == AccountCommandState.Unprocessed ||
                x.Status == AccountCommandState.ExecuteFailed))
            {
                transaction.Execute();
            }
        }
        public void RemoveOldTransactions()
        {
            _transactions.RemoveAll(x =>
                x.Status == AccountCommandState.ExecuteSucceeded && 
                (DateTime.UtcNow - x.CreatedOn).Days > 15);
        }
    }
}