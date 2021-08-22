using ProductsCatalog.Core.Application.Interfaces.Repositories;
using ProductsCatalog.Core.Application.Interfaces;
using ProductsCatalog.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProductsCatalog.Core.Application.DTOs;

namespace ProductsCatalog.Core.Application
{
    public class Catalog : ICatalog
    {
        IProductRepository<ProductDTO> _productRepository;
        ICategoryRepository<CategoryDTO> _categoryRepository;
        
        public Catalog(
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
            return (IList<ProductDTO>)_productRepository.GetAllAsync();
        }

        public async Task<CategoryDTO> GetCategoryById(Guid categoryId)
        {
            var category = await _categoryRepository.GetAsync(categoryId);
            return category;
        }
    }
}
