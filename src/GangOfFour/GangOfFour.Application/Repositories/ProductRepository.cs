using System;
using GangOfFour.Core.Entities.Sales;
using GangOfFour.Core.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace GangOfFour.Application.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private IList<Product> Products { get; set; }

        public ProductRepository()
        {
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
        }

        public override Product GetById(int id)
        {
            Console.WriteLine($"--> Fetching Product By Id: {id}");
            return Products.FirstOrDefault(p => p.Id == id);
        }

        public override IReadOnlyList<Product> ListAll()
        {
            Console.WriteLine("--> Fetching All Products");
            return Products.OrderBy(p => p.Name ).ToList();
        }

        public override int Count()
        {
            Console.WriteLine("--> Fetching Count of Products");
            return Products.Count;
        }

        public Product GetByProductNumber(string productNumber)
        {
            Console.WriteLine($"--> Fetching Product By Number: {productNumber}");
            return Products.FirstOrDefault(p => p.ProductNumber == productNumber);
        }
    }
}