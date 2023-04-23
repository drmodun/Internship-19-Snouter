using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Entities
{
    public static class Seeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var countries = new List<Country>
            {
                new Country
                {
                    Id = new Guid(),
                    Name = "Serbia",
                    Image = "https://www.countryflags.io/rs/flat/64.png",
                    Locations = new List<Location>()
                },
                new Country
                {
                    Id = new Guid(),
                    Name = "Bosnia and Herzegovina",
                    Image = "https://www.countryflags.io/ba/flat/64.png",
                    Locations = new List<Location>()
                },
                new Country
                {
                    Id = new Guid(),
                    Name = "Croatia",
                    Image = "https://www.countryflags.io/hr/flat/64.png",
                    Locations = new List<Location>()
                },
                new Country
                {
                    Id = new Guid(),
                    Name = "Montenegro",
                    Image = "https://www.countryflags.io/me/flat/64.png",
                    Locations = new List<Location>()
                },
                new Country
                {
                    Id = new Guid(),
                    Name = "Macedonia",
                    Image = "https://www.countryflags.io/mk/flat/64.png",
                    Locations = new List<Location>()
                },
                new Country
                {
                    Id = new Guid(),
                    Name = "Slovenia",
                    Image = "https://www.countryflags.io/si/flat/64.png",
                    Locations = new List<Location>()
                },
                new Country
                {
                    Id = new Guid(),
                    Name = "Albania",
                    Image = "https://www.countryflags.io/al/flat/64.png",
                    Locations = new List<Location>()
                }

            };
            var locations = new List<Location>
            {
                new Location
                {
                    Id = new Guid(),
                    Name = "Belgrade",
                    Latitude = 44.786568M,
                    Longitude = 20.448921M,
                    CountryId = countries[0].Id,
                },
                new Location
                {
                    Id = new Guid(),
                    Name = "Novi Sad",
                    Latitude = 45.251667M,
                    Longitude = 19.836944M,
                    CountryId = countries[0].Id,
                },
                new Location
                {
                    Id = new Guid(),
                    Name = "Sarajevo",
                    Latitude = 43.856258M,
                    Longitude = 18.413076M,
                    CountryId = countries[0].Id,
                },
                new Location
                {

                }
                };
                modelBuilder.Entity<Country>().HasData(countries
            );

        }



    }
}
