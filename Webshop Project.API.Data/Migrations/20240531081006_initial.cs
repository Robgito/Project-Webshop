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
                values: new object[] { 1, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(9205), true, 25.0, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(9209) });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Created", "IsActive", "Name", "Updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8491), true, "Samsung", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8497) },
                    { 2, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8504), true, "Apple", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8507) },
                    { 3, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8512), true, "Google", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8515) },
                    { 4, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8520), true, "Huawei", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8523) },
                    { 5, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8527), true, "OnePlus", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8530) }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Created", "IsActive", "Name", "Updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8117), true, "Smartphones", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8188) },
                    { 2, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8209), true, "Accessories", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8212) },
                    { 3, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8217), true, "Tablets", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8220) },
                    { 4, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8225), true, "Wearables", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8228) }
                });

            migrationBuilder.InsertData(
                table: "Smartphones",
                columns: new[] { "ID", "BrandID", "CategoryID", "Colour", "Created", "Description", "Image", "IsActive", "MemoryCapacity", "Name", "Price", "ScreenSize", "Stock", "Updated" },
                values: new object[,]
                {
                    { 1, 1, 1, "Phantom Gray", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8616), "Latest Samsung smartphone with high-end specs.", "https://picsum.photos/181", true, 128, "Samsung Galaxy S21", 799.99000000000001, null, 25, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8621) },
                    { 2, 2, 1, "Midnight", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8636), "New iPhone with advanced features.", "https://picsum.photos/182", true, 256, "Apple iPhone 13", 999.99000000000001, null, 30, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8639) },
                    { 3, 3, 1, "Stormy Black", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8646), "Google's latest smartphone with clean Android experience.", "https://picsum.photos/183", true, 128, "Google Pixel 6", 699.99000000000001, null, 20, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8650) },
                    { 4, 4, 1, "Golden Black", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8656), "High-end smartphone from Huawei.", "https://picsum.photos/184", true, 256, "Huawei P50", 899.99000000000001, null, 15, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8659) },
                    { 5, 5, 1, "Winter Mist", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8666), "Flagship killer from OnePlus.", "https://picsum.photos/185", true, 128, "OnePlus 9", 729.99000000000001, null, 18, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8669) },
                    { 6, 1, 1, "Mystic Bronze", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8678), "Samsung's premium phone with S-Pen.", "https://picsum.photos/186", true, 256, "Samsung Galaxy Note 20", 949.99000000000001, null, 10, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8681) },
                    { 7, 2, 1, "Blue", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8687), "Previous generation iPhone with great performance.", "https://picsum.photos/187", true, 128, "Apple iPhone 12", 799.99000000000001, null, 22, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8690) },
                    { 8, 3, 1, "Just Black", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8697), "Compact and powerful Google phone.", "https://picsum.photos/188", true, 128, "Google Pixel 5", 599.99000000000001, null, 25, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8700) },
                    { 9, 4, 1, "Space Silver", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8706), "Top-tier Huawei device with excellent camera.", "https://picsum.photos/189", true, 256, "Huawei Mate 40", 1099.99, null, 12, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8710) },
                    { 10, 5, 1, "Aquamarine Green", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8718), "Fast and fluid experience from OnePlus.", "https://picsum.photos/190", true, 128, "OnePlus 8T", 649.99000000000001, null, 17, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8721) },
                    { 11, 1, 1, "Phantom Black", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8728), "Folding phone with a large display.", "https://picsum.photos/191", true, 256, "Samsung Galaxy Z Fold 3", 1799.99, null, 5, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8731) },
                    { 12, 2, 1, "Red", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8738), "Compact iPhone with powerful internals.", "https://picsum.photos/192", true, 64, "Apple iPhone SE", 399.99000000000001, null, 40, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8741) },
                    { 13, 3, 1, "Barely Blue", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8749), "Affordable Google phone with great camera.", "https://picsum.photos/193", true, 128, "Google Pixel 4a", 349.99000000000001, null, 33, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8752) },
                    { 14, 4, 1, "Midnight Black", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8758), "Budget-friendly Huawei device.", "https://picsum.photos/194", true, 128, "Huawei Y9s", 249.99000000000001, null, 19, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8761) },
                    { 15, 5, 1, "Gray Onyx", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8768), "Mid-range OnePlus phone with great value.", "https://picsum.photos/195", true, 128, "OnePlus Nord", 399.99000000000001, null, 24, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8771) },
                    { 16, 1, 1, "Awesome Blue", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8777), "Solid mid-range Samsung device.", "https://picsum.photos/196", true, 128, "Samsung Galaxy A52", 349.99000000000001, null, 35, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8780) },
                    { 17, 2, 1, "Green", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8786), "Previous generation iPhone with great performance.", "https://picsum.photos/197", true, 64, "Apple iPhone 11", 599.99000000000001, null, 28, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8789) },
                    { 18, 3, 1, "Not Pink", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8798), "Older Google phone with great features.", "https://picsum.photos/198", true, 64, "Google Pixel 3 XL", 499.99000000000001, null, 14, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8801) },
                    { 19, 4, 1, "Crush Green", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8808), "Stylish and affordable Huawei device.", "https://picsum.photos/199", true, 128, "Huawei Nova 7i", 299.99000000000001, null, 21, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8811) },
                    { 20, 5, 1, "Nebula Blue", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8817), "Premium OnePlus device with pop-up camera.", "https://picsum.photos/200", true, 256, "OnePlus 7 Pro", 599.99000000000001, null, 20, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8820) },
                    { 21, 1, 1, "Cosmic Gray", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8827), "Flagship Samsung smartphone with advanced camera features.", "https://picsum.photos/201", true, 128, "Samsung Galaxy S20", 999.99000000000001, null, 15, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8830) },
                    { 22, 2, 1, "Black", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8837), "Latest Apple iPhone with dual camera system.", "https://picsum.photos/202", true, 64, "Apple iPhone 11", 699.99000000000001, null, 30, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8840) },
                    { 23, 3, 1, "Just Black", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8846), "Google's smartphone with excellent camera and Google Assistant integration.", "https://picsum.photos/203", true, 128, "Google Pixel 4", 799.99000000000001, null, 25, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8850) },
                    { 24, 4, 1, "Aurora", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8857), "High-end Huawei device with superior zoom camera capabilities.", "https://picsum.photos/204", true, 256, "Huawei P30 Pro", 899.99000000000001, null, 10, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8860) },
                    { 25, 2, 1, "Black", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8866), "New iphone flagship!", "https://picsum.photos/205", true, 128, "Iphone 15 Pro Max", 949.99000000000001, null, 12, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8870) },
                    { 26, 1, 1, "Black", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8876), "New camera's, new design.", "https://picsum.photos/206", true, 128, "Samsung Galaxy S24 Ultra", 499.99000000000001, null, 50, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8879) },
                    { 27, 5, 1, "Onyx Black", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8888), "Next-gen OnePlus device with fluid display and wireless charging.", "https://picsum.photos/207", true, 256, "OnePlus 8 Pro", 799.99000000000001, null, 18, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(8891) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "BasketID", "Created", "Email", "IsActive", "Name", "Password", "Role", "Updated" },
                values: new object[] { 1, 1, new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(9123), "test@test.be", true, "TestUser", "123", "[\"Admin\"]", new DateTime(2024, 5, 31, 10, 10, 2, 694, DateTimeKind.Local).AddTicks(9130) });

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
