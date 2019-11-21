using System.Collections.Generic;
using GangOfFour.Core.Entities.Sales;

namespace GangOfFour.Core.Interfaces.Repositories
{
    public interface ISalesOrderRepository : IRepository<SalesOrder>
    {
        List<SalesOrder> GetByCustomerId(int customerId);

        List<SalesOrder> ReportOrdersWithMultipleDetailLines();
    }
}