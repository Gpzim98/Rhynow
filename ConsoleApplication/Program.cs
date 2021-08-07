using System;
using ProductsCatalog.Application;
using ProductsCatalog.Application.Interfaces;
using Infrastructure.IoC;

namespace ConsoleApplication
{
    class IoCContainer : IoCSupportedTest<ConsoleApplicationIoCContainer>
    {
        public ICatalog productsCatalog;
        public IoCContainer()
        {
            productsCatalog = Resolve<ICatalog>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IoCContainer ioCContainer = new IoCContainer();
            ICatalog catalog = ioCContainer.productsCatalog;
            var category = catalog.GetCategoryById(Guid.NewGuid());
            Console.WriteLine(category.Name);
        }
    }
}
