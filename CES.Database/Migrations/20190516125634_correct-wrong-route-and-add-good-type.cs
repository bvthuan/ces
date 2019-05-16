using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CES.Database.Migrations
{
    public partial class correctwrongrouteandaddgoodtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GoodTypes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "GoodTypes",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1L, "RED", "Recorded Delivery" },
                    { 2L, "WEA", "Weapons" },
                    { 3L, "LIA", "Live Animals" },
                    { 4L, "CAP", "Cautious Parcels" },
                    { 5L, "REF", "Refrigerated Goods" }
                });

            migrationBuilder.UpdateData(
                table: "RouteConfigurations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Value",
                value: "3");

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 50L,
                column: "Destination",
                value: "WAD");

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "Id", "Destination", "NumberOfSegments", "Start" },
                values: new object[] { 84L, "KAP", 4, "HVA" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoodTypes");

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.UpdateData(
                table: "RouteConfigurations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Value",
                value: "4");

            migrationBuilder.UpdateData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 50L,
                column: "Destination",
                value: "WAI");
        }
    }
}
