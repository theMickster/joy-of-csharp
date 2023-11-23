using System;
using GangOfFour.Application.Observers;

namespace GangOfFour.Observer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Gang of Four Design Pattern - Observer");
            Console.ForegroundColor = ConsoleColor.White;

            // Create IBM stock and attach investors
            var ibm = new IBM("International Business Machines","IBM", 120.00m);
            ibm.Attach(new StockInvestor {Name = "Tim"});
            ibm.Attach(new StockInvestor { Name = "John" });

            // Fluctuating prices will notify investors
            ibm.Price = 120.10m;
            ibm.Price = 121.00m;
            ibm.Price = 120.50m;
            ibm.Price = 120.75m;


        }
    }
}
