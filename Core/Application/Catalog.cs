using ProductsCatalog.Application.Interfaces;
using ProductsCatalog.Domain.Interfaces;
using System;
using System.Collections.Generic;
using ProductsCatalog.Application.Interfaces.Repositories;

namespace ProductsCatalog.Application
{
    public class Catalog : ICatalog
    {
        public Catalog() { }
        IProductRepository<IProduct> _productRepository;
        ICategoryRepository<ICategory> _categoryRepository;
        public Catalog(
            IProductRepository<IProduct> productRepository,
            ICategoryRepository<ICategory> categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        public IList<ICategory> GetAllCategories()
        {
            return (IList<ICategory>)_categoryRepository.GetAllAsync();
        }

        public IList<IProduct> GetAllProductsAsync()
        {
            return (IList<IProduct>)_productRepository.GetAllAsync();
        }

        public ICategory GetCategoryById(Guid categoryId)
        {
            ICategory category = (ICategory)_categoryRepository.GetAsync(categoryId);
            category.Name = "Category from Oficial Catalog Implementation";
            return category;
        }
    }
}
