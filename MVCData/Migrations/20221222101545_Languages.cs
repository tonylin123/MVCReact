using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCData.Migrations
{
    public partial class Languages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb212a14-e6ae-46a4-bdd4-4dc66e2e740d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "826f822b-1659-4002-ad44-e456aea8cf8a", "b34277b1-aa6e-4879-90f5-f123820b5052" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "826f822b-1659-4002-ad44-e456aea8cf8a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b34277b1-aa6e-4879-90f5-f123820b5052");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b60da16c-50be-4507-a85e-a1a10604e96d", "d49b83eb-6dc0-464e-8f0d-f96f7ef5e6dd", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d1dc7296-3dc1-45bf-9ffc-705501adc613", "659fed01-2094-4bde-a56b-04a0109f7dca", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "819b6d0a-1ae4-4852-bcea-088cac48db8d", 0, "cc9095f6-3573-4f4d-840f-9c9a42646680", "20221209", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEEJlhDTccehr+ZIeAubnogJ3iGYmcid1ZUTlgZGQrHZ/oO0kTqmwH5cnUOUso9Rdvw==", null, false, "a58caa33-0a0b-40e3-929f-bfa2f8b23d88", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b60da16c-50be-4507-a85e-a1a10604e96d", "819b6d0a-1ae4-4852-bcea-088cac48db8d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1dc7296-3dc1-45bf-9ffc-705501adc613");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b60da16c-50be-4507-a85e-a1a10604e96d", "819b6d0a-1ae4-4852-bcea-088cac48db8d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b60da16c-50be-4507-a85e-a1a10604e96d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "819b6d0a-1ae4-4852-bcea-088cac48db8d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "826f822b-1659-4002-ad44-e456aea8cf8a", "853752b9-62fa-42b7-aae2-9d03ce0490f9", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bb212a14-e6ae-46a4-bdd4-4dc66e2e740d", "6fdfa75f-3f1e-4a9a-b6a9-dee52f62d5ee", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b34277b1-aa6e-4879-90f5-f123820b5052", 0, "4e23e602-8566-4958-a0ef-4e840a2b5995", "20221209", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAECHHNbiHmB/ur8H+iGdBI5csz1Qr3eL1AbyecE+StsiDVGz0OilLsuBQkPQ8aXd8LQ==", null, false, "97d44b0c-ded9-4d74-927f-61afa9fc9a2a", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "826f822b-1659-4002-ad44-e456aea8cf8a", "b34277b1-aa6e-4879-90f5-f123820b5052" });
        }
    }
}
