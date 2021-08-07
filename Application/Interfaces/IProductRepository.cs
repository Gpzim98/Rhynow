using ProductsCatalog.Domain.Interfaces;
using System.Collections.Generic;

namespace ProductsCatalog.Application.Interfaces
{
    public interface IProductRepository
    {
        IList<IProduct> GetAllProducts();
    }
}
