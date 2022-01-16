using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstateAgencyAPI.Migrations
{
    public partial class _35_DeleteOtherDetailsFromOffers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "other_details",
                table: "estates");

            migrationBuilder.DropColumn(
                name: "other_details",
                table: "apartments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "other_details",
                table: "estates",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "other_details",
                table: "apartments",
                type: "text",
                maxLength: 5000,
                nullable: true);
        }
    }
}
