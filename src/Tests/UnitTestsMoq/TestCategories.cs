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
    public class TestCategories 
    {
        private ICatalog productsCatalog;
        private readonly Mock<IProductRepository<ProductDTO>> productsMock = new Mock<IProductRepository<ProductDTO>>();
        private readonly Mock<ICategoryRepository<CategoryDTO>> categoryMock = new Mock<ICategoryRepository<CategoryDTO>>();

        public TestCategories()
        {
            productsCatalog = new Catalog(productsMock.Object, categoryMock.Object);
        }

        [Fact]
        public void TestGetAllCategoriesAsync_ShouldBeCalledWithoutArgumentsAndReturnAListOfCategories()
        {
            CategoryDTO[] categories = new CategoryDTO[]
            {
                new CategoryDTO() { Name = "Category 1 Sample " },
                new CategoryDTO() { Name = "Category 2 Sample " },
            };
            categoryMock.Setup(cr => cr.GetAllAsync()).Returns(Task.FromResult((IEnumerable<CategoryDTO>)categories));

            var categoryResponse = productsCatalog.GetAllCategories();
            Assert.NotNull(categoryResponse);
            Assert.Equal(categoryResponse, categories);
        }
    }
}
