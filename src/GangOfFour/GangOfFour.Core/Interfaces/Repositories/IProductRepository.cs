using GangOfFour.Core.Entities.Sales;

namespace GangOfFour.Core.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Product GetByProductNumber(string productNumber);
    }
}