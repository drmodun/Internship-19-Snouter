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
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                AddressId = request.LocationId,
                isAdmin = request.IsAdmin

            };
            return newUser;
        }

        public User RequestToUpdatedUser(UpdateUserRequest request)
        {
            var Location = _shopContext.Locations.FirstOrDefault(l => l.Id == request.LocationId);
            if (Location == null)
            {
                return null;
            }

            var updatedUser = new User
            {
                Id = request.Id,
                Name = request.Name,
                Email = request.Email,
                Password = request.Password,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
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
            if (Category == null)
            {
                return null;
            }
            var SubCategory = _shopContext.SubCategories.FirstOrDefault(sc => sc.Id == request.SubCategoryId);
            if (SubCategory == null)
            {
                return null;
            }
            var Location = _shopContext.Locations.FirstOrDefault(l => l.Id == request.LocationId);
            if (Location == null)
            {
                return null;
            }
            var Seller = _shopContext.Users.FirstOrDefault(u => u.Id == request.SellerId);
            if (Seller == null)
            {
                return null;
            }



            var newProduct = new Product
            {
                Id = new Guid(),
                Name = request.Name,
                Description = request.Description,
                CategoryId = request.CategoryId,
                Category = Category,
                Created = DateTime.Now,
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
            var Seller = _shopContext.Users.FirstOrDefault(u => u.Id == request.SellerId);
            var Category = _shopContext.Categories.FirstOrDefault(c => c.Id == request.CategoryId);
            var SubCategory = _shopContext.SubCategories.FirstOrDefault(sc => sc.Id == request.SubCategoryId);
            var Location = _shopContext.Locations.FirstOrDefault(l => l.Id == request.LocationId);
            if (Seller == null || Category == null || SubCategory == null || Location == null)
            {
                return null;
            }
            var updatedProduct = new Product()
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description,
                CategoryId = request.CategoryId,
                SubCategoryId = request.SubCategoryId,
                Quantity = request.Quantity,
                ExtraProperties = JObject.Parse(request.ExtraProperties),
                SubProperties = JObject.Parse(request.SubProperties),
                SellerId = request.SellerId,
                Buyers = _shopContext.BuyersProducts.Where(bp => bp.ProductId == request.Id).ToList(),
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
                    Users = _shopContext.Users.Where(u => u.AddressId == request.Id).ToList(),
                    Products = _shopContext.Products.Where(p => p.LocationId == request.Id).ToList(),
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
                    Schema = JSchema.Parse(request.Schema)
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
                    Products = _shopContext.Products.Where(p => p.SubCategoryId == request.Id).ToList(),
                    Schema = JSchema.Parse(request.Schema)
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
                Quantity = request.Quantity,
                CreatedAt = DateTime.Now,
            };
           
            return newConnection;
        }
    }
}
