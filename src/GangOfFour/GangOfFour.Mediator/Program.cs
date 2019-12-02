using System;
using Autofac;
using GangOfFour.Application.Mediators;

namespace GangOfFour.Mediator
{
    internal class Program
    {
        private static IContainer Container { get; set; }

        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Gang of Four Design Pattern - Mediator");
            Console.ForegroundColor = ConsoleColor.White;

            Container = ContainerConfiguration.ConfigureContainer();

            using var scope = Container.BeginLifetimeScope();

            var workerFactory = scope.Resolve<IChatroom>();

            var ted = new BaseballWriter("Ted");
            var tom = new BaseballWriter("Tom");
            var pete = new BaseballWriter("Pete");
            var mick = new BaseballFan("Mick");

            workerFactory.Register(ted);
            workerFactory.Register(tom);
            workerFactory.Register(pete);
            workerFactory.Register(mick);

            ted.Send("Tom","Hello Tom, How are you? -Ted");
            tom.Send("Ted", "Hello Ted, I am good. How were the holidays? -Tom");






        }
    }
}
