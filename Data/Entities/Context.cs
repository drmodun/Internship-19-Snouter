using Microsoft.EntityFrameworkCore;

namespace Data.Entities
{
    public class ShopContext : DbContext
    { 
        //write an postgres context
        public DbSet<Models.User> Users { get; set; }
        public DbSet<Models.Admin> Admins { get; set; }
        public DbSet<Models.ComputerProduct> ComputerProducts { get; set; }
        public DbSet<Models.OtherProducts> OtherProducts { get; set; }
        public DbSet<Models.Product> Products { get; set; }
        public DbSet<Models.Car> Cars { get; set; }
        public DbSet<Models.Order> Orders { get; set; }
        public DbSet<Models.OrderItem> OrderItems { get; set; }
        public DbSet<Models.Cart> Carts { get; set; }
        public DbSet<Models.CartItem> CartItems { get; set; }
        public DbSet<Models.Category> Categories { get; set; }
        public DbSet<Models.SubCategory> SubCategories { get; set; }
        public DbSet<Models.ProductCategory> ProductCategories { get; set; }
        public DbSet<Models.ProductSubCategory> ProductSubCategories { get; set; }
        public DbSet<Models.ProductImage> ProductImages { get; set; }
        public DbSet<Models.ProductReview> ProductReviews { get; set; }
        public DbSet<Models.ProductSpecification> ProductSpecifications { get; set; }
        public DbSet<Models.ProductSpecificationValue> ProductSpecificationValues { get; set; }
        public DbSet<Models.ProductSpecificationValueImage> ProductSpecificationValueImages { get; set; }
        public DbSet<Models.ProductSpecificationValueReview> ProductSpecificationValueReviews { get; set; }
        public DbSet<Models.ProductSpecificationValueVideo> ProductSpecificationValueVideos { get; set; }
        public DbSet<Models.ProductVideo> ProductVideos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=Shop;Username=postgres;Password=postgres");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.ProductCategory>()
                .HasKey(pc => new { pc.ProductId, pc.CategoryId });
            modelBuilder.Entity<Models.ProductCategory>()
                .HasOne(pc => pc.Product)
                .WithMany(p => p.ProductCategories)
                .HasForeignKey(pc => pc.ProductId);
            modelBuilder.Entity<Models.ProductCategory>()
                .HasOne(pc => pc.Category)
                .WithMany(c => c.ProductCategories)
                .HasForeignKey(pc => pc.CategoryId);
            modelBuilder.Entity<Models.ProductSubCategory>()
                .HasKey(psc => new { psc.ProductId, psc.SubCategoryId });
            modelBuilder.Entity<Models.ProductSubCategory>()
                .HasOne(psc => psc.Product)
                .WithMany(p => p.ProductSubCategories)
                .HasForeignKey(psc => psc.ProductId);
            modelBuilder.Entity<Models.ProductSubCategory>()
                .HasOne(psc => psc.SubCategory)
                .WithMany(sc => sc.ProductSubCategories)
                .HasForeignKey(psc => psc.SubCategoryId);
            modelBuilder.Entity<Models.ProductSpecificationValue>()
                .HasKey(psv => new { psv.ProductSpecificationId, psv.ProductId });
            modelBuilder.Entity<Models.ProductSpecificationValue>()
                .HasOne(psv => psv.ProductSpecification)
                .WithMany(ps => ps.ProductSpecificationValues)
                .HasForeignKey(psv => psv.ProductSpecificationId);
            modelBuilder.Entity<Models.ProductSpecificationValue>()
                .HasOne(psv => psv.Product)
                .WithMany(p => p.ProductSpecificationValues)
                .HasForeignKey(psv => psv.ProductId);
            modelBuilder.Entity<Models.ProductSpecificationValueImage>()
                .HasKey(psvi => new { psvi.ProductSpecificationValueId, psvi.ProductId });
            modelBuilder.Entity<Models.ProductSpecificationValueImage>()
                .HasOne(psvi => psvi.ProductSpecificationValue)
                .WithMany(psv => psv.ProductSpecificationValueImages)
                .HasForeignKey(psvi => psvi.ProductSpecificationValueId);
            modelBuilder.Entity<Models.ProductSpecificationValueImage>()
                .HasOne(psvi => psvi.Product)
                .WithMany(p => p.ProductSpecificationValueImages)
                .HasForeignKey(psvi => psvi.ProductId);
            modelBuilder.Entity<Models.ProductSpecificationValueReview>()
                .HasKey(psvr => new { psvr.ProductSpecificationValueId, psvr.ProductId });
            modelBuilder.Entity<Models.Product> 
        }

    }
}