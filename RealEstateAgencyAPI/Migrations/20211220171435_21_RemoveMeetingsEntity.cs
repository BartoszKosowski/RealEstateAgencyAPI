using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace RealEstateAgencyAPI.Migrations
{
    public partial class _21_RemoveMeetingsEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "meetings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "meetings",
                columns: table => new
                {
                    id_meetings = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    agent = table.Column<int>(type: "int", nullable: true),
                    customer_email = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: true),
                    customer_name = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: true),
                    customer_number = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: true),
                    date_of_meeting = table.Column<DateTime>(type: "datetime", nullable: false),
                    estate_address = table.Column<int>(type: "int", nullable: true),
                    in_estate = table.Column<bool>(type: "bit(1)", nullable: true),
                    other_address = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    status = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id_meetings);
                    table.ForeignKey(
                        name: "FK_meetings_address",
                        column: x => x.estate_address,
                        principalTable: "addresses",
                        principalColumn: "id_address",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_meetings_agent",
                        column: x => x.agent,
                        principalTable: "agents",
                        principalColumn: "id_agents",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_meetings_status",
                        column: x => x.status,
                        principalTable: "statuses",
                        principalColumn: "id_status",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "FK_estate_address_idx1",
                table: "meetings",
                column: "estate_address");

            migrationBuilder.CreateIndex(
                name: "FK_meetings_agent_idx",
                table: "meetings",
                column: "agent");

            migrationBuilder.CreateIndex(
                name: "FK_meetings_status_idx",
                table: "meetings",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "id_meetings_UNIQUE",
                table: "meetings",
                column: "id_meetings",
                unique: true);
        }
    }
}
