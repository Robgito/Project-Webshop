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
                    Colour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    MemoryCapacity = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ScreenSize = table.Column<double>(type: "float", nullable: true),
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
                    BasketEntityID = table.Column<int>(type: "int", nullable: true),
                    SmartphoneEntityID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketProducts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BasketProducts_Basket_BasketEntityID",
                        column: x => x.BasketEntityID,
                        principalTable: "Basket",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_BasketProducts_Smartphones_SmartphoneEntityID",
                        column: x => x.SmartphoneEntityID,
                        principalTable: "Smartphones",
                        principalColumn: "ID");
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
                values: new object[] { 1, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5619), true, 25.0, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5624) });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Created", "IsActive", "Name", "Updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5128), true, "Samsung", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5133) },
                    { 2, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5141), true, "Apple", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5144) },
                    { 3, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5148), true, "Google", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5151) },
                    { 4, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5156), true, "Huawei", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5159) },
                    { 5, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5163), true, "OnePlus", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5166) }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Created", "IsActive", "Name", "Updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(4741), true, "Smartphones", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(4813) },
                    { 2, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(4832), true, "Accessories", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(4835) },
                    { 3, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(4840), true, "Tablets", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(4843) },
                    { 4, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(4848), true, "Wearables", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(4851) }
                });

            migrationBuilder.InsertData(
                table: "Smartphones",
                columns: new[] { "ID", "BrandID", "CategoryID", "Colour", "Created", "Description", "Image", "IsActive", "MemoryCapacity", "Name", "Price", "ScreenSize", "Stock", "Updated" },
                values: new object[,]
                {
                    { 1, 1, 1, "Phantom Gray", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5253), "Latest Samsung smartphone with high-end specs.", "LoremPicsum", true, 128, "Samsung Galaxy S21", 799.99000000000001, null, 25, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5258) },
                    { 2, 2, 1, "Midnight", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5275), "New iPhone with advanced features.", "LoremPicsum", true, 256, "Apple iPhone 13", 999.99000000000001, null, 30, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5279) },
                    { 3, 3, 1, "Stormy Black", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5287), "Google's latest smartphone with clean Android experience.", "LoremPicsum", true, 128, "Google Pixel 6", 699.99000000000001, null, 20, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5290) },
                    { 4, 4, 1, "Golden Black", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5297), "High-end smartphone from Huawei.", "LoremPicsum", true, 256, "Huawei P50", 899.99000000000001, null, 15, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5301) },
                    { 5, 5, 1, "Winter Mist", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5307), "Flagship killer from OnePlus.", "LoremPicsum", true, 128, "OnePlus 9", 729.99000000000001, null, 18, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5311) },
                    { 6, 1, 1, "Mystic Bronze", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5319), "Samsung's premium phone with S-Pen.", "LoremPicsum", true, 256, "Samsung Galaxy Note 20", 949.99000000000001, null, 10, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5322) },
                    { 7, 2, 1, "Blue", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5329), "Previous generation iPhone with great performance.", "LoremPicsum", true, 128, "Apple iPhone 12", 799.99000000000001, null, 22, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5333) },
                    { 8, 3, 1, "Just Black", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5339), "Compact and powerful Google phone.", "LoremPicsum", true, 128, "Google Pixel 5", 599.99000000000001, null, 25, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5343) },
                    { 9, 4, 1, "Space Silver", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5349), "Top-tier Huawei device with excellent camera.", "LoremPicsum", true, 256, "Huawei Mate 40", 1099.99, null, 12, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5353) },
                    { 10, 5, 1, "Aquamarine Green", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5361), "Fast and fluid experience from OnePlus.", "LoremPicsum", true, 128, "OnePlus 8T", 649.99000000000001, null, 17, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5365) },
                    { 11, 1, 1, "Phantom Black", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5371), "Folding phone with a large display.", "LoremPicsum", true, 256, "Samsung Galaxy Z Fold 3", 1799.99, null, 5, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5375) },
                    { 12, 2, 1, "Red", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5381), "Compact iPhone with powerful internals.", "LoremPicsum", true, 64, "Apple iPhone SE", 399.99000000000001, null, 40, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5385) },
                    { 13, 3, 1, "Barely Blue", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5391), "Affordable Google phone with great camera.", "LoremPicsum", true, 128, "Google Pixel 4a", 349.99000000000001, null, 33, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5395) },
                    { 14, 4, 1, "Midnight Black", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5401), "Budget-friendly Huawei device.", "LoremPicsum", true, 128, "Huawei Y9s", 249.99000000000001, null, 19, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5405) },
                    { 15, 5, 1, "Gray Onyx", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5411), "Mid-range OnePlus phone with great value.", "LoremPicsum", true, 128, "OnePlus Nord", 399.99000000000001, null, 24, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5415) },
                    { 16, 1, 1, "Awesome Blue", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5421), "Solid mid-range Samsung device.", "LoremPicsum", true, 128, "Samsung Galaxy A52", 349.99000000000001, null, 35, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5425) },
                    { 17, 2, 1, "Green", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5431), "Previous generation iPhone with great performance.", "LoremPicsum", true, 64, "Apple iPhone 11", 599.99000000000001, null, 28, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5434) },
                    { 18, 3, 1, "Not Pink", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5442), "Older Google phone with great features.", "LoremPicsum", true, 64, "Google Pixel 3 XL", 499.99000000000001, null, 14, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5446) },
                    { 19, 4, 1, "Crush Green", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5452), "Stylish and affordable Huawei device.", "LoremPicsum", true, 128, "Huawei Nova 7i", 299.99000000000001, null, 21, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5456) },
                    { 20, 5, 1, "Nebula Blue", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5462), "Premium OnePlus device with pop-up camera.", "LoremPicsum", true, 256, "OnePlus 7 Pro", 599.99000000000001, null, 20, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5465) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "BasketID", "Created", "Email", "IsActive", "Name", "Password", "Role", "Updated" },
                values: new object[] { 1, 1, new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5553), "test@test.be", true, "TestUser", "123", "[\"Admin\"]", new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5558) });

            migrationBuilder.CreateIndex(
                name: "IX_BasketProducts_BasketEntityID",
                table: "BasketProducts",
                column: "BasketEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_BasketProducts_SmartphoneEntityID",
                table: "BasketProducts",
                column: "SmartphoneEntityID");

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
