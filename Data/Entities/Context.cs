using Microsoft.EntityFrameworkCore;

namespace Data.Entities
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions options) : base(options) { }
        public DbSet<Models.User> Users => Set<Models.User>();
        public DbSet<Models.Product> Products => Set<Models.Product>();
        public DbSet<Models.Category> Categories => Set<Models.Category>();
        public DbSet<Models.SubCategory> SubCategories => Set<Models.SubCategory>();

        public DbSet<Models.Country> Countries => Set<Models.Country>();

        public DbSet<Models.Location> Locations => Set<Models.Location>();

        public DbSet<Models.BuyersProducts> BuyersProducts => Set<Models.BuyersProducts>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=shop;Username=postgres;Password=postgres;IncludeErrorDetail=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Location>()
                .HasKey(l => l.Id);
            modelBuilder.Entity<Models.Location>()
                .Property(l => l.Latitude)
                .HasColumnType("decimal(9,6)");
            modelBuilder.Entity<Models.Location>()
                .Property(l => l.Longitude)
                .HasColumnType("decimal(9,6)");
            modelBuilder.Entity<Models.Location>()
                .Property(l => l.Name)
                .IsRequired();
            modelBuilder.Entity<Models.Location>()
                .HasOne(l => l.Country)
                .WithMany(c => c.Locations)
                .HasForeignKey(l => l.CountryId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Models.Product>()
                .HasOne(p => p.Seller)
                .WithMany(u => u.ListedProducts)
                .HasForeignKey(p => p.SellerId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Models.BuyersProducts>()
                .HasKey(bp => new { bp.BuyerId, bp.ProductId });
            modelBuilder.Entity<Models.BuyersProducts>()
                .HasOne(bp => bp.Buyer)
                .WithMany(u => u.BoughtProducts)
                .HasForeignKey(bp => bp.BuyerId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Models.BuyersProducts>()
                .HasOne(bp => bp.Product)
                .WithMany(p => p.Buyers)
                .HasForeignKey(bp => bp.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
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
                .Property(c => c.Schema)
                .HasConversion(
                                   v => v.ToString(),
                                                      v => Newtonsoft.Json.JsonConvert.DeserializeObject<Newtonsoft.Json.Schema.JSchema>(v));
            modelBuilder.Entity<Models.SubCategory>()
                .Property(s => s.Schema)
                .HasConversion(
                                                  v => v.ToString(),
                 v => Newtonsoft.Json.JsonConvert.DeserializeObject<Newtonsoft.Json.Schema.JSchema>(v));
            Seeder.Seed(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }


    }
}