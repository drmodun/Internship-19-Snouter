using Domain.DTO;
using System.Net;

namespace Domain.Contracts.Response.User
{
    public class GetUserResponse
    {
        public ViewProfile? User { get; set; }
        public HttpStatusCode Status { get; set; }
        public bool Success { get; set; }
    }
}
