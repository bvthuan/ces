using Microsoft.EntityFrameworkCore.Migrations;

namespace CES.Database.Migrations
{
    public partial class addroutedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "Id", "Destination", "NumberOfSegments", "Start" },
                values: new object[,]
                {
                    { 1L, "TRI", 3, "TUN" },
                    { 60L, "VIF", 11, "LUA" },
                    { 59L, "MOC", 10, "LUA" },
                    { 58L, "KAB", 0, "LUA" },
                    { 57L, "CON", 3, "LUA" },
                    { 56L, "OMD", 6, "TRI" },
                    { 55L, "TUN", 3, "TRI" },
                    { 54L, "TRI", 6, "OMD" },
                    { 53L, "DAR", 3, "OMD" },
                    { 52L, "CAI", 4, "OMD" },
                    { 51L, "SLA", 5, "CON" },
                    { 50L, "WAI", 6, "CON" },
                    { 49L, "DAR", 6, "CON" },
                    { 48L, "LUA", 3, "CON" },
                    { 47L, "SLA", 7, "DAR" },
                    { 46L, "CON", 6, "DAR" },
                    { 45L, "WAD", 4, "DAR" },
                    { 44L, "SAH", 8, "DAR" },
                    { 61L, "DRA", 11, "LUA" },
                    { 43L, "OMD", 3, "DAR" },
                    { 62L, "VIS", 4, "KAB" },
                    { 64L, "HVA", 4, "VIF" },
                    { 81L, "VIF", 3, "DRA" },
                    { 80L, "VIS", 5, "ZAN" },
                    { 79L, "MOC", 3, "ZAN" },
                    { 78L, "KAG", 6, "ZAN" },
                    { 77L, "ZAN", 5, "VIS" },
                    { 76L, "MOC", 6, "VIS" },
                    { 75L, "ADA", 3, "VIS" },
                    { 74L, "BAG", 2, "VIS" },
                    { 73L, "KAB", 4, "VIS" },
                    { 72L, "SUA", 3, "ADA" },
                    { 71L, "KAG", 3, "ADA" },
                    { 70L, "VIS", 3, "ADA" },
                    { 69L, "DAR", 2, "BAG" },
                    { 68L, "VIS", 2, "BAG" },
                    { 67L, "LUA", 11, "VIF" },
                    { 66L, "MOC", 5, "VIF" },
                    { 65L, "DRA", 3, "VIF" },
                    { 63L, "LUA", 4, "KAB" },
                    { 82L, "MOC", 4, "DRA" },
                    { 42L, "SUA", 4, "DAR" },
                    { 40L, "SLA", 7, "WAD" },
                    { 18L, "CON", 5, "SLA" },
                    { 17L, "VIF", 4, "HVA" },
                    { 16L, "HVA", 4, "KAP" },
                    { 15L, "LUA", 10, "MOC" },
                    { 14L, "VIF", 5, "MOC" },
                    { 13L, "DRA", 4, "MOC" },
                    { 12L, "VIS", 6, "MOC" },
                    { 11L, "ZAN", 3, "MOC" },
                    { 10L, "ZAN", 6, "KAG" },
                    { 9L, "ADA", 3, "KAG" },
                    { 8L, "OMD", 4, "CAI" },
                    { 7L, "MAR", 2, "TAN" },
                    { 6L, "SAH", 5, "TAN" },
                    { 5L, "TUN", 5, "TAN" },
                    { 4L, "DAR", 4, "SUA" },
                    { 3L, "ADA", 3, "SUA" },
                    { 2L, "TAN", 5, "TUN" },
                    { 19L, "DAR", 7, "SLA" },
                    { 41L, "BAG", 2, "DAR" },
                    { 20L, "WAD", 7, "SLA" },
                    { 22L, "TIM", 4, "GUL" },
                    { 39L, "CON", 6, "WAD" },
                    { 38L, "DAR", 4, "WAD" },
                    { 37L, "SIL", 5, "TIM" },
                    { 36L, "GUL", 4, "TIM" },
                    { 35L, "SLA", 5, "TIM" },
                    { 34L, "DAR", 8, "SAH" },
                    { 33L, "MAR", 5, "SAH" },
                    { 32L, "TAN", 5, "SAH" },
                    { 31L, "SAH", 5, "MAR" },
                    { 30L, "TAN", 2, "MAR" },
                    { 29L, "DAK", 8, "MAR" },
                    { 28L, "MAR", 8, "DAK" },
                    { 27L, "SIL", 4, "DAK" },
                    { 26L, "DAK", 4, "SIL" },
                    { 25L, "TIM", 5, "SIL" },
                    { 24L, "GUL", 5, "SIL" },
                    { 23L, "SIL", 5, "GUL" },
                    { 21L, "TIM", 5, "SLA" },
                    { 83L, "LUA", 11, "DRA" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "Id",
                keyValue: 83L);
        }
    }
}
