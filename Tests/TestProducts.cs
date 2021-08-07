using ProductsCatalog.Application.Interfaces;
using System.Collections.Generic;
using Xunit;
using ProductsCatalog.Domain.Interfaces;

namespace ProductsCatalog.Tests
{
    public class TestProducts : BaseTest
    {
        private ICatalog productsCatalog;
        public TestProducts()
        {
            productsCatalog = Resolve<ICatalog>();
        }
        [Fact]
        public void ShouldReturnListOfProducts()
        {
            IList<IProduct> listOfProducts = productsCatalog.GetAllProducts();
            Assert.True(listOfProducts.Count > 0);
        }
    }
}
