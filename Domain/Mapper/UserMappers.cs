
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
    public  class UserMappers
    {
        private readonly ShopContext _shopContext;
        public UserMappers(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }

        public  ViewProfile MapUserToDTO(User userToMap)
        {
            var newDTO = new ViewProfile
            {
                Id = userToMap.Id,
                Name = userToMap.Name,
                Email = userToMap.Email,
                Location = userToMap.AddressId,
                Products = _shopContext.Products.Where(p=>p.SellerId == userToMap.Id).Select(p=>p.SellerId).ToList(),
                BoughtProudcts = _shopContext.BuyersProducts.Where(bp => bp.BuyerId == userToMap.Id).Select(bp => bp.ProductId).ToList(),
                CreatedAt = userToMap.CreatedAt,
                UpdatedAt = userToMap.UpdatedAt

            };
            return newDTO;
        }
    }
}
