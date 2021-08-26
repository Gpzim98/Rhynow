namespace ProductsCatalog.Core.Application.Interfaces.Repositories
{
    public interface IProductRepository<ProductDTO> : IGenericRepository<ProductDTO>
    {
        void ProductRepoSpecificMethod();
    }
}
