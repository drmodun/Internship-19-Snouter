using System.Net;

namespace Domain.Contracts.Response.Product
{
    public class DeleteProductResponse
    {
        public bool Success { get; set; }
        public HttpStatusCode Status { get; set; }
    }
}
