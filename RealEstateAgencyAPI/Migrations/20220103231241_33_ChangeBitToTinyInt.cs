using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstateAgencyAPI.Migrations
{
    public partial class _33_ChangeBitToTinyInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "promoted",
                table: "offers",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_river",
                table: "estates",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_mountains",
                table: "estates",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_mall",
                table: "estates",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_lake",
                table: "estates",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_highway",
                table: "estates",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_forest",
                table: "estates",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_coast",
                table: "estates",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_center",
                table: "estates",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "has_balcony",
                table: "estates",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "furnishings",
                table: "estates",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_river",
                table: "apartments",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_mountains",
                table: "apartments",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_mall",
                table: "apartments",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_lake",
                table: "apartments",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_highway",
                table: "apartments",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_forest",
                table: "apartments",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_coast",
                table: "apartments",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_center",
                table: "apartments",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit(1)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "promoted",
                table: "offers",
                type: "bit(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_river",
                table: "estates",
                type: "bit(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_mountains",
                table: "estates",
                type: "bit(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_mall",
                table: "estates",
                type: "bit(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_lake",
                table: "estates",
                type: "bit(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_highway",
                table: "estates",
                type: "bit(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_forest",
                table: "estates",
                type: "bit(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_coast",
                table: "estates",
                type: "bit(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_center",
                table: "estates",
                type: "bit(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "has_balcony",
                table: "estates",
                type: "bit(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "furnishings",
                table: "estates",
                type: "bit(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_river",
                table: "apartments",
                type: "bit(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_mountains",
                table: "apartments",
                type: "bit(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_mall",
                table: "apartments",
                type: "bit(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_lake",
                table: "apartments",
                type: "bit(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_highway",
                table: "apartments",
                type: "bit(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_forest",
                table: "apartments",
                type: "bit(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_coast",
                table: "apartments",
                type: "bit(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "near_center",
                table: "apartments",
                type: "bit(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);
        }
    }
}
