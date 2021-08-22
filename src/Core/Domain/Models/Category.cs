using System;
using System.Collections.Generic;


namespace ProductsCatalog.Core.Domain.Models
{
    public class Category
    {
        public Category() 
        {
            products = new HashSet<Product>();
        }
        public Category(Guid Id)
        {
            this.Id = Id;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Product> products {get; private set;}
    }
}
