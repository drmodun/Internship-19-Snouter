namespace Domain.DTO
{
    public class ViewProfile
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email;
        public Guid Location { get; set; }

        public List<Guid> Products { get; set; }

        public List<Guid> BoughtProudcts { get; set; } = new List<Guid>();

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
