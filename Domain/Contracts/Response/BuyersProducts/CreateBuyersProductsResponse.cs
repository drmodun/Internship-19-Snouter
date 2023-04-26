using Domain.DTO;
using System.Net;

namespace Domain.Contracts.Response.BuyersProducts
{
    public class CreateBuyersProductsResponse
    {
        public BuyersProductsView BuyersProducts { get; set; }
        public bool Success { get; set; }
        public HttpStatusCode Status { get; set; }
    }
}
