using Microsoft.EntityFrameworkCore.Migrations;

namespace e.moiroServer.Migrations
{
    public partial class trainingProgramChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IndependentWork",
                table: "TrainingPrograms");

            migrationBuilder.DropColumn(
                name: "IsIndependentWork",
                table: "TrainingPrograms");

            migrationBuilder.AddColumn<string>(
                name: "ControlWork",
                table: "TrainingPrograms",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsControlWork",
                table: "TrainingPrograms",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ControlWork",
                table: "TrainingPrograms");

            migrationBuilder.DropColumn(
                name: "IsControlWork",
                table: "TrainingPrograms");

            migrationBuilder.AddColumn<string>(
                name: "IndependentWork",
                table: "TrainingPrograms",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsIndependentWork",
                table: "TrainingPrograms",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
