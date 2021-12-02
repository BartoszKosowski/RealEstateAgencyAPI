using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstateAgencyAPI.Migrations
{
    public partial class _06_ImproveEstates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "administration_tax",
                table: "estates");

            migrationBuilder.DropColumn(
                name: "has_rent",
                table: "estates");

            migrationBuilder.DropColumn(
                name: "rent",
                table: "estates");

            migrationBuilder.DropColumn(
                name: "type_of_bathroom",
                table: "estates");

            migrationBuilder.AddColumn<bool>(
                name: "basement",
                table: "estates",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "electricity",
                table: "estates",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "fence",
                table: "estates",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "garage",
                table: "estates",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "heating",
                table: "estates",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "plot",
                table: "estates",
                type: "decimal(7,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "roof_type",
                table: "estates",
                type: "varchar(75)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "sewers",
                table: "estates",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "water_connection",
                table: "estates",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "google_maps_url",
                table: "addresses",
                type: "varchar(500)",
                maxLength: 500,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "basement",
                table: "estates");

            migrationBuilder.DropColumn(
                name: "electricity",
                table: "estates");

            migrationBuilder.DropColumn(
                name: "fence",
                table: "estates");

            migrationBuilder.DropColumn(
                name: "garage",
                table: "estates");

            migrationBuilder.DropColumn(
                name: "heating",
                table: "estates");

            migrationBuilder.DropColumn(
                name: "plot",
                table: "estates");

            migrationBuilder.DropColumn(
                name: "roof_type",
                table: "estates");

            migrationBuilder.DropColumn(
                name: "sewers",
                table: "estates");

            migrationBuilder.DropColumn(
                name: "water_connection",
                table: "estates");

            migrationBuilder.DropColumn(
                name: "google_maps_url",
                table: "addresses");

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

            migrationBuilder.AddColumn<string>(
                name: "type_of_bathroom",
                table: "estates",
                type: "varchar(45)",
                maxLength: 45,
                nullable: true);
        }
    }
}
