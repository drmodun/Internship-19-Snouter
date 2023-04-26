namespace Domain.Contracts.Requests.SubCategory
{
    public class UpdateSubCategoryRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }
        public string Schema { get; set; }
    }
}
