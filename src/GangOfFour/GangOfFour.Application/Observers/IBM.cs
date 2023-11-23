namespace GangOfFour.Application.Observers
{
    /// <summary>
    /// The 'ConcreteSubject' class in the observer design pattern.
    /// </summary>
    public class IBM : Stock
    {
        public IBM(string stockName, string symbol, decimal price)
            : base(stockName, symbol, price)
        {
        }
    }
}