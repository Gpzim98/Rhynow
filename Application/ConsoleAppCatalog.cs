using ProductsCatalog.Application.Interfaces;
using ProductsCatalog.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace ProductsCatalog.Application
{
    public class ConsoleAppCatalog : ICatalog
    {
        public ConsoleAppCatalog() { }
        IProductRepository _productRepository;
        ICategoryRepository _categoryRepository;
        public ConsoleAppCatalog(
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
            var category = _categoryRepository.GetCategoryById(categoryId);
            category.Name = "Category from ConsoleAppCatalog";
            return category;
        }
    }
}
