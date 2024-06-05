using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Webshop_Project.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class intial : Migration
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Colour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    MemoryCapacity = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    BasketID = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
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
                values: new object[] { 1, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1434), true, 25.0, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1435) });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Created", "IsActive", "Name", "Updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1220), true, "Samsung", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1221) },
                    { 2, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1225), true, "Apple", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1226) },
                    { 3, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1228), true, "Google", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1229) },
                    { 4, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1230), true, "Huawei", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1231) },
                    { 5, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1232), true, "OnePlus", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1233) }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Created", "IsActive", "Name", "Updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1088), true, "Smartphones", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1145) },
                    { 2, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1149), true, "Accessories", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1150) },
                    { 3, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1152), true, "Tablets", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1153) },
                    { 4, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1154), true, "Wearables", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1155) }
                });

            migrationBuilder.InsertData(
                table: "Smartphones",
                columns: new[] { "ID", "BrandID", "CategoryID", "Colour", "Created", "Description", "Image", "IsActive", "MemoryCapacity", "Name", "Price", "ScreenSize", "Stock", "Updated" },
                values: new object[,]
                {
                    { 1, 1, 1, "Phantom Gray", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1263), "Latest Samsung smartphone with high-end specs.", "https://picsum.photos/181", true, 128, "Samsung Galaxy S21", 799.99000000000001, 6.2000000000000002, 25, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1264) },
                    { 2, 2, 1, "Midnight", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1273), "New iPhone with advanced features.", "https://picsum.photos/182", true, 256, "Apple iPhone 13", 999.99000000000001, 6.0999999999999996, 30, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1274) },
                    { 3, 3, 1, "Stormy Black", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1276), "Google's latest smartphone with clean Android experience.", "https://picsum.photos/183", true, 128, "Google Pixel 6", 699.99000000000001, 6.4000000000000004, 20, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1277) },
                    { 4, 4, 1, "Golden Black", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1279), "High-end smartphone from Huawei.", "https://picsum.photos/184", true, 256, "Huawei P50", 899.99000000000001, 6.5999999999999996, 15, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1280) },
                    { 5, 5, 1, "Winter Mist", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1282), "Flagship killer from OnePlus.", "https://picsum.photos/185", true, 128, "OnePlus 9", 729.99000000000001, 6.5, 18, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1283) },
                    { 6, 1, 1, "Mystic Bronze", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1285), "Samsung's premium phone with S-Pen.", "https://picsum.photos/186", true, 256, "Samsung Galaxy Note 20", 949.99000000000001, 6.7000000000000002, 10, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1286) },
                    { 7, 2, 1, "Blue", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1288), "Previous generation iPhone with great performance.", "https://picsum.photos/187", true, 128, "Apple iPhone 12", 799.99000000000001, 6.0999999999999996, 22, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1289) },
                    { 8, 3, 1, "Just Black", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1291), "Compact and powerful Google phone.", "https://picsum.photos/188", true, 128, "Google Pixel 5", 599.99000000000001, 6.0, 25, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1292) },
                    { 9, 4, 1, "Space Silver", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1314), "Top-tier Huawei device with excellent camera.", "https://picsum.photos/189", true, 256, "Huawei Mate 40", 1099.99, 6.7999999999999998, 12, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1315) },
                    { 10, 5, 1, "Aquamarine Green", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1318), "Fast and fluid experience from OnePlus.", "https://picsum.photos/190", true, 128, "OnePlus 8T", 649.99000000000001, 6.5, 17, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1319) },
                    { 11, 1, 1, "Phantom Black", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1321), "Folding phone with a large display.", "https://picsum.photos/191", true, 256, "Samsung Galaxy Z Fold 3", 1799.99, 7.5999999999999996, 5, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1322) },
                    { 12, 2, 1, "Red", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1324), "Compact iPhone with powerful internals.", "https://picsum.photos/192", true, 64, "Apple iPhone SE", 399.99000000000001, 4.7000000000000002, 40, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1325) },
                    { 13, 3, 1, "Barely Blue", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1327), "Affordable Google phone with great camera.", "https://picsum.photos/193", true, 128, "Google Pixel 4a", 349.99000000000001, 5.7999999999999998, 33, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1328) },
                    { 14, 4, 1, "Midnight Black", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1330), "Budget-friendly Huawei device.", "https://picsum.photos/194", true, 128, "Huawei Y9s", 249.99000000000001, 6.5, 19, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1331) },
                    { 15, 5, 1, "Gray Onyx", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1333), "Mid-range OnePlus phone with great value.", "https://picsum.photos/195", true, 128, "OnePlus Nord", 399.99000000000001, 6.4000000000000004, 24, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1334) },
                    { 16, 1, 1, "Awesome Blue", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1336), "Solid mid-range Samsung device.", "https://picsum.photos/196", true, 128, "Samsung Galaxy A52", 349.99000000000001, 6.5, 35, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1337) },
                    { 17, 2, 1, "Green", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1339), "Previous generation iPhone with great performance.", "https://picsum.photos/197", true, 64, "Apple iPhone 11", 599.99000000000001, 6.0999999999999996, 28, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1339) },
                    { 18, 3, 1, "Not Pink", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1342), "Older Google phone with excellent camera.", "https://picsum.photos/198", true, 64, "Google Pixel 3 XL", 299.99000000000001, 6.2999999999999998, 12, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1343) },
                    { 19, 4, 1, "Space Silver", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1345), "Huawei flagship with powerful specs.", "https://picsum.photos/199", true, 256, "Huawei Mate 30 Pro", 1099.99, 6.5, 10, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1346) },
                    { 20, 5, 1, "Nebula Blue", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1348), "Previous generation OnePlus flagship.", "https://picsum.photos/200", true, 128, "OnePlus 7 Pro", 499.99000000000001, 6.7000000000000002, 15, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1349) },
                    { 21, 1, 1, "Cosmic Gray", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1351), "Flagship Samsung smartphone with advanced camera features.", "https://picsum.photos/201", true, 128, "Samsung Galaxy S20", 999.99000000000001, 6.2000000000000002, 15, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1351) },
                    { 22, 2, 1, "Black", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1354), "Latest Apple iPhone with dual camera system.", "https://picsum.photos/202", true, 64, "Apple iPhone 11", 699.99000000000001, 6.0999999999999996, 30, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1354) },
                    { 23, 3, 1, "Just Black", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1356), "Google's smartphone with excellent camera and Google Assistant integration.", "https://picsum.photos/203", true, 128, "Google Pixel 4", 799.99000000000001, 5.7000000000000002, 25, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1357) },
                    { 24, 4, 1, "Aurora", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1359), "High-end Huawei device with superior zoom camera capabilities.", "https://picsum.photos/204", true, 256, "Huawei P30 Pro", 899.99000000000001, 6.5, 10, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1360) },
                    { 25, 2, 1, "Black", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1362), "New iphone flagship!", "https://picsum.photos/205", true, 128, "Iphone 15 Pro Max", 949.99000000000001, 6.7000000000000002, 12, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1363) },
                    { 26, 1, 1, "Black", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1365), "New camera's, new design.", "https://picsum.photos/206", true, 128, "Samsung Galaxy S24 Ultra", 499.99000000000001, 6.7999999999999998, 50, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1366) },
                    { 27, 5, 1, "Onyx Black", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1368), "Next-gen OnePlus device with fluid display and wireless charging.", "https://picsum.photos/207", true, 256, "OnePlus 8 Pro", 799.99000000000001, 6.5, 18, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1369) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "BasketID", "Created", "Email", "IsActive", "Name", "Password", "Role", "Updated" },
                values: new object[] { 1, 1, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1404), "test@test.be", true, "TestUser", "123", "[\"Admin\"]", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1405) });

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
