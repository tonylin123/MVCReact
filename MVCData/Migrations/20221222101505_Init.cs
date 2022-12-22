using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCData.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e8b62ad-309f-414d-b2fe-f85d59381ca4");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c49e409a-f74e-444e-8093-86b8e8e72e07", "2004d6f0-90a7-40cf-bd31-7851384bd7a1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c49e409a-f74e-444e-8093-86b8e8e72e07");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2004d6f0-90a7-40cf-bd31-7851384bd7a1");

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LanguagePerson",
                columns: table => new
                {
                    LanguagesID = table.Column<int>(type: "int", nullable: false),
                    PeopleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguagePerson", x => new { x.LanguagesID, x.PeopleID });
                    table.ForeignKey(
                        name: "FK_LanguagePerson_Languages_LanguagesID",
                        column: x => x.LanguagesID,
                        principalTable: "Languages",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguagePerson_People_PeopleID",
                        column: x => x.PeopleID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "826f822b-1659-4002-ad44-e456aea8cf8a", "853752b9-62fa-42b7-aae2-9d03ce0490f9", "Admin", "ADMIN" },
                    { "bb212a14-e6ae-46a4-bdd4-4dc66e2e740d", "6fdfa75f-3f1e-4a9a-b6a9-dee52f62d5ee", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b34277b1-aa6e-4879-90f5-f123820b5052", 0, "4e23e602-8566-4958-a0ef-4e840a2b5995", "20221209", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAECHHNbiHmB/ur8H+iGdBI5csz1Qr3eL1AbyecE+StsiDVGz0OilLsuBQkPQ8aXd8LQ==", null, false, "97d44b0c-ded9-4d74-927f-61afa9fc9a2a", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Mandarin" },
                    { 2, "English" },
                    { 3, "Swedish" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "826f822b-1659-4002-ad44-e456aea8cf8a", "b34277b1-aa6e-4879-90f5-f123820b5052" });

            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "LanguagesID", "PeopleID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LanguagePerson_PeopleID",
                table: "LanguagePerson",
                column: "PeopleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LanguagePerson");

            migrationBuilder.DropTable(
                name: "Languages");

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
                values: new object[] { "2e8b62ad-309f-414d-b2fe-f85d59381ca4", "89c63bf2-0984-4c2d-947b-e65d23ad2b75", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c49e409a-f74e-444e-8093-86b8e8e72e07", "cb228b72-b865-4bc7-b0b5-750bafd96e9f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2004d6f0-90a7-40cf-bd31-7851384bd7a1", 0, "e4cc39c4-dba8-4f1c-aff6-a829824f51c9", "20221209", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEANRJkmz5FwkcGtnqHE2p4QlKyn2cHu3rfKrmGxdLLiikAKYQjSmE9pOjiUQUOcjQw==", null, false, "0070591a-15d4-4728-953e-10cd4843633e", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c49e409a-f74e-444e-8093-86b8e8e72e07", "2004d6f0-90a7-40cf-bd31-7851384bd7a1" });
        }
    }
}
