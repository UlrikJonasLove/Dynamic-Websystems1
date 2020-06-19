using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Arkitekten.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    AdressLine1 = table.Column<string>(nullable: true),
                    AdressLine2 = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    OrderTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderPlaced = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageThumbnailUrl = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    ShoppingCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Kakel", null },
                    { 2, "Golv", null },
                    { 3, "Tak", null },
                    { 4, "Vägg", null },
                    { 5, "Projekt", "Lägg till ett nytt projekt" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Det vitaste kaklet i Sverige!", "https://tilesrus.se/wp-content/uploads/2017/08/kakel-metro-vit-matt-75x150-3.jpg", "https://tilesrus.se/wp-content/uploads/2017/08/kakel-metro-vit-matt-75x150-3.jpg", "Vitt Kakel", 600 },
                    { 2, 1, "Det mörkaste kaklet i Sverige!", "https://media.tidlostkakel.se/2016/11/Biselado-Svart-Milj%C3%B6-002.jpg", "https://media.tidlostkakel.se/2016/11/Biselado-Svart-Milj%C3%B6-002.jpg", "Svart Kakel", 600 },
                    { 3, 1, "Det grönaste kaklet i Sverige!", "https://www.kakelspecialisten.se/upload/inspiration/blogg/kakel-och-badbloggen/groent-kakel-i-badrummet/valencia_image-w644.jpg", "https://www.kakelspecialisten.se/upload/inspiration/blogg/kakel-och-badbloggen/groent-kakel-i-badrummet/valencia_image-w644.jpg", "Grönt kakel", 600 },
                    { 4, 2, "Superfint trägolv!", "https://i.pinimg.com/originals/fd/d0/3e/fdd03e3baad9f6caf773aaf1602439c9.jpg", "https://i.pinimg.com/originals/fd/d0/3e/fdd03e3baad9f6caf773aaf1602439c9.jpg", "Mörkt Trä Golv", 1000 },
                    { 5, 2, "Superljust trägolv!", "https://www.barlinek.se/wp-content/uploads/2019/02/tragolv-ljust.jpg", "https://www.barlinek.se/wp-content/uploads/2019/02/tragolv-ljust.jpg", "Ljust Trä Golv", 1000 },
                    { 6, 2, "Billigt, men bra!", "https://bhgst.imgix.net/pimages/vatrumsmatta-tarkett-aquarelle-designgolv-istanbul-medium-grey__943d89bb-23c9-43a9-b523-af023f194186.jpg?auto=format,compress&w=200&h=200&dpr=2", "https://bhgst.imgix.net/pimages/vatrumsmatta-tarkett-aquarelle-designgolv-istanbul-medium-grey__943d89bb-23c9-43a9-b523-af023f194186.jpg?auto=format,compress&w=200&h=200&dpr=2", "Plast Golv", 400 },
                    { 7, 3, "Superfint trä tak!", "https://files.elledecoration.se/uploads/sites/30/2015/11/150130_Kinfolk_BH_026-copy.jpg", "https://files.elledecoration.se/uploads/sites/30/2015/11/150130_Kinfolk_BH_026-copy.jpg", "Mörkt Trä Tak", 1000 },
                    { 8, 3, "Superljust trä tak!", "https://thumbs.dreamstime.com/b/roterande-takfan-med-ljus-p%C3%A5-lantligt-tr%C3%A4tak-f%C3%B6r-fem-blad-som-installeras-tr%C3%A4plankatak-153334523.jpg", "https://thumbs.dreamstime.com/b/roterande-takfan-med-ljus-p%C3%A5-lantligt-tr%C3%A4tak-f%C3%B6r-fem-blad-som-installeras-tr%C3%A4plankatak-153334523.jpg", "Ljust Trä Tak", 1000 },
                    { 9, 3, "Billigt, men bra!", "https://www.teddytassen.se/webbshop/kanin/kaninburarhus/plasttak-till-kaninburar/large/plasttak-till-kaninburar-3966.jpg", "https://www.teddytassen.se/webbshop/kanin/kaninburarhus/plasttak-till-kaninburar/large/plasttak-till-kaninburar-3966.jpg", "Plast tak", 400 },
                    { 10, 4, "Superfin trä vägg!", "http://cdn3.cdnme.se/cdn/6-1/2514707/images/2013/sfdf074cb2e8e97476eba5991e07c4ad1f5_800x800_50fe64eaddf2b31177766712.jpg", "http://cdn3.cdnme.se/cdn/6-1/2514707/images/2013/sfdf074cb2e8e97476eba5991e07c4ad1f5_800x800_50fe64eaddf2b31177766712.jpg", "Mörk Trä vägg", 1000 },
                    { 11, 4, "Superljus trä vägg!", "https://cdn2.cdnme.se/4271838/8-3/tratapet_ljus_travagg_traplankor_fondvagg_589cd2b6e087c3456ba1f34b.jpg", "https://cdn2.cdnme.se/4271838/8-3/tratapet_ljus_travagg_traplankor_fondvagg_589cd2b6e087c3456ba1f34b.jpg", "Ljus Trä vägg", 1000 },
                    { 12, 4, "Billigt, men bra!", "https://img.bygghemma.se/pimages/vatrumsvav-fg-135-typ-1x25m__3b5e8b97-c471-46b9-8075-9015f2782ea9.jpg?auto=format,compress&w=634&h=634&dpr=1", "https://img.bygghemma.se/pimages/vatrumsvav-fg-135-typ-1x25m__3b5e8b97-c471-46b9-8075-9015f2782ea9.jpg?auto=format,compress&w=634&h=634&dpr=1", "Plast vägg", 400 },
                    { 13, 5, "Passar bra för sommarstugor!", "https://lyx.se/z/wp-content/uploads/2012/11/ks_60jpg.jpg", "https://lyx.se/z/wp-content/uploads/2012/11/ks_60jpg.jpg", "Liten stuga", 500000 },
                    { 14, 5, "Passar bra för året runt!", "https://www.bengt-martins.se/storage/ma/26ecf8a0953f4561801e99cdeae503f5/5d23a00994e44d379047ca0ff903244b/jpg/C524CF6C5FE5A83942E0AF1C165CCB3B04A9F454/Salen-Tand-fjallvilla41_31759_780_400.jpg", "https://www.bengt-martins.se/storage/ma/26ecf8a0953f4561801e99cdeae503f5/5d23a00994e44d379047ca0ff903244b/jpg/C524CF6C5FE5A83942E0AF1C165CCB3B04A9F454/Salen-Tand-fjallvilla41_31759_780_400.jpg", "Stor stuga", 1000000 },
                    { 15, 5, "Perfekt för familjen!", "https://images7.alphacoders.com/341/341714.jpg", "https://images7.alphacoders.com/341/341714.jpg", "Stort hus", 2500000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
