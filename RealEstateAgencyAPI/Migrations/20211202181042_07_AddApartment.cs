using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace RealEstateAgencyAPI.Migrations
{
    public partial class _07_AddApartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "apartment",
                table: "photos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "apartment",
                table: "offers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "has_rent",
                table: "offers",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "rent_value",
                table: "offers",
                type: "decimal(7,2)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "apartments",
                columns: table => new
                {
                    IdApartment = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    address = table.Column<int>(type: "int", nullable: true),
                    property_state = table.Column<byte>(type: "tinyint", nullable: true),
                    property_area = table.Column<decimal>(type: "decimal(7,2)", nullable: true),
                    furnishings = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    has_balcony = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    floor_number = table.Column<byte>(type: "tinyint", nullable: true),
                    number_of_rooms = table.Column<byte>(type: "tinyint", nullable: true),
                    has_bathroom = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    parking_space = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    heating = table.Column<string>(type: "varchar(100)", nullable: true),
                    inside_design = table.Column<string>(type: "varchar(100)", nullable: true),
                    kitchen_equipment = table.Column<string>(type: "varchar(500)", nullable: true),
                    bathroom_equipment = table.Column<string>(type: "varchar(500)", nullable: true),
                    building_name = table.Column<string>(type: "varchar(150)", nullable: true),
                    build_year = table.Column<int>(type: "int", nullable: true),
                    building_type = table.Column<string>(type: "varchar(100)", nullable: true),
                    number_of_floors = table.Column<byte>(type: "tinyint", nullable: true),
                    main_photo_url = table.Column<string>(type: "varchar(300)", nullable: true),
                    near_forest = table.Column<bool>(type: "bit(1)", nullable: true),
                    near_river = table.Column<bool>(type: "bit(1)", nullable: true),
                    near_mountains = table.Column<bool>(type: "bit(1)", nullable: true),
                    near_highway = table.Column<bool>(type: "bit(1)", nullable: true),
                    near_center = table.Column<bool>(type: "bit(1)", nullable: true),
                    near_mall = table.Column<bool>(type: "bit(1)", nullable: true),
                    near_lake = table.Column<bool>(type: "bit(1)", nullable: true),
                    near_coast = table.Column<bool>(type: "bit(1)", nullable: true),
                    distance_to_forest = table.Column<decimal>(type: "decimal(3,1)", nullable: true),
                    distance_to_river = table.Column<decimal>(type: "decimal(3,1)", nullable: true),
                    distance_to_mountains = table.Column<decimal>(type: "decimal(3,1)", nullable: true),
                    distance_to_highway = table.Column<decimal>(type: "decimal(3,1)", nullable: true),
                    distance_to_center = table.Column<decimal>(type: "decimal(3,1)", nullable: true),
                    distance_to_mall = table.Column<decimal>(type: "decimal(3,1)", nullable: true),
                    distance_to_lake = table.Column<decimal>(type: "decimal(3,1)", nullable: true),
                    distance_to_coast = table.Column<decimal>(type: "decimal(3,1)", nullable: true),
                    other_details = table.Column<string>(type: "text", maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.IdApartment);
                    table.ForeignKey(
                        name: "FK_apartment_address",
                        column: x => x.address,
                        principalTable: "addresses",
                        principalColumn: "id_address",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_apartment_status",
                        column: x => x.property_state,
                        principalTable: "statuses",
                        principalColumn: "id_status",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_photos_apartment",
                table: "photos",
                column: "apartment");

            migrationBuilder.CreateIndex(
                name: "IX_offers_apartment",
                table: "offers",
                column: "apartment");

            migrationBuilder.CreateIndex(
                name: "FK_apartment_state_idx",
                table: "apartments",
                column: "property_state");

            migrationBuilder.CreateIndex(
                name: "FK_apartment_trade_info_idx",
                table: "apartments",
                column: "building_type");

            migrationBuilder.CreateIndex(
                name: "id_apartment_UNIQUE",
                table: "apartments",
                column: "IdApartment",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_apartments_address",
                table: "apartments",
                column: "address");

            migrationBuilder.AddForeignKey(
                name: "FK_offer_apartment",
                table: "offers",
                column: "apartment",
                principalTable: "apartments",
                principalColumn: "IdApartment",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_photo_apartment",
                table: "photos",
                column: "apartment",
                principalTable: "apartments",
                principalColumn: "IdApartment",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_offer_apartment",
                table: "offers");

            migrationBuilder.DropForeignKey(
                name: "FK_photo_apartment",
                table: "photos");

            migrationBuilder.DropTable(
                name: "apartments");

            migrationBuilder.DropIndex(
                name: "IX_photos_apartment",
                table: "photos");

            migrationBuilder.DropIndex(
                name: "IX_offers_apartment",
                table: "offers");

            migrationBuilder.DropColumn(
                name: "apartment",
                table: "photos");

            migrationBuilder.DropColumn(
                name: "apartment",
                table: "offers");

            migrationBuilder.DropColumn(
                name: "has_rent",
                table: "offers");

            migrationBuilder.DropColumn(
                name: "rent_value",
                table: "offers");
        }
    }
}
