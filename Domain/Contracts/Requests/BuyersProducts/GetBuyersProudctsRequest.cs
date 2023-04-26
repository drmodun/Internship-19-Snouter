namespace Domain.Contracts.Requests.BuyersProducts
{
    public class GetBuyersProudctsRequest
    {
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
    }
}
