using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProPayment.Migrations
{
    public partial class PROMatchImplemented : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PROMatchId",
                table: "Referee",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PROMatch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PROMatchNumber = table.Column<int>(nullable: true),
                    MatchDescription = table.Column<string>(nullable: true),
                    MatchDateTime = table.Column<DateTime>(nullable: false),
                    Arena = table.Column<string>(nullable: true),
                    HomeTeam = table.Column<string>(nullable: true),
                    AwayTeam = table.Column<string>(nullable: true),
                    ScoreHomeTeam = table.Column<int>(nullable: true),
                    ScoreAwayTeam = table.Column<int>(nullable: true),
                    Ref1 = table.Column<string>(nullable: true),
                    Ref2 = table.Column<string>(nullable: true),
                    Ref3 = table.Column<string>(nullable: true),
                    Ref4 = table.Column<string>(nullable: true),
                    TournamentId = table.Column<int>(nullable: true),
                    MatchNumberTSM = table.Column<int>(nullable: true),
                    RefereeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROMatch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PROMatch_Referee_RefereeId",
                        column: x => x.RefereeId,
                        principalTable: "Referee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROMatch_Tournament_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournament",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Referee_PROMatchId",
                table: "Referee",
                column: "PROMatchId");

            migrationBuilder.CreateIndex(
                name: "IX_PROMatch_RefereeId",
                table: "PROMatch",
                column: "RefereeId");

            migrationBuilder.CreateIndex(
                name: "IX_PROMatch_TournamentId",
                table: "PROMatch",
                column: "TournamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Referee_PROMatch_PROMatchId",
                table: "Referee",
                column: "PROMatchId",
                principalTable: "PROMatch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Referee_PROMatch_PROMatchId",
                table: "Referee");

            migrationBuilder.DropTable(
                name: "PROMatch");

            migrationBuilder.DropIndex(
                name: "IX_Referee_PROMatchId",
                table: "Referee");

            migrationBuilder.DropColumn(
                name: "PROMatchId",
                table: "Referee");
        }
    }
}
