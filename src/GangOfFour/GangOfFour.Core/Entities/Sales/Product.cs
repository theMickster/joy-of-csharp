namespace GangOfFour.Core.Entities.Sales
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public string ProductNumber { get; set; }

        public decimal ListPrice { get; set; }

        public decimal Weight { get; set; }

        public int Size { get; set; }

        public string UnitOfMeasure { get; set; }

    }
}