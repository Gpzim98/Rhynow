using System;
using System.Collections.Generic;


namespace ProductsCatalog.Core.Domain.Models
{
    public class Product
    {
        public Product()
        {
            this.categories = new HashSet<Category>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Category> categories {get; private set;}
    }
}
