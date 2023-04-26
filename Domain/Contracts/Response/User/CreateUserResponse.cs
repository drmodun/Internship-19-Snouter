using Domain.DTO;
using System.Net;

namespace Domain.Contracts.Response.User
{
    public class CreateUserResponse
    {
        public bool? Success { get; set; }
        public ViewProfile? Profile { get; set; }

        public HttpStatusCode StatusCode { get; set; }
    }
}
