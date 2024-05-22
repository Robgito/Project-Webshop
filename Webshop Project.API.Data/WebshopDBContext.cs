using Microsoft.EntityFrameworkCore;
using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data
{
    public class WebshopDBContext : DbContext
    {
        public DbSet<SmartphoneEntity> Smartphones { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<BrandEntity> Brands { get; set; }
        public DbSet<BasketEntity> Basket { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }

        public WebshopDBContext(DbContextOptions<WebshopDBContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            List<SmartphoneEntity> smartphones = new List<SmartphoneEntity>();
            modelBuilder.Entity<SmartphoneEntity>().HasData(smartphones);

            List<UserEntity> users = new List<UserEntity>();
            modelBuilder.Entity<UserEntity>().HasData(users);

            List<CategoryEntity> categories = new List<CategoryEntity>();
            modelBuilder.Entity<CategoryEntity>().HasData(categories);

            List<BrandEntity> brands = new List<BrandEntity>();
            modelBuilder.Entity<BrandEntity>().HasData(brands);

            List<BasketEntity> basket = new List<BasketEntity>();
            modelBuilder.Entity<BasketEntity>().HasData(basket);

            List<OrderEntity> orders = new List<OrderEntity>();
            modelBuilder.Entity<OrderEntity>().HasData(orders);
        }
    }
}
