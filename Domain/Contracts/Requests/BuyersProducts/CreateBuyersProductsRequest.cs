namespace Domain.Contracts.Requests.BuyersProducts
{
    public class CreateBuyersProductsRequest
    {
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
        public int Quantity { get; set; }
    }
}
