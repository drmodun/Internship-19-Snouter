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
    public class LocationMapper
    {
        private readonly ShopContext _shopContext;

        public LocationMapper(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }
        public LocationView LocationToDTO(Location location)
        {
            var newDTO = new LocationView
            {
                Id = location.Id,
                Name = location.Name,
                Products = _shopContext.Products.Where(p => p.LocationId == location.Id).Select(p => p.Id).ToList(),
                Country = location.CountryId,
                Latitude = location.Latitude,
                Longitude = location.Longitude,
                Users = _shopContext.Users.Where(u => u.AddressId == location.Id).Select(u => u.Id).ToList()
            };
            return newDTO;
        }

        public CountryDTO CountryToDTO(Country country)
        {
            var newDTO = new CountryDTO
            {
                Id = country.Id,
                Name = country.Name,
                Locations = _shopContext.Locations.Where(l => l.CountryId == country.Id).Select(l => l.Id).ToList(),
                Image = country.Image
            };
            return newDTO;
        }
    }
}
