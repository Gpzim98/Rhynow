namespace ProductsCatalog.Domain.Interfaces
{
    public interface IProduct
    {
        string Name { get; set; }
        string Description { get; set; }
        bool IsActive { get; set; }
    }
}
