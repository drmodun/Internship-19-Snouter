using Data.Entities.Models;
using Domain.DTO;

namespace Domain.Mapper.Interfaces
{
    public interface IProductsMapper
    {
        public ProductDTO ProductToDTO(Product product);
        public BuyersProductsView BuyersProductsToDto(BuyersProducts buyersProducts);
    }
}
