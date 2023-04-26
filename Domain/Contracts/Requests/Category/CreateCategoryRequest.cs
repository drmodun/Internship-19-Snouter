namespace Domain.Contracts.Requests.Category
{
    public class CreateCategoryRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Schema { get; set; }
    }
}
