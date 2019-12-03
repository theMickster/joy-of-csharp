using Autofac;
using GangOfFour.Application.Repositories;
using GangOfFour.Application.Strategies;
using GangOfFour.Core.Interfaces;
using GangOfFour.Core.Interfaces.Repositories;

namespace GangOfFour.Strategy
{
    public class ContainerConfiguration
    {
        public static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<SalesOrderRepository>().As<ISalesOrderRepository>();

            builder.RegisterType<DhlShippingStrategy>().Keyed<IShippingStrategy>("Dhl");

            builder.RegisterType<FedExShippingStrategy>().Keyed<IShippingStrategy>("FedEx");

            builder.RegisterType<UspsShippingStrategy>().Keyed<IShippingStrategy>("Usps");
            
            builder.RegisterType<UpsShippingStrategy>().Keyed<IShippingStrategy>("Ups");

            return builder.Build();
        }
    }
}