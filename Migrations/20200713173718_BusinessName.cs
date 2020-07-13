using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalLookupAPI.Solution.Migrations
{
    public partial class BusinessName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Businesses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Businesses");
        }
    }
}
