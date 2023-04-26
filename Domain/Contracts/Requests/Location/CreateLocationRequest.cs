namespace Domain.Contracts.Requests.Location
{
    public class CreateLocationRequest
    {
        public string Name { get; set; }
        public Guid CountryId { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
