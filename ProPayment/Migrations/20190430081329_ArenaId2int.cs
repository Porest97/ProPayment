using Microsoft.EntityFrameworkCore.Migrations;

namespace ProPayment.Migrations
{
    public partial class ArenaId2int : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receipt_Arena_ArenaId1",
                table: "Receipt");

            migrationBuilder.DropIndex(
                name: "IX_Receipt_ArenaId1",
                table: "Receipt");

            migrationBuilder.DropColumn(
                name: "ArenaId1",
                table: "Receipt");

            migrationBuilder.AlterColumn<int>(
                name: "ArenaId",
                table: "Receipt",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_ArenaId",
                table: "Receipt",
                column: "ArenaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Receipt_Arena_ArenaId",
                table: "Receipt",
                column: "ArenaId",
                principalTable: "Arena",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receipt_Arena_ArenaId",
                table: "Receipt");

            migrationBuilder.DropIndex(
                name: "IX_Receipt_ArenaId",
                table: "Receipt");

            migrationBuilder.AlterColumn<string>(
                name: "ArenaId",
                table: "Receipt",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArenaId1",
                table: "Receipt",
                nullable: true);

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
    }
}
