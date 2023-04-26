using Domain.DTO;
using System.Net;

namespace Domain.Contracts.Response.User
{
    public class UpdateUserResponse
    {
        public bool Success { get; set; }
        public ViewProfile? User { get; set; }
        public HttpStatusCode Status { get; set; }
    }
}
