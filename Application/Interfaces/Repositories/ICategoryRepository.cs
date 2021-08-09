namespace ProductsCatalog.Application.Interfaces.Repositories
{
    public interface ICategoryRepository<ICategory> : IGenericRepository<ICategory>
    {
        void CategoryRepoSpecificMethod();
    }
}
