using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtWebshop.Data.Migrations.Products
{
    public partial class Correction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "333d9d82-3340-40f2-ae21-71aad7e6d8ca");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "4ecfdefb-f419-44eb-930d-2fe1b897f64a");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "5cf26302-b6e2-4ebd-8a1a-0e5c0455a202");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "d227232d-059b-4800-8b54-4f786e401eee");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "023b2179-3204-4e61-a2f0-a14c197df8f4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "457e1a8d-6951-4cd2-998b-89e0eb6f890c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "bc02b72b-02d2-48fb-b6e9-dc9595909580");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "c9687285-b76b-4a58-9bb7-e7fd320b39fc");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "54b626ca-41c9-42d7-bee3-910d26746815");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "c03dd33c-e42a-4610-937b-b1a8ff03be94");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "c794d19e-6107-4f1a-b550-59368c6e6034");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "e3b1d76c-ead3-4ab2-9c2b-a851f17f2d05");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "47a880a0-47de-4654-a071-071be79f001c");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "95ac4637-0036-4c65-bba4-27870dd278e0");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "c97f9f20-56b2-4690-8761-c18d94f56930");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "db724afd-823e-43e4-9fd2-86163250eff3");

            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "ArtistId", "ArtistName", "UserId" },
                values: new object[,]
                {
                    { "333d9d82-3340-40f2-ae21-71aad7e6d8ca", "Leonardo da Vinci", "userId" },
                    { "4ecfdefb-f419-44eb-930d-2fe1b897f64a", "Leonardo da Vinci", "userId" },
                    { "d227232d-059b-4800-8b54-4f786e401eee", "Edvard Munch", "userId" },
                    { "5cf26302-b6e2-4ebd-8a1a-0e5c0455a202", "Vincent van Gogh", "userId" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ArtistId", "Category", "CreationDate", "Height", "IsPaintingOfTheWeek", "LongDescription", "PictureLink", "Price", "ShortDescription", "Stock", "Style", "ThumbnailLink", "Title", "Width" },
                values: new object[,]
                {
                    { "457e1a8d-6951-4cd2-998b-89e0eb6f890c", null, "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1503), 53, false, "Mona Lisa, also called Portrait of Lisa Gherardini, wife of Francesco del Giocondo, Italian La Gioconda, or French La Joconde, oil painting on a poplar wood panel by Leonardo da Vinci, probably the world’s most famous painting. It was painted sometime between 1503 and 1519, when Leonardo was living in Florence, and it now hangs in the Louvre Museum, Paris, where it remained an object of pilgrimage in the 21st century. The sitter’s mysterious smile and her unproven identity have made the painting a source of ongoing investigation and fascination.", "Images/Paintings/Prints/Mona Lisa.jpg", 50.50m, "A mysterious woman", 0, "Oil on wood Panel", "Images/Thumbnails/Prints/Mona Lisa (thumb).jpg", "Mona Lisa", 77 },
                    { "c9687285-b76b-4a58-9bb7-e7fd320b39fc", null, "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1495), 460, false, "Leonardo Da Vinci", "Images/Paintings/Prints/Nattvarden.jpg", 33.00m, "The last supper", 0, "Olja på duk", "Images/Thumbnails/Prints/Nattvarden (thumb).jpg", "Nattvarden", 880 },
                    { "bc02b72b-02d2-48fb-b6e9-dc9595909580", null, "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1903), 460, false, "", "Images/Paintings/Prints/Skriet.jpg", 15.505m, "Edvard Munch", 0, "Olja, tempera och pastell på papp", "Images/Thumbnails/Prints/Skriet (thumb).jpg", "Nattvarden", 880 },
                    { "023b2179-3204-4e61-a2f0-a14c197df8f4", null, "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1882), 460, false, "", "Images/Paintings/Prints/Utsliten.jpg", 18.505m, "Edvard Munch", 0, "Postexpressionism: Teckning penna på vattenfärgat papper", "Images/Thumbnails/Prints/Utsliten (thumb).jpg", "Utsliten", 880 }
                });
        }
    }
}
