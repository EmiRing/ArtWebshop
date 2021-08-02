using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtWebshop.Data.Migrations.Users
{
    public partial class AddedRolesAndUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6a47c76b-c175-4c8e-9d15-e30470998d73", "6a47c76b-c175-4c8e-9d15-e30470998d73", "Admin", "ADMIN" },
                    { "75c7cbfd-106f-4573-be36-174458ea4884", "75c7cbfd-106f-4573-be36-174458ea4884", "Vendor", "VENDOR" },
                    { "d796de89-c46f-4abc-8944-d53c9f091ca8", "d796de89-c46f-4abc-8944-d53c9f091ca8", "User", "USER" },
                    { "66c81e41-aa05-47d2-98c5-216b67c76a1d", "66c81e41-aa05-47d2-98c5-216b67c76a1d", "Artist", "ARTIST" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BillingCity", "BillingCountry", "BillingPostalCode", "BillingStreetName", "ConcurrencyStamp", "DeliveryCity", "DeliveryCountry", "DeliveryPostalCode", "DeliveryStreetName", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9dfea853-c45a-43fc-9249-246d944afca6", 0, "Göteborg", "Sverige", "12345", "Hemadress 1", "a63f3c29-53b2-4c12-97a7-92514444bfd5", null, null, null, null, "admin@site.com", true, "Admin", "A", false, null, "ADMIN@SITE.COM", "ADMIN@SITE.COM", "AQAAAAEAACcQAAAAECV11i8MHrm0pmL1MaAUuyVuGEHHKcxk5UdrIGBi99RceETXzSU301Cs8UtKbAOIEw==", null, false, "dc0db732-ad3e-4911-b7a5-9b3a0789c475", false, "admin@site.com" },
                    { "f7a07165-20a6-4e24-8cee-40fbd2e32547", 0, "Göteborg", "Sverige", "12345", "Hemadress 1", "153ac259-1c4b-450a-b80b-60e175f92824", null, null, null, null, "vendor@site.com", true, "Vendor", "A", false, null, "VENDOR@SITE.COM", "VENDOR@SITE.COM", "AQAAAAEAACcQAAAAEHrGBleWOp1PM8ku3efVCxetBQ7Cxcu63QatpVCwVHV4tVAkF3PMp1dxN6FVMg94VQ==", null, false, "238520c3-c946-4843-8e14-1f45d089cb79", false, "vendor@site.com" },
                    { "3224840d-e29b-4a97-b717-74905f1789ac", 0, "Göteborg", "Sverige", "12345", "Hemadress 1", "1dee464d-f369-4f16-8739-489f1679deef", null, null, null, null, "customer@site.com", true, "Customer", "A", false, null, "CUSTOMER@SITE.COM", "CUSTOMER@SITE.COM", "AQAAAAEAACcQAAAAEIEAVEQjqxueSk/7+nQPZmOqzseDXPae/Lyk29CfjE396COFHmcQx/sGehKeHud/1A==", null, false, "eebe4710-c2b4-43f4-a711-999cc982cebc", false, "customer@site.com" },
                    { "3c9b81ff-5cca-4b08-87af-cdde3a6088b0", 0, "Göteborg", "Sverige", "12345", "Hemadress 1", "0685ba26-8563-4abe-8e83-f0a19e7120a3", null, null, null, null, "artist@site.com", true, "Artist", "A", false, null, "ARTIST@SITE.COM", "ARTIST@SITE.COM", "AQAAAAEAACcQAAAAEOjJ2dViLQc6geAMsSeI4uhYcN20y7B5hlGcEzxBxKC1bbHi7K45pZm35md2hP696g==", null, false, "9a6d32a7-b677-43dd-a2dc-46351dc19bfd", false, "artist@site.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6a47c76b-c175-4c8e-9d15-e30470998d73", "9dfea853-c45a-43fc-9249-246d944afca6" },
                    { "75c7cbfd-106f-4573-be36-174458ea4884", "f7a07165-20a6-4e24-8cee-40fbd2e32547" },
                    { "d796de89-c46f-4abc-8944-d53c9f091ca8", "3224840d-e29b-4a97-b717-74905f1789ac" },
                    { "66c81e41-aa05-47d2-98c5-216b67c76a1d", "3c9b81ff-5cca-4b08-87af-cdde3a6088b0" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d796de89-c46f-4abc-8944-d53c9f091ca8", "3224840d-e29b-4a97-b717-74905f1789ac" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "66c81e41-aa05-47d2-98c5-216b67c76a1d", "3c9b81ff-5cca-4b08-87af-cdde3a6088b0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6a47c76b-c175-4c8e-9d15-e30470998d73", "9dfea853-c45a-43fc-9249-246d944afca6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "75c7cbfd-106f-4573-be36-174458ea4884", "f7a07165-20a6-4e24-8cee-40fbd2e32547" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66c81e41-aa05-47d2-98c5-216b67c76a1d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a47c76b-c175-4c8e-9d15-e30470998d73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75c7cbfd-106f-4573-be36-174458ea4884");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d796de89-c46f-4abc-8944-d53c9f091ca8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3224840d-e29b-4a97-b717-74905f1789ac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c9b81ff-5cca-4b08-87af-cdde3a6088b0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9dfea853-c45a-43fc-9249-246d944afca6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7a07165-20a6-4e24-8cee-40fbd2e32547");
        }
    }
}
