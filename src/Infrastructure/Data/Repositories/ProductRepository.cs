using ProductsCatalog.Core.Application.Interfaces.Repositories;
using ProductsCatalog.Core.Domain.Models;
using ProductsCatalog.Core.Application.DTOs;

namespace ProductsCatalog.Infrastructure.Data.Repositories
{
    public class ProductRepository : GenericRepository<ProductDTO>, IProductRepository<ProductDTO>
    {
        public ProductRepository(
            string tableName = "Products") : base(tableName)
        {
        }

        void IProductRepository<ProductDTO>.ProductRepoSpecificMethod()
        {
            throw new System.NotImplementedException();
        }
    }
}
