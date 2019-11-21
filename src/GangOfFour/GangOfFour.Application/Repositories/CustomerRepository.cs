using System;
using System.Collections.Generic;
using System.Linq;
using GangOfFour.Core.Entities.Sales;
using GangOfFour.Core.Interfaces.Repositories;

namespace GangOfFour.Application.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private IList<Customer> Customers { get; set; }

        public CustomerRepository()
        {
            Customers = new List<Customer>
            {
                new Customer {Id=1, FirstName = "Terri", LastName = "Duffy"},
                new Customer {Id=2, FirstName = "Roberto", LastName = "Tamburello"},
                new Customer {Id=3, FirstName = "Gail", LastName = "Erickson"},
                new Customer {Id=4, FirstName = "Jossef", LastName = "Goldberg"},
                new Customer {Id=5, FirstName = "Dylan", LastName = "Miller"},
                new Customer {Id=6, FirstName = "Diane", LastName = "Brown"},
                new Customer {Id=7, FirstName = "Gigi", LastName = "Wood"},
                new Customer {Id=8, FirstName = "Michael", LastName = "Raheem"},
                new Customer {Id=9, FirstName = "Terry", LastName = ""},
                new Customer {Id=10, FirstName = "Danielle", LastName = "Gibson"},
                new Customer {Id=11, FirstName = "Russell", LastName = "Williams"},
                new Customer {Id=12, FirstName = "Elizabeth", LastName = "Hamilton"},
                new Customer {Id=13, FirstName = "Jim", LastName = "Gilbert"},
                new Customer {Id=14, FirstName = "Mary", LastName = "Campbell"},
                new Customer {Id=15, FirstName = "Kevin", LastName = "Zwilling"},
                new Customer {Id=16, FirstName = "Tim", LastName = "Fitzgerald"},
                new Customer {Id=17, FirstName = "David", LastName = "Ortiz"},
                new Customer {Id=18, FirstName = "Steve", LastName = "Selikoff"},
                new Customer {Id=19, FirstName = "Bjorn", LastName = "Rettig"},
                new Customer {Id=20, FirstName = "Carol", LastName = "Philips"}
            };
        }

        public override Customer GetById(int id)
        {
            Console.WriteLine($"--> Fetching Customer By Id: {id}");
            return Customers.FirstOrDefault(p => p.Id == id);
        }

        public override IReadOnlyList<Customer> ListAll()
        {
            Console.WriteLine("--> Fetching All Customers");
            return Customers.OrderBy(c => c.LastName).ThenBy(x => x.FirstName).ToList();
        }

        public override int Count()
        {
            Console.WriteLine("--> Fetching Count of Customers");
            return Customers.Count;
        }

        public Customer GetCustomerByFullName(string firstName, string lastName)
        {
            Console.WriteLine($"--> Fetching Customer By Name: {lastName}, {firstName}");
            return Customers.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
        }
    }
}