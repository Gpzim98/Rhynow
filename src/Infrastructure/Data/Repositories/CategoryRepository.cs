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
    }
}
