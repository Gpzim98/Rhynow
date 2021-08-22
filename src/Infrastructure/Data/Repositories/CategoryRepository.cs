using ProductsCatalog.Core.Application.Interfaces.Repositories;
using System.Collections.Generic;
using System;
using ProductsCatalog.Core.Application.DTOs;

namespace ProductsCatalog.Infrastructure.Data.Repositories
{
    public class CategoryRepository : GenericRepository<CategoryDTO>, ICategoryRepository<CategoryDTO>
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

        public IEnumerable<CategoryDTO> GetAll()
        {
            IList<CategoryDTO> categories = new List<CategoryDTO>();
            CategoryDTO category = new CategoryDTO()
            {
                Name = "Category1",
                Description = "Test category",
                IsActive = true
            };

            categories.Add(category);

            CategoryDTO category1 = new CategoryDTO()
            {
                Name = "Category2",
                Description = "Test category",
                IsActive = true
            };

            categories.Add(category1);

            return categories;
        }

        public CategoryDTO GetById(Guid categoryId)
        {
            return new CategoryDTO();
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
