using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProPayment.Migrations
{
    public partial class Receipts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Receipt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MatchDateTime = table.Column<DateTime>(nullable: false),
                    HockeyMatchId = table.Column<int>(nullable: true),
                    RefereeId = table.Column<int>(nullable: true),
                    MatchName = table.Column<string>(nullable: true),
                    Fee = table.Column<double>(nullable: true),
                    Alowence = table.Column<double>(nullable: true),
                    TravelCost = table.Column<double>(nullable: true),
                    LateMatchStart = table.Column<double>(nullable: true),
                    TotalPayment = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receipt_HockeyMatch_HockeyMatchId",
                        column: x => x.HockeyMatchId,
                        principalTable: "HockeyMatch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Receipt_Referee_RefereeId",
                        column: x => x.RefereeId,
                        principalTable: "Referee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_HockeyMatchId",
                table: "Receipt",
                column: "HockeyMatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_RefereeId",
                table: "Receipt",
                column: "RefereeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receipt");
        }
    }
}
