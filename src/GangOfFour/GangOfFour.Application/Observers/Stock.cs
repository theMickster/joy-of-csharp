using System.Collections.Generic;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Application.Observers
{
    /// <summary>
    /// The 'Subject' abstract class in the observer design pattern.
    /// </summary>
    public abstract class Stock : IStock
    {
        private string _symbol;
        private decimal _price;
        private readonly List<IStockInvestor> _investors = new List<IStockInvestor>();

        protected Stock(string stockName, string symbol, decimal price )
        {
            StockName = stockName;
            _symbol = symbol;
            _price = price;
        }

        public void Attach(IStockInvestor investor)
        {
            _investors.Add(investor);
        }

        public void Detach(IStockInvestor investor)
        {
            _investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (var investor in _investors)
            {
                investor.Update(this);
            }
        }

        public string StockName { get; }

        public decimal Price
        {
            get => _price;
            set
            {
                if (_price == value)
                {
                    return;
                }
                _price = value;
                Notify();
            }
        }

        public string Symbol
        {
            get => _symbol; 
            set
            {
                if (_symbol == value)
                {
                    return;
                }

                _symbol = value;
                Notify();
            }
        }
    }
}