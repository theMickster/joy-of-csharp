using System;
using Autofac;
using GangOfFour.Application.Commands;
using GangOfFour.Core.Entities;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Command
{
    internal class Program
    {
        private static IContainer Container { get; set; }

        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Gang of Four Design Pattern - Command");
            Console.ForegroundColor = ConsoleColor.White;

            Container = ContainerConfiguration.ConfigureContainer();

            using var scope = Container.BeginLifetimeScope();
            
            var workerFactory = scope.Resolve<ICommandFactory>();
            var workerTransactionManager = scope.Resolve<IAccountTransactionManager>();
            var mickCheckingAccount = new Account("Mick - Checking", 0.00m);
            var mickSavingAccount = new Account("Mick - Savings", 0.00m);
            var transactionId = 1;

            Console.WriteLine(mickCheckingAccount.GetDetails());

            workerTransactionManager.AddTransaction(workerFactory.CreateCommand<Deposit>(transactionId++, mickCheckingAccount, 25.00m));
            workerTransactionManager.AddTransaction(workerFactory.CreateCommand<Deposit>(transactionId++, mickCheckingAccount, 30.00m));
            workerTransactionManager.AddTransaction(workerFactory.CreateCommand<Deposit>(transactionId++, mickCheckingAccount, 50.00m));
            workerTransactionManager.AddTransaction(workerFactory.CreateCommand<Withdraw>(transactionId++, mickCheckingAccount, 75.00m));
            workerTransactionManager.AddTransaction(workerFactory.CreateCommand<Transfer>(transactionId++, mickCheckingAccount, mickSavingAccount, 15.00m));
            
            workerTransactionManager.ProcessPendingTransactions();
            
            Console.WriteLine(mickCheckingAccount.GetDetails());
            
            Console.WriteLine(mickSavingAccount.GetDetails());
            
            Console.ReadKey();
        }
    }
}
