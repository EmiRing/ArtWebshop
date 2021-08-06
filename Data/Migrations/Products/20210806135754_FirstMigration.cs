using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtWebshop.Data.Migrations.Products
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    ArtistId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtistName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.ArtistId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryStreetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillingStreetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillingPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillingCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillingCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CouponId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LongDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Style = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PictureLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbnailLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtistId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsPaintingOfTheWeek = table.Column<bool>(type: "bit", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Artist_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artist",
                        principalColumn: "ArtistId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArtistRows",
                columns: table => new
                {
                    RowId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ArtistId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistRows", x => x.RowId);
                    table.ForeignKey(
                        name: "FK_ArtistRows_Artist_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artist",
                        principalColumn: "ArtistId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArtistRows_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderRows",
                columns: table => new
                {
                    RowId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderRows", x => x.RowId);
                    table.ForeignKey(
                        name: "FK_OrderRows_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderRows_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "ArtistId", "ArtistName", "UserId" },
                values: new object[,]
                {
                    { "9af131ac-15e8-4133-8e2b-e7a5a9cf7fc9", "Leonardo da Vinci", "userId" },
                    { "3c24b971-8bd4-4ac0-8547-a0fe5e1c113c", "Leonardo da Vinci", "userId" },
                    { "bd695714-66cd-4d80-b3f0-42b8b4ab29b6", "Edvard Munch", "userId" },
                    { "00ade1ba-3e6b-49c9-8450-33036cf18785", "Vincent van Gogh", "userId" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ArtistId", "Category", "CreationDate", "Height", "IsPaintingOfTheWeek", "LongDescription", "PictureLink", "Price", "ShortDescription", "Stock", "Style", "ThumbnailLink", "Title", "Width" },
                values: new object[,]
                {
                    { "1e748a43-fbb4-402e-a80b-8957b3b35898", "9af131ac-15e8-4133-8e2b-e7a5a9cf7fc9", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1503), 53, false, "Mona Lisa, also called Portrait of Lisa Gherardini, wife of Francesco del Giocondo, Italian La Gioconda, or French La Joconde, oil painting on a poplar wood panel by Leonardo da Vinci, probably the world’s most famous painting. It was painted sometime between 1503 and 1519, when Leonardo was living in Florence, and it now hangs in the Louvre Museum, Paris, where it remained an object of pilgrimage in the 21st century. The sitter’s mysterious smile and her unproven identity have made the painting a source of ongoing investigation and fascination.", "~/Images/Originals/Paintings/Mona Lisa.jpg", 50.50m, "A mysterious woman", 15, "Oil on wood Panel", "~/Images/Originals/Thumbnails/Prints/Mona Lisa (thumb).jpg", "Mona Lisa.jpg", 77 },
                    { "6824b620-3d57-410a-b8c4-c918426a1247", "3c24b971-8bd4-4ac0-8547-a0fe5e1c113c", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1495), 460, false, "Leonardo Da Vinci", "~/Images/Originals/Paintings/The Last Supper.jpg", 33.00m, "The last supper", 3, "Olja på duk", "~/Images/Originals/Thumbnails/Prints/Nattvarden (thumb).jpg", "The Last Supper.jpg", 880 },
                    { "3160d351-cf46-45b8-839a-b4a3000552b3", "bd695714-66cd-4d80-b3f0-42b8b4ab29b6", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1903), 460, false, "", "~/Images/Originals/Paintings/Skriet.jpg", 15.505m, "Edvard Munch", 150, "Olja, tempera och pastell på papp", "~/Images/Originals/Thumbnails/Skriet (thumb).jpg", "Skriet.jpg", 880 },
                    { "829836e8-a0ef-4ac3-961f-a4dba5829ac2", "00ade1ba-3e6b-49c9-8450-33036cf18785", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1882), 460, false, "", "~/Images/Originals/Paintings/Utsliten.jpg", 18.505m, "Vincent van Gogh", 5, "Postexpressionism: Teckning penna på vattenfärgat papper", "~/Images/Originals/Thumbnails/Utsliten (thumb).jpg", "Utsliten.jpg", 880 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtistRows_ArtistId",
                table: "ArtistRows",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistRows_ProductId",
                table: "ArtistRows",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_OrderId",
                table: "OrderRows",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_ProductId",
                table: "OrderRows",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ArtistId",
                table: "Products",
                column: "ArtistId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistRows");

            migrationBuilder.DropTable(
                name: "OrderRows");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Artist");
        }
    }
}
