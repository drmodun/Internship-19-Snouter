using System.Net;

namespace Domain.Contracts.Response.BuyersProducts
{
    public class DeleteBuyersProductsResponse
    {
        public bool? Success { get; set; }
        public HttpStatusCode Status { get; set; }
    }
}
