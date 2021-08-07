using System;
using ProductsCatalog.Application;
using ProductsCatalog.Application.Interfaces;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ICatalog catalog = new Catalog();
            catalog.GetAllCategories();
            Console.WriteLine("Hello World!");
        }
    }
}
