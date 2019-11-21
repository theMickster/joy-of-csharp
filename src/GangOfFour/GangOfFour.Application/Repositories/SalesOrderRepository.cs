using System;
using System.Collections.Generic;
using System.Linq;
using GangOfFour.Core.Entities.Sales;
using GangOfFour.Core.Interfaces.Repositories;

namespace GangOfFour.Application.Repositories
{
    public class SalesOrderRepository : Repository<SalesOrder>, ISalesOrderRepository
    {
        private IList<SalesOrder> SalesOrders { get; set; }

        private IList<Product> Products { get; }

        private IList<Customer> Customers { get; }

        public SalesOrderRepository()
        {
            #region CreateProducts
            Products = new List<Product>
            {
                new Product {Id = 974, Name = "Road-200 Blue, 40", ListPrice = 559.99m, ProductNumber = "BK-R02B-40", Size = 40, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 27.35m},
                new Product {Id = 975, Name = "Road-200 Blue, 42", ListPrice = 559.99m, ProductNumber = "BK-R02B-42", Size = 42, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 27.77m},
                new Product {Id = 976, Name = "Road-200 Blue, 44", ListPrice = 559.99m, ProductNumber = "BK-R02B-44", Size = 44, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 28.13m},
                new Product {Id = 977, Name = "Road-200 Blue, 48", ListPrice = 559.99m, ProductNumber = "BK-R02B-48", Size = 48, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 28.42m},
                new Product {Id = 978, Name = "Road-200 Blue, 52", ListPrice = 559.99m, ProductNumber = "BK-R02B-52", Size = 52, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 28.68m},

                new Product {Id = 979, Name = "Road-400 Pink, 40", ListPrice = 859.99m, ProductNumber = "BK-R05P-40", Size = 40, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 27.35m},
                new Product {Id = 980, Name = "Road-400 Pink, 42", ListPrice = 859.99m, ProductNumber = "BK-R05P-42", Size = 42, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 27.77m},
                new Product {Id = 981, Name = "Road-400 Pink, 44", ListPrice = 859.99m, ProductNumber = "BK-R05P-44", Size = 44, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 28.13m},
                new Product {Id = 982, Name = "Road-400 Pink, 48", ListPrice = 859.99m, ProductNumber = "BK-R05P-48", Size = 48, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 28.42m},
                new Product {Id = 983, Name = "Road-400 Pink, 52", ListPrice = 859.99m, ProductNumber = "BK-R05P-52", Size = 52, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 28.68m},

                new Product {Id = 984, Name = "Mountain-500 Silver, 40", ListPrice = 564.99m, ProductNumber = "BK-M18S-40", Size = 40, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 27.35m},
                new Product {Id = 985, Name = "Mountain-500 Silver, 42", ListPrice = 564.99m, ProductNumber = "BK-M18S-42", Size = 42, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 27.77m},
                new Product {Id = 986, Name = "Mountain-500 Silver, 44", ListPrice = 564.99m, ProductNumber = "BK-M18S-44", Size = 44, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 28.13m},
                new Product {Id = 987, Name = "Mountain-500 Silver, 48", ListPrice = 564.99m, ProductNumber = "BK-M18S-48", Size = 48, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 28.42m},
                new Product {Id = 988, Name = "Mountain-500 Silver, 52", ListPrice = 564.99m, ProductNumber = "BK-M18S-52", Size = 52, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 28.68m},

                new Product {Id = 989, Name = "Mountain-500 Black, 40", ListPrice = 539.99m, ProductNumber = "BK-M18B-40", Size = 40, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 27.35m},
                new Product {Id = 990, Name = "Mountain-500 Black, 42", ListPrice = 539.99m, ProductNumber = "BK-M18B-42", Size = 42, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 27.77m},
                new Product {Id = 991, Name = "Mountain-500 Black, 44", ListPrice = 539.99m, ProductNumber = "BK-M18B-44", Size = 44, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 28.13m},
                new Product {Id = 992, Name = "Mountain-500 Black, 48", ListPrice = 539.99m, ProductNumber = "BK-M18B-48", Size = 48, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 28.42m},
                new Product {Id = 993, Name = "Mountain-500 Black, 52", ListPrice = 539.99m, ProductNumber = "BK-M18B-52", Size = 52, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 28.68m},

                new Product {Id = 994, Name = "Triathlon-TR1000 Red, 40", ListPrice = 1259.99m, ProductNumber = "BK-TR1R-40", Size = 40, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 27.35m},
                new Product {Id = 995, Name = "Triathlon-TR1000 Red, 42", ListPrice = 1259.99m, ProductNumber = "BK-TR1R-42", Size = 42, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 27.77m},
                new Product {Id = 996, Name = "Triathlon-TR1000 Red, 44", ListPrice = 1259.99m, ProductNumber = "BK-TR1R-44", Size = 44, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 28.13m},
                new Product {Id = 997, Name = "Triathlon-TR1000 Red, 48", ListPrice = 1259.99m, ProductNumber = "BK-TR1R-48", Size = 48, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 28.42m},
                new Product {Id = 998, Name = "Triathlon-TR1000 Red, 52", ListPrice = 1259.99m, ProductNumber = "BK-TR1R-52", Size = 52, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 28.68m},

                new Product {Id = 999, Name = "Triathlon-TR1000 Yellow, 40", ListPrice = 1459.99m, ProductNumber = "BK-TR1Y-40", Size = 40, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 27.35m},
                new Product {Id = 1000, Name = "Triathlon-TR1000 Yellow, 42", ListPrice = 1459.99m, ProductNumber = "BK-TR1Y-42", Size = 42, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 27.77m},
                new Product {Id = 1001, Name = "Triathlon-TR1000 Yellow, 44", ListPrice = 1459.99m, ProductNumber = "BK-TR1Y-44", Size = 44, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 28.13m},
                new Product {Id = 1002, Name = "Triathlon-TR1000 Yellow, 48", ListPrice = 1459.99m, ProductNumber = "BK-TR1Y-48", Size = 48, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 28.42m},
                new Product {Id = 1003, Name = "Triathlon-TR1000 Yellow, 52", ListPrice = 1459.99m, ProductNumber = "BK-TR1Y-52", Size = 52, UnitOfMeasure = UnitOfMeasure.Centimeter, Weight = 28.68m}
            };


            #endregion

            #region CreateCustomers
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
            #endregion

            #region CreateSalesOrders

            SalesOrders = new List<SalesOrder>
            {
                new SalesOrder
                {
                    Id = 1,
                    AccountNumber = "10-4020-000117",
                    OrderDate = Convert.ToDateTime("10-15-2008"),
                    CreateDate = Convert.ToDateTime("10-15-2008"),
                    OnlineOrder = false,
                    Customer =  Customers.FirstOrDefault(x => x.Id == 1),
                    SalesOrderDetails = new List<SalesOrderDetail>
                        {
                            new SalesOrderDetail{SalesOrderId = 1, OrderQuantity = 1, ProductId = 974, UnitPrice = 659.99m, Product = Products.FirstOrDefault(p =>p.Id==974)},
                            new SalesOrderDetail{SalesOrderId = 2, OrderQuantity = 1, ProductId = 982, UnitPrice = 1459.99m, Product = Products.FirstOrDefault(p =>p.Id==982)},
                            new SalesOrderDetail{SalesOrderId = 3, OrderQuantity = 2, ProductId = 997, UnitPrice = 1899.99m, Product = Products.FirstOrDefault(p =>p.Id==997)}
                        }
                },

                new SalesOrder
                {
                    Id = 2,
                    AccountNumber = "10-4020-000442",
                    OrderDate = Convert.ToDateTime("10-16-2008"),
                    CreateDate = Convert.ToDateTime("10-16-2008"),
                    OnlineOrder = false,
                    Customer =  Customers.FirstOrDefault(x => x.Id == 2),
                    SalesOrderDetails = new List<SalesOrderDetail>
                    {
                        new SalesOrderDetail{SalesOrderId = 4, OrderQuantity = 1, ProductId = 994, UnitPrice = 1599.99m, Product = Products.FirstOrDefault(p =>p.Id==994)},
                        new SalesOrderDetail{SalesOrderId = 5, OrderQuantity = 1, ProductId = 991, UnitPrice = 859.59m, Product = Products.FirstOrDefault(p =>p.Id==991)}
                    }
                },

                new SalesOrder
                {
                    Id = 3,
                    AccountNumber = "10-4020-000227",
                    OrderDate = Convert.ToDateTime("10-18-2008"),
                    CreateDate= Convert.ToDateTime("10-18-2008"),
                    OnlineOrder = false,
                    Customer =  Customers.FirstOrDefault(x => x.Id == 3),
                    SalesOrderDetails = new List<SalesOrderDetail>
                    {
                        new SalesOrderDetail{SalesOrderId = 6, OrderQuantity = 1, ProductId = 978, UnitPrice = 819.99m, Product = Products.FirstOrDefault(p =>p.Id==978)}
                    }
                },

                new SalesOrder
                {
                    Id = 4,
                    AccountNumber = "10-4020-000510",
                    OrderDate = Convert.ToDateTime("11-01-2008"),
                    CreateDate= Convert.ToDateTime("11-01-2008"),
                    OnlineOrder = true,
                    Customer =  Customers.FirstOrDefault(x => x.Id == 4),
                    SalesOrderDetails = new List<SalesOrderDetail>
                    {
                        new SalesOrderDetail{SalesOrderId = 7, OrderQuantity = 5, ProductId = 1002, UnitPrice = 1599.99m, Product = Products.FirstOrDefault(p =>p.Id==1002)}
                    }
                },

                new SalesOrder
                {
                    Id = 5,
                    AccountNumber = "10-4020-000119",
                    OrderDate = Convert.ToDateTime("11-03-2008"),
                    CreateDate = Convert.ToDateTime("11-03-2008"),
                    OnlineOrder = true,
                    Customer =  Customers.FirstOrDefault(x => x.Id == 5),
                    SalesOrderDetails = new List<SalesOrderDetail>
                    {
                        new SalesOrderDetail{SalesOrderId = 8, OrderQuantity = 2, ProductId = 992, UnitPrice = 679.99m, Product = Products.FirstOrDefault(p =>p.Id==992)}
                    }
                },

                new SalesOrder
                {
                    Id = 6,
                    AccountNumber = "10-4020-000618",
                    OrderDate = Convert.ToDateTime("11-03-2008"),
                    CreateDate= Convert.ToDateTime("11-03-2008"),
                    OnlineOrder = true,
                    Customer =  Customers.FirstOrDefault(x => x.Id == 8),
                    SalesOrderDetails = new List<SalesOrderDetail>
                    {
                        new SalesOrderDetail{SalesOrderId = 9, OrderQuantity = 1, ProductId = 981, UnitPrice = 999.99m, Product = Products.FirstOrDefault(p =>p.Id==981)}
                    }
                },

                new SalesOrder
                {
                    Id = 7,
                    AccountNumber = "10-4020-000491",
                    OrderDate = Convert.ToDateTime("11-04-2008"),
                    CreateDate = Convert.ToDateTime("11-04-2008"),
                    OnlineOrder = true,
                    Customer =  Customers.FirstOrDefault(x => x.Id == 8),
                    SalesOrderDetails = new List<SalesOrderDetail>
                    {
                        new SalesOrderDetail{SalesOrderId = 10, OrderQuantity = 10, ProductId = 976, UnitPrice = 699.99m, Product = Products.FirstOrDefault(p =>p.Id==976)}
                    }
                },

                new SalesOrder
                {
                    Id=8,
                    AccountNumber = "10-4020-000486",
                    OrderDate = Convert.ToDateTime("11-05-2008"),
                    CreateDate = Convert.ToDateTime("11-05-2008"),
                    OnlineOrder = true,
                    Customer =  Customers.FirstOrDefault(x => x.Id == 9),
                    SalesOrderDetails = new List<SalesOrderDetail>
                    {
                        new SalesOrderDetail{SalesOrderId = 11, OrderQuantity = 1, ProductId = 992, UnitPrice = 699.99m, Product = Products.FirstOrDefault(p =>p.Id==992)}
                    }

                },

                new SalesOrder
                {
                    Id = 9,
                    AccountNumber = "10-4020-000269",
                    OrderDate = Convert.ToDateTime("11-05-2008"),
                    CreateDate = Convert.ToDateTime("11-05-2008"),
                    OnlineOrder = true,
                    Customer =  Customers.FirstOrDefault(x => x.Id == 15),
                    SalesOrderDetails = new List<SalesOrderDetail>
                    {
                        new SalesOrderDetail{SalesOrderId = 12, OrderQuantity = 1, ProductId = 999, UnitPrice = 1899.99m, Product = Products.FirstOrDefault(p =>p.Id==999)},
                        new SalesOrderDetail{SalesOrderId = 13, OrderQuantity = 1, ProductId = 993, UnitPrice = 1699.99m, Product = Products.FirstOrDefault(p =>p.Id==993)},
                        new SalesOrderDetail{SalesOrderId = 14, OrderQuantity = 1, ProductId = 980, UnitPrice = 999.99m, Product = Products.FirstOrDefault(p =>p.Id==980)},
                        new SalesOrderDetail{SalesOrderId = 15, OrderQuantity = 1, ProductId = 986, UnitPrice = 715.99m, Product = Products.FirstOrDefault(p =>p.Id==986)}
                    }
                },

                new SalesOrder
                {
                    Id = 10,
                    AccountNumber = "10-4030-025863",
                    OrderDate = Convert.ToDateTime("11-05-2008"),
                    CreateDate = Convert.ToDateTime("11-05-2008"),
                    OnlineOrder = true,
                    Customer =  Customers.FirstOrDefault(x => x.Id == 16),
                    SalesOrderDetails = new List<SalesOrderDetail>
                    {
                        new SalesOrderDetail{SalesOrderId = 16, OrderQuantity = 1, ProductId = 978, UnitPrice = 629.99m, Product = Products.FirstOrDefault(p =>p.Id==978)},
                        new SalesOrderDetail{SalesOrderId = 17, OrderQuantity = 1, ProductId = 979, UnitPrice = 929.99m, Product = Products.FirstOrDefault(p =>p.Id==979)},
                        new SalesOrderDetail{SalesOrderId = 18, OrderQuantity = 1, ProductId = 989, UnitPrice = 599.99m, Product = Products.FirstOrDefault(p =>p.Id==989)},
                        new SalesOrderDetail{SalesOrderId = 19, OrderQuantity = 1, ProductId = 998, UnitPrice = 1549.99m, Product = Products.FirstOrDefault(p =>p.Id==998)},
                        new SalesOrderDetail{SalesOrderId = 20, OrderQuantity = 2, ProductId = 986, UnitPrice = 699.99m, Product = Products.FirstOrDefault(p =>p.Id==986)}

                    }
                },

            };

            #endregion
        }

        public override SalesOrder GetById(int id)
        {
            Console.WriteLine($"--> Fetching Sales Order By Id: {id}");
            return SalesOrders.FirstOrDefault(p => p.Id == id);
        }

        public override IReadOnlyList<SalesOrder> ListAll()
        {
            Console.WriteLine("--> Fetching All Sales Orders");
            return SalesOrders.OrderBy(c => c.Id).ToList();
        }

        public override int Count()
        {
            Console.WriteLine("--> Fetching Count of Sales Orders");
            return SalesOrders.Count;
        }

        public virtual List<SalesOrder> GetByCustomerId(int customerId)
        {
            return SalesOrders.Where(o => o.Customer.Id == customerId).ToList();
        }

        public virtual List<SalesOrder> ReportOrdersWithMultipleDetailLines()
        {
            return SalesOrders.Where(c => c.SalesOrderDetails.Count > 1 ).ToList();
        }
    }
}