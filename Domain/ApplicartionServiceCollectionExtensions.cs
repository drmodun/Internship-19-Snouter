using Data.Config;
using Data.Entities;
using Data.Entities.Models;
using Domain.Mapper;
using Domain.Repositories;
using Domain.Services;
using Domain.Validators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json.Serialization;

namespace Domain
{
    public static class ApplicationServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddDbContext<ShopContext>(options =>
                           options.UseNpgsql(ConfigurationHelper.GetConfiguration().GetConnectionString("Database")));
            services.AddScoped<CategoryServices>();
            services.AddScoped<LocationServices>();
            services.AddScoped<CountryServices>();
            services.AddScoped<ProductsServices>();
            services.AddScoped<SubCategoryServices>();
            services.AddScoped<CategoryServices>();
            services.AddScoped<UserServices>();
            services.AddScoped<BuyersProductsService>();
            services.AddScoped<UserRepo>();
            services.AddScoped<ProductRepo>();
            services.AddScoped<CountryRepo>();
            services.AddScoped<LocationRepo>();
            services.AddScoped<EntityMaker>();
            services.AddScoped<CategoryRepo>();
            services.AddScoped<SubCategoryRepo>();
            services.AddScoped<BuyersProductsRepo>();
            services.AddScoped <UserMappers>();
            services.AddScoped<ProductsMapper>();
            services.AddScoped<LocationMapper>();
            services.AddScoped<CategoryMapper>();
            services.AddScoped<CategoriesValidator>();
            services.AddScoped<UserValidator>();
            services.AddScoped<ProductsValidator>();
            services.AddScoped<CountriesValidator>();
            services.AddScoped<SubCategoriesValidator>();
            services.AddScoped<LocationsValidator>();
            services.AddScoped<BuyersProductsValidator>();



            return services;
        }

    }
}