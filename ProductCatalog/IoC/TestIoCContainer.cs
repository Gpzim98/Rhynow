using Autofac;
using ProductCatalog.Application.Interfaces;
using ProductsCatalog.Application;
using ProductsCatalog.Application.Interfaces;
using ProductsCatalog.Infrastructure;

namespace ProductCatalog.IoC
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
