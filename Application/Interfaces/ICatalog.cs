using ProductsCatalog.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace ProductsCatalog.Application.Interfaces
{
    public interface ICatalog
    {
        IList<IProduct> GetAllProducts();
        IList<ICategory> GetAllCategories();
        ICategory GetCategoryById(Guid categoryId);
    }
}
