namespace Domain.DTO
{
    public class CategoryDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Schema { get; set; }
        public List<Guid> Products { get; set; }
        public List<Guid> SubCategories { get; set; } = new List<Guid>();
    }
}
