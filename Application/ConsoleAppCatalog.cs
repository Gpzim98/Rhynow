using ProductsCatalog.Application.Interfaces;
using ProductsCatalog.Application.Interfaces.Repositories;
using ProductsCatalog.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductsCatalog.Application
{
    public class ConsoleAppCatalog : ICatalog
    {
        public ConsoleAppCatalog() { }
        IProductRepository<IProduct> _productRepository;
        ICategoryRepository<ICategory> _categoryRepository;
        public ConsoleAppCatalog(
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
            return (IList<IProduct>) _productRepository.GetAllAsync();
        }

        public ICategory GetCategoryById(Guid categoryId)
        {
            var category = (ICategory)_categoryRepository.GetAsync(categoryId);
            category.Name = "Category from ConsoleAppCatalog";
            return category;
        }
    }
}
