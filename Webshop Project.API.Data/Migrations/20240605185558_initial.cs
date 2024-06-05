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
            migrationBuilder.UpdateData(
                table: "Basket",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "ShippingPrice", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8675), 0.0, new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8676) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8456), new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8457) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8460), new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8461) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8463), new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8464) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8465), new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8466) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8468), new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8468) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8361), new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8397), new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8400), new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8402), new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8508), "https://image-us.samsung.com/SamsungUS/home/mobile/phones/pdp/galaxy-s21-fe-5g/gallery/SM-G990U-graphite-1.png", new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8516), "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/refurb-iphone-13-starlight-2023?wid=1144&hei=1144&fmt=jpeg&qlt=90&.v=1679072987025", new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8517) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8519), "https://static.fnac-static.com/multimedia/Images/FR/MDM/2f/0a/05/17107503/1540-1/tsp20240222071736/Smartphone-Google-Pixel-6-6-4-5G-128-Go-Noir-Carbone.jpg", new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8522), "https://consumer.huawei.com/content/dam/huawei-cbg-site/common/mkt/pdp/phones/p50-pro/list/black.png", new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8523) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8525), "https://www.refurbished.be/cache/images/oneplus-9-pro-zwart-frontandback_600x600_BGresize_16777215-tj.png", new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8526) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8528), "https://www.refurbished.be/cache/images/note20_brons_multi_600x600_BGresize_16777215-tj.png", new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8529) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8531), "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/refurb-iphone-12-black-2020?wid=1144&hei=1144&fmt=jpeg&qlt=90&.v=1635202741000", new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8532) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8534), "https://www.refurbished.be/cache/images/google-pixel-5-zwart-multi_600x600_BGresize_16777215-tj.png", new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8535) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8537), "https://www.refurbished.be/cache/images/huawei-mate-40-pro-zwart-frontandback_600x600_BGresize_16777215-tj.png", new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8540), "https://oasis.opstatics.com/content/dam/oasis/default/product-specs/8t-green.png", new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8568), "https://media.asmartworld.be/smartphones-samsung-galaxy-z-fold3-5g_550_550-4552.jpg", new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8572) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8574), "https://www.forza-refurbished.be/media/catalog/product/cache/d29a0fbb193099ba8eda5bb143f05214/r/e/refurbished-iphone-se-2020-rood-thumbnail.jpg", new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8575) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8577), "https://www.refurbished.be/cache/images/google-pixel-4a-zwart-frontandback_600x600_BGresize_16777215-tj.png", new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8580), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTNzKch8GGQHin4EU4WoX1szX7pS0vvXo_UkA&s", new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8583), "https://www.refurbished.be/cache/images/oneplus-nord-5g-grijs-frontandback_600x600_BGresize_16777215-tj.png", new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8586), "https://www.refurbished.be/cache/images/a52_multi_blue_600x600_BGresize_16777215-tj.png", new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8588), "https://www.detelecomshop.net/wp-content/uploads/2020/08/New-Project-1-1.jpg", new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8589) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8592), "https://www.refurbished.be/cache/images/google-pixel-3-xl-zwart-multi_600x600_BGresize_16777215-tj.png", new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8595), "https://mobiele-telefoon-verzekering.be/img/mobile/huawei-mate-30-pro/mate30-pro-space-silver-new.png", new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8598), "https://www.refurbished.be/cache/images/oneplus-7-pro-grijs-frontandback_600x600_BGresize_16777215-tj.png", new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8600), "https://www.electrodepot.be/media/catalog/product/P968553.jpg", new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8603), "https://cdn.centralpoint.be/objects/high_pic/f/f0a/3300900_smartphones-apple-iphone-11-mhda3zd-a.jpg", new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8606), "https://www.refurbished.be/cache/images/google-pixel-4-wit-frontandback_600x600_BGresize_16777215-tj.png", new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8607) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8609), "https://consumer.huawei.com/content/dam/huawei-cbg-site/common/mkt/list-image/phones/p30-pro/P30Pro_skyblue.png", new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8612), "https://assets.swappie.com/cdn-cgi/image/width=600,height=600,fit=contain,format=auto/swappie-iphone-15-pro-max-natural-titanium.png?v=9166c13e", new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8613) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8615), "https://images.samsung.com/is/image/samsung/p6pim/be/2401/gallery/be-galaxy-s24-s928-sm-s928bztgeub-thumb-539420288", new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8618), "https://www.refurbished.be/cache/images/oneplus-8-pro-zwart-duo_600x600_BGresize_16777215-tj.png", new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8618) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8650), new DateTime(2024, 6, 5, 20, 55, 58, 486, DateTimeKind.Local).AddTicks(8652) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Basket",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "ShippingPrice", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1434), 25.0, new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1220), new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1221) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1225), new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1226) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1228), new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1229) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1230), new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1231) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1232), new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1233) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1088), new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1149), new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1152), new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1153) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1154), new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1155) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1263), "https://picsum.photos/181", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1264) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1273), "https://picsum.photos/182", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1274) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1276), "https://picsum.photos/183", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1279), "https://picsum.photos/184", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1282), "https://picsum.photos/185", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1285), "https://picsum.photos/186", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1288), "https://picsum.photos/187", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1289) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1291), "https://picsum.photos/188", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1292) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1314), "https://picsum.photos/189", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1315) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1318), "https://picsum.photos/190", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1321), "https://picsum.photos/191", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1324), "https://picsum.photos/192", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1325) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1327), "https://picsum.photos/193", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1330), "https://picsum.photos/194", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1331) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1333), "https://picsum.photos/195", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1334) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1336), "https://picsum.photos/196", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1337) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1339), "https://picsum.photos/197", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1342), "https://picsum.photos/198", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1343) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1345), "https://picsum.photos/199", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1346) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1348), "https://picsum.photos/200", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1349) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1351), "https://picsum.photos/201", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1351) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1354), "https://picsum.photos/202", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1356), "https://picsum.photos/203", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1359), "https://picsum.photos/204", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1362), "https://picsum.photos/205", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1365), "https://picsum.photos/206", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1366) });

            migrationBuilder.UpdateData(
                table: "Smartphones",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "Created", "Image", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1368), "https://picsum.photos/207", new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1369) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1404), new DateTime(2024, 6, 4, 16, 1, 31, 149, DateTimeKind.Local).AddTicks(1405) });
        }
    }
}
