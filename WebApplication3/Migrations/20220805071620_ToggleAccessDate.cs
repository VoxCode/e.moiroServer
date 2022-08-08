using Microsoft.EntityFrameworkCore.Migrations;

namespace e.moiroServer.Migrations
{
    public partial class ToggleAccessDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AccessDateEnabled",
                table: "TrainingProgramRegulations",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AccessDateEnabled",
                table: "TrainingProgramMainLiteratures",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AccessDateEnabled",
                table: "TrainingProgramAdditionalLiteratures",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AccessDateEnabled",
                table: "Regulations",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AccessDateEnabled",
                table: "MainLiteratures",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AccessDateEnabled",
                table: "AdditionalLiteratures",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessDateEnabled",
                table: "TrainingProgramRegulations");

            migrationBuilder.DropColumn(
                name: "AccessDateEnabled",
                table: "TrainingProgramMainLiteratures");

            migrationBuilder.DropColumn(
                name: "AccessDateEnabled",
                table: "TrainingProgramAdditionalLiteratures");

            migrationBuilder.DropColumn(
                name: "AccessDateEnabled",
                table: "Regulations");

            migrationBuilder.DropColumn(
                name: "AccessDateEnabled",
                table: "MainLiteratures");

            migrationBuilder.DropColumn(
                name: "AccessDateEnabled",
                table: "AdditionalLiteratures");
        }
    }
}
