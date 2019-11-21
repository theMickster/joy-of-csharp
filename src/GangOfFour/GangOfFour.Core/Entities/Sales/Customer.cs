using System.Collections.Generic;

namespace GangOfFour.Core.Entities.Sales
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<SalesOrder> Orders { get; set; }
    }
}