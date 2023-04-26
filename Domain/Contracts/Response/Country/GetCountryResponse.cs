using Domain.DTO;
using System.Net;

namespace Domain.Contracts.Response.Country
{
    public class GetCountryResponse
    {
        public bool? Success { get; set; }
        public CountryDTO? Country { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
