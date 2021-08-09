using Autofac;
using ProductsCatalog.Application;
using ProductsCatalog.Infrastructure.Repositories;
using ProductsCatalog.Application.Interfaces.Repositories;
using ProductsCatalog.Application.Interfaces;
using ProductsCatalog.Domain.Interfaces;

namespace Infrastructure.IoC
{
    public class TestIoCContainer : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Catalog>().As<ICatalog>().InstancePerLifetimeScope();
            builder.RegisterType<ProductRepository>().As<IProductRepository<IProduct>>().InstancePerLifetimeScope();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository<ICategory>>().InstancePerLifetimeScope();
        }
    }
}
