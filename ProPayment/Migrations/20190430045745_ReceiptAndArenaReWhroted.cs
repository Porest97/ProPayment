using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProPayment.Migrations
{
    public partial class ReceiptAndArenaReWhroted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArenaId",
                table: "Receipt",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArenaId1",
                table: "Receipt",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TravelDistance",
                table: "Receipt",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TravelFee",
                table: "Receipt",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_ArenaId1",
                table: "Receipt",
                column: "ArenaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Receipt_Arena_ArenaId1",
                table: "Receipt",
                column: "ArenaId1",
                principalTable: "Arena",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receipt_Arena_ArenaId1",
                table: "Receipt");

            migrationBuilder.DropTable(
                name: "Arena");

            migrationBuilder.DropIndex(
                name: "IX_Receipt_ArenaId1",
                table: "Receipt");

            migrationBuilder.DropColumn(
                name: "ArenaId",
                table: "Receipt");

            migrationBuilder.DropColumn(
                name: "ArenaId1",
                table: "Receipt");

            migrationBuilder.DropColumn(
                name: "TravelDistance",
                table: "Receipt");

            migrationBuilder.DropColumn(
                name: "TravelFee",
                table: "Receipt");
        }
    }
}
