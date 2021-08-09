using Autofac;
using ProductsCatalog.Application;
using ProductsCatalog.Application.Interfaces;
using ProductsCatalog.Application.Interfaces.Repositories;
using ProductsCatalog.Domain.Interfaces;
using ProductsCatalog.Infrastructure.Repositories;

namespace Infrastructure.IoC
{
    public class ConsoleApplicationIoCContainer : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ConsoleAppCatalog>().As<ICatalog>().InstancePerLifetimeScope();
            builder.RegisterType<ProductRepository>().As<IProductRepository<IProduct>>().InstancePerLifetimeScope();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository<ICategory>>().InstancePerLifetimeScope();
        }
    }
}
