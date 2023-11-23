using System;
using GangOfFour.Core.Entities;
using GangOfFour.Core.Enumerations;

namespace GangOfFour.Core.Interfaces
{
    public interface IAccountTransaction
    {
        int Id { get; set; }
        
        DateTime CreatedOn { get; set; }
        
        AccountCommandState Status { get; set; }

        //void SetAccount(Account account);

        void Execute();
        
    }
}