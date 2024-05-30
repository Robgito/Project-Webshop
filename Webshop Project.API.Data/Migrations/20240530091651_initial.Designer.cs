﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Webshop_Project.API.Data;

#nullable disable

namespace Webshop_Project.API.Data.Migrations
{
    [DbContext(typeof(WebshopDBContext))]
    [Migration("20240530091651_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Webshop_Project.API.Data.Entities.BasketEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<double>("ShippingPrice")
                        .HasColumnType("float");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Basket");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5619),
                            IsActive = true,
                            ShippingPrice = 25.0,
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5624)
                        });
                });

            modelBuilder.Entity("Webshop_Project.API.Data.Entities.BasketProductEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("BasketEntityID")
                        .HasColumnType("int");

                    b.Property<int>("BasketID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int?>("SmartphoneEntityID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("BasketEntityID");

                    b.HasIndex("SmartphoneEntityID");

                    b.ToTable("BasketProducts");
                });

            modelBuilder.Entity("Webshop_Project.API.Data.Entities.BrandEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5128),
                            IsActive = true,
                            Name = "Samsung",
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5133)
                        },
                        new
                        {
                            ID = 2,
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5141),
                            IsActive = true,
                            Name = "Apple",
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5144)
                        },
                        new
                        {
                            ID = 3,
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5148),
                            IsActive = true,
                            Name = "Google",
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5151)
                        },
                        new
                        {
                            ID = 4,
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5156),
                            IsActive = true,
                            Name = "Huawei",
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5159)
                        },
                        new
                        {
                            ID = 5,
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5163),
                            IsActive = true,
                            Name = "OnePlus",
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5166)
                        });
                });

            modelBuilder.Entity("Webshop_Project.API.Data.Entities.CategoryEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(4741),
                            IsActive = true,
                            Name = "Smartphones",
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(4813)
                        },
                        new
                        {
                            ID = 2,
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(4832),
                            IsActive = true,
                            Name = "Accessories",
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(4835)
                        },
                        new
                        {
                            ID = 3,
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(4840),
                            IsActive = true,
                            Name = "Tablets",
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(4843)
                        },
                        new
                        {
                            ID = 4,
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(4848),
                            IsActive = true,
                            Name = "Wearables",
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(4851)
                        });
                });

            modelBuilder.Entity("Webshop_Project.API.Data.Entities.OrderEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StreetNumber")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Webshop_Project.API.Data.Entities.OrderProductEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("OrderEntityID")
                        .HasColumnType("int");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int?>("SmartphoneEntityID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("OrderEntityID");

                    b.HasIndex("SmartphoneEntityID");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("Webshop_Project.API.Data.Entities.SmartphoneEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("BrandID")
                        .HasColumnType("int");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Colour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("MemoryCapacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double?>("ScreenSize")
                        .HasColumnType("float");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("BrandID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Smartphones");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            BrandID = 1,
                            CategoryID = 1,
                            Colour = "Phantom Gray",
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5253),
                            Description = "Latest Samsung smartphone with high-end specs.",
                            Image = "LoremPicsum",
                            IsActive = true,
                            MemoryCapacity = 128,
                            Name = "Samsung Galaxy S21",
                            Price = 799.99000000000001,
                            Stock = 25,
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5258)
                        },
                        new
                        {
                            ID = 2,
                            BrandID = 2,
                            CategoryID = 1,
                            Colour = "Midnight",
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5275),
                            Description = "New iPhone with advanced features.",
                            Image = "LoremPicsum",
                            IsActive = true,
                            MemoryCapacity = 256,
                            Name = "Apple iPhone 13",
                            Price = 999.99000000000001,
                            Stock = 30,
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5279)
                        },
                        new
                        {
                            ID = 3,
                            BrandID = 3,
                            CategoryID = 1,
                            Colour = "Stormy Black",
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5287),
                            Description = "Google's latest smartphone with clean Android experience.",
                            Image = "LoremPicsum",
                            IsActive = true,
                            MemoryCapacity = 128,
                            Name = "Google Pixel 6",
                            Price = 699.99000000000001,
                            Stock = 20,
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5290)
                        },
                        new
                        {
                            ID = 4,
                            BrandID = 4,
                            CategoryID = 1,
                            Colour = "Golden Black",
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5297),
                            Description = "High-end smartphone from Huawei.",
                            Image = "LoremPicsum",
                            IsActive = true,
                            MemoryCapacity = 256,
                            Name = "Huawei P50",
                            Price = 899.99000000000001,
                            Stock = 15,
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5301)
                        },
                        new
                        {
                            ID = 5,
                            BrandID = 5,
                            CategoryID = 1,
                            Colour = "Winter Mist",
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5307),
                            Description = "Flagship killer from OnePlus.",
                            Image = "LoremPicsum",
                            IsActive = true,
                            MemoryCapacity = 128,
                            Name = "OnePlus 9",
                            Price = 729.99000000000001,
                            Stock = 18,
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5311)
                        },
                        new
                        {
                            ID = 6,
                            BrandID = 1,
                            CategoryID = 1,
                            Colour = "Mystic Bronze",
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5319),
                            Description = "Samsung's premium phone with S-Pen.",
                            Image = "LoremPicsum",
                            IsActive = true,
                            MemoryCapacity = 256,
                            Name = "Samsung Galaxy Note 20",
                            Price = 949.99000000000001,
                            Stock = 10,
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5322)
                        },
                        new
                        {
                            ID = 7,
                            BrandID = 2,
                            CategoryID = 1,
                            Colour = "Blue",
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5329),
                            Description = "Previous generation iPhone with great performance.",
                            Image = "LoremPicsum",
                            IsActive = true,
                            MemoryCapacity = 128,
                            Name = "Apple iPhone 12",
                            Price = 799.99000000000001,
                            Stock = 22,
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5333)
                        },
                        new
                        {
                            ID = 8,
                            BrandID = 3,
                            CategoryID = 1,
                            Colour = "Just Black",
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5339),
                            Description = "Compact and powerful Google phone.",
                            Image = "LoremPicsum",
                            IsActive = true,
                            MemoryCapacity = 128,
                            Name = "Google Pixel 5",
                            Price = 599.99000000000001,
                            Stock = 25,
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5343)
                        },
                        new
                        {
                            ID = 9,
                            BrandID = 4,
                            CategoryID = 1,
                            Colour = "Space Silver",
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5349),
                            Description = "Top-tier Huawei device with excellent camera.",
                            Image = "LoremPicsum",
                            IsActive = true,
                            MemoryCapacity = 256,
                            Name = "Huawei Mate 40",
                            Price = 1099.99,
                            Stock = 12,
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5353)
                        },
                        new
                        {
                            ID = 10,
                            BrandID = 5,
                            CategoryID = 1,
                            Colour = "Aquamarine Green",
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5361),
                            Description = "Fast and fluid experience from OnePlus.",
                            Image = "LoremPicsum",
                            IsActive = true,
                            MemoryCapacity = 128,
                            Name = "OnePlus 8T",
                            Price = 649.99000000000001,
                            Stock = 17,
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5365)
                        },
                        new
                        {
                            ID = 11,
                            BrandID = 1,
                            CategoryID = 1,
                            Colour = "Phantom Black",
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5371),
                            Description = "Folding phone with a large display.",
                            Image = "LoremPicsum",
                            IsActive = true,
                            MemoryCapacity = 256,
                            Name = "Samsung Galaxy Z Fold 3",
                            Price = 1799.99,
                            Stock = 5,
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5375)
                        },
                        new
                        {
                            ID = 12,
                            BrandID = 2,
                            CategoryID = 1,
                            Colour = "Red",
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5381),
                            Description = "Compact iPhone with powerful internals.",
                            Image = "LoremPicsum",
                            IsActive = true,
                            MemoryCapacity = 64,
                            Name = "Apple iPhone SE",
                            Price = 399.99000000000001,
                            Stock = 40,
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5385)
                        },
                        new
                        {
                            ID = 13,
                            BrandID = 3,
                            CategoryID = 1,
                            Colour = "Barely Blue",
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5391),
                            Description = "Affordable Google phone with great camera.",
                            Image = "LoremPicsum",
                            IsActive = true,
                            MemoryCapacity = 128,
                            Name = "Google Pixel 4a",
                            Price = 349.99000000000001,
                            Stock = 33,
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5395)
                        },
                        new
                        {
                            ID = 14,
                            BrandID = 4,
                            CategoryID = 1,
                            Colour = "Midnight Black",
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5401),
                            Description = "Budget-friendly Huawei device.",
                            Image = "LoremPicsum",
                            IsActive = true,
                            MemoryCapacity = 128,
                            Name = "Huawei Y9s",
                            Price = 249.99000000000001,
                            Stock = 19,
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5405)
                        },
                        new
                        {
                            ID = 15,
                            BrandID = 5,
                            CategoryID = 1,
                            Colour = "Gray Onyx",
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5411),
                            Description = "Mid-range OnePlus phone with great value.",
                            Image = "LoremPicsum",
                            IsActive = true,
                            MemoryCapacity = 128,
                            Name = "OnePlus Nord",
                            Price = 399.99000000000001,
                            Stock = 24,
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5415)
                        },
                        new
                        {
                            ID = 16,
                            BrandID = 1,
                            CategoryID = 1,
                            Colour = "Awesome Blue",
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5421),
                            Description = "Solid mid-range Samsung device.",
                            Image = "LoremPicsum",
                            IsActive = true,
                            MemoryCapacity = 128,
                            Name = "Samsung Galaxy A52",
                            Price = 349.99000000000001,
                            Stock = 35,
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5425)
                        },
                        new
                        {
                            ID = 17,
                            BrandID = 2,
                            CategoryID = 1,
                            Colour = "Green",
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5431),
                            Description = "Previous generation iPhone with great performance.",
                            Image = "LoremPicsum",
                            IsActive = true,
                            MemoryCapacity = 64,
                            Name = "Apple iPhone 11",
                            Price = 599.99000000000001,
                            Stock = 28,
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5434)
                        },
                        new
                        {
                            ID = 18,
                            BrandID = 3,
                            CategoryID = 1,
                            Colour = "Not Pink",
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5442),
                            Description = "Older Google phone with great features.",
                            Image = "LoremPicsum",
                            IsActive = true,
                            MemoryCapacity = 64,
                            Name = "Google Pixel 3 XL",
                            Price = 499.99000000000001,
                            Stock = 14,
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5446)
                        },
                        new
                        {
                            ID = 19,
                            BrandID = 4,
                            CategoryID = 1,
                            Colour = "Crush Green",
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5452),
                            Description = "Stylish and affordable Huawei device.",
                            Image = "LoremPicsum",
                            IsActive = true,
                            MemoryCapacity = 128,
                            Name = "Huawei Nova 7i",
                            Price = 299.99000000000001,
                            Stock = 21,
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5456)
                        },
                        new
                        {
                            ID = 20,
                            BrandID = 5,
                            CategoryID = 1,
                            Colour = "Nebula Blue",
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5462),
                            Description = "Premium OnePlus device with pop-up camera.",
                            Image = "LoremPicsum",
                            IsActive = true,
                            MemoryCapacity = 256,
                            Name = "OnePlus 7 Pro",
                            Price = 599.99000000000001,
                            Stock = 20,
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5465)
                        });
                });

            modelBuilder.Entity("Webshop_Project.API.Data.Entities.UserEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("BasketID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("BasketID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            BasketID = 1,
                            Created = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5553),
                            Email = "test@test.be",
                            IsActive = true,
                            Name = "TestUser",
                            Password = "123",
                            Role = "[\"Admin\"]",
                            Updated = new DateTime(2024, 5, 30, 11, 16, 49, 564, DateTimeKind.Local).AddTicks(5558)
                        });
                });

            modelBuilder.Entity("Webshop_Project.API.Data.Entities.BasketProductEntity", b =>
                {
                    b.HasOne("Webshop_Project.API.Data.Entities.BasketEntity", null)
                        .WithMany("ListProducts")
                        .HasForeignKey("BasketEntityID");

                    b.HasOne("Webshop_Project.API.Data.Entities.SmartphoneEntity", null)
                        .WithMany("ProductsInBaskets")
                        .HasForeignKey("SmartphoneEntityID");
                });

            modelBuilder.Entity("Webshop_Project.API.Data.Entities.OrderProductEntity", b =>
                {
                    b.HasOne("Webshop_Project.API.Data.Entities.OrderEntity", null)
                        .WithMany("ListProducts")
                        .HasForeignKey("OrderEntityID");

                    b.HasOne("Webshop_Project.API.Data.Entities.SmartphoneEntity", null)
                        .WithMany("ProductsInOrders")
                        .HasForeignKey("SmartphoneEntityID");
                });

            modelBuilder.Entity("Webshop_Project.API.Data.Entities.SmartphoneEntity", b =>
                {
                    b.HasOne("Webshop_Project.API.Data.Entities.BrandEntity", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Webshop_Project.API.Data.Entities.CategoryEntity", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Webshop_Project.API.Data.Entities.UserEntity", b =>
                {
                    b.HasOne("Webshop_Project.API.Data.Entities.BasketEntity", "Basket")
                        .WithMany()
                        .HasForeignKey("BasketID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Basket");
                });

            modelBuilder.Entity("Webshop_Project.API.Data.Entities.BasketEntity", b =>
                {
                    b.Navigation("ListProducts");
                });

            modelBuilder.Entity("Webshop_Project.API.Data.Entities.OrderEntity", b =>
                {
                    b.Navigation("ListProducts");
                });

            modelBuilder.Entity("Webshop_Project.API.Data.Entities.SmartphoneEntity", b =>
                {
                    b.Navigation("ProductsInBaskets");

                    b.Navigation("ProductsInOrders");
                });
#pragma warning restore 612, 618
        }
    }
}
