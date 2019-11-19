using System;
using Autofac;
using GangOfFour.Core.Enumerations;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Builder
{
    internal class Program
    {
        private static IContainer Container { get; set; }

        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Gang of Four Design Pattern - Builder");

            Container = ContainerConfiguration.ConfigureContainer();

            BuildTriathlonBike("Olivia");

            BuildRoadBike("Mya");

            BuildMountainBike("Nora");

            Console.ReadKey();

        }

        private static void BuildRoadBike(string bicycleName)
        {
            using var scope = Container.BeginLifetimeScope(BicycleType.Road.ToString());

            var builder = scope.ResolveKeyed<IBicycleBuilder>(serviceKey: BicycleType.Road.ToString());
            var worker = scope.Resolve<IBicycleShop>(new NamedParameter(nameof(IBicycleBuilder), builder));
            worker.UpdateBicycleBuilder(builder);
            worker.ConstructBicycle();
            var myNewRoadBicycle = worker.GetBicycle();
            myNewRoadBicycle.UpdateBicycleName(bicycleName);
            myNewRoadBicycle.UpdateBicycleBicycleType(BicycleType.Road);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"****** New {BicycleType.Road.ToString()} Bike Created ******");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(myNewRoadBicycle.ListAssembledParts());
        }

        private static void BuildTriathlonBike(string bicycleName)
        {
            using var scope = Container.BeginLifetimeScope(BicycleType.Triathlon.ToString());

            var builder = scope.ResolveKeyed<IBicycleBuilder>(serviceKey: BicycleType.Triathlon.ToString());
            var worker = scope.Resolve<IBicycleShop>(new NamedParameter(nameof(IBicycleBuilder), builder));
            worker.UpdateBicycleBuilder(builder);
            worker.ConstructBicycle();
            var myNewTriathlonBicycle = worker.GetBicycle();
            myNewTriathlonBicycle.UpdateBicycleName(bicycleName);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"****** New {BicycleType.Triathlon.ToString()} Bike Created ******");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(myNewTriathlonBicycle.ListAssembledParts());
        }

        private static void BuildMountainBike(string bicycleName)
        {
            using var scope = Container.BeginLifetimeScope(BicycleType.Mountain.ToString());

            var builder = scope.ResolveKeyed<IBicycleBuilder>(serviceKey: BicycleType.Mountain.ToString());
            var worker = scope.Resolve<IBicycleShop>(new NamedParameter(nameof(IBicycleBuilder), builder));
            worker.UpdateBicycleBuilder(builder);
            worker.ConstructBicycle();
            var myNewTriathlonBicycle = worker.GetBicycle();
            myNewTriathlonBicycle.UpdateBicycleName(bicycleName);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"****** New {BicycleType.Mountain.ToString()} Bike Created ******");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(myNewTriathlonBicycle.ListAssembledParts());
        }
    }
}
