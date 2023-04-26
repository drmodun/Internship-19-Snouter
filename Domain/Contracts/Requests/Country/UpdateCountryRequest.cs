namespace Domain.Contracts.Requests.Country
{
    public class UpdateCountryRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
