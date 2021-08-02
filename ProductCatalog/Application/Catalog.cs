using ProductCatalog.Application.Interfaces;
using ProductsCatalog.Application.Interfaces;
using ProductsCatalog.Domain.Interfaces;
using System.Collections.Generic;

namespace ProductsCatalog.Application
{
    public class Catalog : ICatalog
    {
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
    }
}
