using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Data.Entities
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions options) : base(options) { }
        //write an postgres context
        public DbSet<Models.User> Users { get; set; }
        public DbSet<Models.Product> Products { get; set; }
        public DbSet<Models.Category> Categories { get; set; }
        public DbSet<Models.SubCategory> SubCategories { get; set; }

        public DbSet<Models.Country> Countries { get; set; }

        public DbSet<Models.Location> Locations { get; set; }

        public DbSet<Models.BuyersProducts> BuyersProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=shop;Username=postgres;Password=drmodunV9");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Location>()
                .HasKey(l => l.Id);
            modelBuilder.Entity<Models.Location>()
                .HasOne(l => l.Country)
                .WithMany(c => c.Locations)
                .HasForeignKey(l => l.CountryId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Models.Country>()
                .HasMany(c => c.Locations)
                .WithOne(l => l.Country)
                .HasForeignKey(l => l.CountryId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Models.Product>()
                .HasOne(p => p.Seller)
                .WithMany(u => u.ListedProducts)
                .HasForeignKey(p => p.SellerId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Models.BuyersProducts>()
                .HasKey(bp => new { bp.BuyerId, bp.ProductId });
            modelBuilder.Entity<Models.User>()
                .HasMany(u => u.BoughtProducts)
                .WithOne(p => p.Buyer)
                .HasForeignKey(p => p.BuyerId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Models.Product>()
                .HasOne(p => p.Location)
                .WithMany(l => l.Products)
                .HasForeignKey(p => p.LocationId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Models.User>()
                .HasOne(p => p.Address)
                .WithMany(l => l.Users)
                .HasForeignKey(p => p.AddressId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Models.Product>()
                .HasMany(p => p.Buyers)
                .WithOne(b => b.Product)
                .HasForeignKey(b => b.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Models.SubCategory>()
                .HasOne(s => s.Category)
                .WithMany(c => c.SubCategories)
                .HasForeignKey(s => s.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Models.Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Models.Product>()
                .HasOne(p => p.SubCategory)
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.SubCategoryId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Models.Product>()
                .Property(p => p.ExtraProperties)
                .HasConversion(
                    v => v.ToString(),
                    v => Newtonsoft.Json.JsonConvert.DeserializeObject<Newtonsoft.Json.Linq.JObject>(v));
            modelBuilder.Entity<Models.Product>()
                .Property(p => p.SubProperties)
                .HasConversion(
                       v => v.ToString(),
                       v => Newtonsoft.Json.JsonConvert.DeserializeObject<Newtonsoft.Json.Linq.JObject>(v));
            modelBuilder.Entity<Models.Category>()
                .Property(c=>c.Schema)
                .HasConversion(
                                   v => v.ToString(),
                                                      v => Newtonsoft.Json.JsonConvert.DeserializeObject<Newtonsoft.Json.Schema.JSchema>(v));
            modelBuilder.Entity<Models.SubCategory>()
                .Property(s => s.Schema)
                .HasConversion(
                                                  v => v.ToString(),
                 v => Newtonsoft.Json.JsonConvert.DeserializeObject<Newtonsoft.Json.Schema.JSchema>(v));
        }


    }
}