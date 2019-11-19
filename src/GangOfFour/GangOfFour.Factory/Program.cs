using Autofac;
using GangOfFour.Core.Enumerations;
using GangOfFour.Core.Interfaces;
using System;

namespace GangOfFour.Factory
{
    internal class Program
    {
        private static IContainer Container { get; set; }

        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Gang of Four Design Pattern - Abstract Factory");

            Container = ContainerConfiguration.ConfigureContainer();

            ProduceResumeDocument();

            ProduceReportDocument();

            Console.ReadKey();
        }

        private static void ProduceReportDocument()
        {
            using var scope = Container.BeginLifetimeScope(DocumentType.Report);
            var workerFactory = scope.ResolveKeyed<IDocumentFactory>(DocumentType.Report);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"****** New {DocumentType.Report} Document Created from the Factory ******");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(workerFactory.GetDetails());
            Console.WriteLine();
        }

        private static void ProduceResumeDocument()
        {
            using var scope = Container.BeginLifetimeScope(DocumentType.Resume);
            var workerFactory = scope.ResolveKeyed<IDocumentFactory>(DocumentType.Resume);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"****** New {DocumentType.Resume} Document Created from the Factory ******");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(workerFactory.GetDetails());
            Console.WriteLine();
        }
    }
}
