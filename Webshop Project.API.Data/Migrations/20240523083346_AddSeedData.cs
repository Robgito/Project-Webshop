using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webshop_Project.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "ScreenSize",
                table: "Smartphones",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "MemoryCapacity",
                table: "Smartphones",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Smartphones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Smartphones",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Colour",
                table: "Smartphones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Basket",
                columns: new[] { "ID", "Created", "IsActive", "ShippingPrice", "Updated" },
                values: new object[] { 1, new DateTime(2024, 5, 23, 10, 33, 44, 76, DateTimeKind.Local).AddTicks(1054), true, 25.0, new DateTime(2024, 5, 23, 10, 33, 44, 76, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Created", "IsActive", "Name", "Updated" },
                values: new object[] { 1, new DateTime(2024, 5, 23, 10, 33, 44, 76, DateTimeKind.Local).AddTicks(880), true, "Samsung", new DateTime(2024, 5, 23, 10, 33, 44, 76, DateTimeKind.Local).AddTicks(886) });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Created", "IsActive", "Name", "Updated" },
                values: new object[] { 1, new DateTime(2024, 5, 23, 10, 33, 44, 76, DateTimeKind.Local).AddTicks(538), true, "Test", new DateTime(2024, 5, 23, 10, 33, 44, 76, DateTimeKind.Local).AddTicks(610) });

            migrationBuilder.InsertData(
                table: "Smartphones",
                columns: new[] { "ID", "BrandID", "CategoryID", "Colour", "Created", "Description", "Image", "IsActive", "MemoryCapacity", "Name", "Price", "ScreenSize", "Stock", "Updated" },
                values: new object[] { 1, 1, 1, "Red", new DateTime(2024, 5, 23, 10, 33, 44, 76, DateTimeKind.Local).AddTicks(954), "Lorem Ipsum", "LoremPicsum", true, 125, "Samsung", 1099.99, null, 5, new DateTime(2024, 5, 23, 10, 33, 44, 76, DateTimeKind.Local).AddTicks(959) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Basket",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.AlterColumn<double>(
                name: "ScreenSize",
                table: "Smartphones",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MemoryCapacity",
                table: "Smartphones",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Smartphones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Smartphones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Colour",
                table: "Smartphones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
