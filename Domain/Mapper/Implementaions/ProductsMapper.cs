using Data.Entities;
using Data.Entities.Models;
using Domain.DTO;
using Domain.Mapper.Interfaces;
using Newtonsoft.Json;

namespace Domain.Mapper.Implementaions
{
    public class ProductsMapper : IProductsMapper
    {
        private readonly ShopContext _shopContext;

        public ProductsMapper(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }

        public ProductDTO ProductToDTO(Product product)
        {
            var newDTO = new ProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Location = product.LocationId,
                Seller = product.SellerId,
                ExtraProperties = JsonConvert.SerializeObject(product.ExtraProperties),
                SubProperties = JsonConvert.SerializeObject(product.SubProperties),
                BuyersProducts = _shopContext.BuyersProducts.Where(bp => bp.ProductId == product.Id).Select(bp => bp.BuyerId).ToList(),
                Price = product.Price,
                Description = product.Description,
                Created = product.Created,
                Images = product.Images,
                Category = product.CategoryId,
                SubCategory = product.SubCategoryId,
                Quantity = product.Quantity,
            };
            return newDTO;
        }


        public BuyersProductsView BuyersProductsToDto(BuyersProducts buyersProducts)
        {
            var newDTO = new BuyersProductsView
            {
                Product = buyersProducts.ProductId,
                Quantity = buyersProducts.Quantity,
                Buyer = buyersProducts.BuyerId,
                CreatedAt = buyersProducts.CreatedAt
            };
            return newDTO;
        }

    }
}
