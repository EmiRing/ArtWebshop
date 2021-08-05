using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtWebshop.Data.Migrations.Products
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
