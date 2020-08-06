using Microsoft.EntityFrameworkCore.Migrations;

namespace e.moiroServer.Migrations
{
    public partial class manyToManyId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicTrainingProgram",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicTheQuestion",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicTeacherCategory",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicTeacher",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicMainLiterature",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicDepartment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicConsultationTopic",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicAdditionalLiterature",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
