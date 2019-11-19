using Autofac;
using GangOfFour.Application.Factories;
using GangOfFour.Core.Enumerations;
using GangOfFour.Core.Interfaces;

namespace GangOfFour.Factory
{
    internal static class ContainerConfiguration
    {
        public static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ResumeFactory>().Keyed<IDocumentFactory>(DocumentType.Resume);

            builder.RegisterType<ReportFactory>().Keyed<IDocumentFactory>(DocumentType.Report);

            return builder.Build();
        }
    }
}