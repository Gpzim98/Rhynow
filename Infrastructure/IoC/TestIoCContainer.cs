using Autofac;
using ProductsCatalog.Application.Interfaces;
using ProductsCatalog.Application;
using ProductsCatalog.Application.Interfaces;
using ProductsCatalog.Infrastructure;

namespace Infrastructure.IoC
{
    public class TestIoCContainer : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Catalog>().As<ICatalog>().InstancePerLifetimeScope();
            builder.RegisterType<ProductRepository>().As<IProductRepository>().InstancePerLifetimeScope();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>().InstancePerLifetimeScope();
        }
    }
}
