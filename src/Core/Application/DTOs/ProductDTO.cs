using ProductsCatalog.Core.Domain.Models;

namespace ProductsCatalog.Core.Domain.DTOs
{
    public class ProductDTO
    {
        public ProductDTO(Product product)
        {
            this.Name = product.Name;
            this.Description = product.Description;
            this.IsActive = product.IsActive;
        }
        public string Name { get; }
        public string Description { get; }
        public bool IsActive { get; }
    }
}