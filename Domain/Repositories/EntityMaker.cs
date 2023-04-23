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
using Npgsql.EntityFrameworkCore.PostgreSQL.Query.Expressions.Internal;

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
            var Location = _shopContext.Locations.FirstOrDefault(l => l.Id == request.LocationId);
            if (Location == null)
            {
                return null;
            }
            var newUser = new User
            {
                Id = new Guid(),
                Name = request.Name,
                Email = request.Email,
                Password = request.Password,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                AddressId = request.LocationId,
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
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                AddressId = request.LocationId,
                isAdmin = request.isAdmin


            };
            return updatedUser;
        }

        public Product RequestToNewProduct(CreateProductRequest request)
        {
            try
            {

                var newProduct = new Product
                {
                    Id = new Guid(),
                    Name = request.Name,
                    Description = request.Description,
                    CategoryId = request.CategoryId,
                    Created = DateTime.UtcNow,
                    Images = request.Images,
                    ExtraProperties = JObject.Parse(@request.ExtraProperties),
                    SubProperties = JObject.Parse(@request.ExtraProperties),
                    SubCategoryId = request.SubCategoryId,
                    LocationId = request.LocationId,
                    Quantity = request.Quantity
                };
                return newProduct;
            }
            catch {
                return null;
            }
        }

        public Product RequestToUpdatedProduct(UpdateProductRequest request)
        {
            try
            {
                var updatedProduct = new Product()
                {
                    Id = request.Id,
                    Name = request.Name,
                    Description = request.Description,
                    CategoryId = request.CategoryId,
                    SubCategoryId = request.SubCategoryId,
                    Quantity = request.Quantity,
                    ExtraProperties = JObject.Parse(@request.ExtraProperties),
                    SubProperties = JObject.Parse(@request.SubProperties),
                    SellerId = request.SellerId,
                };

                return updatedProduct;
            }
            catch (JsonReaderException)
            {
                return null;
            }
            catch 
            {
                return null;
            }
        }

        public Country RequestToNewCountry(CreateCountryRequest request)
        {
            var newCountry = new Country
            {
                Id = new Guid(),
                Name = request.Name,
                Image = request.Image,
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
            };

            return updatedCountry;
        }

        public Location RequestToNewLocation(CreateLocationRequest request)
        {
            try
            {
                var newLocation = new Location
                {
                    Id = new Guid(),
                    Name = request.Name,
                    Latitude = request.Latitude,
                    Longitude = request.Longitude,
                    CountryId = request.CountryId,
                };
                return newLocation;
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException) {
                return null;
            }
        }
        public Location RequestToUpdatedLocation(UpdatedLocationRequest request)
        {
            try
            {
                var updatedLocation = new Location
                {
                    Id = request.Id,
                    Name = request.Name,
                    CountryId = request.CountryId,
                    Latitude = request.Latitude,
                    Longitude = request.Longitude,
                };

                return updatedLocation;
            }
            catch (Npgsql.PostgresException)
            {
                return null;
            }
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
            var Category = _shopContext.Categories.FirstOrDefault(c => c.Id == request.Id);
                if (Category == null)
                {
                return null;
            }
            var updatedCategory = new Category
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description,
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
            catch (Npgsql.PostgresException)
            {
                return null;
            }
        }
        public SubCategory RequestToNewSubcategory(CreateSubcategoryRequest request)
        {
            try
            {
                var newSubcategory = new SubCategory
                {
                    Id = new Guid(),
                    Name = request.Name,
                    Description = request.Description,
                    CategoryId = request.CategoryId,
                    Products = new List<Product>(),
                    Schema = JSchema.Parse(@request.Schema)
                };
                
                return newSubcategory;
            }
            catch (JsonReaderException ) {
                return null;
            }
            catch (JSchemaReaderException) {
                return null;
            }
        }
        public SubCategory RequestToUpdatedSubcategory(UpdateSubCategoryRequest request)
        {
            try
            {
                var newSubcategory = new SubCategory
                {
                    Id = request.Id,
                    Name = request.Name,
                    Description = request.Description,
                    CategoryId = request.CategoryId,
                    Schema = JSchema.Parse(@request.Schema)
                };
                return newSubcategory;
                
            }
            catch (JsonReaderException )
            {
                return null;
            }
            catch(JSchemaReaderException)
            {
                return null;
            }
        }
        public BuyersProducts RequestToNewBuyersProducts(CreateBuyersProductsRequest request)
        {
            var newConnection = new BuyersProducts
            {
                BuyerId = request.UserId,
                ProductId = request.ProductId,
                Quantity = request.Quantity,
                CreatedAt = DateTime.UtcNow,
            };
            
            return newConnection;
        }
        public BuyersProducts RequestToUpdatedBuyersProducts(UpdateBuyersProductsRequest request)
        {
            var newConnection = new BuyersProducts
            {
                BuyerId = request.UserId,
                ProductId = request.ProductId,
                Quantity = request.Quantity,
                CreatedAt = DateTime.UtcNow,
            };
           
            return newConnection;
        }
    }
}
