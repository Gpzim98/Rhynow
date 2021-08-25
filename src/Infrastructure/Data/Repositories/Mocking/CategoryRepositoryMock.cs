using ProductsCatalog.Core.Application.Interfaces.Repositories;
using System.Collections.Generic;
using System;
using ProductsCatalog.Core.Application.DTOs;
using System.Threading.Tasks;

namespace ProductsCatalog.Infrastructure.Data.Repositories.Mocking
{
    public class CategoryRepositoryMock<T> : GenericRepository<T>, ICategoryRepository<T> where T : CategoryDTO
    {
        public CategoryRepositoryMock(
            string tableName = "Categories") : base(tableName)
        { 
        }

        public void CategoryRepoSpecificMethod()
        {
            throw new NotImplementedException();
        }
        
        public override async Task<IEnumerable<T>> GetAllAsync()
        {
            CategoryDTO[] categories = new CategoryDTO[]
            {
                new CategoryDTO() { Name = "Category Sample " },
            };
            
            return (IEnumerable<T>)await Task.FromResult(categories);
        }

        public override async Task<T> GetAsync(Guid id)
        {
            var category = new CategoryDTO() { Name = "Category Sample " };
            return (T) await Task.FromResult(category);
        }
    }
}
