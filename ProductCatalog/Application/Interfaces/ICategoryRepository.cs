using ProductsCatalog.Domain.Interfaces;
using System.Collections.Generic;


namespace ProductsCatalog.Application.Interfaces
{
    public interface ICategoryRepository
    {
        IList<ICategory> GetAllCategories();
    }
}
