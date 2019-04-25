using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProPayment.Migrations
{
    public partial class RefReceiptImplemented : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HockeyMatch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MatchName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HockeyMatch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefereeReceipt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HockeyMatchId = table.Column<int>(nullable: false),
                    RefereeId = table.Column<int>(nullable: false),
                    RefereeFeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefereeReceipt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefereeReceipt_HockeyMatch_HockeyMatchId",
                        column: x => x.HockeyMatchId,
                        principalTable: "HockeyMatch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RefereeReceipt_RefereeFee_RefereeFeeId",
                        column: x => x.RefereeFeeId,
                        principalTable: "RefereeFee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RefereeReceipt_Referee_RefereeId",
                        column: x => x.RefereeId,
                        principalTable: "Referee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RefereeReceipt_HockeyMatchId",
                table: "RefereeReceipt",
                column: "HockeyMatchId");

            migrationBuilder.CreateIndex(
                name: "IX_RefereeReceipt_RefereeFeeId",
                table: "RefereeReceipt",
                column: "RefereeFeeId");

            migrationBuilder.CreateIndex(
                name: "IX_RefereeReceipt_RefereeId",
                table: "RefereeReceipt",
                column: "RefereeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefereeReceipt");

            migrationBuilder.DropTable(
                name: "HockeyMatch");
        }
    }
}
