using Autofac;
using iProspect.TestApp.Abstractions;
using iProspect.TestApp.Implementations;

namespace iProspect.TestApp
{
    public static class AppContainerBuilder
    {
        public static IContainer Build()
        {
            var builder = new ContainerBuilder();
            RegisterTypes( builder );
            var container = builder.Build();
            return container;
        }

        private static void RegisterTypes( ContainerBuilder builder )
        {
            builder.RegisterType< Job >().As< IJob >();
            builder.RegisterType<Converter>().As<IConverter>();
            builder.RegisterType<FileProvider>().As<IFileProvider>();

            //TODO Register IConverter and IFileProvider
        }
    }
}