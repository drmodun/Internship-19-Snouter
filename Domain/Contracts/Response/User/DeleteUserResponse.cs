using System.Net;

namespace Domain.Contracts.Response.User
{
    public class DeleteUserResponse
    {
        public bool Success { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
