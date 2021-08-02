using ProductsCatalog.Domain.Interfaces;

namespace ProductsCatalog.Domain.Models
{
    public class Category : ICategory
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
