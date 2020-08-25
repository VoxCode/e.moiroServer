using Microsoft.EntityFrameworkCore.Migrations;

namespace e.moiroServer.Migrations
{
    public partial class ddaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "СurriculumTopicTrainingProgram");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "СurriculumTopicTheQuestion");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "СurriculumTopicTeacherCategory");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "СurriculumTopicTeacher");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "СurriculumTopicMainLiterature");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "СurriculumTopicDepartment");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "СurriculumTopicConsultationTopic");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "СurriculumTopicAdditionalLiterature");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicTrainingProgram",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicTheQuestion",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicTeacherCategory",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicTeacher",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicMainLiterature",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicDepartment",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicConsultationTopic",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicAdditionalLiterature",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
