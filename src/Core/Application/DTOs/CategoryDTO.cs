using System;
using ProductsCatalog.Core.Domain.Models;

namespace ProductsCatalog.Core.Application.DTOs
{
    public class CategoryDTO
    {
        public CategoryDTO() {}
        internal CategoryDTO(Category category)
        {
            this.Name = category.Name;
            this.Description = category.Description;
            this.IsActive = category.IsActive;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}