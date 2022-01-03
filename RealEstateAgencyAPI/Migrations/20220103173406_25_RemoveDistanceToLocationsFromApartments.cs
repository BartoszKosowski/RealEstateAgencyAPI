using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstateAgencyAPI.Migrations
{
    public partial class _25_RemoveDistanceToLocationsFromApartments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "distance_to_center",
                table: "apartments");

            migrationBuilder.DropColumn(
                name: "distance_to_coast",
                table: "apartments");

            migrationBuilder.DropColumn(
                name: "distance_to_forest",
                table: "apartments");

            migrationBuilder.DropColumn(
                name: "distance_to_highway",
                table: "apartments");

            migrationBuilder.DropColumn(
                name: "distance_to_lake",
                table: "apartments");

            migrationBuilder.DropColumn(
                name: "distance_to_mall",
                table: "apartments");

            migrationBuilder.DropColumn(
                name: "distance_to_mountains",
                table: "apartments");

            migrationBuilder.DropColumn(
                name: "distance_to_river",
                table: "apartments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "distance_to_center",
                table: "apartments",
                type: "decimal(3,1)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "distance_to_coast",
                table: "apartments",
                type: "decimal(3,1)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "distance_to_forest",
                table: "apartments",
                type: "decimal(3,1)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "distance_to_highway",
                table: "apartments",
                type: "decimal(3,1)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "distance_to_lake",
                table: "apartments",
                type: "decimal(3,1)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "distance_to_mall",
                table: "apartments",
                type: "decimal(3,1)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "distance_to_mountains",
                table: "apartments",
                type: "decimal(3,1)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "distance_to_river",
                table: "apartments",
                type: "decimal(3,1)",
                nullable: true);
        }
    }
}
