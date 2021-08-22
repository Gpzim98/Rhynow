using ProductsCatalog.Core.Application.Interfaces.Repositories;
using ProductsCatalog.Core.Domain.Models;

namespace ProductsCatalog.Infrastructure.Data.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository<Product>
    {
        public ProductRepository(
            string tableName = "Products") : base(tableName)
        {
        }

        void IProductRepository<Product>.ProductRepoSpecificMethod()
        {
            throw new System.NotImplementedException();
        }
    }
}
