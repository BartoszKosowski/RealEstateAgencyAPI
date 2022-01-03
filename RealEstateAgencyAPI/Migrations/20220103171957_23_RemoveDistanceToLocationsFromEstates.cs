using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstateAgencyAPI.Migrations
{
    public partial class _23_RemoveDistanceToLocationsFromEstates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "distance_to_center",
                table: "estates");

            migrationBuilder.DropColumn(
                name: "distance_to_coast",
                table: "estates");

            migrationBuilder.DropColumn(
                name: "distance_to_forest",
                table: "estates");

            migrationBuilder.DropColumn(
                name: "distance_to_highway",
                table: "estates");

            migrationBuilder.DropColumn(
                name: "distance_to_lake",
                table: "estates");

            migrationBuilder.DropColumn(
                name: "distance_to_mall",
                table: "estates");

            migrationBuilder.DropColumn(
                name: "distance_to_mountains",
                table: "estates");

            migrationBuilder.DropColumn(
                name: "distance_to_river",
                table: "estates");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "distance_to_center",
                table: "estates",
                type: "decimal(3,1)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "distance_to_coast",
                table: "estates",
                type: "decimal(3,1)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "distance_to_forest",
                table: "estates",
                type: "decimal(3,1)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "distance_to_highway",
                table: "estates",
                type: "decimal(3,1)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "distance_to_lake",
                table: "estates",
                type: "decimal(3,1)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "distance_to_mall",
                table: "estates",
                type: "decimal(3,1)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "distance_to_mountains",
                table: "estates",
                type: "decimal(3,1)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "distance_to_river",
                table: "estates",
                type: "decimal(3,1)",
                nullable: true);
        }
    }
}
