using Domain.DTO;

namespace Domain.Contracts.Response.BuyersProducts
{
    public class GetAllBuyersProductsResponse
    {
        public List<BuyersProductsView> BuyersProducts { get; set; }
    }
}
