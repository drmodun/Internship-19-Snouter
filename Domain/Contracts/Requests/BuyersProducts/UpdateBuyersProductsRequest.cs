namespace Domain.Contracts.Requests.BuyersProducts
{
    public class UpdateBuyersProductsRequest
    {
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
        public int Quantity { get; set; }
    }
}
