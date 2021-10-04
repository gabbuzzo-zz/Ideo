using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ideo.Backend.Data.Migrations
{
    public partial class AddSeededData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "admin_role", "aead5900-0e0d-4037-b3e1-2e9e2a2779d6", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthdayDate", "ConcurrencyStamp", "Curriculum", "Email", "EmailConfirmed", "FiscalCode", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9ab299fe-e318-4d25-97fa-1525939629c0", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "93a4566a-2f0f-4c66-9b53-6525c7bc88e6", null, "gabbuzzo@admin.com", true, null, false, null, null, null, "GABBUZZO", null, "AQAAAAEAACcQAAAAEDNPDXAeqqZTWgdNfUcAFuVUV9cmz9jYZS1GebNJ0hQhexr73bTuiLotMzffv49AwA==", null, false, "dc128cc5-226f-4352-9117-b80eb6e01e2e", null, false, "Gabbuzzo" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "admin_role", "9ab299fe-e318-4d25-97fa-1525939629c0" });

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
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "VideoCourses");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "JobApplications");

            migrationBuilder.DropTable(
                name: "ReportTypes");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
