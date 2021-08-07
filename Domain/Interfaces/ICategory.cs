namespace ProductsCatalog.Domain.Interfaces
{
    public interface ICategory
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
