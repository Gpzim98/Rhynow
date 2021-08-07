using Autofac;
using ProductsCatalog.Application;
using ProductsCatalog.Application.Interfaces;
using ProductsCatalog.Infrastructure;

namespace Infrastructure.IoC
{
    public class ConsoleApplicationIoCContainer : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ConsoleAppCatalog>().As<ICatalog>().InstancePerLifetimeScope();
            builder.RegisterType<ProductRepository>().As<IProductRepository>().InstancePerLifetimeScope();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>().InstancePerLifetimeScope();
        }
    }
}
