using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CES.Database.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "RouteConfigurations",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Key = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RouteConfigurations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Start = table.Column<string>(nullable: true),
                    Destination = table.Column<string>(nullable: true),
                    NumberOfSegments = table.Column<int>(nullable: false),
                    Transportation = table.Column<int>(nullable: false),
                    TotalTime = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1L, "DKO", "DE KANARISKE OER" },
                    { 32L, "DRA", "DRAGEBJERGET" },
                    { 31L, "ZAN", "ZANZIBAR" },
                    { 30L, "VIS", "VICTORIASOEN" },
                    { 29L, "ADA", "ADDIS ABEBA" },
                    { 28L, "BAG", "BAHREL GHAZAL" },
                    { 27L, "VIF", "VICTORIAFALDENE" },
                    { 26L, "KAB", "KABALO" },
                    { 25L, "LUA", "LUANDA" },
                    { 24L, "TRI", "TRIPOLI" },
                    { 23L, "OMD", "OMDURMAN" },
                    { 22L, "CON", "CONGO" },
                    { 20L, "WAD", "WADAI" },
                    { 19L, "TIM", "TIMBUKTU" },
                    { 18L, "SAH", "SAHARA" },
                    { 17L, "MAR", "MARRAKESH" },
                    { 21L, "DAR", "DARFUR" },
                    { 15L, "SIL", "SIERRA LEONE" },
                    { 2L, "TUN", "TUNIS'" },
                    { 3L, "SUA", "SUAKIN" },
                    { 4L, "TAN", "TANGER" },
                    { 16L, "DAK", "DAKAR" },
                    { 6L, "KAG", "KAP GUARDAFUI" },
                    { 7L, "AMA", "AMATAVE" },
                    { 8L, "MOC", "MOCAMBIQUE" },
                    { 5L, "CAI", "CAIRO" },
                    { 10L, "KAP", "KAPSTADEN" },
                    { 11L, "HVA", "HVALBUGTEN" },
                    { 12L, "HEL", "ST. HELENA" },
                    { 13L, "SLA", "SLAVEKYSTEN" },
                    { 14L, "GUL", "GULDKYSTEN" },
                    { 9L, "KAM", "KAP ST.MARIE" }
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

            migrationBuilder.InsertData(
                table: "RouteConfigurations",
                columns: new[] { "Id", "Key", "Value" },
                values: new object[,]
                {
                    { 1L, "PriceBetweenTwoSegments", "3" },
                    { 3L, "ShipProviderURL", "" },
                    { 2L, "MaxiumWeight", "40" },
                    { 4L, "AirProviderURL", "" },
                    { 5L, "TimeBetweenTwoSegments", "4" }
                });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "Id", "Destination", "NumberOfSegments", "Start", "TotalTime", "Transportation" },
                values: new object[,]
                {
                    { 6L, "SAH", 5, "TAN", 0, 0 },
                    { 66L, "MOC", 5, "VIF", 0, 0 },
                    { 65L, "DRA", 3, "VIF", 0, 0 },
                    { 64L, "HVA", 4, "VIF", 0, 0 },
                    { 63L, "LUA", 4, "KAB", 0, 0 },
                    { 62L, "VIS", 4, "KAB", 0, 0 },
                    { 61L, "DRA", 11, "LUA", 0, 0 },
                    { 60L, "VIF", 11, "LUA", 0, 0 },
                    { 59L, "MOC", 10, "LUA", 0, 0 },
                    { 58L, "KAB", 0, "LUA", 0, 0 },
                    { 57L, "CON", 3, "LUA", 0, 0 },
                    { 56L, "OMD", 6, "TRI", 0, 0 },
                    { 55L, "TUN", 3, "TRI", 0, 0 },
                    { 54L, "TRI", 6, "OMD", 0, 0 },
                    { 53L, "DAR", 3, "OMD", 0, 0 },
                    { 52L, "CAI", 4, "OMD", 0, 0 },
                    { 51L, "SLA", 5, "CON", 0, 0 },
                    { 50L, "WAD", 6, "CON", 0, 0 },
                    { 67L, "LUA", 11, "VIF", 0, 0 },
                    { 49L, "DAR", 6, "CON", 0, 0 },
                    { 68L, "VIS", 2, "BAG", 0, 0 },
                    { 70L, "VIS", 3, "ADA", 0, 0 },
                    { 1L, "TRI", 3, "TUN", 0, 0 },
                    { 2L, "TAN", 5, "TUN", 0, 0 },
                    { 3L, "ADA", 3, "SUA", 0, 0 },
                    { 84L, "KAP", 4, "HVA", 0, 0 },
                    { 83L, "LUA", 11, "DRA", 0, 0 },
                    { 82L, "MOC", 4, "DRA", 0, 0 },
                    { 81L, "VIF", 3, "DRA", 0, 0 },
                    { 80L, "VIS", 5, "ZAN", 0, 0 },
                    { 79L, "MOC", 3, "ZAN", 0, 0 },
                    { 78L, "KAG", 6, "ZAN", 0, 0 },
                    { 77L, "ZAN", 5, "VIS", 0, 0 },
                    { 76L, "MOC", 6, "VIS", 0, 0 },
                    { 75L, "ADA", 3, "VIS", 0, 0 },
                    { 74L, "BAG", 2, "VIS", 0, 0 },
                    { 73L, "KAB", 4, "VIS", 0, 0 },
                    { 72L, "SUA", 3, "ADA", 0, 0 },
                    { 71L, "KAG", 3, "ADA", 0, 0 },
                    { 69L, "DAR", 2, "BAG", 0, 0 },
                    { 48L, "LUA", 3, "CON", 0, 0 },
                    { 47L, "SLA", 7, "DAR", 0, 0 },
                    { 46L, "CON", 6, "DAR", 0, 0 },
                    { 23L, "SIL", 5, "GUL", 0, 0 },
                    { 22L, "TIM", 4, "GUL", 0, 0 },
                    { 21L, "TIM", 5, "SLA", 0, 0 },
                    { 20L, "WAD", 7, "SLA", 0, 0 },
                    { 19L, "DAR", 7, "SLA", 0, 0 },
                    { 18L, "CON", 5, "SLA", 0, 0 },
                    { 17L, "VIF", 4, "HVA", 0, 0 },
                    { 16L, "HVA", 4, "KAP", 0, 0 },
                    { 15L, "LUA", 10, "MOC", 0, 0 },
                    { 14L, "VIF", 5, "MOC", 0, 0 },
                    { 13L, "DRA", 4, "MOC", 0, 0 },
                    { 12L, "VIS", 6, "MOC", 0, 0 },
                    { 11L, "ZAN", 3, "MOC", 0, 0 },
                    { 10L, "ZAN", 6, "KAG", 0, 0 },
                    { 9L, "ADA", 3, "KAG", 0, 0 },
                    { 8L, "OMD", 4, "CAI", 0, 0 },
                    { 7L, "MAR", 2, "TAN", 0, 0 },
                    { 24L, "GUL", 5, "SIL", 0, 0 },
                    { 25L, "TIM", 5, "SIL", 0, 0 },
                    { 4L, "DAR", 4, "SUA", 0, 0 },
                    { 27L, "SIL", 4, "DAK", 0, 0 },
                    { 45L, "WAD", 4, "DAR", 0, 0 },
                    { 44L, "SAH", 8, "DAR", 0, 0 },
                    { 43L, "OMD", 3, "DAR", 0, 0 },
                    { 42L, "SUA", 4, "DAR", 0, 0 },
                    { 41L, "BAG", 2, "DAR", 0, 0 },
                    { 40L, "SLA", 7, "WAD", 0, 0 },
                    { 39L, "CON", 6, "WAD", 0, 0 },
                    { 38L, "DAR", 4, "WAD", 0, 0 },
                    { 5L, "TUN", 5, "TAN", 0, 0 },
                    { 37L, "SIL", 5, "TIM", 0, 0 },
                    { 35L, "SLA", 5, "TIM", 0, 0 },
                    { 34L, "DAR", 8, "SAH", 0, 0 },
                    { 33L, "MAR", 5, "SAH", 0, 0 },
                    { 32L, "TAN", 5, "SAH", 0, 0 },
                    { 31L, "SAH", 5, "MAR", 0, 0 },
                    { 30L, "TAN", 2, "MAR", 0, 0 },
                    { 29L, "DAK", 8, "MAR", 0, 0 },
                    { 28L, "MAR", 8, "DAK", 0, 0 },
                    { 36L, "GUL", 4, "TIM", 0, 0 },
                    { 26L, "DAK", 4, "SIL", 0, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "GoodTypes");

            migrationBuilder.DropTable(
                name: "RouteConfigurations");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
