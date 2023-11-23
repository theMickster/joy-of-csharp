using Autofac;
using GangOfFour.Application.Commands;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Command
{
    internal static class ContainerConfiguration
    {
        public static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<CommandFactory>().As<ICommandFactory>();

            builder.RegisterType<AccountTransactionManager>().As<IAccountTransactionManager>();

            return builder.Build();
        }
    }
}