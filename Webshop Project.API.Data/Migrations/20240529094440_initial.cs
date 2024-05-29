using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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
                values: new object[] { 1, new DateTime(2024, 5, 29, 11, 44, 37, 594, DateTimeKind.Local).AddTicks(5004), true, 25.0, new DateTime(2024, 5, 29, 11, 44, 37, 594, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Created", "IsActive", "Name", "Updated" },
                values: new object[] { 1, new DateTime(2024, 5, 29, 11, 44, 37, 594, DateTimeKind.Local).AddTicks(4722), true, "Samsung", new DateTime(2024, 5, 29, 11, 44, 37, 594, DateTimeKind.Local).AddTicks(4727) });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Created", "IsActive", "Name", "Updated" },
                values: new object[] { 1, new DateTime(2024, 5, 29, 11, 44, 37, 594, DateTimeKind.Local).AddTicks(4410), true, "Test", new DateTime(2024, 5, 29, 11, 44, 37, 594, DateTimeKind.Local).AddTicks(4484) });

            migrationBuilder.InsertData(
                table: "Smartphones",
                columns: new[] { "ID", "BrandID", "CategoryID", "Colour", "Created", "Description", "Image", "IsActive", "MemoryCapacity", "Name", "Price", "ScreenSize", "Stock", "Updated" },
                values: new object[] { 1, 1, 1, "Red", new DateTime(2024, 5, 29, 11, 44, 37, 594, DateTimeKind.Local).AddTicks(4864), "Lorem Ipsum", "LoremPicsum", true, 125, "Samsung", 1099.99, null, 5, new DateTime(2024, 5, 29, 11, 44, 37, 594, DateTimeKind.Local).AddTicks(4870) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "BasketID", "Created", "Email", "IsActive", "Name", "Password", "Role", "Updated" },
                values: new object[] { 1, 1, new DateTime(2024, 5, 29, 11, 44, 37, 594, DateTimeKind.Local).AddTicks(4941), "test@test.be", true, "TestUser", "123", "[\"Admin\"]", new DateTime(2024, 5, 29, 11, 44, 37, 594, DateTimeKind.Local).AddTicks(4945) });

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
