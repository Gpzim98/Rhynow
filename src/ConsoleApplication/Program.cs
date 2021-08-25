using System;
using ProductsCatalog.Core.Application.Interfaces;
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
            var categoryId = new Guid("27f9f112-1b4c-44b9-8ed9-2abdc351d005");
            var category = catalog.GetCategoryById(categoryId);
            Console.WriteLine(category.Result.ToString());
        }
    }
}
