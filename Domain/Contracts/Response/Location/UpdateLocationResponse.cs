using Domain.DTO;
using System.Net;

namespace Domain.Contracts.Response.Location
{
    public class UpdateLocationResponse
    {
        public LocationView? Location { get; set; }
        public bool Success { get; set; }
        public HttpStatusCode Status { get; set; }
    }
}
