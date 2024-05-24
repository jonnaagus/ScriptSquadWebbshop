﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScriptSquadWebbshop.Data;

#nullable disable

namespace ScriptSquadWebbshop.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ScriptSquadWebbshop.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Order");

                    b.HasData(
                        new
                        {
                            OrderId = 100,
                            OrderDate = new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "0c047536-998d-4509-9c19-d1e88253f242"
                        },
                        new
                        {
                            OrderId = 101,
                            OrderDate = new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "b01e3f0d-acb0-4eab-90b3-8a519e3456b9"
                        },
                        new
                        {
                            OrderId = 102,
                            OrderDate = new DateTime(2024, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "4028df22-8f69-48cc-ac21-6bacd405582e"
                        },
                        new
                        {
                            OrderId = 103,
                            OrderDate = new DateTime(2024, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "4028df22-8f69-48cc-ac21-6bacd405582e"
                        },
                        new
                        {
                            OrderId = 104,
                            OrderDate = new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "b01e3f0d-acb0-4eab-90b3-8a519e3456b9"
                        },
                        new
                        {
                            OrderId = 105,
                            OrderDate = new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "0c047536-998d-4509-9c19-d1e88253f242"
                        });
                });

            modelBuilder.Entity("ScriptSquadWebbshop.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = 100,
                            Description = "Apple TV 4K (2022) – all underhållning på ett ställe med skarp bild, tillgång till appar, filmer, musik och spel och en ännu mer lättanvänd fjärrkontroll.",
                            ImageUrl = "/images/appletv.jpg",
                            Price = 1995f,
                            ProductName = "Apple TV",
                            Quantity = 5
                        },
                        new
                        {
                            ProductId = 102,
                            Description = "Electrolux Pure 300 luftrenare erbjuder avancerad luftrening för hem upp till 46 m². Med dess smarta design och kraftfulla filtreringssystem andas du renare och friskare luft varje dag.",
                            ImageUrl = "/images/luftrenare.jpg",
                            Price = 1499f,
                            ProductName = "Electrolux luftrenare",
                            Quantity = 1
                        },
                        new
                        {
                            ProductId = 103,
                            Description = "Rena luften tyst och effektivt i små rum som sovrum eller i en liten lägenhet. Svensktillverkade Woods AL310 luftrenare med joniserande filtreringsteknologi tar bort 99,98 procent av alla skadliga partiklar. För rum upp till 55 kvm.",
                            ImageUrl = "/images/luftrenare1.jpg",
                            Price = 4990f,
                            ProductName = "Woods luftrenare",
                            Quantity = 3
                        },
                        new
                        {
                            ProductId = 104,
                            Description = "TP-Link Deco BE65 är en avancerad mesh-router som levererar blixtsnabba hastigheter och stabil uppkoppling i hela hemmet. Med WiFi 7 är du rustad för framtidens internethastigheter.",
                            ImageUrl = "/images/router.jpg",
                            Price = 6490f,
                            ProductName = "TP-Link router",
                            Quantity = 7
                        },
                        new
                        {
                            ProductId = 105,
                            Description = "Asus RT-AX53U är en högpresterande router med stöd för framtidens trådlösa standard (WiFi 6). Upp till 1,8 Gbps hastighet, hög säkerhet med inbyggt virussystem och föräldrakontroll.",
                            ImageUrl = "/images/router1.jpg",
                            Price = 849f,
                            ProductName = "Asus router",
                            Quantity = 5
                        },
                        new
                        {
                            ProductId = 106,
                            Description = "Starlink Business High Performance kit – koppla upp företaget eller användare med höga krav till ett snabbt och pålitligt internet 24/7. Med Starlink Business har du alltid bästa prestanda oavsett belastningen på nätverket. (Abonnemang krävs och säljs separat.)",
                            ImageUrl = "/images/routerkit.jpg",
                            Price = 27999f,
                            ProductName = "Starlink router",
                            Quantity = 2
                        },
                        new
                        {
                            ProductId = 107,
                            Description = "Nexa MYC-4 plug-in-kit med fjärrkontroll och 3 trådlösa plug-in-mottagare. Tänd och släck lampor hemma med fjärrkontroll. Plugga in i vägguttaget och anslut lampans stickpropp.",
                            ImageUrl = "/images/uttag.jpg",
                            Price = 199.9f,
                            ProductName = "Nexa fjärrströmbrytare",
                            Quantity = 5
                        },
                        new
                        {
                            ProductId = 108,
                            Description = "Yale Doorman L3S Flex är det digitala dörrlåset som gör livet enklare. Lås upp med kod, nyckeltag, app eller låt låset låsa upp dörren åt dig med hjälp av geofencing. Lägg in koder till varje familjemedlem eller skapa tillfälliga dygnskoder till besökare.",
                            ImageUrl = "/images/yale.jpg",
                            Price = 5990f,
                            ProductName = "Yale Doorman L3S",
                            Quantity = 7
                        },
                        new
                        {
                            ProductId = 109,
                            Description = "Yale Doorman Classic digitalt lås – lås upp med sifferkod, nyckeltagg eller en kombination av båda. Lägg in koder till varje familjemedlem eller skapa tillfälliga dygnskoder till besökare. Upp till 10 nyckelbrickor och upp till 10 unika användarkoder. Låsklass 2A.",
                            ImageUrl = "/images/yale1.jpg",
                            Price = 3499f,
                            ProductName = "Yale Doorman Classic",
                            Quantity = 12
                        });
                });

            modelBuilder.Entity("ScriptSquadWebbshop.Models.ProductOrder", b =>
                {
                    b.Property<int>("ProductOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductOrderId"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("ProductOrderId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductOrder");

                    b.HasData(
                        new
                        {
                            ProductOrderId = 100,
                            Amount = 1,
                            OrderId = 100,
                            ProductId = 100
                        },
                        new
                        {
                            ProductOrderId = 101,
                            Amount = 2,
                            OrderId = 101,
                            ProductId = 102
                        },
                        new
                        {
                            ProductOrderId = 102,
                            Amount = 2,
                            OrderId = 102,
                            ProductId = 109
                        },
                        new
                        {
                            ProductOrderId = 103,
                            Amount = 1,
                            OrderId = 103,
                            ProductId = 105
                        },
                        new
                        {
                            ProductOrderId = 104,
                            Amount = 5,
                            OrderId = 104,
                            ProductId = 102
                        },
                        new
                        {
                            ProductOrderId = 105,
                            Amount = 2,
                            OrderId = 104,
                            ProductId = 103
                        },
                        new
                        {
                            ProductOrderId = 106,
                            Amount = 3,
                            OrderId = 105,
                            ProductId = 100
                        },
                        new
                        {
                            ProductOrderId = 107,
                            Amount = 1,
                            OrderId = 105,
                            ProductId = 107
                        },
                        new
                        {
                            ProductOrderId = 108,
                            Amount = 1,
                            OrderId = 105,
                            ProductId = 102
                        });
                });

            modelBuilder.Entity("ScriptSquadWebbshop.Models.Purchase", b =>
                {
                    b.Property<int>("PurchaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PurchaseId"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PurchaseId");

                    b.HasIndex("ProductId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("ScriptSquadWebbshop.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "0c047536-998d-4509-9c19-d1e88253f242",
                            AccessFailedCount = 0,
                            Address = "Testargatan 1",
                            City = "Testarstan",
                            ConcurrencyStamp = "d98be3fe-89e5-43a6-b40a-5cb62ced8f26",
                            Email = "test@mail.co",
                            EmailConfirmed = true,
                            FirstName = "Test",
                            LastName = "Testsson",
                            LockoutEnabled = false,
                            NormalizedEmail = "TEST@MAIL.COM",
                            NormalizedUserName = "TEST@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEHz6D5PkuxWvVuTYuRltDmTNT0IuIH/4X1sEN7h1cvukhyg6bNWtC8P+aFgRXDN7uw==",
                            PhoneNumber = "123456",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3da6786a-5bf4-49a3-a5f9-5716e9f872ff",
                            TwoFactorEnabled = false,
                            UserName = "test@mail.com",
                            ZipCode = 11123
                        },
                        new
                        {
                            Id = "b01e3f0d-acb0-4eab-90b3-8a519e3456b9",
                            AccessFailedCount = 0,
                            Address = "Testargatan 1",
                            City = "Testarstan",
                            ConcurrencyStamp = "17db0f69-d0d4-4a22-b08b-4bae04439724",
                            Email = "test1@mail.co",
                            EmailConfirmed = true,
                            FirstName = "Test1",
                            LastName = "Testsson",
                            LockoutEnabled = false,
                            NormalizedEmail = "TEST1@MAIL.COM",
                            NormalizedUserName = "TEST1@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEC+wiHQfSUEIq9i7ICYYunoUwy9hbHhJt3wrQJxhPEwsMu10fByrb59Y40pRGq5FPQ==",
                            PhoneNumber = "123456",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e8e3eea5-f24a-4036-966a-4044e679c12a",
                            TwoFactorEnabled = false,
                            UserName = "test1@mail.com",
                            ZipCode = 11123
                        },
                        new
                        {
                            Id = "4028df22-8f69-48cc-ac21-6bacd405582e",
                            AccessFailedCount = 0,
                            Address = "Testargatan 1",
                            City = "Testarstan",
                            ConcurrencyStamp = "09520ed2-2dd3-463f-9a7b-dd512c4826d2",
                            Email = "tes2t@mail.co",
                            EmailConfirmed = true,
                            FirstName = "Test2",
                            LastName = "Testsson",
                            LockoutEnabled = false,
                            NormalizedEmail = "TEST2@MAIL.COM",
                            NormalizedUserName = "TEST2@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEFrxo60da4ngjGx0+Yr5GHXG4yXImmp9o23WdFgj1qSfBk0QOAcGTv7gVt9Qt3MrfQ==",
                            PhoneNumber = "123456",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4cb53a88-ab05-4088-b300-80ef4b848b19",
                            TwoFactorEnabled = false,
                            UserName = "test2@mail.com",
                            ZipCode = 11123
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ScriptSquadWebbshop.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ScriptSquadWebbshop.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ScriptSquadWebbshop.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ScriptSquadWebbshop.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ScriptSquadWebbshop.Models.Order", b =>
                {
                    b.HasOne("ScriptSquadWebbshop.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ScriptSquadWebbshop.Models.ProductOrder", b =>
                {
                    b.HasOne("ScriptSquadWebbshop.Models.Order", "Order")
                        .WithMany("ProductOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ScriptSquadWebbshop.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ScriptSquadWebbshop.Models.Purchase", b =>
                {
                    b.HasOne("ScriptSquadWebbshop.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ScriptSquadWebbshop.Models.Order", b =>
                {
                    b.Navigation("ProductOrders");
                });
#pragma warning restore 612, 618
        }
    }
}
