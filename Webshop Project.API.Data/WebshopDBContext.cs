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
                    Name = "Samsung"
                    },
                    new BrandEntity
                    {
                        ID = 2,
                        Created = DateTime.Now,
                        Updated = DateTime.Now,
                        IsActive = true,
                        Name = "Apple"
                    },
                    new BrandEntity
                    {
                        ID = 3,
                        Created = DateTime.Now,
                        Updated = DateTime.Now,
                        IsActive = true,
                        Name = "Google"
                    },
                    new BrandEntity
                    {
                        ID = 4,
                        Created = DateTime.Now,
                        Updated = DateTime.Now,
                        IsActive = true,
                        Name = "Huawei"
                    },
                    new BrandEntity
                    {
                        ID = 5,
                        Created = DateTime.Now,
                        Updated = DateTime.Now,
                        IsActive = true,
                        Name = "OnePlus"
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
                    Name = "Smartphones"
                    },
                    new CategoryEntity
                    {
                        ID = 2,
                        Created = DateTime.Now,
                        Updated = DateTime.Now,
                        IsActive = true,
                        Name = "Accessories"
                    },
                    new CategoryEntity
                    {
                        ID = 3,
                        Created = DateTime.Now,
                        Updated = DateTime.Now,
                        IsActive = true,
                        Name = "Tablets"
                    },
                    new CategoryEntity
                    {
                        ID = 4,
                        Created = DateTime.Now,
                        Updated = DateTime.Now,
                        IsActive = true,
                        Name = "Wearables"
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
            Name = "Samsung Galaxy S21",
            Image = "LoremPicsum",
            BrandID = 1,
            CategoryID = 1,
            Colour = "Phantom Gray",
            Description = "Latest Samsung smartphone with high-end specs.",
            MemoryCapacity = 128,
            Price = 799.99,
            Stock = 25
        },
        new SmartphoneEntity()
        {
            ID = 2,
            Created = DateTime.Now,
            Updated = DateTime.Now,
            IsActive = true,
            Name = "Apple iPhone 13",
            Image = "LoremPicsum",
            BrandID = 2,
            CategoryID = 1,
            Colour = "Midnight",
            Description = "New iPhone with advanced features.",
            MemoryCapacity = 256,
            Price = 999.99,
            Stock = 30
        },
        new SmartphoneEntity()
        {
            ID = 3,
            Created = DateTime.Now,
            Updated = DateTime.Now,
            IsActive = true,
            Name = "Google Pixel 6",
            Image = "LoremPicsum",
            BrandID = 3,
            CategoryID = 1,
            Colour = "Stormy Black",
            Description = "Google's latest smartphone with clean Android experience.",
            MemoryCapacity = 128,
            Price = 699.99,
            Stock = 20
        },
        new SmartphoneEntity()
        {
            ID = 4,
            Created = DateTime.Now,
            Updated = DateTime.Now,
            IsActive = true,
            Name = "Huawei P50",
            Image = "LoremPicsum",
            BrandID = 4,
            CategoryID = 1,
            Colour = "Golden Black",
            Description = "High-end smartphone from Huawei.",
            MemoryCapacity = 256,
            Price = 899.99,
            Stock = 15
        },
        new SmartphoneEntity()
        {
            ID = 5,
            Created = DateTime.Now,
            Updated = DateTime.Now,
            IsActive = true,
            Name = "OnePlus 9",
            Image = "LoremPicsum",
            BrandID = 5,
            CategoryID = 1,
            Colour = "Winter Mist",
            Description = "Flagship killer from OnePlus.",
            MemoryCapacity = 128,
            Price = 729.99,
            Stock = 18
        },
        new SmartphoneEntity()
        {
            ID = 6,
            Created = DateTime.Now,
            Updated = DateTime.Now,
            IsActive = true,
            Name = "Samsung Galaxy Note 20",
            Image = "LoremPicsum",
            BrandID = 1,
            CategoryID = 1,
            Colour = "Mystic Bronze",
            Description = "Samsung's premium phone with S-Pen.",
            MemoryCapacity = 256,
            Price = 949.99,
            Stock = 10
        },
        new SmartphoneEntity()
        {
            ID = 7,
            Created = DateTime.Now,
            Updated = DateTime.Now,
            IsActive = true,
            Name = "Apple iPhone 12",
            Image = "LoremPicsum",
            BrandID = 2,
            CategoryID = 1,
            Colour = "Blue",
            Description = "Previous generation iPhone with great performance.",
            MemoryCapacity = 128,
            Price = 799.99,
            Stock = 22
        },
        new SmartphoneEntity()
        {
            ID = 8,
            Created = DateTime.Now,
            Updated = DateTime.Now,
            IsActive = true,
            Name = "Google Pixel 5",
            Image = "LoremPicsum",
            BrandID = 3,
            CategoryID = 1,
            Colour = "Just Black",
            Description = "Compact and powerful Google phone.",
            MemoryCapacity = 128,
            Price = 599.99,
            Stock = 25
        },
        new SmartphoneEntity()
        {
            ID = 9,
            Created = DateTime.Now,
            Updated = DateTime.Now,
            IsActive = true,
            Name = "Huawei Mate 40",
            Image = "LoremPicsum",
            BrandID = 4,
            CategoryID = 1,
            Colour = "Space Silver",
            Description = "Top-tier Huawei device with excellent camera.",
            MemoryCapacity = 256,
            Price = 1099.99,
            Stock = 12
        },
        new SmartphoneEntity()
        {
            ID = 10,
            Created = DateTime.Now,
            Updated = DateTime.Now,
            IsActive = true,
            Name = "OnePlus 8T",
            Image = "LoremPicsum",
            BrandID = 5,
            CategoryID = 1,
            Colour = "Aquamarine Green",
            Description = "Fast and fluid experience from OnePlus.",
            MemoryCapacity = 128,
            Price = 649.99,
            Stock = 17
        },
        new SmartphoneEntity()
        {
            ID = 11,
            Created = DateTime.Now,
            Updated = DateTime.Now,
            IsActive = true,
            Name = "Samsung Galaxy Z Fold 3",
            Image = "LoremPicsum",
            BrandID = 1,
            CategoryID = 1,
            Colour = "Phantom Black",
            Description = "Folding phone with a large display.",
            MemoryCapacity = 256,
            Price = 1799.99,
            Stock = 5
        },
        new SmartphoneEntity()
        {
            ID = 12,
            Created = DateTime.Now,
            Updated = DateTime.Now,
            IsActive = true,
            Name = "Apple iPhone SE",
            Image = "LoremPicsum",
            BrandID = 2,
            CategoryID = 1,
            Colour = "Red",
            Description = "Compact iPhone with powerful internals.",
            MemoryCapacity = 64,
            Price = 399.99,
            Stock = 40
        },
        new SmartphoneEntity()
        {
            ID = 13,
            Created = DateTime.Now,
            Updated = DateTime.Now,
            IsActive = true,
            Name = "Google Pixel 4a",
            Image = "LoremPicsum",
            BrandID = 3,
            CategoryID = 1,
            Colour = "Barely Blue",
            Description = "Affordable Google phone with great camera.",
            MemoryCapacity = 128,
            Price = 349.99,
            Stock = 33
        },
        new SmartphoneEntity()
        {
            ID = 14,
            Created = DateTime.Now,
            Updated = DateTime.Now,
            IsActive = true,
            Name = "Huawei Y9s",
            Image = "LoremPicsum",
            BrandID = 4,
            CategoryID = 1,
            Colour = "Midnight Black",
            Description = "Budget-friendly Huawei device.",
            MemoryCapacity = 128,
            Price = 249.99,
            Stock = 19
        },
        new SmartphoneEntity()
        {
            ID = 15,
            Created = DateTime.Now,
            Updated = DateTime.Now,
            IsActive = true,
            Name = "OnePlus Nord",
            Image = "LoremPicsum",
            BrandID = 5,
            CategoryID = 1,
            Colour = "Gray Onyx",
            Description = "Mid-range OnePlus phone with great value.",
            MemoryCapacity = 128,
            Price = 399.99,
            Stock = 24
        },
        new SmartphoneEntity()
        {
            ID = 16,
            Created = DateTime.Now,
            Updated = DateTime.Now,
            IsActive = true,
            Name = "Samsung Galaxy A52",
            Image = "LoremPicsum",
            BrandID = 1,
            CategoryID = 1,
            Colour = "Awesome Blue",
            Description = "Solid mid-range Samsung device.",
            MemoryCapacity = 128,
            Price = 349.99,
            Stock = 35
        },
        new SmartphoneEntity()
        {
            ID = 17,
            Created = DateTime.Now,
            Updated = DateTime.Now,
            IsActive = true,
            Name = "Apple iPhone 11",
            Image = "LoremPicsum",
            BrandID = 2,
            CategoryID = 1,
            Colour = "Green",
            Description = "Previous generation iPhone with great performance.",
            MemoryCapacity = 64,
            Price = 599.99,
            Stock = 28
        },
        new SmartphoneEntity()
        {
            ID = 18,
            Created = DateTime.Now,
            Updated = DateTime.Now,
            IsActive = true,
            Name = "Google Pixel 3 XL",
            Image = "LoremPicsum",
            BrandID = 3,
            CategoryID = 1,
            Colour = "Not Pink",
            Description = "Older Google phone with great features.",
            MemoryCapacity = 64,
            Price = 499.99,
            Stock = 14
        },
        new SmartphoneEntity()
        {
            ID = 19,
            Created = DateTime.Now,
            Updated = DateTime.Now,
            IsActive = true,
            Name = "Huawei Nova 7i",
            Image = "LoremPicsum",
            BrandID = 4,
            CategoryID = 1,
            Colour = "Crush Green",
            Description = "Stylish and affordable Huawei device.",
            MemoryCapacity = 128,
            Price = 299.99,
            Stock = 21
        },
        new SmartphoneEntity()
        {
            ID = 20,
            Created = DateTime.Now,
            Updated = DateTime.Now,
            IsActive = true,
            Name = "OnePlus 7 Pro",
            Image = "LoremPicsum",
            BrandID = 5,
            CategoryID = 1,
            Colour = "Nebula Blue",
            Description = "Premium OnePlus device with pop-up camera.",
            MemoryCapacity = 256,
            Price = 599.99,
            Stock = 20
        }
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
