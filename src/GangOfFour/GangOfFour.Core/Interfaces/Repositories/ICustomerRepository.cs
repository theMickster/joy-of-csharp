using GangOfFour.Core.Entities.Sales;

namespace GangOfFour.Core.Interfaces.Repositories
{
    public interface ICustomerRepository
    {
        Customer GetCustomerByFullName(string firstName, string lastName);
    }
}