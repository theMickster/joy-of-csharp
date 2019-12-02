using System;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Application.Observers
{
    public class StockInvestor : IStockInvestor
    {
        public void Update(IStock stock)
        {
            Console.WriteLine($"Notified {Name} of {stock.StockName}'s change to {stock.Price}");
        }

        public IStock Stock { get; set; }

        public string Name { get; set; }
    }
}