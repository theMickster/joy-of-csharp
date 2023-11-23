using System;
using GangOfFour.Core.Entities;
using GangOfFour.Core.Enumerations;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Application.Commands
{
    /// <summary>
    /// A ConcreteCommand object used by the command design pattern.
    /// Defines a binding between a Receiver and an action.
    /// </summary>
    public class Transfer : IAccountTransaction
    {
        private readonly decimal _amount;

        private readonly Account _fromAccount;

        private readonly Account _toAccount;

        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public AccountCommandState Status { get; set; }

        public Transfer()
        {
            
        }

        public Transfer(int id, Account fromAccount, Account toAccount, decimal amount)
        {
            Id = id;
            CreatedOn = DateTime.UtcNow;

            _fromAccount = fromAccount;
            _toAccount = toAccount;
            _amount = amount;

            Status = AccountCommandState.Unprocessed;
        }

        public void Execute()
        {
            if (_fromAccount.Balance >= _amount)
            {
                _fromAccount.Balance -= _amount;
                _toAccount.Balance += _amount;

                Status = AccountCommandState.ExecuteSucceeded;
            }
            else
            {
                Status = AccountCommandState.ExecuteFailed;
            }
        }

    }
}