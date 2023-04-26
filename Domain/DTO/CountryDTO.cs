namespace Domain.DTO
{
    public class CountryDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Guid> Locations { get; set; }
        public string Image { get; set; }

    }
}
