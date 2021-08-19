using System;
using ProductsCatalog.Domain.Interfaces;

namespace ProductsCatalog.Domain.Models
{
    public class Category : ICategory
    {
        public Category() { }
        public Category(Guid Id)
        {
            this.Id = Id;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
