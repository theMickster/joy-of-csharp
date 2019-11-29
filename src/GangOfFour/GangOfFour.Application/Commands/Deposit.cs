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
    public class Deposit : IAccountTransaction
    {
        private readonly Account _account;

        private readonly decimal _amount;

        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public AccountCommandState Status { get; set; }

        public Deposit(int id, Account account, decimal amount)
        {
            Id = id;
            CreatedOn = DateTime.UtcNow;

            _account = account;
            _amount = amount;

            Status = AccountCommandState.Unprocessed;
        }


        public void Execute()
        {
            _account.Balance += _amount;

            Status = AccountCommandState.ExecuteSucceeded;
        }
    }
}