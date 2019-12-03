using System;
using System.Linq;
using GangOfFour.Core.Entities.Sales;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Application.Strategies
{
    public class FedExShippingStrategy : IShippingStrategy
    {
        private const decimal Factor = 0.13m;

        public decimal Calculate(SalesOrder order)
        {
            var totalPrice = order.SalesOrderDetails.Sum(p => p.TotalPrice);

            return Math.Round(totalPrice * Factor, 2);
        }
    }
}