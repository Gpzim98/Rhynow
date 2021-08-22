using ProductsCatalog.Core.Domain.Models;

namespace ProductsCatalog.Core.Application.Interfaces.Repositories
{
    public interface ICategoryRepository<CategoryDTO> : IGenericRepository<CategoryDTO>
    {
        void CategoryRepoSpecificMethod();
    }
}
