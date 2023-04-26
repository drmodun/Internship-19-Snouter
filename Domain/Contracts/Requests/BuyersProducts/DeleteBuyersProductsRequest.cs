namespace Domain.Contracts.Requests.BuyersProducts
{
    public class DeleteBuyersProductsRequest
    {
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
    }
}
