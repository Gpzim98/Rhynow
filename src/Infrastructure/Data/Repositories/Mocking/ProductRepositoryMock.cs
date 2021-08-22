using ProductsCatalog.Core.Application.Interfaces.Repositories;
using System.Collections.Generic;
using System;
using ProductsCatalog.Core.Application.DTOs;
using System.Threading.Tasks;

namespace ProductsCatalog.Infrastructure.Data.Repositories.Mocking
{
    public class ProductRepositoryMock<T> : GenericRepository<T>, IProductRepository<T> where T : ProductDTO
    {
        public ProductRepositoryMock(
            string tableName = "Products") : base(tableName)
        { 
        }
        public void ProductRepoSpecificMethod()
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

        public ProductDTO GetById(Guid ProductId)
        {
            return new ProductDTO();
        }

        public T Update()
        {
            throw new NotImplementedException();
        }

        public override async Task<IEnumerable<T>> GetAllAsync()
        {
            ProductDTO[] categories = new ProductDTO[]
            {
                new ProductDTO() { Name = "Product Sample " },
            };
            
            return (IEnumerable<T>)await Task.FromResult(categories);
        }
    }
}
