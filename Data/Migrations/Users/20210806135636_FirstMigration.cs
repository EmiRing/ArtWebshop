using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtWebshop.Data.Migrations.User
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillingStreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillingPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillingCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillingCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryStreetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cf6cbbb1-793e-4996-9a7b-09b66e330661", "cf6cbbb1-793e-4996-9a7b-09b66e330661", "Admin", "ADMIN" },
                    { "d58a14b6-6efc-426f-ba02-a01fbe40a2fe", "d58a14b6-6efc-426f-ba02-a01fbe40a2fe", "Vendor", "VENDOR" },
                    { "2f1da8ed-5fb1-4646-90d4-4a23f3d0708b", "2f1da8ed-5fb1-4646-90d4-4a23f3d0708b", "User", "USER" },
                    { "136497bb-c1c9-4b91-9934-eb537dde5a25", "136497bb-c1c9-4b91-9934-eb537dde5a25", "Artist", "ARTIST" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BillingCity", "BillingCountry", "BillingPostalCode", "BillingStreetName", "ConcurrencyStamp", "DeliveryCity", "DeliveryCountry", "DeliveryPostalCode", "DeliveryStreetName", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b84357c6-ef6d-4fbd-b349-38b052f066e1", 0, "Göteborg", "Sverige", "12345", "Hemadress 1", "b59f1fe0-67d5-4707-84ed-2c73c17a35a8", null, null, null, null, "admin@site.com", true, "TestUserAdmin", "SuperUser", false, null, "ADMIN@SITE.COM", "ADMIN@SITE.COM", "AQAAAAEAACcQAAAAEBaEB8D1H/o2HjEMcIT8kWaWZ/h8h/1UpDqS9G/W2ypj94jUKX9Thqi/gx5frUqa8A==", null, false, "44401953-0991-49c0-9e39-7637222e1bd9", false, "admin@site.com" },
                    { "12752564-6882-4aa1-b484-889826f71edf", 0, "Göteborg", "Sverige", "12345", "Hemadress 1", "c6b2aa0f-a796-448e-a379-286f0c9d23b1", null, null, null, null, "vendor@site.com", true, "TestUserVendor", "Admin", false, null, "VENDOR@SITE.COM", "VENDOR@SITE.COM", "AQAAAAEAACcQAAAAEKObbW1yzfoWm6Cypa3OtI6OCr9Nu+GfANDVX6ke/WtOvggY49i/5UIMGtH/ZPu77g==", null, false, "0c7dd75d-1e60-4701-8ba7-bf4873423eab", false, "vendor@site.com" },
                    { "f2868be0-8053-4ad1-a092-4403741f230b", 0, "Göteborg", "Sverige", "12345", "Hemadress 1", "93f33ed8-e160-456f-a1f7-1836d3a501f6", null, null, null, null, "customer@site.com", true, "TestUserCustomer", "Buy", false, null, "CUSTOMER@SITE.COM", "CUSTOMER@SITE.COM", "AQAAAAEAACcQAAAAEDwd1ywOneebihJgj2gSDTWcpvMKNlCEMTZh2U9yMX/Uf+mRFEFFV8+63TtmMyxxaA==", null, false, "569ed5b6-8912-47bb-bb5b-7c81acc2077f", false, "customer@site.com" },
                    { "39be2141-fe19-4129-92b3-dbbe5f8e6896", 0, "Göteborg", "Sverige", "12345", "Hemadress 1", "85b58529-18e7-43bf-adfc-a08c242bfa19", null, null, null, null, "artist@site.com", true, "TestUserArtist", "Upload", false, null, "ARTIST@SITE.COM", "ARTIST@SITE.COM", "AQAAAAEAACcQAAAAEE4SgacTz6KCRrGtTDRUocs/Rk0o//AAFtg9c8xHmixZTRK6w3SuSky7kdDJ617P6Q==", null, false, "d2d3f13b-5c04-4ffa-b2a8-929093193ae8", false, "artist@site.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cf6cbbb1-793e-4996-9a7b-09b66e330661", "b84357c6-ef6d-4fbd-b349-38b052f066e1" },
                    { "d58a14b6-6efc-426f-ba02-a01fbe40a2fe", "12752564-6882-4aa1-b484-889826f71edf" },
                    { "2f1da8ed-5fb1-4646-90d4-4a23f3d0708b", "f2868be0-8053-4ad1-a092-4403741f230b" },
                    { "136497bb-c1c9-4b91-9934-eb537dde5a25", "39be2141-fe19-4129-92b3-dbbe5f8e6896" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
