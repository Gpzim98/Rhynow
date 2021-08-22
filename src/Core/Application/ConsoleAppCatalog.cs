﻿using ProductsCatalog.Core.Application.Interfaces;
using ProductsCatalog.Core.Application.Interfaces.Repositories;
using ProductsCatalog.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductsCatalog.Core.Application
{
    public class ConsoleAppCatalog : ICatalog
    {
        public ConsoleAppCatalog() { }
        IProductRepository<Product> _productRepository;
        ICategoryRepository<Category> _categoryRepository;
        public ConsoleAppCatalog(
            IProductRepository<Product> productRepository,
            ICategoryRepository<Category> categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        public IList<Category> GetAllCategories()
        {
            return (IList<Category>)_categoryRepository.GetAllAsync();
        }

        public IList<Product> GetAllProductsAsync()
        {
            return (IList<Product>) _productRepository.GetAllAsync();
        }

        public async Task<Category> GetCategoryById(Guid categoryId)
        {
            var category = await _categoryRepository.GetAsync(categoryId);
            category.Name = "Category from ConsoleAppCatalog";
            return category;
        }
    }
}
