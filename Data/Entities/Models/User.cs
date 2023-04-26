namespace Data.Entities.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Guid AddressId;
        public Location? Address { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<BuyersProducts> BoughtProducts { get; set; } = new List<BuyersProducts>();

        public ICollection<Product> ListedProducts { get; set; } = new List<Product>();


    }
}
