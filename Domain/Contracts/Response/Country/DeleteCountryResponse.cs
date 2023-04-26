using System.Net;

namespace Domain.Contracts.Response.Country
{
    public class DeleteCountryResponse
    {
        public bool? Success { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
