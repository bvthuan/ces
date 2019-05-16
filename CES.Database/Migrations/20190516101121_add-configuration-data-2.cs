using Microsoft.EntityFrameworkCore.Migrations;

namespace CES.Database.Migrations
{
    public partial class addconfigurationdata2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RouteConfigurations",
                columns: new[] { "Id", "Key", "Value" },
                values: new object[,]
                {
                    { 1L, "PriceBetweenTwoSegments", "4" },
                    { 2L, "MaxiumWeight", "40" },
                    { 3L, "ShipProviderURL", "" },
                    { 4L, "AirProviderURL", "" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RouteConfigurations",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "RouteConfigurations",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "RouteConfigurations",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "RouteConfigurations",
                keyColumn: "Id",
                keyValue: 4L);
        }
    }
}
