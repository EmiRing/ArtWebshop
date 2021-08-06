using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtWebshop.Data.Migrations.Products
{
    public partial class UpdatedArtist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "1e748a43-fbb4-402e-a80b-8957b3b35898");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "3160d351-cf46-45b8-839a-b4a3000552b3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "6824b620-3d57-410a-b8c4-c918426a1247");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "829836e8-a0ef-4ac3-961f-a4dba5829ac2");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "00ade1ba-3e6b-49c9-8450-33036cf18785");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "3c24b971-8bd4-4ac0-8547-a0fe5e1c113c");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "9af131ac-15e8-4133-8e2b-e7a5a9cf7fc9");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "bd695714-66cd-4d80-b3f0-42b8b4ab29b6");

            migrationBuilder.AddColumn<string>(
                name: "Presentation",
                table: "Artist",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicture",
                table: "Artist",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "ArtistId", "ArtistName", "Presentation", "ProfilePicture", "UserId" },
                values: new object[,]
                {
                    { "dc3eb372-f6b7-4eb2-8eb5-140c0429c834", "Leonardo da Vinci", null, null, "userId" },
                    { "79c46d7c-0e69-4bf9-90a8-522737ed74ef", "Leonardo da Vinci", null, null, "userId" },
                    { "397ce743-9717-4e23-a6d3-1436cbf25ac5", "Edvard Munch", null, null, "userId" },
                    { "adb04188-e30e-403a-a0fb-5676f9f7afde", "Vincent van Gogh", null, null, "userId" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ArtistId", "Category", "CreationDate", "Height", "IsPaintingOfTheWeek", "LongDescription", "PictureLink", "Price", "ShortDescription", "Stock", "Style", "ThumbnailLink", "Title", "Width" },
                values: new object[,]
                {
                    { "1857677d-2ba4-4ef1-b8fa-0f42ba193a78", "dc3eb372-f6b7-4eb2-8eb5-140c0429c834", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1503), 53, false, "Mona Lisa, also called Portrait of Lisa Gherardini, wife of Francesco del Giocondo, Italian La Gioconda, or French La Joconde, oil painting on a poplar wood panel by Leonardo da Vinci, probably the world’s most famous painting. It was painted sometime between 1503 and 1519, when Leonardo was living in Florence, and it now hangs in the Louvre Museum, Paris, where it remained an object of pilgrimage in the 21st century. The sitter’s mysterious smile and her unproven identity have made the painting a source of ongoing investigation and fascination.", "~/Images/Originals/Paintings/Mona Lisa.jpg", 50.50m, "A mysterious woman", 15, "Oil on wood Panel", "~/Images/Originals/Thumbnails/Prints/Mona Lisa (thumb).jpg", "Mona Lisa.jpg", 77 },
                    { "10b62824-0340-411a-9ef8-c4c982143354", "79c46d7c-0e69-4bf9-90a8-522737ed74ef", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1495), 460, false, "Leonardo Da Vinci", "~/Images/Originals/Paintings/The Last Supper.jpg", 33.00m, "The last supper", 3, "Olja på duk", "~/Images/Originals/Thumbnails/Prints/Nattvarden (thumb).jpg", "The Last Supper.jpg", 880 },
                    { "52a4487f-2166-4d2c-a00a-a8241ea9591c", "397ce743-9717-4e23-a6d3-1436cbf25ac5", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1903), 460, false, "", "~/Images/Originals/Paintings/Skriet.jpg", 15.505m, "Edvard Munch", 150, "Olja, tempera och pastell på papp", "~/Images/Originals/Thumbnails/Skriet (thumb).jpg", "Skriet.jpg", 880 },
                    { "bb3fab59-105b-4922-bc8d-92938a64f01d", "adb04188-e30e-403a-a0fb-5676f9f7afde", "Print", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1882), 460, false, "", "~/Images/Originals/Paintings/Utsliten.jpg", 18.505m, "Vincent van Gogh", 5, "Postexpressionism: Teckning penna på vattenfärgat papper", "~/Images/Originals/Thumbnails/Utsliten (thumb).jpg", "Utsliten.jpg", 880 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "10b62824-0340-411a-9ef8-c4c982143354");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "1857677d-2ba4-4ef1-b8fa-0f42ba193a78");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "52a4487f-2166-4d2c-a00a-a8241ea9591c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "bb3fab59-105b-4922-bc8d-92938a64f01d");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "397ce743-9717-4e23-a6d3-1436cbf25ac5");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "79c46d7c-0e69-4bf9-90a8-522737ed74ef");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "adb04188-e30e-403a-a0fb-5676f9f7afde");

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: "dc3eb372-f6b7-4eb2-8eb5-140c0429c834");

            migrationBuilder.DropColumn(
                name: "Presentation",
                table: "Artist");

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "Artist");

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
        }
    }
}
