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
    public static class LocationMapper
    {
        public static LocationView LocationToDTO(Location location)
        {
            var newDTO = new LocationView
            {
                Id = location.Id,
                Name = location.Name,
                Products = location.Products.Select(ProductsMapper.ProductToDTO).ToList(),
                Country = CountryToDTO(location.Country),
                Latitude = location.Latitude,
                Longitude = location.Longitude
            };
            return newDTO;
        }

        public static CountryDTO CountryToDTO(Country country)
        {
            var newDTO = new CountryDTO
            {
                Id = country.Id,
                Name = country.Name,
                Locations = country.Locations.Select(LocationToDTO).ToList(),
                Image = country.Image
            };
            return newDTO;
        }
    }
}
