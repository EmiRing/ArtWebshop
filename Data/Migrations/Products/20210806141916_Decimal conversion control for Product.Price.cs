using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtWebshop.Data.Migrations.Products
{
    public partial class DecimalconversioncontrolforProductPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "0d014485-aa7b-451c-af64-c97ff444dbe8", "Leonardo da Vinci", "userId" },
                    { "37e091e9-62ab-4b45-8876-dc544d8f8501", "Leonardo da Vinci", "userId" },
                    { "70ac378c-6330-40b9-895e-83d96c533507", "Edvard Munch", "userId" },
                    { "59b9f13a-0678-4cd5-aac0-bfde6eb67926", "Vincent van Gogh", "userId" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ArtistId", "Category", "CreationDate", "Height", "IsPaintingOfTheWeek", "LongDescription", "PictureLink", "Price", "ShortDescription", "Stock", "Style", "ThumbnailLink", "Title", "Width" },
                values: new object[,]
                {
                    { "bfa5a5b9-f02d-4907-963e-2bb18791bfab", "0d014485-aa7b-451c-af64-c97ff444dbe8", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1503), 53, false, "Mona Lisa, also called Portrait of Lisa Gherardini, wife of Francesco del Giocondo, Italian La Gioconda, or French La Joconde, oil painting on a poplar wood panel by Leonardo da Vinci, probably the world’s most famous painting. It was painted sometime between 1503 and 1519, when Leonardo was living in Florence, and it now hangs in the Louvre Museum, Paris, where it remained an object of pilgrimage in the 21st century. The sitter’s mysterious smile and her unproven identity have made the painting a source of ongoing investigation and fascination.", "/Images/Originals/Paintings/Mona Lisa.jpg", 50.50m, "A mysterious woman", 15, "Oil on wood Panel", "/Images/Originals/Thumbnails//Mona Lisa (thumb).jpg", "Mona Lisa.jpg", 77 },
                    { "cbb33110-909e-4229-852a-2abb17584d3d", "37e091e9-62ab-4b45-8876-dc544d8f8501", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1495), 460, false, "Leonardo Da Vinci", "/Images/Originals/Paintings/The Last Supper.jpg", 33.00m, "The last supper", 3, "Olja på duk", "/Images/Originals/Thumbnails/Nattvarden (thumb).jpg", "The Last Supper.jpg", 880 },
                    { "595d69f5-827f-4c0a-8da1-cb2800217604", "70ac378c-6330-40b9-895e-83d96c533507", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1903), 460, false, "", "/Images/Originals/Paintings/Skriet.jpg", 15.505m, "Edvard Munch", 150, "Olja, tempera och pastell på papp", "/Images/Originals/Thumbnails/Skriet (thumb).jpg", "Skriet.jpg", 880 },
                    { "d795ec0b-9389-4742-98d2-7a17557da4d8", "59b9f13a-0678-4cd5-aac0-bfde6eb67926", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1882), 460, false, "", "/Images/Originals/Paintings/Utsliten.jpg", 18.505m, "Vincent van Gogh", 5, "Postexpressionism: Teckning penna på vattenfärgat papper", "/Images/Originals/Thumbnails/Utsliten (thumb).jpg", "Utsliten.jpg", 880 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "595d69f5-827f-4c0a-8da1-cb2800217604");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "bfa5a5b9-f02d-4907-963e-2bb18791bfab");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "cbb33110-909e-4229-852a-2abb17584d3d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "d795ec0b-9389-4742-98d2-7a17557da4d8");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "0d014485-aa7b-451c-af64-c97ff444dbe8");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "37e091e9-62ab-4b45-8876-dc544d8f8501");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "59b9f13a-0678-4cd5-aac0-bfde6eb67926");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "70ac378c-6330-40b9-895e-83d96c533507");

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
    }
}
