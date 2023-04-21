using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Data.Config;
using Microsoft.Extensions.Configuration;
namespace Domain.Factories
{
    public class ShopContextFactory : IDesignTimeDbContextFactory<ShopContext>
    {
        public ShopContext CreateDbContext(string[] args)
        {
            var connectionString = ConfigurationHelper
                .GetConfiguration()
                .GetConnectionString("Database")
                ?? throw new ArgumentNullException("Database connection string is not specified.");

            var options = new DbContextOptionsBuilder<ShopContext>()
                .UseNpgsql(connectionString)
                .Options;

            return new ShopContext(options);
        }
    }
}
