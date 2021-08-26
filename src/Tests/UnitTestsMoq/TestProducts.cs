using System;
using ProductsCatalog.Core.Application.Interfaces.Repositories;
using ProductsCatalog.Core.Application.Interfaces;
using Xunit;
using Infrastructure.IoC;
using Moq;
using ProductsCatalog.Core.Application.DTOs;
using System.Threading.Tasks;
using System.Collections.Generic;
using  ProductsCatalog.Core.Application;

namespace ProductsCatalog.UnitTestsMoq
{
    public class TestProducts
    {
        private ICatalog productsCatalog;
        private readonly Mock<IProductRepository<ProductDTO>> productsMock = new Mock<IProductRepository<ProductDTO>>();
        private readonly Mock<ICategoryRepository<CategoryDTO>> categoryMock = new Mock<ICategoryRepository<CategoryDTO>>();

        public TestProducts()
        {
            productsCatalog = new Catalog(productsMock.Object, categoryMock.Object);
        }

        [Fact]
        public void TestGetAllProductsAsync_ShouldBeCalledWithoutArgumentsAndReturnAListOfProducts()
        {
            ProductDTO[] products = new ProductDTO[]
            {
                new ProductDTO() { Name = "Product 1 Sample " },
                new ProductDTO() { Name = "Product 2 Sample " },
            };
            productsMock.Setup(pr => pr.GetAllAsync()).Returns(Task.FromResult((IEnumerable<ProductDTO>)products));

            var productsResponse = productsCatalog.GetAllProductsAsync();
            Assert.NotNull(productsResponse);
            Assert.Equal(productsResponse, products);
        }
    }
}
