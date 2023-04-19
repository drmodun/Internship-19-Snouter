using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities.Models;
using Domain.DTO;

namespace Domain.Mapper
{
    public static class ProductsMapper
    {
        public static ProductDTO ProductToDTO(Product product)
        {
            var newDTO = new ProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Location = LocationMapper.LocationToDTO(product.Location),
                Seller = UserMappers.MapUserToDTO(product.Seller),
                ExtraProperties = product.ExtraProperties,
                SubProperties = product.SubProperties,
                BuyersProducts = product.Buyers.Select(BuyersProductsToDto).ToList(),
                Price = product.Price,
                Description = product.Description,
                Created = product.Created
            };
            return newDTO;
        }


        public static BuyersProductsView BuyersProductsToDto(BuyersProducts buyersProducts)
        {
            var newDTO = new BuyersProductsView
            {
                Product = ProductToDTO(buyersProducts.Product),
                Quantity = buyersProducts.Quantity,
                Buyer = UserMappers.MapUserToDTO(buyersProducts.Buyer),
                CreatedAt = buyersProducts.CreatedAt
            };
            return newDTO;
        }

    }
}
