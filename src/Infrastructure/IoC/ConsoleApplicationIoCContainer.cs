using Autofac;
using ProductsCatalog.Core.Application;
using ProductsCatalog.Core.Application.Interfaces;
using ProductsCatalog.Core.Application.Interfaces.Repositories;
using ProductsCatalog.Core.Domain.Models;
using ProductsCatalog.Infrastructure.Data.Repositories;

namespace Infrastructure.IoC
{
    public class ConsoleApplicationIoCContainer : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ConsoleAppCatalog>().As<ICatalog>().InstancePerLifetimeScope();
            builder.RegisterType<ProductRepository>().As<IProductRepository<Product>>().InstancePerLifetimeScope();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository<Category>>().InstancePerLifetimeScope();
        }
    }
}
