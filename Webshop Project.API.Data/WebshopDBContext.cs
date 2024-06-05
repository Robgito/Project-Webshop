using Microsoft.EntityFrameworkCore;
using Webshop_Project.API.Data.Entities;

namespace Webshop_Project.API.Data
{
    public class WebshopDBContext : DbContext
    {
        public WebshopDBContext(DbContextOptions<WebshopDBContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<BasketEntity> Basket { get; set; }
        public DbSet<BasketProductEntity> BasketProducts { get; set; }
        public DbSet<BrandEntity> Brands { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<OrderProductEntity> OrderProducts { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<SmartphoneEntity> Smartphones { get; set; }
        public DbSet<UserEntity> Users { get; set; }

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
                new BasketEntity()
                {
                    ID = 1,
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                    IsActive = true,
                    ShippingPrice = 0,
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
                    new BrandEntity()
                    {
                        ID = 2,
                        Created = DateTime.Now,
                        Updated = DateTime.Now,
                        IsActive = true,
                        Name = "Apple"
                    },
                    new BrandEntity()
                    {
                        ID = 3,
                        Created = DateTime.Now,
                        Updated = DateTime.Now,
                        IsActive = true,
                        Name = "Google"
                    },
                    new BrandEntity()
                    {
                        ID = 4,
                        Created = DateTime.Now,
                        Updated = DateTime.Now,
                        IsActive = true,
                        Name = "Huawei"
                    },
                    new BrandEntity()
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
                new CategoryEntity()
                {
                    ID = 2,
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                    IsActive = true,
                    Name = "Accessories"
                },
                    new CategoryEntity()
                    {
                        ID = 3,
                        Created = DateTime.Now,
                        Updated = DateTime.Now,
                        IsActive = true,
                        Name = "Tablets"
                    },
                    new CategoryEntity()
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
    Image = "https://image-us.samsung.com/SamsungUS/home/mobile/phones/pdp/galaxy-s21-fe-5g/gallery/SM-G990U-graphite-1.png",
    BrandID = 1,
    CategoryID = 1,
    Colour = "Phantom Gray",
    Description = "Latest Samsung smartphone with high-end specs.",
    MemoryCapacity = 128,
    Price = 799.99,
    Stock = 25,
    ScreenSize = 6.2
},
new SmartphoneEntity()
{
    ID = 2,
    Created = DateTime.Now,
    Updated = DateTime.Now,
    IsActive = true,
    Name = "Apple iPhone 13",
    Image = "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/refurb-iphone-13-starlight-2023?wid=1144&hei=1144&fmt=jpeg&qlt=90&.v=1679072987025",
    BrandID = 2,
    CategoryID = 1,
    Colour = "Midnight",
    Description = "New iPhone with advanced features.",
    MemoryCapacity = 256,
    Price = 999.99,
    Stock = 30,
    ScreenSize = 6.1
},
new SmartphoneEntity()
{
    ID = 3,
    Created = DateTime.Now,
    Updated = DateTime.Now,
    IsActive = true,
    Name = "Google Pixel 6",
    Image = "https://static.fnac-static.com/multimedia/Images/FR/MDM/2f/0a/05/17107503/1540-1/tsp20240222071736/Smartphone-Google-Pixel-6-6-4-5G-128-Go-Noir-Carbone.jpg",
    BrandID = 3,
    CategoryID = 1,
    Colour = "Stormy Black",
    Description = "Google's latest smartphone with clean Android experience.",
    MemoryCapacity = 128,
    Price = 699.99,
    Stock = 20,
    ScreenSize = 6.4
},
new SmartphoneEntity()
{
    ID = 4,
    Created = DateTime.Now,
    Updated = DateTime.Now,
    IsActive = true,
    Name = "Huawei P50",
    Image = "https://consumer.huawei.com/content/dam/huawei-cbg-site/common/mkt/pdp/phones/p50-pro/list/black.png",
    BrandID = 4,
    CategoryID = 1,
    Colour = "Golden Black",
    Description = "High-end smartphone from Huawei.",
    MemoryCapacity = 256,
    Price = 899.99,
    Stock = 15,
    ScreenSize = 6.6
},
new SmartphoneEntity()
{
    ID = 5,
    Created = DateTime.Now,
    Updated = DateTime.Now,
    IsActive = true,
    Name = "OnePlus 9",
    Image = "https://www.refurbished.be/cache/images/oneplus-9-pro-zwart-frontandback_600x600_BGresize_16777215-tj.png",
    BrandID = 5,
    CategoryID = 1,
    Colour = "Winter Mist",
    Description = "Flagship killer from OnePlus.",
    MemoryCapacity = 128,
    Price = 729.99,
    Stock = 18,
    ScreenSize = 6.5
},
new SmartphoneEntity()
{
    ID = 6,
    Created = DateTime.Now,
    Updated = DateTime.Now,
    IsActive = true,
    Name = "Samsung Galaxy Note 20",
    Image = "https://www.refurbished.be/cache/images/note20_brons_multi_600x600_BGresize_16777215-tj.png",
    BrandID = 1,
    CategoryID = 1,
    Colour = "Mystic Bronze",
    Description = "Samsung's premium phone with S-Pen.",
    MemoryCapacity = 256,
    Price = 949.99,
    Stock = 10,
    ScreenSize = 6.7
},
new SmartphoneEntity()
{
    ID = 7,
    Created = DateTime.Now,
    Updated = DateTime.Now,
    IsActive = true,
    Name = "Apple iPhone 12",
    Image = "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/refurb-iphone-12-black-2020?wid=1144&hei=1144&fmt=jpeg&qlt=90&.v=1635202741000",
    BrandID = 2,
    CategoryID = 1,
    Colour = "Blue",
    Description = "Previous generation iPhone with great performance.",
    MemoryCapacity = 128,
    Price = 799.99,
    Stock = 22,
    ScreenSize = 6.1
},
new SmartphoneEntity()
{
    ID = 8,
    Created = DateTime.Now,
    Updated = DateTime.Now,
    IsActive = true,
    Name = "Google Pixel 5",
    Image = "https://www.refurbished.be/cache/images/google-pixel-5-zwart-multi_600x600_BGresize_16777215-tj.png",
    BrandID = 3,
    CategoryID = 1,
    Colour = "Just Black",
    Description = "Compact and powerful Google phone.",
    MemoryCapacity = 128,
    Price = 599.99,
    Stock = 25,
    ScreenSize = 6.0
},
new SmartphoneEntity()
{
    ID = 9,
    Created = DateTime.Now,
    Updated = DateTime.Now,
    IsActive = true,
    Name = "Huawei Mate 40",
    Image = "https://www.refurbished.be/cache/images/huawei-mate-40-pro-zwart-frontandback_600x600_BGresize_16777215-tj.png",
    BrandID = 4,
    CategoryID = 1,
    Colour = "Space Silver",
    Description = "Top-tier Huawei device with excellent camera.",
    MemoryCapacity = 256,
    Price = 1099.99,
    Stock = 12,
    ScreenSize = 6.8
},
new SmartphoneEntity()
{
    ID = 10,
    Created = DateTime.Now,
    Updated = DateTime.Now,
    IsActive = true,
    Name = "OnePlus 8T",
    Image = "https://oasis.opstatics.com/content/dam/oasis/default/product-specs/8t-green.png",
    BrandID = 5,
    CategoryID = 1,
    Colour = "Aquamarine Green",
    Description = "Fast and fluid experience from OnePlus.",
    MemoryCapacity = 128,
    Price = 649.99,
    Stock = 17,
    ScreenSize = 6.5
},
new SmartphoneEntity()
{
    ID = 11,
    Created = DateTime.Now,
    Updated = DateTime.Now,
    IsActive = true,
    Name = "Samsung Galaxy Z Fold 3",
    Image = "https://media.asmartworld.be/smartphones-samsung-galaxy-z-fold3-5g_550_550-4552.jpg",
    BrandID = 1,
    CategoryID = 1,
    Colour = "Phantom Black",
    Description = "Folding phone with a large display.",
    MemoryCapacity = 256,
    Price = 1799.99,
    Stock = 5,
    ScreenSize = 7.6
},
new SmartphoneEntity()
{
    ID = 12,
    Created = DateTime.Now,
    Updated = DateTime.Now,
    IsActive = true,
    Name = "Apple iPhone SE",
    Image = "https://www.forza-refurbished.be/media/catalog/product/cache/d29a0fbb193099ba8eda5bb143f05214/r/e/refurbished-iphone-se-2020-rood-thumbnail.jpg",
    BrandID = 2,
    CategoryID = 1,
    Colour = "Red",
    Description = "Compact iPhone with powerful internals.",
    MemoryCapacity = 64,
    Price = 399.99,
    Stock = 40,
    ScreenSize = 4.7
},
new SmartphoneEntity()
{
    ID = 13,
    Created = DateTime.Now,
    Updated = DateTime.Now,
    IsActive = true,
    Name = "Google Pixel 4a",
    Image = "https://www.refurbished.be/cache/images/google-pixel-4a-zwart-frontandback_600x600_BGresize_16777215-tj.png",
    BrandID = 3,
    CategoryID = 1,
    Colour = "Barely Blue",
    Description = "Affordable Google phone with great camera.",
    MemoryCapacity = 128,
    Price = 349.99,
    Stock = 33,
    ScreenSize = 5.8
},
new SmartphoneEntity()
{
    ID = 14,
    Created = DateTime.Now,
    Updated = DateTime.Now,
    IsActive = true,
    Name = "Huawei Y9s",
    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNzKch8GGQHin4EU4WoX1szX7pS0vvXo_UkA&s",
    BrandID = 4,
    CategoryID = 1,
    Colour = "Midnight Black",
    Description = "Budget-friendly Huawei device.",
    MemoryCapacity = 128,
    Price = 249.99,
    Stock = 19,
    ScreenSize = 6.5
},
new SmartphoneEntity()
{
    ID = 15,
    Created = DateTime.Now,
    Updated = DateTime.Now,
    IsActive = true,
    Name = "OnePlus Nord",
    Image = "https://www.refurbished.be/cache/images/oneplus-nord-5g-grijs-frontandback_600x600_BGresize_16777215-tj.png",
    BrandID = 5,
    CategoryID = 1,
    Colour = "Gray Onyx",
    Description = "Mid-range OnePlus phone with great value.",
    MemoryCapacity = 128,
    Price = 399.99,
    Stock = 24,
    ScreenSize = 6.4
},
new SmartphoneEntity()
{
    ID = 16,
    Created = DateTime.Now,
    Updated = DateTime.Now,
    IsActive = true,
    Name = "Samsung Galaxy A52",
    Image = "https://www.refurbished.be/cache/images/a52_multi_blue_600x600_BGresize_16777215-tj.png",
    BrandID = 1,
    CategoryID = 1,
    Colour = "Awesome Blue",
    Description = "Solid mid-range Samsung device.",
    MemoryCapacity = 128,
    Price = 349.99,
    Stock = 35,
    ScreenSize = 6.5
},
new SmartphoneEntity()
{
    ID = 17,
    Created = DateTime.Now,
    Updated = DateTime.Now,
    IsActive = true,
    Name = "Apple iPhone 11",
    Image = "https://www.detelecomshop.net/wp-content/uploads/2020/08/New-Project-1-1.jpg",
    BrandID = 2,
    CategoryID = 1,
    Colour = "Green",
    Description = "Previous generation iPhone with great performance.",
    MemoryCapacity = 64,
    Price = 599.99,
    Stock = 28,
    ScreenSize = 6.1
},
new SmartphoneEntity()
{
    ID = 18,
    Created = DateTime.Now,
    Updated = DateTime.Now,
    IsActive = true,
    Name = "Google Pixel 3 XL",
    Image = "https://www.refurbished.be/cache/images/google-pixel-3-xl-zwart-multi_600x600_BGresize_16777215-tj.png",
    BrandID = 3,
    CategoryID = 1,
    Colour = "Not Pink",
    Description = "Older Google phone with excellent camera.",
    MemoryCapacity = 64,
    Price = 299.99,
    Stock = 12,
    ScreenSize = 6.3
},
new SmartphoneEntity()
{
    ID = 19,
    Created = DateTime.Now,
    Updated = DateTime.Now,
    IsActive = true,
    Name = "Huawei Mate 30 Pro",
    Image = "https://mobiele-telefoon-verzekering.be/img/mobile/huawei-mate-30-pro/mate30-pro-space-silver-new.png",
    BrandID = 4,
    CategoryID = 1,
    Colour = "Space Silver",
    Description = "Huawei flagship with powerful specs.",
    MemoryCapacity = 256,
    Price = 1099.99,
    Stock = 10,
    ScreenSize = 6.5
},
new SmartphoneEntity()
{
    ID = 20,
    Created = DateTime.Now,
    Updated = DateTime.Now,
    IsActive = true,
    Name = "OnePlus 7 Pro",
    Image = "https://www.refurbished.be/cache/images/oneplus-7-pro-grijs-frontandback_600x600_BGresize_16777215-tj.png",
    BrandID = 5,
    CategoryID = 1,
    Colour = "Nebula Blue",
    Description = "Previous generation OnePlus flagship.",
    MemoryCapacity = 128,
    Price = 499.99,
    Stock = 15,
    ScreenSize = 6.7
},
new SmartphoneEntity()
{
    ID = 21,
    Created = DateTime.Now,
    Updated = DateTime.Now,
    IsActive = true,
    Name = "Samsung Galaxy S20",
    Image = "https://www.electrodepot.be/media/catalog/product/P968553.jpg",
    BrandID = 1,
    CategoryID = 1,
    Colour = "Cosmic Gray",
    Description = "Flagship Samsung smartphone with advanced camera features.",
    MemoryCapacity = 128,
    Price = 999.99,
    Stock = 15,
    ScreenSize = 6.2
},

new SmartphoneEntity()
{
    ID = 22,
    Created = DateTime.Now,
    Updated = DateTime.Now,
    IsActive = true,
    Name = "Apple iPhone 11",
    Image = "https://cdn.centralpoint.be/objects/high_pic/f/f0a/3300900_smartphones-apple-iphone-11-mhda3zd-a.jpg",
    BrandID = 2,
    CategoryID = 1,
    Colour = "Black",
    Description = "Latest Apple iPhone with dual camera system.",
    MemoryCapacity = 64,
    Price = 699.99,
    Stock = 30,
    ScreenSize = 6.1
},

new SmartphoneEntity()
{
    ID = 23,
    Created = DateTime.Now,
    Updated = DateTime.Now,
    IsActive = true,
    Name = "Google Pixel 4",
    Image = "https://www.refurbished.be/cache/images/google-pixel-4-wit-frontandback_600x600_BGresize_16777215-tj.png",
    BrandID = 3,
    CategoryID = 1,
    Colour = "Just Black",
    Description = "Google's smartphone with excellent camera and Google Assistant integration.",
    MemoryCapacity = 128,
    Price = 799.99,
    Stock = 25,
    ScreenSize = 5.7
},

new SmartphoneEntity()
{
    ID = 24,
    Created = DateTime.Now,
    Updated = DateTime.Now,
    IsActive = true,
    Name = "Huawei P30 Pro",
    Image = "https://consumer.huawei.com/content/dam/huawei-cbg-site/common/mkt/list-image/phones/p30-pro/P30Pro_skyblue.png",
    BrandID = 4,
    CategoryID = 1,
    Colour = "Aurora",
    Description = "High-end Huawei device with superior zoom camera capabilities.",
    MemoryCapacity = 256,
    Price = 899.99,
    Stock = 10,
    ScreenSize = 6.5
},

new SmartphoneEntity()
{
    ID = 25,
    Created = DateTime.Now,
    Updated = DateTime.Now,
    IsActive = true,
    Name = "Iphone 15 Pro Max",
    Image = "https://assets.swappie.com/cdn-cgi/image/width=600,height=600,fit=contain,format=auto/swappie-iphone-15-pro-max-natural-titanium.png?v=9166c13e",
    BrandID = 2,
    CategoryID = 1,
    Colour = "Black",
    Description = "New iphone flagship!",
    MemoryCapacity = 128,
    Price = 949.99,
    Stock = 12,
    ScreenSize = 6.7
},

new SmartphoneEntity()
{
    ID = 26,
    Created = DateTime.Now,
    Updated = DateTime.Now,
    IsActive = true,
    Name = "Samsung Galaxy S24 Ultra",
    Image = "https://images.samsung.com/is/image/samsung/p6pim/be/2401/gallery/be-galaxy-s24-s928-sm-s928bztgeub-thumb-539420288",
    BrandID = 1,
    CategoryID = 1,
    Colour = "Black",
    Description = "New camera's, new design.",
    MemoryCapacity = 128,
    Price = 499.99,
    Stock = 50,
    ScreenSize = 6.8
},

new SmartphoneEntity()
{
    ID = 27,
    Created = DateTime.Now,
    Updated = DateTime.Now,
    IsActive = true,
    Name = "OnePlus 8 Pro",
    Image = "https://www.refurbished.be/cache/images/oneplus-8-pro-zwart-duo_600x600_BGresize_16777215-tj.png",
    BrandID = 5,
    CategoryID = 1,
    Colour = "Onyx Black",
    Description = "Next-gen OnePlus device with fluid display and wireless charging.",
    MemoryCapacity = 256,
    Price = 799.99,
    Stock = 18,
    ScreenSize = 6.5
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