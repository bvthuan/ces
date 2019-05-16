using Microsoft.EntityFrameworkCore.Migrations;

namespace CES.Database.Migrations
{
    public partial class addcitylist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Cities",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "code",
                table: "Cities",
                newName: "Code");

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1L, "DKO", "DE KANARISKE OER" },
                    { 30L, "VIS", "VICTORIASOEN" },
                    { 29L, "ADA", "ADDIS ABEBA" },
                    { 28L, "BAG", "BAHREL GHAZAL" },
                    { 27L, "VIF", "VICTORIAFALDENE" },
                    { 26L, "KAB", "KABALO" },
                    { 25L, "LUA", "LUANDA" },
                    { 24L, "TRI", "TRIPOLI" },
                    { 23L, "OMD", "OMDURMAN" },
                    { 22L, "CON", "CONGO" },
                    { 21L, "DAR", "DARFUR" },
                    { 20L, "WAD", "WADAI" },
                    { 19L, "TIM", "TIMBUKTU" },
                    { 18L, "SAH", "SAHARA" },
                    { 17L, "MAR", "MARRAKESH" },
                    { 16L, "DAK", "DAKAR" },
                    { 15L, "SIL", "SIERRA LEONE" },
                    { 14L, "GUL", "GULDKYSTEN" },
                    { 13L, "SLA", "SLAVEKYSTEN" },
                    { 12L, "HEL", "ST. HELENA" },
                    { 11L, "HVA", "HVALBUGTEN" },
                    { 10L, "KAP", "KAPSTADEN" },
                    { 9L, "KAM", "KAP ST.MARIE" },
                    { 8L, "MOC", "MOCAMBIQUE" },
                    { 7L, "AMA", "AMATAVE" },
                    { 6L, "KAG", "KAP GUARDAFUI" },
                    { 5L, "CAI", "CAIRO" },
                    { 4L, "TAN", "TANGER" },
                    { 3L, "SUA", "SUAKIN" },
                    { 2L, "TUN", "TUNIS'" },
                    { 31L, "ZAN", "ZANZIBAR" },
                    { 32L, "DRA", "DRAGEBJERGET" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Cities",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Cities",
                newName: "code");
        }
    }
}
