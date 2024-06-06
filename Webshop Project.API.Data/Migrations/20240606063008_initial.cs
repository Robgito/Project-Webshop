using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Webshop_Project.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Basket",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ShippingPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basket", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StreetNumber = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", maxLength: 9999, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    BasketID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_Basket_BasketID",
                        column: x => x.BasketID,
                        principalTable: "Basket",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Smartphones",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandID = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    Colour = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    MemoryCapacity = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ScreenSize = table.Column<double>(type: "float", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Smartphones", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Smartphones_Brands_BrandID",
                        column: x => x.BrandID,
                        principalTable: "Brands",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Smartphones_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BasketProducts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    BasketID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketProducts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BasketProducts_Basket_BasketID",
                        column: x => x.BasketID,
                        principalTable: "Basket",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketProducts_Smartphones_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Smartphones",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderProducts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    OrderEntityID = table.Column<int>(type: "int", nullable: true),
                    SmartphoneEntityID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Orders_OrderEntityID",
                        column: x => x.OrderEntityID,
                        principalTable: "Orders",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrderProducts_Smartphones_SmartphoneEntityID",
                        column: x => x.SmartphoneEntityID,
                        principalTable: "Smartphones",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "Basket",
                columns: new[] { "ID", "Created", "IsActive", "ShippingPrice", "Updated" },
                values: new object[] { 1, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7495), true, 0.0, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7496) });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Created", "IsActive", "Name", "Updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7328), true, "Samsung", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7329) },
                    { 2, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7332), true, "Apple", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7334) },
                    { 3, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7335), true, "Google", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7336) },
                    { 4, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7337), true, "Huawei", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7338) },
                    { 5, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7339), true, "OnePlus", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7340) }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Created", "IsActive", "Name", "Updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7216), true, "Smartphones", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7240) },
                    { 2, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7244), true, "Accessories", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7245) },
                    { 3, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7246), true, "Tablets", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7248) },
                    { 4, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7249), true, "Wearables", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7250) }
                });

            migrationBuilder.InsertData(
                table: "Smartphones",
                columns: new[] { "ID", "BrandID", "CategoryID", "Colour", "Created", "Description", "Image", "IsActive", "MemoryCapacity", "Name", "Price", "ScreenSize", "Stock", "Updated" },
                values: new object[,]
                {
                    { 1, 1, 1, "Phantom Gray", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7365), "Latest Samsung smartphone with high-end specs.", "https://image-us.samsung.com/SamsungUS/home/mobile/phones/pdp/galaxy-s21-fe-5g/gallery/SM-G990U-graphite-1.png", true, 128, "Samsung Galaxy S21", 799.99000000000001, 6.2000000000000002, 25, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7366) },
                    { 2, 2, 1, "Midnight", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7372), "New iPhone with advanced features.", "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/refurb-iphone-13-starlight-2023?wid=1144&hei=1144&fmt=jpeg&qlt=90&.v=1679072987025", true, 256, "Apple iPhone 13", 999.99000000000001, 6.0999999999999996, 30, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7373) },
                    { 3, 3, 1, "Stormy Black", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7375), "Google's latest smartphone with clean Android experience.", "https://static.fnac-static.com/multimedia/Images/FR/MDM/2f/0a/05/17107503/1540-1/tsp20240222071736/Smartphone-Google-Pixel-6-6-4-5G-128-Go-Noir-Carbone.jpg", true, 128, "Google Pixel 6", 699.99000000000001, 6.4000000000000004, 20, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7377) },
                    { 4, 4, 1, "Golden Black", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7378), "High-end smartphone from Huawei.", "https://consumer.huawei.com/content/dam/huawei-cbg-site/common/mkt/pdp/phones/p50-pro/list/black.png", true, 256, "Huawei P50", 899.99000000000001, 6.5999999999999996, 15, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7380) },
                    { 5, 5, 1, "Winter Mist", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7381), "Flagship killer from OnePlus.", "https://www.refurbished.be/cache/images/oneplus-9-pro-zwart-frontandback_600x600_BGresize_16777215-tj.png", true, 128, "OnePlus 9", 729.99000000000001, 6.5, 18, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7382) },
                    { 6, 1, 1, "Mystic Bronze", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7385), "Samsung's premium phone with S-Pen.", "https://www.refurbished.be/cache/images/note20_brons_multi_600x600_BGresize_16777215-tj.png", true, 256, "Samsung Galaxy Note 20", 949.99000000000001, 6.7000000000000002, 10, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7386) },
                    { 7, 2, 1, "Blue", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7388), "Previous generation iPhone with great performance.", "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/refurb-iphone-12-black-2020?wid=1144&hei=1144&fmt=jpeg&qlt=90&.v=1635202741000", true, 128, "Apple iPhone 12", 799.99000000000001, 6.0999999999999996, 22, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7388) },
                    { 8, 3, 1, "Just Black", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7391), "Compact and powerful Google phone.", "https://www.refurbished.be/cache/images/google-pixel-5-zwart-multi_600x600_BGresize_16777215-tj.png", true, 128, "Google Pixel 5", 599.99000000000001, 6.0, 25, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7392) },
                    { 9, 4, 1, "Space Silver", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7394), "Top-tier Huawei device with excellent camera.", "https://www.refurbished.be/cache/images/huawei-mate-40-pro-zwart-frontandback_600x600_BGresize_16777215-tj.png", true, 256, "Huawei Mate 40", 1099.99, 6.7999999999999998, 12, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7394) },
                    { 10, 5, 1, "Aquamarine Green", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7397), "Fast and fluid experience from OnePlus.", "https://oasis.opstatics.com/content/dam/oasis/default/product-specs/8t-green.png", true, 128, "OnePlus 8T", 649.99000000000001, 6.5, 17, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7398) },
                    { 11, 1, 1, "Phantom Black", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7400), "Folding phone with a large display.", "https://media.asmartworld.be/smartphones-samsung-galaxy-z-fold3-5g_550_550-4552.jpg", true, 256, "Samsung Galaxy Z Fold 3", 1799.99, 7.5999999999999996, 5, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7400) },
                    { 12, 2, 1, "Red", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7402), "Compact iPhone with powerful internals.", "https://www.forza-refurbished.be/media/catalog/product/cache/d29a0fbb193099ba8eda5bb143f05214/r/e/refurbished-iphone-se-2020-rood-thumbnail.jpg", true, 64, "Apple iPhone SE", 399.99000000000001, 4.7000000000000002, 40, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7403) },
                    { 13, 3, 1, "Barely Blue", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7405), "Affordable Google phone with great camera.", "https://www.refurbished.be/cache/images/google-pixel-4a-zwart-frontandback_600x600_BGresize_16777215-tj.png", true, 128, "Google Pixel 4a", 349.99000000000001, 5.7999999999999998, 33, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7406) },
                    { 14, 4, 1, "Midnight Black", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7408), "Budget-friendly Huawei device.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNzKch8GGQHin4EU4WoX1szX7pS0vvXo_UkA&s", true, 128, "Huawei Y9s", 249.99000000000001, 6.5, 19, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7409) },
                    { 15, 5, 1, "Gray Onyx", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7411), "Mid-range OnePlus phone with great value.", "https://www.refurbished.be/cache/images/oneplus-nord-5g-grijs-frontandback_600x600_BGresize_16777215-tj.png", true, 128, "OnePlus Nord", 399.99000000000001, 6.4000000000000004, 24, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7412) },
                    { 16, 1, 1, "Awesome Blue", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7414), "Solid mid-range Samsung device.", "https://www.refurbished.be/cache/images/a52_multi_blue_600x600_BGresize_16777215-tj.png", true, 128, "Samsung Galaxy A52", 349.99000000000001, 6.5, 35, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7415) },
                    { 17, 2, 1, "Green", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7417), "Previous generation iPhone with great performance.", "https://www.detelecomshop.net/wp-content/uploads/2020/08/New-Project-1-1.jpg", true, 64, "Apple iPhone 11", 599.99000000000001, 6.0999999999999996, 28, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7418) },
                    { 18, 3, 1, "Not Pink", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7420), "Older Google phone with excellent camera.", "https://www.refurbished.be/cache/images/google-pixel-3-xl-zwart-multi_600x600_BGresize_16777215-tj.png", true, 64, "Google Pixel 3 XL", 299.99000000000001, 6.2999999999999998, 12, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7421) },
                    { 19, 4, 1, "Space Silver", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7423), "Huawei flagship with powerful specs.", "https://mobiele-telefoon-verzekering.be/img/mobile/huawei-mate-30-pro/mate30-pro-space-silver-new.png", true, 256, "Huawei Mate 30 Pro", 1099.99, 6.5, 10, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7424) },
                    { 20, 5, 1, "Nebula Blue", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7426), "Previous generation OnePlus flagship.", "https://www.refurbished.be/cache/images/oneplus-7-pro-grijs-frontandback_600x600_BGresize_16777215-tj.png", true, 128, "OnePlus 7 Pro", 499.99000000000001, 6.7000000000000002, 15, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7427) },
                    { 21, 1, 1, "Cosmic Gray", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7429), "Flagship Samsung smartphone with advanced camera features.", "https://www.electrodepot.be/media/catalog/product/P968553.jpg", true, 128, "Samsung Galaxy S20", 999.99000000000001, 6.2000000000000002, 15, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7430) },
                    { 22, 2, 1, "Black", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7432), "Latest Apple iPhone with dual camera system.", "https://cdn.centralpoint.be/objects/high_pic/f/f0a/3300900_smartphones-apple-iphone-11-mhda3zd-a.jpg", true, 64, "Apple iPhone 11", 699.99000000000001, 6.0999999999999996, 30, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7432) },
                    { 23, 3, 1, "Just Black", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7434), "Google's smartphone with excellent camera and Google Assistant integration.", "https://www.refurbished.be/cache/images/google-pixel-4-wit-frontandback_600x600_BGresize_16777215-tj.png", true, 128, "Google Pixel 4", 799.99000000000001, 5.7000000000000002, 25, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7435) },
                    { 24, 4, 1, "Aurora", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7437), "High-end Huawei device with superior zoom camera capabilities.", "https://consumer.huawei.com/content/dam/huawei-cbg-site/common/mkt/list-image/phones/p30-pro/P30Pro_skyblue.png", true, 256, "Huawei P30 Pro", 899.99000000000001, 6.5, 10, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7438) },
                    { 25, 2, 1, "Black", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7440), "New iphone flagship!", "https://assets.swappie.com/cdn-cgi/image/width=600,height=600,fit=contain,format=auto/swappie-iphone-15-pro-max-natural-titanium.png?v=9166c13e", true, 128, "Iphone 15 Pro Max", 949.99000000000001, 6.7000000000000002, 12, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7441) },
                    { 26, 1, 1, "Black", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7443), "New camera's, new design.", "https://images.samsung.com/is/image/samsung/p6pim/be/2401/gallery/be-galaxy-s24-s928-sm-s928bztgeub-thumb-539420288", true, 128, "Samsung Galaxy S24 Ultra", 499.99000000000001, 6.7999999999999998, 50, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7444) },
                    { 27, 5, 1, "Onyx Black", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7446), "Next-gen OnePlus device with fluid display and wireless charging.", "https://www.refurbished.be/cache/images/oneplus-8-pro-zwart-duo_600x600_BGresize_16777215-tj.png", true, 256, "OnePlus 8 Pro", 799.99000000000001, 6.5, 18, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7447) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "BasketID", "Created", "Email", "IsActive", "Name", "Password", "Role", "Updated" },
                values: new object[] { 1, 1, new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7475), "test@test.be", true, "TestUser", "123", "[\"Admin\"]", new DateTime(2024, 6, 6, 8, 30, 8, 361, DateTimeKind.Local).AddTicks(7476) });

            migrationBuilder.CreateIndex(
                name: "IX_BasketProducts_BasketID",
                table: "BasketProducts",
                column: "BasketID");

            migrationBuilder.CreateIndex(
                name: "IX_BasketProducts_ProductID",
                table: "BasketProducts",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_OrderEntityID",
                table: "OrderProducts",
                column: "OrderEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_SmartphoneEntityID",
                table: "OrderProducts",
                column: "SmartphoneEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Smartphones_BrandID",
                table: "Smartphones",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_Smartphones_CategoryID",
                table: "Smartphones",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_BasketID",
                table: "Users",
                column: "BasketID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketProducts");

            migrationBuilder.DropTable(
                name: "OrderProducts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Smartphones");

            migrationBuilder.DropTable(
                name: "Basket");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
