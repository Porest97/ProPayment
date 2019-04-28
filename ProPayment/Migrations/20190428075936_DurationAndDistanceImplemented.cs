using Microsoft.EntityFrameworkCore.Migrations;

namespace ProPayment.Migrations
{
    public partial class DurationAndDistanceImplemented : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "WorkoutDuration",
                table: "PROWorkouts",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "WoroutDistance",
                table: "PROWorkouts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkoutDuration",
                table: "PROWorkouts");

            migrationBuilder.DropColumn(
                name: "WoroutDistance",
                table: "PROWorkouts");
        }
    }
}
