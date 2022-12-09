using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCData.Migrations
{
    public partial class AddedIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88b4a5c0-7232-4c3b-89b7-94ac15b69fbd");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "497e8d6b-886a-4619-8940-a903366c596a", "671656ed-ba48-48d2-9368-312ec11b4d1d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "497e8d6b-886a-4619-8940-a903366c596a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "671656ed-ba48-48d2-9368-312ec11b4d1d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a6d50bdc-8cd6-4551-a34b-987f6e9d328f", "8619f59d-1072-46ed-bb30-6e7b6c08dafd", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c687d47c-bfb7-4ca4-88cf-4cbb50b1cb56", "b3770a6b-84c0-435a-ad49-40ebc25c51bf", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b388c3d5-7fbd-4549-a886-78c0cdeaa8b2", 0, "160975df-2ca8-4971-a312-d1e8693a583b", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEE6EXpdHf+JkCud5MaOGyZxY8RGu7/u7E6GPGo3lXPWiFdaVY1QEN5zqabTfl/y12w==", null, false, "b843f9dd-3bc6-4caa-91a6-f7ec2944192d", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a6d50bdc-8cd6-4551-a34b-987f6e9d328f", "b388c3d5-7fbd-4549-a886-78c0cdeaa8b2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c687d47c-bfb7-4ca4-88cf-4cbb50b1cb56");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a6d50bdc-8cd6-4551-a34b-987f6e9d328f", "b388c3d5-7fbd-4549-a886-78c0cdeaa8b2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6d50bdc-8cd6-4551-a34b-987f6e9d328f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b388c3d5-7fbd-4549-a886-78c0cdeaa8b2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "497e8d6b-886a-4619-8940-a903366c596a", "a757f86c-db8c-4927-a962-3910a0d0f9b5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "88b4a5c0-7232-4c3b-89b7-94ac15b69fbd", "6447418b-f378-4b06-88ce-8fb3d21e007a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "671656ed-ba48-48d2-9368-312ec11b4d1d", 0, "50d67c5d-4f5b-4852-a2c3-1f0aea27af05", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEPk/URf+Ks9/yVi/p2GI56aRcBq9fYA3cBhK+bYkxipaDpT2lGkJaefcZWClgq246w==", null, false, "d0eb2ff9-ef4f-44c3-8fee-a095872826dc", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "497e8d6b-886a-4619-8940-a903366c596a", "671656ed-ba48-48d2-9368-312ec11b4d1d" });
        }
    }
}
