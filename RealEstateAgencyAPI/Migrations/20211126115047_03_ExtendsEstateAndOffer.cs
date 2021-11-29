using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstateAgencyAPI.Migrations
{
    public partial class _03_ExtendsEstateAndOffer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "offer_name",
                table: "offers",
                type: "varchar(150)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "price_for_meter",
                table: "offers",
                type: "decimal(8,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "administration_tax",
                table: "estates",
                type: "decimal(8,2)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "has_rent",
                table: "estates",
                type: "bit(1)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "rent",
                table: "estates",
                type: "decimal(8,2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "offer_name",
                table: "offers");

            migrationBuilder.DropColumn(
                name: "price_for_meter",
                table: "offers");

            migrationBuilder.DropColumn(
                name: "administration_tax",
                table: "estates");

            migrationBuilder.DropColumn(
                name: "has_rent",
                table: "estates");

            migrationBuilder.DropColumn(
                name: "rent",
                table: "estates");
        }
    }
}
