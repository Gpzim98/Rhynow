using ProductsCatalog.Domain.Interfaces;
using System;
using System.Collections.Generic;


namespace ProductsCatalog.Application.Interfaces
{
    public interface ICategoryRepository
    {
        IList<ICategory> GetAllCategories();
        ICategory GetCategoryById(Guid categoryId);
    }
}
