using System;
using System.Collections.Generic;


namespace ProductsCatalog.Core.Domain.Models
{
    internal class Product
    {
        internal Product()
        {
            this.categories = new HashSet<Category>();
        }
        internal string Name { get; set; }
        internal string Description { get; set; }
        internal bool IsActive { get; set; }
        internal ICollection<Category> categories {get; private set;}
    }
}

