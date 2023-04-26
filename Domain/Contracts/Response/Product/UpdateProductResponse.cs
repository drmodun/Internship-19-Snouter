using Domain.DTO;
using System.Net;

namespace Domain.Contracts.Response.Product
{
    public class UpdateProductResponse
    {
        public bool Success { get; set; }
        public HttpStatusCode Status { get; set; }
        public ProductDTO? Product { get; set; }
    }
}
