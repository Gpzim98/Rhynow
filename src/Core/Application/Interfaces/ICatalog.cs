using ProductsCatalog.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductsCatalog.Core.Application.Interfaces
{
    public interface ICatalog
    {
        IList<Product> GetAllProductsAsync();
        IList<Category> GetAllCategories();
        Task<Category> GetCategoryById(Guid categoryId);
    }
}
