using Domain.DTO;

namespace Domain.Contracts.Response.Product
{
    public class GetAllProductsResponse
    {
        public List<ProductDTO> Products { get; set; }
    }
}
