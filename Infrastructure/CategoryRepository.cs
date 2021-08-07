using ProductsCatalog.Application.Interfaces;
using ProductsCatalog.Domain.Interfaces;
using System.Collections.Generic;
using ProductsCatalog.Domain.Models;
using System;

namespace ProductsCatalog.Infrastructure
{
    public class CategoryRepository : ICategoryRepository
    {
        public IList<ICategory> GetAllCategories()
        {
            IList<ICategory> categories = new List<ICategory>();
            ICategory category = new Category()
            {
                Name = "Category1",
                Description = "Test category",
                IsActive = true
            };

            categories.Add(category);

            ICategory category1 = new Category()
            {
                Name = "Category2",
                Description = "Test category",
                IsActive = true
            };

            categories.Add(category1);

            return categories;
        }

        public ICategory GetCategoryById(Guid categoryId)
        {
            return new Category();
        }
    }
}
