using ProductsCatalog.Core.Domain.Models;

namespace ProductsCatalog.Core.Application.Interfaces.Repositories
{
    public interface ICategoryRepository<Category> : IGenericRepository<Category>
    {
        void CategoryRepoSpecificMethod();
    }
}
