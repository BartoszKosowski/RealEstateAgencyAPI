using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstateAgencyAPI.Migrations
{
    public partial class _34_DeleteViewsAndPromotedFieldsFromOffers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "promoted",
                table: "offers");

            migrationBuilder.DropColumn(
                name: "views",
                table: "offers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "promoted",
                table: "offers",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "views",
                table: "offers",
                type: "int",
                nullable: true);
        }
    }
}
