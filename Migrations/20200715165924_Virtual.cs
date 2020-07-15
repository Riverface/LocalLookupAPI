using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalLookupAPI.Migrations
{
    public partial class Virtual : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2,
                column: "CityId",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2,
                column: "CityId",
                value: 0);
        }
    }
}
