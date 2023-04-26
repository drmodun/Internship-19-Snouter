using Domain.DTO;
using System.Net;

namespace Domain.Contracts.Response.Location
{
    public class GetLocationResponse
    {
        public LocationView? Location { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public bool Success { get; set; }


    }
}
