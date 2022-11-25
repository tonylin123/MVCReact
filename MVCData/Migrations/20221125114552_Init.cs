using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCData.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
