using Autofac;

namespace GangOfFour.Iterator
{
    internal static class ContainerConfiguration
    {
        public static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            
            return builder.Build();
        }
    }
}