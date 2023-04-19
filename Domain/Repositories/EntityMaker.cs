using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Entities.Models;
using Domain.Contracts.Requests.Country;
using Domain.Contracts.Requests.Product;
using Domain.Contracts.Requests.User;
using Newtonsoft.Json;

namespace Domain.Repositories
{
    public class EntityMaker
    {
        private readonly ShopContext _shopContext;

        public User RequestToNewUser(CreateUserRequest request)
        {
            var newUser = new User
            {
                Id = new Guid(),
                Name = request.Name,
                Email = request.Email,
                Password = request.Password,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Address = _shopContext.Locations.FirstOrDefault(l => l.Id == request.LocationId),
                AddressId = request.LocationId,
                ListedProducts = new List<Product>(),
                BoughtProducts = new List<BuyersProducts>(),
                isAdmin = request.IsAdmin

            };
            return newUser;
        }

        public User RequestToUpdatedUser(UpdateUserRequest request)
        {
            var updatedUser = new User
            {
                Id = request.Id,
                Name = request.Name,
                Email = request.Email,
                Password = request.Password,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Address = _shopContext.Locations.FirstOrDefault(l => l.Id == request.LocationId),
                AddressId = request.LocationId,
                ListedProducts = _shopContext.Products.Where(p => p.SellerId == request.Id).ToList(),
                BoughtProducts = _shopContext.BuyersProducts.Where(bp => bp.BuyerId == request.Id).ToList(),
                isAdmin = request.isAdmin


            };
            return updatedUser;
        }

        public Product RequestToNewProduct(CreateProductRequest request)
        {
            var Category = _shopContext.Categories.FirstOrDefault(c => c.Id == request.CategoryId);
            //add schema validation later



            var newProduct = new Product
            {
                Id = new Guid(),
                Name = request.Name,
                Description = request.Description,
                CategoryId = request.CategoryId,
                Category = Category,
                SubCategory = _shopContext.SubCategories.FirstOrDefault(s => s.Id == request.SubCategoryId),
                Created = DateTime.Now,
                Location = _shopContext.Locations.FirstOrDefault(l => l.Id == request.LocationId),
                Seller = _shopContext.Users.FirstOrDefault(se => se.Id == request.SellerId),
                Buyers = new List<BuyersProducts>(),
                Images = request.Images,
                ExtraProperties = request.ExtraProperties,
                SubProperties = request.SubProperties,
                SubCategoryId = request.SubCategoryId,
                LocationId = request.LocationId,
                Quantity = request.Quantity
            };
            return newProduct;

        }

        public Product RequestToUpdatedProduct(UpdateProductRequest request)
        {
            var updatedProduct = new Product()
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description,
                CategoryId = request.CategoryId,
                Category = _shopContext.Categories.FirstOrDefault(c => c.Id == request.CategoryId),
                SubCategory = _shopContext.SubCategories.FirstOrDefault(se => se.Id == request.CategoryId),
                SubCategoryId = request.SubCategoryId,
                Quantity = request.Quantity,
                ExtraProperties = request.ExtraProperties,
                SubProperties = request.SubProperties,
                SellerId = request.SellerId,
                Seller = _shopContext.Users.FirstOrDefault(u => u.Id == request.SellerId),
                Buyers = _shopContext.BuyersProducts.Where(bp => bp.ProductId == request.Id).ToList(),
                Location = _shopContext.Locations.FirstOrDefault(l => l.Id == request.LocationId),
            };
            return updatedProduct;
        }

        public Country requestToNewCountry(CreateCountryRequest request)
        {
            var newCountry = new Country
            {
                Id = new Guid(),
                Name = request.Name,
                Image = request.Image,
                Locations = new List<Location>(),
            };
            return newCountry;
        }

        public Country RequestToUpdatedCountry(UpdateCountryRequest request)
        {
            var updatedCountry = new Country
            {
                Id = request.Id,
                Name = request.Name,
                Image = request.Image,
                Locations = _shopContext.Locations.Where(l => l.Id == request.Id).ToList(),
            };
            return updatedCountry;
        }
    }
}
