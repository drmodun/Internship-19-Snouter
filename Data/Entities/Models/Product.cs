using Newtonsoft.Json.Linq;

namespace Data.Entities.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Guid SellerId { get; set; }

        public DateTime Created { get; set; }
        public User? Seller { get; set; }

        public List<string> Images { get; set; }
        public Guid CategoryId { get; set; }
        public Category? Category { get; set; }
        public Guid SubCategoryId { get; set; }
        public SubCategory? SubCategory { get; set; }

        public JObject? ExtraProperties { get; set; }

        public JObject SubProperties { get; set; }
        public ICollection<BuyersProducts> Buyers { get; set; } = new List<BuyersProducts>();

        public Guid LocationId;

        public Location Location;



    }
}
