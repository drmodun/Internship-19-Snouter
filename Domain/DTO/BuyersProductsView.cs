namespace Domain.DTO
{
    public class BuyersProductsView
    {
        public Guid Buyer { get; set; }
        public Guid Product { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
