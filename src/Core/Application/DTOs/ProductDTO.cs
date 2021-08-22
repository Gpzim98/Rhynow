using ProductsCatalog.Core.Domain.Models;

namespace ProductsCatalog.Core.Application.DTOs
{
    public class ProductDTO
    {
        public ProductDTO() {}
        internal ProductDTO(Product product)
        {
            this.Name = product.Name;
            this.Description = product.Description;
            this.IsActive = product.IsActive;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}