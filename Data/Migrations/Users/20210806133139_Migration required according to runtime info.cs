using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtWebshop.Data.Migrations.Users
{
    public partial class Migrationrequiredaccordingtoruntimeinfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "878c8bfc-59b1-4a41-becc-e6b2b5f7185b", "148212fc-8421-4151-8a20-daad9dd4cd9a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "55a182aa-10ce-4975-901a-38e606978b32", "3a037856-e1ad-48d6-92f3-77553d97f535" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c3c0726b-072f-4202-b2a3-a71309e8e870", "8aee0c42-b86c-480d-8585-8e632ae44adf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cfd3e227-a15b-4bde-bef4-e093ea748157", "9e930bfa-991b-40f6-a86b-6519f55cf78a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55a182aa-10ce-4975-901a-38e606978b32");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "878c8bfc-59b1-4a41-becc-e6b2b5f7185b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3c0726b-072f-4202-b2a3-a71309e8e870");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfd3e227-a15b-4bde-bef4-e093ea748157");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "148212fc-8421-4151-8a20-daad9dd4cd9a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a037856-e1ad-48d6-92f3-77553d97f535");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aee0c42-b86c-480d-8585-8e632ae44adf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e930bfa-991b-40f6-a86b-6519f55cf78a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d38f1499-8a56-49e9-9499-b44106cf488f", "d38f1499-8a56-49e9-9499-b44106cf488f", "Admin", "ADMIN" },
                    { "2ba890d1-7638-4dd7-89f6-0471ffde0fab", "2ba890d1-7638-4dd7-89f6-0471ffde0fab", "Vendor", "VENDOR" },
                    { "dcd7abf1-add1-4f94-bdd6-331c3e441323", "dcd7abf1-add1-4f94-bdd6-331c3e441323", "User", "USER" },
                    { "fbfd952f-db39-44c4-a831-fc718d1fbe28", "fbfd952f-db39-44c4-a831-fc718d1fbe28", "Artist", "ARTIST" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BillingCity", "BillingCountry", "BillingPostalCode", "BillingStreetName", "ConcurrencyStamp", "DeliveryCity", "DeliveryCountry", "DeliveryPostalCode", "DeliveryStreetName", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6f771b46-dac3-4860-b056-71263c1f1890", 0, "Göteborg", "Sverige", "12345", "Hemadress 1", "58f0353a-82e4-486c-b37e-dc71dffa4564", null, null, null, null, "admin@site.com", true, "TestUserAdmin", "SuperUser", false, null, "ADMIN@SITE.COM", "ADMIN@SITE.COM", "AQAAAAEAACcQAAAAEBOKiB0f/K/lMHXOsS6IFHsJsmWyy9dzfOWkKkPObF2X5jzJWe1CRNxTnpA48gquHQ==", null, false, "a60f5cf4-b76a-44d7-a44c-2f61a9b78eb1", false, "admin@site.com" },
                    { "7853f3e9-b12c-4955-a1d3-383c0caa3d16", 0, "Göteborg", "Sverige", "12345", "Hemadress 1", "7c22acb9-195a-4d11-ba65-8a10c2f906aa", null, null, null, null, "vendor@site.com", true, "TestUserVendor", "Admin", false, null, "VENDOR@SITE.COM", "VENDOR@SITE.COM", "AQAAAAEAACcQAAAAEDPDubzk42650JAf08I3rJbon2bmxcyUit08gD9lgiuHTBzdfHfcui48vUUP0f5a2g==", null, false, "a1571469-2ab7-4a39-930a-6a41dd2ed66c", false, "vendor@site.com" },
                    { "c9c50f87-9cb6-46cf-a04f-97255608a6fb", 0, "Göteborg", "Sverige", "12345", "Hemadress 1", "e0efc47d-c815-4f82-a2e0-04f8ea196a80", null, null, null, null, "customer@site.com", true, "TestUserCustomer", "Buy", false, null, "CUSTOMER@SITE.COM", "CUSTOMER@SITE.COM", "AQAAAAEAACcQAAAAEKRoJUS/rFKP713fQE3goB4o0+GbrsJmwRIe8N8kF6UX7WcaQ+xZwMbWPqdWMqNX4w==", null, false, "3ac19513-9e10-42f9-b4ef-26ad0cb5546f", false, "customer@site.com" },
                    { "9b4fb251-de7c-46b5-9d34-dee375f3bb9a", 0, "Göteborg", "Sverige", "12345", "Hemadress 1", "9f72584f-8b3b-41fb-b40a-ba28cad67669", null, null, null, null, "artist@site.com", true, "TestUserArtist", "Upload", false, null, "ARTIST@SITE.COM", "ARTIST@SITE.COM", "AQAAAAEAACcQAAAAEKwJcGON+x6TliPeRgzB0Kj/C0sT9d3D3KmgDibejs59RpPe5ayMN8uoaYdBfSZuLA==", null, false, "fd4bb31a-bcb9-446a-8dc4-ff645098498e", false, "artist@site.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d38f1499-8a56-49e9-9499-b44106cf488f", "6f771b46-dac3-4860-b056-71263c1f1890" },
                    { "2ba890d1-7638-4dd7-89f6-0471ffde0fab", "7853f3e9-b12c-4955-a1d3-383c0caa3d16" },
                    { "dcd7abf1-add1-4f94-bdd6-331c3e441323", "c9c50f87-9cb6-46cf-a04f-97255608a6fb" },
                    { "fbfd952f-db39-44c4-a831-fc718d1fbe28", "9b4fb251-de7c-46b5-9d34-dee375f3bb9a" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d38f1499-8a56-49e9-9499-b44106cf488f", "6f771b46-dac3-4860-b056-71263c1f1890" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2ba890d1-7638-4dd7-89f6-0471ffde0fab", "7853f3e9-b12c-4955-a1d3-383c0caa3d16" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fbfd952f-db39-44c4-a831-fc718d1fbe28", "9b4fb251-de7c-46b5-9d34-dee375f3bb9a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dcd7abf1-add1-4f94-bdd6-331c3e441323", "c9c50f87-9cb6-46cf-a04f-97255608a6fb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ba890d1-7638-4dd7-89f6-0471ffde0fab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d38f1499-8a56-49e9-9499-b44106cf488f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dcd7abf1-add1-4f94-bdd6-331c3e441323");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fbfd952f-db39-44c4-a831-fc718d1fbe28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f771b46-dac3-4860-b056-71263c1f1890");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7853f3e9-b12c-4955-a1d3-383c0caa3d16");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b4fb251-de7c-46b5-9d34-dee375f3bb9a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9c50f87-9cb6-46cf-a04f-97255608a6fb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cfd3e227-a15b-4bde-bef4-e093ea748157", "cfd3e227-a15b-4bde-bef4-e093ea748157", "Admin", "ADMIN" },
                    { "c3c0726b-072f-4202-b2a3-a71309e8e870", "c3c0726b-072f-4202-b2a3-a71309e8e870", "Vendor", "VENDOR" },
                    { "878c8bfc-59b1-4a41-becc-e6b2b5f7185b", "878c8bfc-59b1-4a41-becc-e6b2b5f7185b", "User", "USER" },
                    { "55a182aa-10ce-4975-901a-38e606978b32", "55a182aa-10ce-4975-901a-38e606978b32", "Artist", "ARTIST" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BillingCity", "BillingCountry", "BillingPostalCode", "BillingStreetName", "ConcurrencyStamp", "DeliveryCity", "DeliveryCountry", "DeliveryPostalCode", "DeliveryStreetName", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9e930bfa-991b-40f6-a86b-6519f55cf78a", 0, "Göteborg", "Sverige", "12345", "Hemadress 1", "bea55096-d5fc-4d8e-93c0-fc9532f9be69", null, null, null, null, "admin@site.com", true, "TestUserAdmin", "SuperUser", false, null, "ADMIN@SITE.COM", "ADMIN@SITE.COM", "AQAAAAEAACcQAAAAEB10g1IbXlGZJByXyz8P1K6CspS9XqumQcdLjCNc1ABTOkgkETpXfWlC6WXDO/zlig==", null, false, "917cfd6d-aac9-4cca-b518-88bce5a69d88", false, "admin@site.com" },
                    { "8aee0c42-b86c-480d-8585-8e632ae44adf", 0, "Göteborg", "Sverige", "12345", "Hemadress 1", "d9afdc32-6c86-46b8-9f91-4f46b6cc87bb", null, null, null, null, "vendor@site.com", true, "TestUserVendor", "Admin", false, null, "VENDOR@SITE.COM", "VENDOR@SITE.COM", "AQAAAAEAACcQAAAAEMVuD9rzIe0VB3ZR2dp0S/909PP6FYpkfZUfAVODJ9ihfe4CBmL8oSqC9n1ngrLFTg==", null, false, "d8431dc6-cf00-47e9-bdd4-72e0333e5a31", false, "vendor@site.com" },
                    { "148212fc-8421-4151-8a20-daad9dd4cd9a", 0, "Göteborg", "Sverige", "12345", "Hemadress 1", "fa1788da-fa2e-4767-b46b-ca5f2fe843f3", null, null, null, null, "customer@site.com", true, "TestUserCustomer", "Buy", false, null, "CUSTOMER@SITE.COM", "CUSTOMER@SITE.COM", "AQAAAAEAACcQAAAAEBlEkaUGrnlVJwTOp4TTlV4oDkMwsuE7sHeBcUaKmidTXdFqUwbxbH/svnusj6w7vQ==", null, false, "e7da5d15-526f-439e-8be0-dcd9d189fd22", false, "customer@site.com" },
                    { "3a037856-e1ad-48d6-92f3-77553d97f535", 0, "Göteborg", "Sverige", "12345", "Hemadress 1", "09d1c91e-177d-42b1-986a-6e213bf37616", null, null, null, null, "artist@site.com", true, "TestUserArtist", "Upload", false, null, "ARTIST@SITE.COM", "ARTIST@SITE.COM", "AQAAAAEAACcQAAAAEI4b7pDAld3ZkfBIILeaD+70vA0gnFUECYJI6lhyVZzVjmHohp/NQuQHC8eVohQHxA==", null, false, "20392f7c-eb6b-4654-b0c8-bedc56a3a479", false, "artist@site.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cfd3e227-a15b-4bde-bef4-e093ea748157", "9e930bfa-991b-40f6-a86b-6519f55cf78a" },
                    { "c3c0726b-072f-4202-b2a3-a71309e8e870", "8aee0c42-b86c-480d-8585-8e632ae44adf" },
                    { "878c8bfc-59b1-4a41-becc-e6b2b5f7185b", "148212fc-8421-4151-8a20-daad9dd4cd9a" },
                    { "55a182aa-10ce-4975-901a-38e606978b32", "3a037856-e1ad-48d6-92f3-77553d97f535" }
                });
        }
    }
}
