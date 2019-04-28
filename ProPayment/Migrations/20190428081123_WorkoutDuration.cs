using Microsoft.EntityFrameworkCore.Migrations;

namespace ProPayment.Migrations
{
    public partial class WorkoutDuration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WoroutDistance",
                table: "PROWorkouts",
                newName: "WorkoutDistance");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WorkoutDistance",
                table: "PROWorkouts",
                newName: "WoroutDistance");
        }
    }
}
