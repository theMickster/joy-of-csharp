namespace GangOfFour.Core.Entities
{
    /// <summary>
    /// The "Receiver" class in the command design pattern.
    /// Also used as a collection item in the iterator pattern.
    /// </summary>
    public class Account
    {
        public string OwnerName { get; set; }

        public decimal Balance { get; set; }

        public Account(string ownerName, decimal balance)
        {
            OwnerName = ownerName;
            Balance = balance;
        }

        public string GetDetails()
        {
            return $"Account owned by: {OwnerName} has a balance of: ${Balance}";
        }
    }
}