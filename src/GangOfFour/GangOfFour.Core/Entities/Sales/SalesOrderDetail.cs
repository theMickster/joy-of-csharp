namespace GangOfFour.Core.Entities.Sales
{
    public class SalesOrderDetail : BaseEntity
    {
        public int SalesOrderId { get; set; }

        public int OrderQuantity { get; set; }

        public int ProductId { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal TotalPrice => OrderQuantity * UnitPrice;
        
        public Product Product { get; set; }

        public SalesOrder SalesOrder { get; set; }
    }
}