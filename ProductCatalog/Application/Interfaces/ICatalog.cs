using ProductsCatalog.Domain.Interfaces;
using System.Collections.Generic;

namespace ProductCatalog.Application.Interfaces
{
    public interface ICatalog
    {
        IList<IProduct> GetAllProducts();
        IList<ICategory> GetAllCategories();
    }
}
