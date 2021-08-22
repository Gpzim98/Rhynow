using Autofac;
using ProductsCatalog.Core.Application;
using ProductsCatalog.Infrastructure.Data.Repositories;
using ProductsCatalog.Core.Domain.Models;
using ProductsCatalog.Core.Application.Interfaces;
using ProductsCatalog.Core.Application.Interfaces.Repositories;

namespace Infrastructure.IoC
{
    public class TestIoCContainer : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Catalog>().As<ICatalog>().InstancePerLifetimeScope();
            builder.RegisterType<ProductRepository>().As<IProductRepository<Product>>().InstancePerLifetimeScope();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository<Category>>().InstancePerLifetimeScope();
        }
    }
}
