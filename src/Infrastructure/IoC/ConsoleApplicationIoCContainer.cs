using Autofac;
using ProductsCatalog.Core.Application;
using ProductsCatalog.Core.Application.Interfaces;
using ProductsCatalog.Core.Application.Interfaces.Repositories;
using ProductsCatalog.Infrastructure.Data.Repositories;
using ProductsCatalog.Core.Application.DTOs;

namespace Infrastructure.IoC
{
    public class ConsoleApplicationIoCContainer : Module
    {
        protected override void Load(ContainerBuilder builder)
        {   
            builder.RegisterType<ConsoleAppCatalog>().As<ICatalog>().InstancePerLifetimeScope();
            builder.RegisterType<ProductRepository>().As<IProductRepository<ProductDTO>>().InstancePerLifetimeScope();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository<CategoryDTO>>().InstancePerLifetimeScope();
        }
    }
}
