using Autofac;
using GangOfFour.Application.Mediators;

namespace GangOfFour.Mediator
{
    internal static class ContainerConfiguration
    {
        public static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<BaseballChatroom>().As<IChatroom>();

            return builder.Build();
        }
    }
}