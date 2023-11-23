using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using Autofac.Core;
using GangOfFour.Core.Entities.Sales;
using GangOfFour.Core.Interfaces;
using GangOfFour.Core.Interfaces.Repositories;

namespace GangOfFour.Strategy
{
    internal class Program
    {
        private static IContainer Container { get; set; }

        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Gang of Four Design Pattern - Strategy");
            Console.WriteLine("");
            Container = ContainerConfiguration.ConfigureContainer();
            using var scope = Container.BeginLifetimeScope();
            var salesOrders = scope.Resolve<ISalesOrderRepository>().ListAll();

            CalculateDhlShippingRates(salesOrders);

            CalculateFedExShippingRates(salesOrders);

            CalculateUspsShippingRates(salesOrders);

            CalculateUpsShippingRates(salesOrders);

            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void CalculateUpsShippingRates(IReadOnlyList<SalesOrder> salesOrders)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"****** UPS => Calculating Shipping Sales Orders ******");
            const string shippingStrategy = "Ups";

            using var scope = Container.BeginLifetimeScope(shippingStrategy);
            try
            {
                var worker = scope.ResolveKeyed<IShippingStrategy>(serviceKey: shippingStrategy);

                foreach (var salesOrder in salesOrders)
                {
                    var shipping = worker.Calculate(salesOrder);
                    var orderCost = salesOrder.SalesOrderDetails.Sum(p => p.TotalPrice);
                    var finalCost = shipping + orderCost;

                    Console.WriteLine($"  Sales Order {salesOrder.Id} => Order Cost: ${orderCost} + Shipping Cost: ${shipping} Total Cost: ${finalCost}");
                }
            }
            catch (DependencyResolutionException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(
                    $"Unable to resolve instance for IShippingStrategy. {Environment.NewLine}{ex.InnerException}");
            }
            finally
            {
                Console.WriteLine();
            }
        }

        private static void CalculateUspsShippingRates(IReadOnlyList<SalesOrder> salesOrders)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"****** USPS => Calculating Shipping Sales Orders ******");
            const string shippingStrategy = "Usps";

            using var scope = Container.BeginLifetimeScope(shippingStrategy);
            try
            {
                var worker = scope.ResolveKeyed<IShippingStrategy>(serviceKey: shippingStrategy);

                foreach (var salesOrder in salesOrders)
                {
                    var shipping = worker.Calculate(salesOrder);
                    var orderCost = salesOrder.SalesOrderDetails.Sum(p => p.TotalPrice);
                    var finalCost = shipping + orderCost;

                    Console.WriteLine($"  Sales Order {salesOrder.Id} => Order Cost: ${orderCost} + Shipping Cost: ${shipping} Total Cost: ${finalCost}");
                }
            }
            catch (DependencyResolutionException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(
                    $"Unable to resolve instance for IShippingStrategy. {Environment.NewLine}{ex.InnerException}");
            }
            finally
            {
                Console.WriteLine();
            }
        }

        private static void CalculateFedExShippingRates(IReadOnlyList<SalesOrder> salesOrders)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"****** FedEx => Calculating Shipping Sales Orders ******");
            const string shippingStrategy = "FedEx";

            using var scope = Container.BeginLifetimeScope(shippingStrategy);
            try
            {
                var worker = scope.ResolveKeyed<IShippingStrategy>(serviceKey: shippingStrategy);

                foreach (var salesOrder in salesOrders)
                {
                    var shipping = worker.Calculate(salesOrder);
                    var orderCost = salesOrder.SalesOrderDetails.Sum(p => p.TotalPrice);
                    var finalCost = shipping + orderCost;

                    Console.WriteLine($"  Sales Order {salesOrder.Id} => Order Cost: ${orderCost} + Shipping Cost: ${shipping} Total Cost: ${finalCost}");
                }
            }
            catch (DependencyResolutionException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(
                    $"Unable to resolve instance for IShippingStrategy. {Environment.NewLine}{ex.InnerException}");
            }
            finally
            {
                Console.WriteLine();
            }
        }

        private static void CalculateDhlShippingRates(IReadOnlyList<SalesOrder> salesOrders)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"****** Dhl => Calculating Shipping Sales Orders ******");
            const string shippingStrategy = "Dhl";

            using var scope = Container.BeginLifetimeScope(shippingStrategy);
            try
            {
                var worker = scope.ResolveKeyed<IShippingStrategy>(serviceKey: shippingStrategy);

                foreach (var salesOrder in salesOrders)
                {
                    var shipping = worker.Calculate(salesOrder);
                    var orderCost = salesOrder.SalesOrderDetails.Sum(p => p.TotalPrice);
                    var finalCost = shipping + orderCost;

                    Console.WriteLine($"  Sales Order {salesOrder.Id} => Order Cost: ${orderCost} + Shipping Cost: ${shipping} Total Cost: ${finalCost}");
                }
            }
            catch (DependencyResolutionException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(
                    $"Unable to resolve instance for IShippingStrategy. {Environment.NewLine}{ex.InnerException}");
            }
            finally
            {
                Console.WriteLine();
            }
        }
    }
}
