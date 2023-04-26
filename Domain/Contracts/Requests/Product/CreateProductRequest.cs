namespace Domain.Contracts.Requests.Product
{
    public class CreateProductRequest
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public Guid SellerId { get; set; }

        public Guid LocationId { get; set; }

        public Guid CategoryId { get; set; }
        public Guid SubCategoryId { get; set; }
        public string ExtraProperties { get; set; }
        public string SubProperties { get; set; }
        public List<string> Images { get; set; }
        public decimal Price { get; set; }
    }
}
