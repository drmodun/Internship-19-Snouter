using Domain.DTO;

namespace Domain.Contracts.Response.Country
{
    public class GetAllCountriesResponse
    {
        public List<CountryDTO>? Countries { get; set; }
    }
}
