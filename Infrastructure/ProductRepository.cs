using ProductsCatalog.Domain.Models;
using ProductsCatalog.Application.Interfaces;
using ProductsCatalog.Domain.Interfaces;
using System.Collections.Generic;


namespace ProductsCatalog.Infrastructure
{
    public class ProductRepository : IProductRepository
    {
        public IList<IProduct> GetAllProducts()
        {
            // TODO: Implement factory to avoid new-ing up Product
            IList<IProduct> productsList = new List<IProduct>();
            IProduct product1 = new Product() {  
                Name = "Produto1",
                Description = "Description product 1",
                IsActive = true
            };

            productsList.Add(product1);

            IProduct product2 = new Product()
            {
                Name = "Produto2",
                Description = "Description product 2",
                IsActive = true
            };

            productsList.Add(product2);
            return productsList;
        }
    }
}
