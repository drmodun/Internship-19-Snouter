namespace Data.Entities.Models
{
    public class Country
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<Location> Locations { get; set; } = new List<Location>();
        public string Image { get; set; }
    }
}
