using ProductCatalog.Infrastructure.Repositories;
using ProductsCatalog.Application.Interfaces.Repositories;
using ProductsCatalog.Domain.Interfaces;

namespace ProductsCatalog.Infrastructure.Repositories
{
    public class ProductRepository : GenericRepository<IProduct>, IProductRepository<IProduct>
    {
        public ProductRepository(
            string tableName = "Products") : base(tableName)
        {
        }

        void IProductRepository<IProduct>.ProductRepoSpecificMethod()
        {
            throw new System.NotImplementedException();
        }
    }
}
