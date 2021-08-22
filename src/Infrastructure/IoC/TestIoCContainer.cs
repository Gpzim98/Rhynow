using Autofac;
using ProductsCatalog.Core.Application;
using ProductsCatalog.Infrastructure.Data.Repositories;
using ProductsCatalog.Core.Application.Interfaces;
using ProductsCatalog.Core.Application.Interfaces.Repositories;
using ProductsCatalog.Core.Application.DTOs;
using ProductsCatalog.Infrastructure.Data.Repositories.Mocking;

namespace Infrastructure.IoC
{
    public class TestIoCContainer : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Catalog>().As<ICatalog>().InstancePerLifetimeScope();
            builder.RegisterType<ProductRepositoryMock<ProductDTO>>().As<IProductRepository<ProductDTO>>().InstancePerLifetimeScope();
            builder.RegisterType<CategoryRepositoryMock<CategoryDTO>>().As<ICategoryRepository<CategoryDTO>>().InstancePerLifetimeScope();
        }
    }
}
