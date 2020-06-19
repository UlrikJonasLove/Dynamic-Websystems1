﻿// <auto-generated />
using System;
using Arkitekten.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Arkitekten.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200110191419_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Arkitekten.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Kakel"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Golv"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Tak"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Vägg"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Projekt",
                            Description = "Lägg till ett nytt projekt"
                        });
                });

            modelBuilder.Entity("Arkitekten.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Arkitekten.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Arkitekten.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Description = "Det vitaste kaklet i Sverige!",
                            ImageThumbnailUrl = "https://tilesrus.se/wp-content/uploads/2017/08/kakel-metro-vit-matt-75x150-3.jpg",
                            ImageUrl = "https://tilesrus.se/wp-content/uploads/2017/08/kakel-metro-vit-matt-75x150-3.jpg",
                            Name = "Vitt Kakel",
                            Price = 600
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Description = "Det mörkaste kaklet i Sverige!",
                            ImageThumbnailUrl = "https://media.tidlostkakel.se/2016/11/Biselado-Svart-Milj%C3%B6-002.jpg",
                            ImageUrl = "https://media.tidlostkakel.se/2016/11/Biselado-Svart-Milj%C3%B6-002.jpg",
                            Name = "Svart Kakel",
                            Price = 600
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            Description = "Det grönaste kaklet i Sverige!",
                            ImageThumbnailUrl = "https://www.kakelspecialisten.se/upload/inspiration/blogg/kakel-och-badbloggen/groent-kakel-i-badrummet/valencia_image-w644.jpg",
                            ImageUrl = "https://www.kakelspecialisten.se/upload/inspiration/blogg/kakel-och-badbloggen/groent-kakel-i-badrummet/valencia_image-w644.jpg",
                            Name = "Grönt kakel",
                            Price = 600
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            Description = "Superfint trägolv!",
                            ImageThumbnailUrl = "https://i.pinimg.com/originals/fd/d0/3e/fdd03e3baad9f6caf773aaf1602439c9.jpg",
                            ImageUrl = "https://i.pinimg.com/originals/fd/d0/3e/fdd03e3baad9f6caf773aaf1602439c9.jpg",
                            Name = "Mörkt Trä Golv",
                            Price = 1000
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 2,
                            Description = "Superljust trägolv!",
                            ImageThumbnailUrl = "https://www.barlinek.se/wp-content/uploads/2019/02/tragolv-ljust.jpg",
                            ImageUrl = "https://www.barlinek.se/wp-content/uploads/2019/02/tragolv-ljust.jpg",
                            Name = "Ljust Trä Golv",
                            Price = 1000
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 2,
                            Description = "Billigt, men bra!",
                            ImageThumbnailUrl = "https://bhgst.imgix.net/pimages/vatrumsmatta-tarkett-aquarelle-designgolv-istanbul-medium-grey__943d89bb-23c9-43a9-b523-af023f194186.jpg?auto=format,compress&w=200&h=200&dpr=2",
                            ImageUrl = "https://bhgst.imgix.net/pimages/vatrumsmatta-tarkett-aquarelle-designgolv-istanbul-medium-grey__943d89bb-23c9-43a9-b523-af023f194186.jpg?auto=format,compress&w=200&h=200&dpr=2",
                            Name = "Plast Golv",
                            Price = 400
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 3,
                            Description = "Superfint trä tak!",
                            ImageThumbnailUrl = "https://files.elledecoration.se/uploads/sites/30/2015/11/150130_Kinfolk_BH_026-copy.jpg",
                            ImageUrl = "https://files.elledecoration.se/uploads/sites/30/2015/11/150130_Kinfolk_BH_026-copy.jpg",
                            Name = "Mörkt Trä Tak",
                            Price = 1000
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 3,
                            Description = "Superljust trä tak!",
                            ImageThumbnailUrl = "https://thumbs.dreamstime.com/b/roterande-takfan-med-ljus-p%C3%A5-lantligt-tr%C3%A4tak-f%C3%B6r-fem-blad-som-installeras-tr%C3%A4plankatak-153334523.jpg",
                            ImageUrl = "https://thumbs.dreamstime.com/b/roterande-takfan-med-ljus-p%C3%A5-lantligt-tr%C3%A4tak-f%C3%B6r-fem-blad-som-installeras-tr%C3%A4plankatak-153334523.jpg",
                            Name = "Ljust Trä Tak",
                            Price = 1000
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 3,
                            Description = "Billigt, men bra!",
                            ImageThumbnailUrl = "https://www.teddytassen.se/webbshop/kanin/kaninburarhus/plasttak-till-kaninburar/large/plasttak-till-kaninburar-3966.jpg",
                            ImageUrl = "https://www.teddytassen.se/webbshop/kanin/kaninburarhus/plasttak-till-kaninburar/large/plasttak-till-kaninburar-3966.jpg",
                            Name = "Plast tak",
                            Price = 400
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 4,
                            Description = "Superfin trä vägg!",
                            ImageThumbnailUrl = "http://cdn3.cdnme.se/cdn/6-1/2514707/images/2013/sfdf074cb2e8e97476eba5991e07c4ad1f5_800x800_50fe64eaddf2b31177766712.jpg",
                            ImageUrl = "http://cdn3.cdnme.se/cdn/6-1/2514707/images/2013/sfdf074cb2e8e97476eba5991e07c4ad1f5_800x800_50fe64eaddf2b31177766712.jpg",
                            Name = "Mörk Trä vägg",
                            Price = 1000
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 4,
                            Description = "Superljus trä vägg!",
                            ImageThumbnailUrl = "https://cdn2.cdnme.se/4271838/8-3/tratapet_ljus_travagg_traplankor_fondvagg_589cd2b6e087c3456ba1f34b.jpg",
                            ImageUrl = "https://cdn2.cdnme.se/4271838/8-3/tratapet_ljus_travagg_traplankor_fondvagg_589cd2b6e087c3456ba1f34b.jpg",
                            Name = "Ljus Trä vägg",
                            Price = 1000
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 4,
                            Description = "Billigt, men bra!",
                            ImageThumbnailUrl = "https://img.bygghemma.se/pimages/vatrumsvav-fg-135-typ-1x25m__3b5e8b97-c471-46b9-8075-9015f2782ea9.jpg?auto=format,compress&w=634&h=634&dpr=1",
                            ImageUrl = "https://img.bygghemma.se/pimages/vatrumsvav-fg-135-typ-1x25m__3b5e8b97-c471-46b9-8075-9015f2782ea9.jpg?auto=format,compress&w=634&h=634&dpr=1",
                            Name = "Plast vägg",
                            Price = 400
                        },
                        new
                        {
                            ProductId = 13,
                            CategoryId = 5,
                            Description = "Passar bra för sommarstugor!",
                            ImageThumbnailUrl = "https://lyx.se/z/wp-content/uploads/2012/11/ks_60jpg.jpg",
                            ImageUrl = "https://lyx.se/z/wp-content/uploads/2012/11/ks_60jpg.jpg",
                            Name = "Liten stuga",
                            Price = 500000
                        },
                        new
                        {
                            ProductId = 14,
                            CategoryId = 5,
                            Description = "Passar bra för året runt!",
                            ImageThumbnailUrl = "https://www.bengt-martins.se/storage/ma/26ecf8a0953f4561801e99cdeae503f5/5d23a00994e44d379047ca0ff903244b/jpg/C524CF6C5FE5A83942E0AF1C165CCB3B04A9F454/Salen-Tand-fjallvilla41_31759_780_400.jpg",
                            ImageUrl = "https://www.bengt-martins.se/storage/ma/26ecf8a0953f4561801e99cdeae503f5/5d23a00994e44d379047ca0ff903244b/jpg/C524CF6C5FE5A83942E0AF1C165CCB3B04A9F454/Salen-Tand-fjallvilla41_31759_780_400.jpg",
                            Name = "Stor stuga",
                            Price = 1000000
                        },
                        new
                        {
                            ProductId = 15,
                            CategoryId = 5,
                            Description = "Perfekt för familjen!",
                            ImageThumbnailUrl = "https://images7.alphacoders.com/341/341714.jpg",
                            ImageUrl = "https://images7.alphacoders.com/341/341714.jpg",
                            Name = "Stort hus",
                            Price = 2500000
                        });
                });

            modelBuilder.Entity("Arkitekten.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Arkitekten.Models.OrderDetail", b =>
                {
                    b.HasOne("Arkitekten.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Arkitekten.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Arkitekten.Models.Product", b =>
                {
                    b.HasOne("Arkitekten.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Arkitekten.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("Arkitekten.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
