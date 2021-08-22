using System;
using ProductsCatalog.Core.Application.Interfaces;
using ProductsCatalog.Core.Domain.Models;
using Infrastructure.IoC;
using System.Threading.Tasks;

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
            Console.WriteLine(category);
        }
    }
}
