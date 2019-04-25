using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProPayment.Migrations
{
    public partial class PamntVerificationsImplemnted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentVerification",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ssn = table.Column<string>(nullable: true),
                    RefName = table.Column<string>(nullable: true),
                    NumberOfMatches = table.Column<int>(nullable: false),
                    NumberOfAsHD = table.Column<int>(nullable: false),
                    NumberOfAsLD = table.Column<int>(nullable: false),
                    FeeHD = table.Column<int>(nullable: false),
                    FeeLD = table.Column<int>(nullable: false),
                    Fee = table.Column<int>(nullable: false),
                    TravelKost = table.Column<int>(nullable: false),
                    LateMatchStart = table.Column<int>(nullable: false),
                    Alowance = table.Column<int>(nullable: false),
                    TotalPayment = table.Column<int>(nullable: false),
                    TournamentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentVerification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentVerification_Tournament_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournament",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentVerification_TournamentId",
                table: "PaymentVerification",
                column: "TournamentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentVerification");
        }
    }
}
