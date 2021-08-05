﻿// <auto-generated />
using System;
using ArtWebshop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArtWebshop.Data.Migrations.Products
{
    [DbContext(typeof(ProductDbContext))]
    partial class ProductDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArtWebshop.Models.Artist", b =>
                {
                    b.Property<string>("ArtistId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ArtistName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtistId");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("ArtWebshop.Models.ArtistRow", b =>
                {
                    b.Property<string>("RowId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ArtistId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RowId");

                    b.HasIndex("ArtistId");

                    b.HasIndex("ProductId");

                    b.ToTable("ArtistRows");
                });

            modelBuilder.Entity("ArtWebshop.Models.Order", b =>
                {
                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BillingCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillingCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillingPostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillingStreetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CouponId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeliveryCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeliveryCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeliveryPostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeliveryStreetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ArtWebshop.Models.OrderRow", b =>
                {
                    b.Property<string>("RowId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RowId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderRows");
                });

            modelBuilder.Entity("ArtWebshop.Models.Product", b =>
                {
                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ArtistId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<bool>("IsPaintingOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<string>("Style")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbnailLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("ArtistId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = "457e1a8d-6951-4cd2-998b-89e0eb6f890c",
                            Category = "Print",
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1503),
                            Height = 53,
                            IsPaintingOfTheWeek = false,
                            LongDescription = "Mona Lisa, also called Portrait of Lisa Gherardini, wife of Francesco del Giocondo, Italian La Gioconda, or French La Joconde, oil painting on a poplar wood panel by Leonardo da Vinci, probably the world’s most famous painting. It was painted sometime between 1503 and 1519, when Leonardo was living in Florence, and it now hangs in the Louvre Museum, Paris, where it remained an object of pilgrimage in the 21st century. The sitter’s mysterious smile and her unproven identity have made the painting a source of ongoing investigation and fascination.",
                            PictureLink = "Images/Paintings/Prints/Mona Lisa.jpg",
                            Price = 50.50m,
                            ShortDescription = "A mysterious woman",
                            Stock = 0,
                            Style = "Oil on wood Panel",
                            ThumbnailLink = "Images/Thumbnails/Prints/Mona Lisa (thumb).jpg",
                            Title = "Mona Lisa",
                            Width = 77
                        },
                        new
                        {
                            ProductId = "c9687285-b76b-4a58-9bb7-e7fd320b39fc",
                            Category = "Print",
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1495),
                            Height = 460,
                            IsPaintingOfTheWeek = false,
                            LongDescription = "Leonardo Da Vinci",
                            PictureLink = "Images/Paintings/Prints/Nattvarden.jpg",
                            Price = 33.00m,
                            ShortDescription = "The last supper",
                            Stock = 0,
                            Style = "Olja på duk",
                            ThumbnailLink = "Images/Thumbnails/Prints/Nattvarden (thumb).jpg",
                            Title = "Nattvarden",
                            Width = 880
                        },
                        new
                        {
                            ProductId = "bc02b72b-02d2-48fb-b6e9-dc9595909580",
                            Category = "Print",
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1903),
                            Height = 460,
                            IsPaintingOfTheWeek = false,
                            LongDescription = "",
                            PictureLink = "Images/Paintings/Prints/Skriet.jpg",
                            Price = 15.505m,
                            ShortDescription = "Edvard Munch",
                            Stock = 0,
                            Style = "Olja, tempera och pastell på papp",
                            ThumbnailLink = "Images/Thumbnails/Prints/Skriet (thumb).jpg",
                            Title = "Nattvarden",
                            Width = 880
                        },
                        new
                        {
                            ProductId = "023b2179-3204-4e61-a2f0-a14c197df8f4",
                            Category = "Print",
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1882),
                            Height = 460,
                            IsPaintingOfTheWeek = false,
                            LongDescription = "",
                            PictureLink = "Images/Paintings/Prints/Utsliten.jpg",
                            Price = 18.505m,
                            ShortDescription = "Edvard Munch",
                            Stock = 0,
                            Style = "Postexpressionism: Teckning penna på vattenfärgat papper",
                            ThumbnailLink = "Images/Thumbnails/Prints/Utsliten (thumb).jpg",
                            Title = "Utsliten",
                            Width = 880
                        });
                });

            modelBuilder.Entity("ArtWebshop.Models.ArtistRow", b =>
                {
                    b.HasOne("ArtWebshop.Models.Artist", "Artist")
                        .WithMany("ArtistRows")
                        .HasForeignKey("ArtistId");

                    b.HasOne("ArtWebshop.Models.Product", "Product")
                        .WithMany("ArtistRows")
                        .HasForeignKey("ProductId");

                    b.Navigation("Artist");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ArtWebshop.Models.OrderRow", b =>
                {
                    b.HasOne("ArtWebshop.Models.Order", "Order")
                        .WithMany("OrderRows")
                        .HasForeignKey("OrderId");

                    b.HasOne("ArtWebshop.Models.Product", "Product")
                        .WithMany("OrderRows")
                        .HasForeignKey("ProductId");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ArtWebshop.Models.Product", b =>
                {
                    b.HasOne("ArtWebshop.Models.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId");

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("ArtWebshop.Models.Artist", b =>
                {
                    b.Navigation("ArtistRows");
                });

            modelBuilder.Entity("ArtWebshop.Models.Order", b =>
                {
                    b.Navigation("OrderRows");
                });

            modelBuilder.Entity("ArtWebshop.Models.Product", b =>
                {
                    b.Navigation("ArtistRows");

                    b.Navigation("OrderRows");
                });
#pragma warning restore 612, 618
        }
    }
}
