using ProductCatalog.Application.Interfaces;
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
    }
}
