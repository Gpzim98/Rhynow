using ProductsCatalog.Domain.Interfaces;

namespace ProductsCatalog.Domain.Models
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
