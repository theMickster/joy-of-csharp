namespace GangOfFour.Core.Interfaces
{
    public interface IAccountTransactionManager
    {
        bool HasPendingTransactions { get; }
        
        void AddTransaction(IAccountTransaction transaction);
        
        void ProcessPendingTransactions();
        
        void RemoveOldTransactions();
    }
}