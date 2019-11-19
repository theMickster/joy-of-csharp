using Autofac;
using GangOfFour.Application.Builders;
using GangOfFour.Core.Enumerations;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Builder
{
    internal static class ContainerConfiguration
    {
        public static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            
            builder.RegisterType<BicycleShop>().As<IBicycleShop>().InstancePerLifetimeScope();

            builder.RegisterType<RoadBicycleBuilder>().Keyed<IBicycleBuilder>(BicycleType.Road.ToString());

            builder.RegisterType<TriathlonBicycleBuilder>().Keyed<IBicycleBuilder>(BicycleType.Triathlon.ToString());

            builder.RegisterType<MountainBicycleBuilder>().Keyed<IBicycleBuilder>(BicycleType.Mountain.ToString());

            return builder.Build();
        }
    }
}