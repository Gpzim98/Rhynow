using System;
using System.Collections.Generic;


namespace ProductsCatalog.Core.Domain.Models
{
    internal class Category
    {
        public Category() 
        {
            products = new HashSet<Product>();
        }
        internal Category(Guid Id)
        {
            this.Id = Id;
        }
        internal Guid Id { get; set; }
        internal string Name { get; set; }
        internal string Description { get; set; }
        internal bool IsActive { get; set; }
        internal ICollection<Product> products {get; private set;}
    }
}
