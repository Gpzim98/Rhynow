﻿using ProductsCatalog.Application.Interfaces;
using ProductsCatalog.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace ProductsCatalog.Application
{
    public class Catalog : ICatalog
    {
        public Catalog() { }
        IProductRepository _productRepository;
        ICategoryRepository _categoryRepository;
        public Catalog(
            IProductRepository productRepository,
            ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        public IList<ICategory> GetAllCategories()
        {
            return _categoryRepository.GetAllCategories();
        }

        public IList<IProduct> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public ICategory GetCategoryById(Guid categoryId)
        {
            ICategory category = _categoryRepository.GetCategoryById(categoryId);
            category.Name = "Category from Oficial Catalog Implementation";
            return category;
        }
    }
}
