using Microsoft.EntityFrameworkCore.Migrations;

namespace e.moiroServer.Migrations
{
    public partial class TrainngProgramAddFormOfEducation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FormOfEducationId",
                table: "TrainingPrograms",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPrograms_FormOfEducationId",
                table: "TrainingPrograms",
                column: "FormOfEducationId");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingPrograms_FormOfEducations_FormOfEducationId",
                table: "TrainingPrograms",
                column: "FormOfEducationId",
                principalTable: "FormOfEducations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingPrograms_FormOfEducations_FormOfEducationId",
                table: "TrainingPrograms");

            migrationBuilder.DropIndex(
                name: "IX_TrainingPrograms_FormOfEducationId",
                table: "TrainingPrograms");

            migrationBuilder.DropColumn(
                name: "FormOfEducationId",
                table: "TrainingPrograms");
        }
    }
}
