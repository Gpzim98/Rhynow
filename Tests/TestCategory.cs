using ProductsCatalog.Application.Interfaces;
using System;
using Xunit;

namespace ProductsCatalog.Tests
{
    public class TestCategory : BaseTest
    {
        private ICatalog productsCatalog;
        public TestCategory()
        {
            productsCatalog = Resolve<ICatalog>();
        }
        [Fact]
        public void ShouldReturnListOfCategories()
        {
            var listOfProducts = productsCatalog.GetAllCategories();
            Assert.True(listOfProducts.Count > 0);
        }

        [Fact]
        public void ShouldReturnCategoryById()
        {
            Guid categoryId = Guid.NewGuid();
            var category = productsCatalog.GetCategoryById(categoryId);
            Assert.NotNull(category);
        }

        [Fact]
        public void ShouldReturnCategoryWithCorrectIdWhenCallingGetCategoryById()
        {
            Guid categoryId = Guid.NewGuid();
            var category = productsCatalog.GetCategoryById(categoryId);
            Assert.Equal(categoryId, category.Id);
        }
    }
}
