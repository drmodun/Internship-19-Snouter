using Data.Config;
using Data.Entities;
using Domain.Mapper.Implementaions;
using Domain.Mapper.Interfaces;
using Domain.Repositories;
using Domain.Repositories.Inter;
using Domain.Repositories.Interfaces;
using Domain.Services;
using Domain.Services.Implmentations;
using Domain.Services.Interfaces;
using Domain.Validators;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Domain
{
    public static class ApplicationServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddValidatorsFromAssemblyContaining<IApplicarionMarker>(ServiceLifetime.Singleton);
            services.AddDbContext<ShopContext>(options =>
                           options.UseNpgsql(ConfigurationHelper.GetConfiguration().GetConnectionString("Database")));
            services.AddScoped<IUserRepo, UserRepo>();
            services.AddScoped<IProductRepo, ProductRepo>();
            services.AddScoped<ICountryRepo, CountryRepo>();
            services.AddScoped<ILocationRepo, LocationRepo>();
            services.AddScoped<EntityMaker>();
            services.AddScoped<ICategoryRepo, CategoryRepo>();
            services.AddScoped<ISubCategoryRepo, SubCategoryRepo>();
            services.AddScoped<IBuyersProductsRepo, BuyersProductsRepo>();
            services.AddScoped<ICategoryServices, CategoryServices>();
            services.AddScoped<ILocationServices, LocationServices>();
            services.AddScoped<ICountryServices, CountryServices>();
            services.AddScoped<IProductsServices, ProductsServices>();
            services.AddScoped<ISubCategoryServices, SubCategoryServices>();
            services.AddScoped<ICategoryServices, CategoryServices>();
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<IBuyersProductsService, BuyersProductsService>();
            services.AddScoped<IUserMappers, UserMappers>();
            services.AddScoped<IProductsMapper, ProductsMapper>();
            services.AddScoped<ILocationMapper, LocationMapper>();
            services.AddScoped<ICategoryMapper, CategoryMapper>();
            return services;
        }

    }
}