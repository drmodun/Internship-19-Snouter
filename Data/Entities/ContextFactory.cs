using Data.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
namespace Data.Entities
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
