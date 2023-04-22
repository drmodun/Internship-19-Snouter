using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Entities.Models;
using Domain.DTO;

namespace Domain.Mapper
{
    public  class ProductsMapper
    {
        private readonly ShopContext _shopContext;

        public ProductsMapper(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }

        public  ProductDTO ProductToDTO(Product product)
        {
            var newDTO = new ProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Location = product.LocationId,
                Seller = product.SellerId,
                ExtraProperties = product.ExtraProperties.ToString(),
                SubProperties = product.SubProperties.ToString(),
                BuyersProducts = _shopContext.BuyersProducts.Where(bp=>bp.ProductId == product.Id).Select(bp=>bp.BuyerId).ToList(),
                Price = product.Price,
                Description = product.Description,
                Created = product.Created
            };
            return newDTO;
        }


        public  BuyersProductsView BuyersProductsToDto(BuyersProducts buyersProducts)
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
