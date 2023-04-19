
using System.Security.Cryptography;
using Data.Entities;
using Data.Entities.Models;
using Domain.Contracts;
using Domain.Contracts.Requests.User;
using Domain.DTO;
using Domain.Mapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace Domain
{
    public static class UserMappers
    {
        private static ShopContext _shopContext;
        

        public static ViewProfile MapUserToDTO(User userToMap)
        {
            var newDTO = new ViewProfile
            {
                Id = userToMap.Id,
                Name = userToMap.Name,
                Email = userToMap.Email,
                Location = LocationMapper.LocationToDTO(userToMap.Address),
                Products = userToMap.ListedProducts.Select(ProductsMapper.ProductToDTO).ToList(),
                BoughtProudcts = userToMap.BoughtProducts.Select(ProductsMapper.BuyersProductsToDto).ToList(),
                CreatedAt = userToMap.CreatedAt,
                UpdatedAt = userToMap.UpdatedAt

            };
            return newDTO;
        }
    }
}
