using Newtonsoft.Json.Schema;

namespace Data.Entities.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; } = new List<SubCategory>();
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();

        public JSchema Schema { get; set; }






    }
}