using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProductsCatalog.Core.Application.DTOs;

namespace ProductsCatalog.Core.Application.Interfaces
{
    public interface ICatalog
    {
        IList<ProductDTO> GetAllProductsAsync();
        IList<CategoryDTO> GetAllCategories();
        Task<CategoryDTO> GetCategoryById(Guid categoryId);
    }
}
