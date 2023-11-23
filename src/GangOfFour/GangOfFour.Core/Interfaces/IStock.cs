namespace GangOfFour.Core.Interfaces
{
    public interface IStock
    {
        string StockName { get; }

        decimal Price { get; set; }

        string Symbol { get; set; }

        void Attach(IStockInvestor investor);

        void Detach(IStockInvestor investor);

        void Notify();
    }
}