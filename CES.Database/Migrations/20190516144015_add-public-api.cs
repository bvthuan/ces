using Microsoft.EntityFrameworkCore.Migrations;

namespace CES.Database.Migrations
{
    public partial class addpublicapi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RouteConfigurations",
                columns: new[] { "Id", "Key", "Value" },
                values: new object[] { 5L, "HourBetweenTwoSegments", "4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RouteConfigurations",
                keyColumn: "Id",
                keyValue: 5L);
        }
    }
}
