using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

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
                    Id = Guid.NewGuid(),
                    Name = "Serbia",
                    Image = "https://www.countryflags.io/rs/flat/64.png",
                    Locations = new List<Location>()
                },
                new Country
                {
                    Id = Guid.NewGuid(),
                    Name = "Bosnia and Herzegovina",
                    Image = "https://www.countryflags.io/ba/flat/64.png",
                    Locations = new List<Location>()
                },
                new Country
                {
                    Id = Guid.NewGuid(),
                    Name = "Croatia",
                    Image = "https://www.countryflags.io/hr/flat/64.png",
                    Locations = new List<Location>()
                },
                new Country
                {
                    Id = Guid.NewGuid(),
                    Name = "Montenegro",
                    Image = "https://www.countryflags.io/me/flat/64.png",
                    Locations = new List<Location>()
                },
                new Country
                {
                    Id = Guid.NewGuid(),
                    Name = "Macedonia",
                    Image = "https://www.countryflags.io/mk/flat/64.png",
                    Locations = new List<Location>()
                },
                new Country
                {
                    Id = Guid.NewGuid(),
                    Name = "Slovenia",
                    Image = "https://www.countryflags.io/si/flat/64.png",
                    Locations = new List<Location>()
                },
                new Country
                {
                    Id = Guid.NewGuid(),
                    Name = "Albania",
                    Image = "https://www.countryflags.io/al/flat/64.png",
                    Locations = new List<Location>()
                }

            };
            var locations = new List<Location>
            {
                new Location
                {
                    Id = Guid.NewGuid(),
                    Name = "Belgrade",
                    Latitude = 44.786568M,
                    Longitude = 20.448921M,
                    CountryId = countries[0].Id,
                },
                new Location
                {
                    Id = Guid.NewGuid(),
                    Name = "Novi Sad",
                    Latitude = 45.251667M,
                    Longitude = 19.836944M,
                    CountryId = countries[0].Id,
                },
                new Location
                {
                    Id = Guid.NewGuid(),
                    Name = "Sarajevo",
                    Latitude = 43.856258M,
                    Longitude = 18.413076M,
                    CountryId = countries[0].Id,
                },
                new Location
                {
                    Id = Guid.NewGuid(),
                    Name = "Zagreb",
                    Latitude = 45.815010M,
                    Longitude = 15.981919M,
                    CountryId = countries[2].Id,
                },
                new Location
                {
                    Id = Guid.NewGuid(),
                    Name = "Podgorica",
                    Latitude = 42.460201M,
                    Longitude = 19.259995M,
                    CountryId = countries[2].Id,
                },
                new Location
                {
                    Id = Guid.NewGuid(),
                    Name = "Skopje",
                    Latitude = 42.002876M,
                    Longitude = 21.436935M,
                    CountryId = countries[1].Id,
                },
                new Location
                {
                    Id = Guid.NewGuid(),
                    Name = "Ljubljana",
                    Latitude = 46.056946M,
                    Longitude = 14.505751M,
                    CountryId = countries[3].Id,
                },
                new Location
                {
                    Id = Guid.NewGuid(),
                    Name = "Town",
                    Latitude = 40.056946M,
                    Longitude = 10.505751M,
                    CountryId = countries[4].Id,
                },
                new Location
                {
                    Id = Guid.NewGuid(),
                    Name = "othertown",
                    Latitude = 20.056946M,
                    Longitude = 4.505751M,
                    CountryId = countries[5].Id,
                }
            };
            var categories = new List<Category>
            {
                new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Food",
                    Description = "Food for eating",
                    Schema = JSchema.Parse(
                        @"{  'type': 'object',  'properties': {    'name': {'type':'string'},    'ingredients': {'type': 'array'}  }}")
                },
                new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Clothes",
                    Description = "Clothes for wearing",
                    Schema = JSchema.Parse(
                        @"{  'type': 'object',  'properties': {    'name': {'type':'string'},    'size': {'type': 'array'}  }}")
                },
                new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Electronics",
                    Description = "Electronics for using",
                    Schema = JSchema.Parse(
                        @"{  'type': 'object',  'properties': {    'name': {'type':'string'},    'voltage': {'type': 'string'}  }}")
                },
                new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Vehicles",
                    Description = "Vehicles for driving",
                    Schema = JSchema.Parse(
                        @"{  'type': 'object',  'properties': {    'name': {'type':'string'},    'color': {'type': 'string'}  }}")
                },
                new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Books",
                    Description = "Books for reading",
                    Schema = JSchema.Parse(
                        @"{  'type': 'object',  'properties': {    'name': {'type':'string'},    'author': {'type': 'string'}  }}")
                },
                new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Furniture",
                    Description = "Furniture for sitting",
                    Schema = JSchema.Parse(
                        @"{  'type': 'object',  'properties': {    'name': {'type':'string'},    'color': {'type': 'string'}  }}")
                },
                new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Toys",
                    Description = "Toys for playing",
                    Schema = JSchema.Parse(
                        @"{  'type': 'object',  'properties': {    'name': {'type':'string'},    'aimedFor': {'type': 'string'}  }}")
                }
            };
            var subCategories = new List<SubCategory>
            {
                new SubCategory()
                {
                    Id = Guid.NewGuid(),
                    Name = "Fruits",
                    Description = "Fruits for eating",
                    CategoryId = categories[0].Id,
                    Schema = JSchema.Parse(
                        @"{  'type': 'object',  'properties': {    'sweetLevel': {'type':'string'},    'colors': {'type': 'array'}  }}")
                },
                new SubCategory()
                {
                    Id = Guid.NewGuid(),
                    Name = "Vegetables",
                    Description = "Vegetables for eating",
                    CategoryId = categories[0].Id,
                    Schema = JSchema.Parse(
                        @"{  'type': 'object',  'properties': {    'sourLevel': {'type':'string'},    'colors': {'type': 'array'}  }}")
                },
                new SubCategory()
                {
                    Id = Guid.NewGuid(),
                    Name = "Meat",
                    Description = "Meat for eating",
                    CategoryId = categories[0].Id,
                    Schema = JSchema.Parse(
                        @"{  'type': 'object',  'properties': {    'taste': {'type':'string'},    'colors': {'type': 'array'}  }}")
                },
                new SubCategory()
                {
                    Id = Guid.NewGuid(),
                    Name = "Shirts",
                    Description = "Shirts for wearing",
                    CategoryId = categories[1].Id,
                    Schema = JSchema.Parse(
                        @"{  'type': 'object',  'properties': {    'material': {'type':'string'},    'colors': {'type': 'array'}  }}")
                },
                new SubCategory()
                {
                    Id = Guid.NewGuid(),
                    Name = "Pants",
                    Description = "Pants for wearing",
                    CategoryId = categories[1].Id,
                    Schema = JSchema.Parse(
                        @"{  'type': 'object',  'properties': {    'material': {'type':'string'},    'shades': {'type': 'array'}  }}")
                },
                new SubCategory()
                {
                    Id = Guid.NewGuid(),
                    Name = "Phones",
                    Description = "Phones for using",
                    CategoryId = categories[2].Id,
                    Schema = JSchema.Parse(
                        @"{  'type': 'object',  'properties': {    'brand': {'type':'string'},    'colors': {'type': 'array'}  }}")
                },
                new SubCategory()
                {
                    Id = Guid.NewGuid(),
                    Name = "Laptops",
                    Description = "Laptops for using",
                    CategoryId = categories[2].Id,
                    Schema = JSchema.Parse(
                        @"{  'type': 'object',  'properties': {    'brand': {'type':'string'},    'screensizes': {'type': 'array'}  }}")
                },
                new SubCategory()
                {
                    Id = Guid.NewGuid(),
                    Name = "Cars",
                    Description = "Cars for driving",
                    CategoryId = categories[3].Id,
                    Schema = JSchema.Parse(
                        @"{  'type': 'object',  'properties': {    'brand': {'type':'string'},    'motors': {'type': 'array'}  }}")
                },
                new SubCategory()
                {
                    Id = Guid.NewGuid(),
                    Name = "Bikes",
                    Description = "Bikes for driving",
                    CategoryId = categories[3].Id,
                    Schema = JSchema.Parse(
                        @"{  'type': 'object',  'properties': {    'brand': {'type':'string'},    'handles': {'type': 'array'}  }}")
                },
                new SubCategory()
                {
                    Id = Guid.NewGuid(),
                    Name = "Novels",
                    Description = "Novels for reading",
                    CategoryId = categories[4].Id,
                    Schema = JSchema.Parse(
                        @"{  'type': 'object',  'properties': {    'genre': {'type':'string'},    'themes': {'type': 'array'}  }}")
                },
                new SubCategory()
                {
                    Id = Guid.NewGuid(),
                    Name = "Comics",
                    Description = "Comics for reading",
                    CategoryId = categories[4].Id,
                    Schema = JSchema.Parse(
                        @"{  'type': 'object',  'properties': {    'genre': {'type':'string'},    'characters': {'type': 'array'}  }}")
                }
            };
            var users = new List<User>
            {
                new User()
                {
                    Id = Guid.NewGuid(),
                    Name = "John",
                    Email = "John@gmail.com",
                    Password = "123456",
                    AddressId = locations[0].Id,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new User()
                {
                    Id = Guid.NewGuid(),
                    Name = "Jane",
                    Email = "Jane@gmail.com",
                    Password = "123456",
                    AddressId = locations[1].Id,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new User()
                {
                    Id = Guid.NewGuid(),
                    Name = "Admin",
                    Email = "admin@gmail.com",
                    Password = "123456",
                    AddressId = locations[2].Id,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new User()
                {
                    Id = Guid.NewGuid(),
                    Name = "Admin2",
                    Email = "admin2@gmail.com",
                    Password = "123456",
                    AddressId = locations[5].Id,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new User()
                {
                    Id = Guid.NewGuid(),
                    Name = "Admin3",
                    Email = "admin3@gmail.com",
                    Password = "123sdda456",
                    AddressId = locations[4].Id,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new User()
                {
                    Id = Guid.NewGuid(),
                    Name = "DebyDoo",
                    Email = "DebyDebyDoo@gmail.com",
                    Password = "debugger",
                    AddressId = locations[7].Id,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new User()
                {
                    Id = Guid.NewGuid(),
                    Name = "nonexistant",
                    Email = "none@gmail.com",
                    Password = "123456",
                    AddressId = locations[6].Id,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new User()
                {
                    Id = Guid.NewGuid(),
                    Name = "duje",
                    Email = "duje@gmail.com",
                    Password = "1111",
                    AddressId = locations[8].Id,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
            };

            var products = new List<Product>
    {
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "T-Shirt",
            Description = "T-Shirt for wearing",
            Price = 10,
            Quantity = 10,
            SubCategoryId = subCategories[3].Id,
            SellerId = users[0].Id,
            Images = new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" },
            Created = DateTime.UtcNow,
            SubProperties = JObject.Parse(@"{  'material': 'cotton',  'colors': ['red', 'blue']}"),
            LocationId = locations[0].Id,
            CategoryId = categories[1].Id,
            //generate extra propreties field with clothes schema category
            ExtraProperties = JObject.Parse(@"{  'name': 'cotton',  'size': ['red', 'blue']}"),

        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Jeans",
            Description = "Jeans for wearing",
            Price = 20,
            Quantity = 20,
            SubCategoryId = subCategories[4].Id,
            SellerId = users[0].Id,
            Images = new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" },
            Created = DateTime.UtcNow,
            SubProperties = JObject.Parse(@"{  'material': 'cotton',  'shades': ['red', 'blue']}"),
            LocationId = locations[0].Id,
            CategoryId = categories[1].Id,
            //generate extra propreties field with clothes schema category
            ExtraProperties = JObject.Parse(@"{  'name': 'cotton',  'size': ['red', 'blue']}"),
        },
    new Product
    {
            Id = Guid.NewGuid(),
            Name = "Shoes",
            Description = "Shoes for wearing",
            Price = 30,
            Quantity = 30,
            SubCategoryId = subCategories[4].Id,
            SellerId = users[3].Id,
            Images = new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" },
            Created = DateTime.UtcNow,
            ExtraProperties = JObject.Parse(@"{  'material': 'cotton',  'voltage': ['250V', '100V']}"),
            LocationId = locations[0].Id,
            CategoryId = categories[1].Id,
            //generate extra propreties field with clothes schema category
            SubProperties = JObject.Parse(@"{  'name': 'cotton',  'size': ['red', 'blue']}"),
        },
    new Product
    {
        Id  = Guid.NewGuid(),
        Name = "Windows Laptop",
        Description = "Laptop for working",
        Price = 500,
        Quantity = 5,
        SubCategoryId = subCategories[6].Id,
        SellerId = users[4].Id,
        Images = new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" },
        Created = DateTime.UtcNow,
        CategoryId = categories[2].Id,
        ExtraProperties = JObject.Parse(@"{  'name': 'cotton',  'voltage': ['250V', '100V']}"),
        LocationId = locations[0].Id,
        //generate extra propreties field with clothes schema category
        SubProperties = JObject.Parse(@"{  'brand': 'cotton',  'screensizes': ['1000p', '400p']}"),
    },
    new Product { 
        Id = Guid.NewGuid(),
        Name = "MacBook",
        Description = "Laptop for working",
        Price = 1000,
        Quantity = 5,
        SubCategoryId = subCategories[6].Id,
        SellerId = users[3].Id,
        Images = new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" },
        Created = DateTime.UtcNow,
        CategoryId = categories[2].Id,
        ExtraProperties = JObject.Parse(@"{  'name': 'macbook',  'voltage': ['250V', '100V']}"),
        LocationId = locations[4].Id,
        //generate extra propreties field with clothes schema category
        SubProperties = JObject.Parse(@"{  'brand': 'apple',  'screensizes': ['1000p', '400p']}"),

    },
 new Product
 {
        Id = Guid.NewGuid(),
        Name = "Asus Laptop",
        Description = "Laptop for working",
        Price = 1000,
        Quantity = 5,
        SubCategoryId = subCategories[6].Id,
        SellerId = users[1].Id,
        Images = new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" },
        Created = DateTime.UtcNow,
        CategoryId = categories[2].Id,
        ExtraProperties = JObject.Parse(@"{  'name': 'asus',  'voltage': ['250V', '100V']}"),
        LocationId = locations[1].Id,
        //generate extra propreties field with clothes schema category
        SubProperties = JObject.Parse(@"{  'brand': 'asus',  'screensizes': ['10300p', '4100p']}"),
    },  
    new Product
    {
        Id = Guid.NewGuid(),
        Name = "Iphone 12",
        Description = "Iphone 12 for working",
        Price = 1000,
        Quantity = 5,
        SubCategoryId = subCategories[5].Id,
        SellerId = users[1].Id,
        Images = new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" },
        Created = DateTime.UtcNow,
        CategoryId = categories[2].Id,
        ExtraProperties = JObject.Parse(@"{  'name': 'iphone',  'voltage': ['250V', '100V']}"),
        LocationId = locations[1].Id,
        //generate extra propreties field with clothes schema category
        SubProperties = JObject.Parse(@"{  'brand': 'apple',  'colors': ['red', 'blue']}"),
    },
    new Product
    {
        Id = Guid.NewGuid(),
        Name = "Iphone 11",
        Description = "Iphone 11 for working",
        Price = 1000,
        Quantity = 5,
        SubCategoryId = subCategories[5].Id,
        SellerId = users[1].Id,
        Images = new List<string> { "https://i.imgur.com/1Q1Z1Zm.jpg" },
        Created = DateTime.UtcNow,
        CategoryId = categories[2].Id,
        ExtraProperties = JObject.Parse(@"{  'name': 'iphone',  'voltage': ['150V', '100V']}"),
        LocationId = locations[1].Id,
        //generate extra propreties field with clothes schema category
        SubProperties = JObject.Parse(@"{  'brand': 'apple',  'colors': ['red', 'blue']}"),
    },

    };
            modelBuilder.Entity<Country>().HasData(countries);
            modelBuilder.Entity<Location>().HasData(locations);
            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<SubCategory>().HasData(subCategories);
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Product>().HasData(products);

        }



    }
}
