using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace RealEstateAgencyAPI.Migrations
{
    public partial class _01_adding_requests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "requests",
                columns: table => new
                {
                    IdRequest = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    last_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    email = table.Column<string>(type: "varchar(75)", maxLength: 75, nullable: true),
                    phone_name = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true),
                    description = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    service = table.Column<byte>(type: "tinyint", nullable: false),
                    request_status = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.IdRequest);
                    table.ForeignKey(
                        name: "FK_request_status",
                        column: x => x.request_status,
                        principalTable: "statuses",
                        principalColumn: "id_status",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_request_trade_info",
                        column: x => x.service,
                        principalTable: "trade_info",
                        principalColumn: "id_info",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "FK_request_status_idx",
                table: "requests",
                column: "request_status");

            migrationBuilder.CreateIndex(
                name: "FK_request_trade_info_idx",
                table: "requests",
                column: "service");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "meetings");

            migrationBuilder.DropTable(
                name: "offers");

            migrationBuilder.DropTable(
                name: "photos");

            migrationBuilder.DropTable(
                name: "requests");

            migrationBuilder.DropTable(
                name: "agents");

            migrationBuilder.DropTable(
                name: "estates");

            migrationBuilder.DropTable(
                name: "addresses");

            migrationBuilder.DropTable(
                name: "statuses");

            migrationBuilder.DropTable(
                name: "trade_info");
        }
    }
}
