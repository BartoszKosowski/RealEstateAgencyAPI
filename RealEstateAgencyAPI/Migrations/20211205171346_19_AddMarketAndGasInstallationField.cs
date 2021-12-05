using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstateAgencyAPI.Migrations
{
    public partial class _19_AddMarketAndGasInstallationField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "market",
                table: "offers",
                type: "varchar(75)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "gas_installation",
                table: "estates",
                type: "tinyint(1)",
                nullable: true
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "market",
                table: "offers");

            migrationBuilder.DropColumn(
                name: "gas_installation",
                table: "estates"
                );
        }
    }
}
