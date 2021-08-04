using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtWebshop.Data.Migrations.Users
{
    public partial class FixedMistakes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "BillingCountry",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "aad30e29-ac3f-436d-95df-a9006941d82d", "aad30e29-ac3f-436d-95df-a9006941d82d", "Admin", "ADMIN" },
                    { "8c514ec2-9a80-4e32-9c7f-359614180953", "8c514ec2-9a80-4e32-9c7f-359614180953", "Vendor", "VENDOR" },
                    { "58031bb0-5b71-40c9-b4d4-fd186ca00348", "58031bb0-5b71-40c9-b4d4-fd186ca00348", "User", "USER" },
                    { "b15b6bf9-d17d-46e1-84e6-3c58bfacdc77", "b15b6bf9-d17d-46e1-84e6-3c58bfacdc77", "Artist", "ARTIST" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BillingCity", "BillingCountry", "BillingPostalCode", "BillingStreetName", "ConcurrencyStamp", "DeliveryCity", "DeliveryCountry", "DeliveryPostalCode", "DeliveryStreetName", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c78fe577-1183-43cc-9cae-52daaa309687", 0, "Göteborg", "Sverige", "12345", "Hemadress 1", "aea750b4-ae67-4240-9209-85e0a9221c86", null, null, null, null, "admin@site.com", true, "Admin", "A", false, null, "ADMIN@SITE.COM", "ADMIN@SITE.COM", "AQAAAAEAACcQAAAAENMkbmTmgxw09NjizrauWHsQBEC7rDrp7RL9WSmaYyLRlStoWsCfusvjuuwrM9sK9g==", null, false, "90dda61e-3397-455e-bf8c-3cd7a0a46d8d", false, "admin@site.com" },
                    { "817f78a0-fc06-4bdf-8798-2abc13f3ef56", 0, "Göteborg", "Sverige", "12345", "Hemadress 1", "13e7f514-d7f7-4ece-9f63-0f02cd9fa112", null, null, null, null, "vendor@site.com", true, "Vendor", "A", false, null, "VENDOR@SITE.COM", "VENDOR@SITE.COM", "AQAAAAEAACcQAAAAEEFW5yhAfZKU7p8f3yd0lPpjgpkPFiLrT7achTvuKewOIlnCLY0/+w9P0lQsG20jRQ==", null, false, "391fc0be-3294-4c03-b6aa-e998f918d484", false, "vendor@site.com" },
                    { "8636d93c-a823-462e-85de-5601e945577f", 0, "Göteborg", "Sverige", "12345", "Hemadress 1", "fe8df1ef-cf1d-4dfb-9423-79151898e195", null, null, null, null, "customer@site.com", true, "Customer", "A", false, null, "CUSTOMER@SITE.COM", "CUSTOMER@SITE.COM", "AQAAAAEAACcQAAAAEH2xGk7BygnCseRNYnsJ8AYs8ZLXMnjgsHgI4mSFByNWno+42zNNoxTXiYXaE/xFpw==", null, false, "1f3d3471-c345-4e41-a53e-44cf270965a3", false, "customer@site.com" },
                    { "34924827-f0e2-494b-b4e9-b298212789de", 0, "Göteborg", "Sverige", "12345", "Hemadress 1", "1181f11b-4f28-4d0a-ac6a-226aa0e82572", null, null, null, null, "artist@site.com", true, "Artist", "A", false, null, "ARTIST@SITE.COM", "ARTIST@SITE.COM", "AQAAAAEAACcQAAAAEK5/s6vW78KXM0HziPONj+Qw9Tb3XT92mjEGWPO8GUtZHz43TpbZ0z0Wz/osLzGT8w==", null, false, "2c4dcbd5-2685-4d81-a8e3-1e9646f0c72c", false, "artist@site.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "aad30e29-ac3f-436d-95df-a9006941d82d", "c78fe577-1183-43cc-9cae-52daaa309687" },
                    { "8c514ec2-9a80-4e32-9c7f-359614180953", "817f78a0-fc06-4bdf-8798-2abc13f3ef56" },
                    { "58031bb0-5b71-40c9-b4d4-fd186ca00348", "8636d93c-a823-462e-85de-5601e945577f" },
                    { "b15b6bf9-d17d-46e1-84e6-3c58bfacdc77", "34924827-f0e2-494b-b4e9-b298212789de" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b15b6bf9-d17d-46e1-84e6-3c58bfacdc77", "34924827-f0e2-494b-b4e9-b298212789de" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8c514ec2-9a80-4e32-9c7f-359614180953", "817f78a0-fc06-4bdf-8798-2abc13f3ef56" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "58031bb0-5b71-40c9-b4d4-fd186ca00348", "8636d93c-a823-462e-85de-5601e945577f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aad30e29-ac3f-436d-95df-a9006941d82d", "c78fe577-1183-43cc-9cae-52daaa309687" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58031bb0-5b71-40c9-b4d4-fd186ca00348");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c514ec2-9a80-4e32-9c7f-359614180953");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aad30e29-ac3f-436d-95df-a9006941d82d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b15b6bf9-d17d-46e1-84e6-3c58bfacdc77");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34924827-f0e2-494b-b4e9-b298212789de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "817f78a0-fc06-4bdf-8798-2abc13f3ef56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8636d93c-a823-462e-85de-5601e945577f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c78fe577-1183-43cc-9cae-52daaa309687");

            migrationBuilder.AlterColumn<string>(
                name: "BillingCountry",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
