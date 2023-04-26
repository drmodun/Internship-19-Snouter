using System.Net;

namespace Domain.Contracts.Response.Location
{
    public class DeleteLocationResponse
    {
        public bool? Success { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
