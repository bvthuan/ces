using Microsoft.EntityFrameworkCore.Migrations;

namespace CES.Database.Migrations
{
    public partial class addconfigurationdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PriceBetweenTwoSegments",
                table: "RouteConfigurations",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "MaxiumWeight",
                table: "RouteConfigurations",
                newName: "Key");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value",
                table: "RouteConfigurations",
                newName: "PriceBetweenTwoSegments");

            migrationBuilder.RenameColumn(
                name: "Key",
                table: "RouteConfigurations",
                newName: "MaxiumWeight");
        }
    }
}
