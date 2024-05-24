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
        public DbSet<OrderProductEntity> OrderProducts { get; set; }
        public DbSet<BasketProductEntity> BasketProducts { get; set; }

        public WebshopDBContext(DbContextOptions<WebshopDBContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            List<CategoryEntity> categories = GetDummyCategories();
            modelBuilder.Entity<CategoryEntity>().HasData(categories);

            List<BrandEntity> brands = GetDummyBrands();
            modelBuilder.Entity<BrandEntity>().HasData(brands);

            List<SmartphoneEntity> smartphones = GetDummySmartphones();
            modelBuilder.Entity<SmartphoneEntity>().HasData(smartphones);

            List<UserEntity> users = GetDummyUsers();
            modelBuilder.Entity<UserEntity>().HasData(users);

            List<BasketEntity> basket = GetDummyBaskets();
            modelBuilder.Entity<BasketEntity>().HasData(basket);

            List<OrderEntity> orders = new List<OrderEntity>();
            modelBuilder.Entity<OrderEntity>().HasData(orders);
        }

        private List<BasketEntity> GetDummyBaskets()
        {
            return new List<BasketEntity>
            {
                new BasketEntity
                {
                    ID = 1,
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                    IsActive = true,
                    ShippingPrice = 25,
                }
            };
        }

        private List<BrandEntity> GetDummyBrands()
        {
            return new List<BrandEntity>
            {
                new BrandEntity()
                {
                    ID = 1,
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                    IsActive = true,
                    Name = "Samsung",
                }
            };
        }

        private List<CategoryEntity> GetDummyCategories()
        {
            return new List<CategoryEntity> 
            { 
                new CategoryEntity()
                {
                    ID = 1,
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                    IsActive = true,
                    Name = "Test",
                }
            };
        }

        private List<SmartphoneEntity> GetDummySmartphones()
        {
            return new List<SmartphoneEntity>
            {
                new SmartphoneEntity()
                {
                    ID = 1,
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                    IsActive = true,
                    Name = "Samsung",
                    Image = "LoremPicsum",
                    BrandID = 1,
                    CategoryID = 1,
                    Colour = "Red",
                    Description = "Lorem Ipsum",
                    MemoryCapacity = 125,
                    Price = 1099.99,
                    Stock = 5
                },
            };
        }

        private List<UserEntity> GetDummyUsers()
        {
            return new List<UserEntity>
            {
                new UserEntity()
                {
                    ID = 1,
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                    IsActive = true,
                    Name = "TestUser",
                    Role = ["Admin"],
                    Email = "test@test.be",
                    Password = "123",
                    BasketID = 1,
                },
            };
        }
    }
}
