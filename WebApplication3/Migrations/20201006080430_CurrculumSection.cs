using Microsoft.EntityFrameworkCore.Migrations;

namespace e.moiroServer.Migrations
{
    public partial class CurrculumSection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurriculumSectionId",
                table: "CurriculumTopicTrainingPrograms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumTopicTrainingPrograms_CurriculumSectionId",
                table: "CurriculumTopicTrainingPrograms",
                column: "CurriculumSectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_CurriculumTopicTrainingPrograms_CurriculumSections_Curricul~",
                table: "CurriculumTopicTrainingPrograms",
                column: "CurriculumSectionId",
                principalTable: "CurriculumSections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurriculumTopicTrainingPrograms_CurriculumSections_Curricul~",
                table: "CurriculumTopicTrainingPrograms");

            migrationBuilder.DropIndex(
                name: "IX_CurriculumTopicTrainingPrograms_CurriculumSectionId",
                table: "CurriculumTopicTrainingPrograms");

            migrationBuilder.DropColumn(
                name: "CurriculumSectionId",
                table: "CurriculumTopicTrainingPrograms");
        }
    }
}
