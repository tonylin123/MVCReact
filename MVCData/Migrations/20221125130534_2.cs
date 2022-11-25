using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCData.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "061e8a47-df0e-463b-8bc8-d82583ec1790");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "46eb9338-7f43-4f25-a370-77d482bc2590");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "5bf7a66b-bcbf-4e44-bc63-de789f4186e1");

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "Phone" },
                values: new object[] { "396d104b-43ea-4260-a197-1d4c9224b84d", "ManCity", "Jake Paul", "123289" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "Phone" },
                values: new object[] { "51665871-d702-41c0-b9a1-a25b9cb7b817", "NewYork", "Captain America", "3213213" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "Phone" },
                values: new object[] { "fbe56e9a-b6b5-4056-9263-b09d524727cd", "Gothenburg", "Tony Stark", "12345" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "396d104b-43ea-4260-a197-1d4c9224b84d");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "51665871-d702-41c0-b9a1-a25b9cb7b817");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "fbe56e9a-b6b5-4056-9263-b09d524727cd");

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "Phone" },
                values: new object[] { "061e8a47-df0e-463b-8bc8-d82583ec1790", "Gothenburg", "Tony Stark", "12345" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "Phone" },
                values: new object[] { "46eb9338-7f43-4f25-a370-77d482bc2590", "NewYork", "Captain America", "3213213" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "Phone" },
                values: new object[] { "5bf7a66b-bcbf-4e44-bc63-de789f4186e1", "ManCity", "Jake Paul", "123289" });
        }
    }
}
