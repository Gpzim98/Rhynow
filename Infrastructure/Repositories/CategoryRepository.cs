using ProductsCatalog.Application.Interfaces.Repositories;
using ProductsCatalog.Domain.Interfaces;
using System.Collections.Generic;
using ProductsCatalog.Domain.Models;
using System;
using ProductCatalog.Infrastructure.Repositories;

namespace ProductsCatalog.Infrastructure.Repositories
{
    public class CategoryRepository : GenericRepository<ICategory>, ICategoryRepository<ICategory>
    {
        public CategoryRepository(
            string tableName = "Categories") : base(tableName)
        { 
        }

        public void CategoryRepoSpecificMethod()
        {
            throw new NotImplementedException();
        }

        public T Create<T>()
        {
            throw new NotImplementedException();
        }

        public T Delete<T>()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ICategory> GetAll()
        {
            IList<ICategory> categories = new List<ICategory>();
            ICategory category = new Category()
            {
                Name = "Category1",
                Description = "Test category",
                IsActive = true
            };

            categories.Add(category);

            Category category1 = new Category()
            {
                Name = "Category2",
                Description = "Test category",
                IsActive = true
            };

            categories.Add(category1);

            return categories;
        }

        public ICategory GetById(Guid categoryId)
        {
            return new Category(categoryId);
        }

        public void ProductRepoSpecificMethod()
        {
            throw new NotImplementedException();
        }

        public T Update<T>()
        {
            throw new NotImplementedException();
        }
    }
}
