using System;
using System.Collections.Generic;
using GangOfFour.Core.Enumerations;

namespace GangOfFour.Core.Entities.Sales
{
    public class SalesOrder : BaseEntity
    {
        public DateTime OrderDate { get; set; }

        public DateTime ShipDate { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public bool OnlineOrder { get; set; }

        public string AccountNumber { get; set; }

        public Customer Customer { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }

        public SalesOrder()
        {
            OrderStatus = OrderStatus.InProcess;
        }

    }
}