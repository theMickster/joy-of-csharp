using System;
using GangOfFour.Application.Decorators;
using GangOfFour.Core.Entities.Desserts;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Decorator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Gang of Four Design Pattern - Decorator");
            
            IDessert cookie = new Cookie { BatterFlavor = "Vanilla", HasFrosting = true, FrostingFlavor = "Buttercream", UnitCost = .89m};
            cookie.UpdatePrice(1.99m);

            IDessert cake = new Cake { BatterFlavor = "Chocolate", HasFrosting = true, FrostingFlavor = "German Chocolate", UnitCost = 5.99m };
            cake.UpdatePrice(12.99m);

            IDessert cupcake = new Cupcake() { BatterFlavor = "Red Velvet", HasFrosting = true, FrostingFlavor = "Cream cheese", UnitCost = 1.39m };
            cupcake.UpdatePrice(3.99m);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(cookie.GetDetails());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(cake.GetDetails());

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(cupcake.GetDetails());

            Console.ForegroundColor = ConsoleColor.White;

            var offer = new DayOldDessertDecorator(cupcake) {DiscountPercentage = 25, Offer = "25% Day Old"};
            offer.ApplyDiscount();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{offer.Offer}  {offer.GetDetails()}");
            


        }
    }
}
