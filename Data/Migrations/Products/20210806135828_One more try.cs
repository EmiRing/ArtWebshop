using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtWebshop.Data.Migrations.Products
{
    public partial class Onemoretry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "ArtistId", "ArtistName", "UserId" },
                values: new object[,]
                {
                    { "e41c76b0-9639-4414-8588-256d116c73f6", "Leonardo da Vinci", "userId" },
                    { "38d093e9-a749-4595-b0f8-2907e2d80653", "Leonardo da Vinci", "userId" },
                    { "86cb5b5c-a952-42ac-89f4-3220c8d4eae0", "Edvard Munch", "userId" },
                    { "a1e3cb4e-ab53-4710-88b7-280c4db835f1", "Vincent van Gogh", "userId" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ArtistId", "Category", "CreationDate", "Height", "IsPaintingOfTheWeek", "LongDescription", "PictureLink", "Price", "ShortDescription", "Stock", "Style", "ThumbnailLink", "Title", "Width" },
                values: new object[,]
                {
                    { "c48c5953-e717-44c1-95e5-698f09cccd40", "e41c76b0-9639-4414-8588-256d116c73f6", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1503), 53, false, "Mona Lisa, also called Portrait of Lisa Gherardini, wife of Francesco del Giocondo, Italian La Gioconda, or French La Joconde, oil painting on a poplar wood panel by Leonardo da Vinci, probably the world’s most famous painting. It was painted sometime between 1503 and 1519, when Leonardo was living in Florence, and it now hangs in the Louvre Museum, Paris, where it remained an object of pilgrimage in the 21st century. The sitter’s mysterious smile and her unproven identity have made the painting a source of ongoing investigation and fascination.", "/Images/Originals/Paintings/Mona Lisa.jpg", 50.50m, "A mysterious woman", 15, "Oil on wood Panel", "/Images/Originals/Thumbnails//Mona Lisa (thumb).jpg", "Mona Lisa.jpg", 77 },
                    { "5081c33b-29b8-4937-9bf9-21af0159a9af", "38d093e9-a749-4595-b0f8-2907e2d80653", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1495), 460, false, "Leonardo Da Vinci", "/Images/Originals/Paintings/The Last Supper.jpg", 33.00m, "The last supper", 3, "Olja på duk", "/Images/Originals/Thumbnails/Nattvarden (thumb).jpg", "The Last Supper.jpg", 880 },
                    { "19e4c2fb-29db-4c59-ad1c-c51645366a60", "86cb5b5c-a952-42ac-89f4-3220c8d4eae0", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1903), 460, false, "", "/Images/Originals/Paintings/Skriet.jpg", 15.505m, "Edvard Munch", 150, "Olja, tempera och pastell på papp", "/Images/Originals/Thumbnails/Skriet (thumb).jpg", "Skriet.jpg", 880 },
                    { "6bae2b50-4943-4e0c-8ce5-5b7933fe8b99", "a1e3cb4e-ab53-4710-88b7-280c4db835f1", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1882), 460, false, "", "/Images/Originals/Paintings/Utsliten.jpg", 18.505m, "Vincent van Gogh", 5, "Postexpressionism: Teckning penna på vattenfärgat papper", "/Images/Originals/Thumbnails/Utsliten (thumb).jpg", "Utsliten.jpg", 880 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "19e4c2fb-29db-4c59-ad1c-c51645366a60");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "5081c33b-29b8-4937-9bf9-21af0159a9af");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "6bae2b50-4943-4e0c-8ce5-5b7933fe8b99");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "c48c5953-e717-44c1-95e5-698f09cccd40");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "38d093e9-a749-4595-b0f8-2907e2d80653");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "86cb5b5c-a952-42ac-89f4-3220c8d4eae0");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "a1e3cb4e-ab53-4710-88b7-280c4db835f1");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "e41c76b0-9639-4414-8588-256d116c73f6");

            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "ArtistId", "ArtistName", "UserId" },
                values: new object[,]
                {
                    { "95ac4637-0036-4c65-bba4-27870dd278e0", "Leonardo da Vinci", "userId" },
                    { "47a880a0-47de-4654-a071-071be79f001c", "Leonardo da Vinci", "userId" },
                    { "db724afd-823e-43e4-9fd2-86163250eff3", "Edvard Munch", "userId" },
                    { "c97f9f20-56b2-4690-8761-c18d94f56930", "Vincent van Gogh", "userId" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ArtistId", "Category", "CreationDate", "Height", "IsPaintingOfTheWeek", "LongDescription", "PictureLink", "Price", "ShortDescription", "Stock", "Style", "ThumbnailLink", "Title", "Width" },
                values: new object[,]
                {
                    { "c794d19e-6107-4f1a-b550-59368c6e6034", "95ac4637-0036-4c65-bba4-27870dd278e0", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1503), 53, false, "Mona Lisa, also called Portrait of Lisa Gherardini, wife of Francesco del Giocondo, Italian La Gioconda, or French La Joconde, oil painting on a poplar wood panel by Leonardo da Vinci, probably the world’s most famous painting. It was painted sometime between 1503 and 1519, when Leonardo was living in Florence, and it now hangs in the Louvre Museum, Paris, where it remained an object of pilgrimage in the 21st century. The sitter’s mysterious smile and her unproven identity have made the painting a source of ongoing investigation and fascination.", "/Images/Originals/Paintings/Mona Lisa.jpg", 50.50m, "A mysterious woman", 15, "Oil on wood Panel", "/Images/Originals/Thumbnails/Prints/Mona Lisa (thumb).jpg", "Mona Lisa.jpg", 77 },
                    { "54b626ca-41c9-42d7-bee3-910d26746815", "47a880a0-47de-4654-a071-071be79f001c", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1495), 460, false, "Leonardo Da Vinci", "/Images/Originals/Paintings/The Last Supper.jpg", 33.00m, "The last supper", 3, "Olja på duk", "/Images/Originals/Thumbnails/Nattvarden (thumb).jpg", "The Last Supper.jpg", 880 },
                    { "e3b1d76c-ead3-4ab2-9c2b-a851f17f2d05", "db724afd-823e-43e4-9fd2-86163250eff3", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1903), 460, false, "", "/Images/Originals/Paintings/Skriet.jpg", 15.505m, "Edvard Munch", 150, "Olja, tempera och pastell på papp", "/Images/Originals/Thumbnails/Skriet (thumb).jpg", "Skriet.jpg", 880 },
                    { "c03dd33c-e42a-4610-937b-b1a8ff03be94", "c97f9f20-56b2-4690-8761-c18d94f56930", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1882), 460, false, "", "/Images/Originals/Paintings/Utsliten.jpg", 18.505m, "Vincent van Gogh", 5, "Postexpressionism: Teckning penna på vattenfärgat papper", "/Images/Originals/Thumbnails/Utsliten (thumb).jpg", "Utsliten.jpg", 880 }
                });
        }
    }
}
