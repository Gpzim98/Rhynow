using ProductsCatalog.Domain.Interfaces;
using System.Collections.Generic;

namespace ProductsCatalog.Application.Interfaces.Repositories
{
    public interface IProductRepository<IProduct> : IGenericRepository<IProduct>
    {
        void ProductRepoSpecificMethod();
    }
}
