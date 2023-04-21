using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Entities.Models;
using Domain.Contracts.Requests.BuyersProducts;
using Domain.Contracts.Requests.Category;
using Domain.Contracts.Requests.Country;
using Domain.Contracts.Requests.Location;
using Domain.Contracts.Requests.Product;
using Domain.Contracts.Requests.SubCategory;
using Domain.Contracts.Requests.User;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace Domain.Repositories
{
    public class EntityMaker
    {
        private readonly ShopContext _shopContext = new ShopContextFactory().CreateDbContext(null);
        public EntityMaker(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }

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
                SubProperties = request.ExtraProperties,
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
                ExtraProperties = JObject.Parse(request.ExtraProperties),
                SubProperties = JObject.Parse(request.SubProperties),
                SellerId = request.SellerId,
                Seller = _shopContext.Users.FirstOrDefault(u => u.Id == request.SellerId),
                Buyers = _shopContext.BuyersProducts.Where(bp => bp.ProductId == request.Id).ToList(),
                Location = _shopContext.Locations.FirstOrDefault(l => l.Id == request.LocationId),
            };
            return updatedProduct;
        }

        public Country RequestToNewCountry(CreateCountryRequest request)
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

        public Location RequestToNewLocation(CreateLocationRequest request)
        {
            var newLocation = new Location
            {
                Id = request.Id,
                Name = request.Name,
                Products = new List<Product>(),
                Users = new List<User>(),
                Latitude = request.Latitude,
                Longitude = request.Longitude,
                CountryId = request.CountryId,
                Country = _shopContext.Countries.FirstOrDefault(c => c.Id == request.CountryId)
            };
            return newLocation;
        }
        public Location RequestToUpdatedLocation(UpdatedLocationRequest request)
        {
            var updatedLocation = new Location
            {
                Id = request.Id,
                Name = request.Name,
                Users = _shopContext.Users.Where(u => u.AddressId == request.Id).ToList(),
                Products = _shopContext.Products.Where(p => p.LocationId == request.Id).ToList(),
                CountryId = request.CountryId,
                Country = _shopContext.Countries.FirstOrDefault(c => c.Id == request.CountryId),
                Latitude = request.Latitude,
                Longitude = request.Longitude,
            };
            return updatedLocation;
        }
        public Category RequestToNewCategory(CreateCategoryRequest request)
        {
            try
            {
                var newCategory = new Category
                {
                    Id = new Guid(),
                    Name = request.Name,
                    Description = request.Description,
                    Products = new List<Product>(),
                    SubCategories = new List<SubCategory>(),
                    Schema = JSchema.Parse(@request.Schema)
                };
                return newCategory;
            }
            catch (JsonReaderException ) {
                return null;
            }
            catch (JSchemaReaderException)
            {
                return null;
            }
        }
        public Category RequestToUpdatedCategory(UpdateCategoryRequest request)
        {
            try {
            var updatedCategory = new Category
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description,
                Products = _shopContext.Products.Where(p => p.Id == request.Id).ToList(),
                SubCategories = _shopContext.SubCategories.Where(sb => sb.Id == request.Id).ToList(),
                Schema = JSchema.Parse(@request.Schema)
            };
            return updatedCategory;
                }
            catch (JsonReaderException )
            {
                return null;
            }
            catch (JSchemaReaderException)
            {
                return null;
            }
        }
        public SubCategory RequestToNewSubcategory(CreateSubcategoryRequest request)
        {
            var newSubcategory = new SubCategory
            {
                Id = new Guid(),
                Name = request.Name,
                Description = request.Description,
                CategoryId = request.CategoryId,
                Category = _shopContext.Categories.FirstOrDefault(c => c.Id == request.CategoryId),
                Products = new List<Product>(),
                Schema = JSchema.Parse(request.Schema)
            };
            return newSubcategory;
        }
        public SubCategory RequestToUpdatedSubcategory(UpdateSubCategoryRequest request)
        {
            var newSubcategory = new SubCategory
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description,
                CategoryId = request.CategoryId,
                Category = _shopContext.Categories.FirstOrDefault(c => c.Id == request.CategoryId),
                Products = _shopContext.Products.Where(p=>p.SubCategoryId == request.Id).ToList(),
                Schema = JSchema.Parse(request.Schema)
            };
            return newSubcategory;
        }
        public BuyersProducts RequestToNewBuyersProducts(CreateBuyersProductsRequest request)
        {
            var newConnection = new BuyersProducts
            {
                BuyerId = request.UserId,
                ProductId = request.ProductId,
                Buyer = _shopContext.Users.FirstOrDefault(u => u.Id == request.UserId),
                Product = _shopContext.Products.FirstOrDefault(p => p.Id == request.ProductId),
                Quantity = request.Quantity,
                CreatedAt = DateTime.Now,
            };
            return newConnection;
        }
        public BuyersProducts RequestToUpdatedBuyersProducts(UpdateBuyersProductsRequest request)
        {
            var newConnection = new BuyersProducts
            {
                BuyerId = request.UserId,
                ProductId = request.ProductId,
                Buyer = _shopContext.Users.FirstOrDefault(u => u.Id == request.UserId),
                Product = _shopContext.Products.FirstOrDefault(p => p.Id == request.ProductId),
                Quantity = request.Quantity,
                CreatedAt = DateTime.Now,
            };
            return newConnection;
        }
    }
}
