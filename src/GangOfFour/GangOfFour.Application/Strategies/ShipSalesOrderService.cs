using GangOfFour.Core.Entities.Sales;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Application.Strategies
{
    public class ShipSalesOrderService
    {
        private readonly IShippingStrategy _shippingStrategy;

        public ShipSalesOrderService(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }

        public decimal CalculateShippingCosts(SalesOrder salesOrder)
        {
            return _shippingStrategy.Calculate(salesOrder);
        }
    }
}