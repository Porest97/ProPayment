using Microsoft.EntityFrameworkCore.Migrations;

namespace ProPayment.Migrations
{
    public partial class string4ssn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Ssn",
                table: "PaymentVerification",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Ssn",
                table: "PaymentVerification",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
