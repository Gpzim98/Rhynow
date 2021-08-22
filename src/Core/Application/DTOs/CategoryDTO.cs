using ProductsCatalog.Core.Domain.Models;

namespace ProductsCatalog.Core.Domain.DTOs
{
    public class CategoryDTO
    {
        public CategoryDTO(Category category)
        {
            this.Name = category.Name;
            this.Description = category.Description;
            this.IsActive = category.IsActive;
        }
        public string Name { get; }
        public string Description { get; }
        public bool IsActive { get; }
    }
}