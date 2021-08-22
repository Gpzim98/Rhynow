using ProductsCatalog.Core.Application.Interfaces.Repositories;
using ProductsCatalog.Core.Domain.Models;
using System.Collections.Generic;
using System;

namespace ProductsCatalog.Infrastructure.Data.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository<Category>
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

        public IEnumerable<Category> GetAll()
        {
            IList<Category> categories = new List<Category>();
            Category category = new Category()
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

        public Category GetById(Guid categoryId)
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
