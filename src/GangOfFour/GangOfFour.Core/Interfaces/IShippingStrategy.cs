using GangOfFour.Core.Entities.Sales;

namespace GangOfFour.Core.Interfaces
{
    public interface IShippingStrategy
    {
        decimal Calculate(SalesOrder order);
    }
}