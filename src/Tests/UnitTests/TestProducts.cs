using ProductsCatalog.Core.Application.Interfaces;
using System.Collections.Generic;
using Xunit;
using ProductsCatalog.Core.Domain.Models;
using ProductsCatalog.Core.Application.DTOs;

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
            IList<ProductDTO> listOfProducts = productsCatalog.GetAllProductsAsync();
            Assert.True(listOfProducts.Count > 0);
        }
    }
}
