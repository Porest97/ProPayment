using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProPayment.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arena",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArenaName = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arena", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AwayTeam",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AwayTeamName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwayTeam", x => x.Id);
                });

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
                name: "HomeTeam",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HomeTeamName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeTeam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MatchFee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Series = table.Column<string>(nullable: true),
                    SeriesAgeGroupe = table.Column<string>(nullable: true),
                    MatchLength = table.Column<string>(nullable: true),
                    HDFee = table.Column<int>(nullable: true),
                    LDFee = table.Column<int>(nullable: true),
                    SeriesCategory = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchFee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Referee1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ssn = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(nullable: true),
                    RefNumber = table.Column<int>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referee1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Referee2",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ssn = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(nullable: true),
                    RefNumber = table.Column<int>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referee2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Referee3",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ssn = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(nullable: true),
                    RefNumber = table.Column<int>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referee3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Referee4",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ssn = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(nullable: true),
                    RefNumber = table.Column<int>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referee4", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefereeFee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RefereeFeeName = table.Column<string>(nullable: true),
                    RefereeFeeCategory = table.Column<string>(nullable: true),
                    RefereeFeeValue = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefereeFee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sport",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SportName = table.Column<string>(nullable: true),
                    KcalPerMinute = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tournament",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TournamentName = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournament", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PROWorkouts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StartDateTime = table.Column<DateTime>(nullable: false),
                    EndDateTime = table.Column<DateTime>(nullable: false),
                    SportId = table.Column<int>(nullable: true),
                    WorkoutDuration = table.Column<double>(nullable: true),
                    WorkoutDistance = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROWorkouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PROWorkouts_Sport_SportId",
                        column: x => x.SportId,
                        principalTable: "Sport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CupOnlineMatch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MatchNumberCupOnline = table.Column<int>(nullable: true),
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
                    MatchNumberTSM = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CupOnlineMatch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CupOnlineMatch_Tournament_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournament",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentVerification",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ssn = table.Column<string>(nullable: true),
                    RefName = table.Column<string>(nullable: true),
                    NumberOfMatches = table.Column<int>(nullable: true),
                    NumberOfAsHD = table.Column<int>(nullable: true),
                    NumberOfAsLD = table.Column<int>(nullable: true),
                    FeeHD = table.Column<int>(nullable: true),
                    FeeLD = table.Column<int>(nullable: true),
                    Fee = table.Column<int>(nullable: true),
                    TravelKost = table.Column<int>(nullable: true),
                    LateMatchStart = table.Column<int>(nullable: false),
                    Alowance = table.Column<int>(nullable: true),
                    TotalPayment = table.Column<int>(nullable: true),
                    BankAccountNumber = table.Column<string>(nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Match",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MatchNumber = table.Column<int>(nullable: true),
                    MatchDateTime = table.Column<DateTime>(nullable: false),
                    ArenaId = table.Column<int>(nullable: true),
                    HomeTeamId = table.Column<int>(nullable: true),
                    AwayTeamId = table.Column<int>(nullable: true),
                    HomeTeamScore = table.Column<int>(nullable: true),
                    AwayTeamScore = table.Column<int>(nullable: true),
                    RefereeId = table.Column<int>(nullable: true),
                    Referee1Id = table.Column<int>(nullable: true),
                    Referee2Id = table.Column<int>(nullable: true),
                    Referee3Id = table.Column<int>(nullable: true),
                    Referee4Id = table.Column<int>(nullable: true),
                    TournamentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Match", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Match_Arena_ArenaId",
                        column: x => x.ArenaId,
                        principalTable: "Arena",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Match_AwayTeam_AwayTeamId",
                        column: x => x.AwayTeamId,
                        principalTable: "AwayTeam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Match_HomeTeam_HomeTeamId",
                        column: x => x.HomeTeamId,
                        principalTable: "HomeTeam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Match_Referee1_Referee1Id",
                        column: x => x.Referee1Id,
                        principalTable: "Referee1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Match_Referee2_Referee2Id",
                        column: x => x.Referee2Id,
                        principalTable: "Referee2",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Match_Referee3_Referee3Id",
                        column: x => x.Referee3Id,
                        principalTable: "Referee3",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Match_Referee4_Referee4Id",
                        column: x => x.Referee4Id,
                        principalTable: "Referee4",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Match_Tournament_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournament",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Receipt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MatchDateTime = table.Column<DateTime>(nullable: false),
                    ArenaId = table.Column<int>(nullable: true),
                    HockeyMatchId = table.Column<int>(nullable: true),
                    RefereeId = table.Column<int>(nullable: true),
                    MatchName = table.Column<string>(nullable: true),
                    Fee = table.Column<double>(nullable: true),
                    Alowence = table.Column<double>(nullable: true),
                    TravelDistance = table.Column<double>(nullable: true),
                    TravelCost = table.Column<double>(nullable: true),
                    LateMatchStart = table.Column<double>(nullable: true),
                    TotalPayment = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receipt_Arena_ArenaId",
                        column: x => x.ArenaId,
                        principalTable: "Arena",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Receipt_HockeyMatch_HockeyMatchId",
                        column: x => x.HockeyMatchId,
                        principalTable: "HockeyMatch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                });

            migrationBuilder.CreateTable(
                name: "Referee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ssn = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    EMail = table.Column<string>(nullable: true),
                    RefNumber = table.Column<int>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PROMatchId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referee", x => x.Id);
                });

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
                name: "IX_CupOnlineMatch_TournamentId",
                table: "CupOnlineMatch",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_Match_ArenaId",
                table: "Match",
                column: "ArenaId");

            migrationBuilder.CreateIndex(
                name: "IX_Match_AwayTeamId",
                table: "Match",
                column: "AwayTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Match_HomeTeamId",
                table: "Match",
                column: "HomeTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Match_Referee1Id",
                table: "Match",
                column: "Referee1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Match_Referee2Id",
                table: "Match",
                column: "Referee2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Match_Referee3Id",
                table: "Match",
                column: "Referee3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Match_Referee4Id",
                table: "Match",
                column: "Referee4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Match_RefereeId",
                table: "Match",
                column: "RefereeId");

            migrationBuilder.CreateIndex(
                name: "IX_Match_TournamentId",
                table: "Match",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentVerification_TournamentId",
                table: "PaymentVerification",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_PROMatch_RefereeId",
                table: "PROMatch",
                column: "RefereeId");

            migrationBuilder.CreateIndex(
                name: "IX_PROMatch_TournamentId",
                table: "PROMatch",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_PROWorkouts_SportId",
                table: "PROWorkouts",
                column: "SportId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_ArenaId",
                table: "Receipt",
                column: "ArenaId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_HockeyMatchId",
                table: "Receipt",
                column: "HockeyMatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_RefereeId",
                table: "Receipt",
                column: "RefereeId");

            migrationBuilder.CreateIndex(
                name: "IX_Referee_PROMatchId",
                table: "Referee",
                column: "PROMatchId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Referee_RefereeId",
                table: "Match",
                column: "RefereeId",
                principalTable: "Referee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Receipt_Referee_RefereeId",
                table: "Receipt",
                column: "RefereeId",
                principalTable: "Referee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RefereeReceipt_Referee_RefereeId",
                table: "RefereeReceipt",
                column: "RefereeId",
                principalTable: "Referee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_PROMatch_Tournament_TournamentId",
                table: "PROMatch");

            migrationBuilder.DropForeignKey(
                name: "FK_PROMatch_Referee_RefereeId",
                table: "PROMatch");

            migrationBuilder.DropTable(
                name: "CupOnlineMatch");

            migrationBuilder.DropTable(
                name: "Match");

            migrationBuilder.DropTable(
                name: "MatchFee");

            migrationBuilder.DropTable(
                name: "PaymentVerification");

            migrationBuilder.DropTable(
                name: "PROWorkouts");

            migrationBuilder.DropTable(
                name: "Receipt");

            migrationBuilder.DropTable(
                name: "RefereeReceipt");

            migrationBuilder.DropTable(
                name: "AwayTeam");

            migrationBuilder.DropTable(
                name: "HomeTeam");

            migrationBuilder.DropTable(
                name: "Referee1");

            migrationBuilder.DropTable(
                name: "Referee2");

            migrationBuilder.DropTable(
                name: "Referee3");

            migrationBuilder.DropTable(
                name: "Referee4");

            migrationBuilder.DropTable(
                name: "Sport");

            migrationBuilder.DropTable(
                name: "Arena");

            migrationBuilder.DropTable(
                name: "HockeyMatch");

            migrationBuilder.DropTable(
                name: "RefereeFee");

            migrationBuilder.DropTable(
                name: "Tournament");

            migrationBuilder.DropTable(
                name: "Referee");

            migrationBuilder.DropTable(
                name: "PROMatch");
        }
    }
}
