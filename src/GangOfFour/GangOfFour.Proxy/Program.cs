using System;
using System.Linq;
using Autofac;
using Autofac.Core;
using GangOfFour.Core.Entities;
using GangOfFour.Core.Interfaces;
using GangOfFour.Core.Interfaces.Repositories;
using Microsoft.Extensions.Caching.Memory;

namespace GangOfFour.Proxy
{
    internal class Program
    {
        private static IContainer Container { get; set; }

        private static MemoryCache MemoryCache { get; set; }

        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Gang of Four Design Pattern - Proxy");
            MemoryCache = new MemoryCache(new MemoryCacheOptions());

            Container = ContainerConfiguration.ConfigureContainer();

            OperateOnNonCachedSalesOrders();

            OperateOnCachedSalesOrders();

            MyProxyMathHomework();

            Console.ReadKey();
        }

        private static void MyProxyMathHomework()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"****** My Proxy Math Homework ******");

            using var scope = Container.BeginLifetimeScope("MyMathHomework");
            try
            {
                var worker = scope.Resolve<IMath>();
                Console.WriteLine("4 + 2 = " + worker.Add(4, 2));
                Console.WriteLine("10 - 3 = " + worker.Sub(10, 3));
                Console.WriteLine("60 * 40 = " + worker.Mul(60, 40));
                Console.WriteLine("100 / 4 = " + worker.Div(100, 4));
            }
            catch (DependencyResolutionException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(
                    $"Unable to resolve Math instance for IMath. {Environment.NewLine}{ex.InnerException}");
            }
            finally
            {
                Console.WriteLine();
            }
        }

        private static void OperateOnCachedSalesOrders ()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"****** Cached Sales Orders ******");

            using var scope = Container.BeginLifetimeScope("Cached");
            try
            {
                var worker = scope.ResolveKeyed<ISalesOrderRepository>(serviceKey: "Cached",
                    parameters: new NamedParameter("cache", MemoryCache));
                var salesOrders = worker.ListAll();
                foreach (var salesOrder in salesOrders)
                {
                    Console.WriteLine(
                        $"Id: {salesOrder.Id} Account: {salesOrder.AccountNumber} Total: {salesOrder.SalesOrderDetails.Sum(x => x.TotalPrice)}");
                }

                var salesOrder01 = worker.GetById(10);
                var salesOrder02 = worker.GetById(10);
                var salesOrder03 = worker.GetById(10);
                var salesOrder04 = worker.GetById(10);
            }
            catch (DependencyResolutionException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(
                    $"Unable to resolve cached instance for ISalesOrderRepository. {Environment.NewLine}{ex.InnerException}");
            }
            finally
            {
                Console.WriteLine();
            }
        }

        private static void OperateOnNonCachedSalesOrders()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"****** Non-Cached Sales Orders ******");

            using var scope = Container.BeginLifetimeScope("NonCached");
            try
            {
                var worker = scope.ResolveKeyed<ISalesOrderRepository>(serviceKey: "NonCached");
                var salesOrders = worker.ListAll();
                foreach (var salesOrder in salesOrders)
                {
                    Console.WriteLine($"Id: {salesOrder.Id} Account: {salesOrder.AccountNumber} Total: {salesOrder.SalesOrderDetails.Sum(x => x.TotalPrice)}");
                }

                var salesOrder01 = worker.GetById(10);
                var salesOrder02 = worker.GetById(10);
                var salesOrder03 = worker.GetById(10);
                var salesOrder04 = worker.GetById(10);
            }
            catch (DependencyResolutionException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Unable to resolve non-cached instance for ISalesOrderRepository. {Environment.NewLine}{ex.InnerException}");
            }
            finally
            {
                Console.WriteLine();
            }
        }
    }
}
