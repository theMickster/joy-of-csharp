using System;
using Autofac;
using GangOfFour.Application.Iterators;
using GangOfFour.Core.Entities;

namespace GangOfFour.Iterator
{
    internal class Program
    {
        private static IContainer Container { get; set; }

        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Gang of Four Design Pattern - Iterator");
            Console.ForegroundColor = ConsoleColor.White;

            Container = ContainerConfiguration.ConfigureContainer();

            var collection = new AccountCollection
            {
                [0] = new Account("Alice", 10.00m),
                [1] = new Account("Anthony", 20.00m),
                [2] = new Account("Bethany", 30.00m),
                [3] = new Account("Charles", 40.00m),
                [4] = new Account("DiAntonio", 50.00m),
                [5] = new Account("Freddy", 60.00m),
                [5] = new Account("Mike", 100.00m)
            };

            var iterator = new AccountIterator(collection)
            {
                Step = 1
            };

            Console.WriteLine("Beginning iterating over collection...");
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (var account = iterator.First(); !iterator.IsDone; account = iterator.Next())
            {
                Console.WriteLine(account.GetDetails());
            }
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
