using ProductsCatalog.Core.Application.Interfaces;
using ProductsCatalog.Core.Application.Interfaces.Repositories;
using ProductsCatalog.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProductsCatalog.Core.Application.DTOs;

namespace ProductsCatalog.Core.Application
{
    public class ConsoleAppCatalog : ICatalog
    {
        IProductRepository<ProductDTO> _productRepository;
        ICategoryRepository<CategoryDTO> _categoryRepository;
        
        public ConsoleAppCatalog(
            IProductRepository<ProductDTO> productRepository,
            ICategoryRepository<CategoryDTO> categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        public IList<CategoryDTO> GetAllCategories()
        {
            return (IList<CategoryDTO>)_categoryRepository.GetAllAsync();
        }

        public IList<ProductDTO> GetAllProductsAsync()
        {
            return (IList<ProductDTO>) _productRepository.GetAllAsync().Result;
        }

        public async Task<CategoryDTO> GetCategoryById(Guid categoryId)
        {
            var category = await _categoryRepository.GetAsync(categoryId);
            return category;
        }
    }
}
