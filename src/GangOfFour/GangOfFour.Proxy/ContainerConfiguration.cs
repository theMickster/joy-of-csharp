using Autofac;
using GangOfFour.Application.Repositories;
using GangOfFour.Core.Entities;
using GangOfFour.Core.Interfaces;
using GangOfFour.Core.Interfaces.Repositories;
using Microsoft.Extensions.Caching.Memory;

namespace GangOfFour.Proxy
{
    internal static class ContainerConfiguration
    {
        public static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            // If not using the Keyed pattern, we'd used a single, simple register methodology.
            //builder.RegisterType<SalesOrderRepository>().As<ISalesOrderRepository>();

            builder.RegisterType<SalesOrderRepository>().Keyed<ISalesOrderRepository>("NonCached");

            builder.RegisterType<CachedSalesOrderRepository>().Keyed<ISalesOrderRepository>("Cached");

            builder.RegisterType<MathProxy>().As<IMath>();

            return builder.Build();
        }
    }
}