using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtWebshop.Data.Migrations.Products
{
    public partial class DecimalconversioncontrolforProductalldecimalproperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "550538cc-a4ca-48a7-abe8-e6b5a6c518f9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "6e1cfadc-30f8-489d-aa47-18e43f63d305");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "9f879dc1-5ca3-4a5f-aca7-ec7709af9e4a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "e9068e66-f92a-4043-824a-e19542a94236");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "3ec5a963-37b6-4291-b3f9-b2c5b4d6db1e");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "51c408cd-7c75-4ab6-92c0-5802d3ca7639");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "7e80b578-ba8f-4b78-9758-cfb019b200f4");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "c029a0aa-da59-4453-80b8-61c6f75ce74e");

            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "ArtistId", "ArtistName", "UserId" },
                values: new object[,]
                {
                    { "7bd6641e-853e-4194-bfe4-98e7d74d4c86", "Leonardo da Vinci", "userId" },
                    { "617c2263-cf15-4609-9b69-c267a61f2a36", "Leonardo da Vinci", "userId" },
                    { "d969538a-e82e-4e3e-9dcf-2068f031024d", "Edvard Munch", "userId" },
                    { "aaed5a19-d2db-4842-9628-0083d920a9a0", "Vincent van Gogh", "userId" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ArtistId", "Category", "CreationDate", "Height", "IsPaintingOfTheWeek", "LongDescription", "PictureLink", "Price", "ShortDescription", "Stock", "Style", "ThumbnailLink", "Title", "Width" },
                values: new object[,]
                {
                    { "7f847eb4-7fdc-45c3-a937-e48c8d25d4c0", "7bd6641e-853e-4194-bfe4-98e7d74d4c86", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1503), 53, false, "Mona Lisa, also called Portrait of Lisa Gherardini, wife of Francesco del Giocondo, Italian La Gioconda, or French La Joconde, oil painting on a poplar wood panel by Leonardo da Vinci, probably the world’s most famous painting. It was painted sometime between 1503 and 1519, when Leonardo was living in Florence, and it now hangs in the Louvre Museum, Paris, where it remained an object of pilgrimage in the 21st century. The sitter’s mysterious smile and her unproven identity have made the painting a source of ongoing investigation and fascination.", "/Images/Originals/Paintings/Mona Lisa.jpg", 50.50m, "A mysterious woman", 15, "Oil on wood Panel", "/Images/Originals/Thumbnails//Mona Lisa (thumb).jpg", "Mona Lisa.jpg", 77 },
                    { "7d4f87d9-b555-4872-aa3c-ca946cd4ccef", "617c2263-cf15-4609-9b69-c267a61f2a36", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1495), 460, false, "Leonardo Da Vinci", "/Images/Originals/Paintings/The Last Supper.jpg", 33.00m, "The last supper", 3, "Olja på duk", "/Images/Originals/Thumbnails/Nattvarden (thumb).jpg", "The Last Supper.jpg", 880 },
                    { "7f11d7ff-6886-4c35-8bab-be4e95a0b78d", "d969538a-e82e-4e3e-9dcf-2068f031024d", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1903), 460, false, "", "/Images/Originals/Paintings/Skriet.jpg", 15.505m, "Edvard Munch", 150, "Olja, tempera och pastell på papp", "/Images/Originals/Thumbnails/Skriet (thumb).jpg", "Skriet.jpg", 880 },
                    { "5242d9ab-3637-4226-b424-375f3a906191", "aaed5a19-d2db-4842-9628-0083d920a9a0", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1882), 460, false, "", "/Images/Originals/Paintings/Utsliten.jpg", 18.505m, "Vincent van Gogh", 5, "Postexpressionism: Teckning penna på vattenfärgat papper", "/Images/Originals/Thumbnails/Utsliten (thumb).jpg", "Utsliten.jpg", 880 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "5242d9ab-3637-4226-b424-375f3a906191");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "7d4f87d9-b555-4872-aa3c-ca946cd4ccef");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "7f11d7ff-6886-4c35-8bab-be4e95a0b78d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "7f847eb4-7fdc-45c3-a937-e48c8d25d4c0");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "617c2263-cf15-4609-9b69-c267a61f2a36");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "7bd6641e-853e-4194-bfe4-98e7d74d4c86");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "aaed5a19-d2db-4842-9628-0083d920a9a0");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "d969538a-e82e-4e3e-9dcf-2068f031024d");

            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "ArtistId", "ArtistName", "UserId" },
                values: new object[,]
                {
                    { "7e80b578-ba8f-4b78-9758-cfb019b200f4", "Leonardo da Vinci", "userId" },
                    { "c029a0aa-da59-4453-80b8-61c6f75ce74e", "Leonardo da Vinci", "userId" },
                    { "3ec5a963-37b6-4291-b3f9-b2c5b4d6db1e", "Edvard Munch", "userId" },
                    { "51c408cd-7c75-4ab6-92c0-5802d3ca7639", "Vincent van Gogh", "userId" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ArtistId", "Category", "CreationDate", "Height", "IsPaintingOfTheWeek", "LongDescription", "PictureLink", "Price", "ShortDescription", "Stock", "Style", "ThumbnailLink", "Title", "Width" },
                values: new object[,]
                {
                    { "550538cc-a4ca-48a7-abe8-e6b5a6c518f9", "7e80b578-ba8f-4b78-9758-cfb019b200f4", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1503), 53, false, "Mona Lisa, also called Portrait of Lisa Gherardini, wife of Francesco del Giocondo, Italian La Gioconda, or French La Joconde, oil painting on a poplar wood panel by Leonardo da Vinci, probably the world’s most famous painting. It was painted sometime between 1503 and 1519, when Leonardo was living in Florence, and it now hangs in the Louvre Museum, Paris, where it remained an object of pilgrimage in the 21st century. The sitter’s mysterious smile and her unproven identity have made the painting a source of ongoing investigation and fascination.", "/Images/Originals/Paintings/Mona Lisa.jpg", 50.50m, "A mysterious woman", 15, "Oil on wood Panel", "/Images/Originals/Thumbnails//Mona Lisa (thumb).jpg", "Mona Lisa.jpg", 77 },
                    { "9f879dc1-5ca3-4a5f-aca7-ec7709af9e4a", "c029a0aa-da59-4453-80b8-61c6f75ce74e", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1495), 460, false, "Leonardo Da Vinci", "/Images/Originals/Paintings/The Last Supper.jpg", 33.00m, "The last supper", 3, "Olja på duk", "/Images/Originals/Thumbnails/Nattvarden (thumb).jpg", "The Last Supper.jpg", 880 },
                    { "6e1cfadc-30f8-489d-aa47-18e43f63d305", "3ec5a963-37b6-4291-b3f9-b2c5b4d6db1e", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1903), 460, false, "", "/Images/Originals/Paintings/Skriet.jpg", 15.505m, "Edvard Munch", 150, "Olja, tempera och pastell på papp", "/Images/Originals/Thumbnails/Skriet (thumb).jpg", "Skriet.jpg", 880 },
                    { "e9068e66-f92a-4043-824a-e19542a94236", "51c408cd-7c75-4ab6-92c0-5802d3ca7639", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1882), 460, false, "", "/Images/Originals/Paintings/Utsliten.jpg", 18.505m, "Vincent van Gogh", 5, "Postexpressionism: Teckning penna på vattenfärgat papper", "/Images/Originals/Thumbnails/Utsliten (thumb).jpg", "Utsliten.jpg", 880 }
                });
        }
    }
}
