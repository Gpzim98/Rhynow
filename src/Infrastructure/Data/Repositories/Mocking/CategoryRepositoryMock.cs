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

        public T Create()
        {
            throw new NotImplementedException();
        }

        public T Delete()
        {
            throw new NotImplementedException();
        }

        public CategoryDTO GetById(Guid categoryId)
        {
            return new CategoryDTO();
        }

        public void ProductRepoSpecificMethod()
        {
            throw new NotImplementedException();
        }

        public T Update()
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
    }
}
