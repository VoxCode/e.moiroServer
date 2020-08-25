using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace e.moiroServer.Migrations
{
    public partial class dd22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicTrainingProgram",
                table: "СurriculumTopicTrainingProgram");

            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicTheQuestion",
                table: "СurriculumTopicTheQuestion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicTeacherCategory",
                table: "СurriculumTopicTeacherCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicTeacher",
                table: "СurriculumTopicTeacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicMainLiterature",
                table: "СurriculumTopicMainLiterature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicDepartment",
                table: "СurriculumTopicDepartment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicConsultationTopic",
                table: "СurriculumTopicConsultationTopic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicAdditionalLiterature",
                table: "СurriculumTopicAdditionalLiterature");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicTrainingProgram",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicTheQuestion",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicTeacherCategory",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicTeacher",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicMainLiterature",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicDepartment",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicConsultationTopic",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicAdditionalLiterature",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicTrainingProgram",
                table: "СurriculumTopicTrainingProgram",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicTheQuestion",
                table: "СurriculumTopicTheQuestion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicTeacherCategory",
                table: "СurriculumTopicTeacherCategory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicTeacher",
                table: "СurriculumTopicTeacher",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicMainLiterature",
                table: "СurriculumTopicMainLiterature",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicDepartment",
                table: "СurriculumTopicDepartment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicConsultationTopic",
                table: "СurriculumTopicConsultationTopic",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicAdditionalLiterature",
                table: "СurriculumTopicAdditionalLiterature",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTrainingProgram_CurriculumTopicId",
                table: "СurriculumTopicTrainingProgram",
                column: "CurriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTheQuestion_CurriculumTopicId",
                table: "СurriculumTopicTheQuestion",
                column: "CurriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTeacherCategory_CurriculumTopicId",
                table: "СurriculumTopicTeacherCategory",
                column: "CurriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTeacher_CurriculumTopicId",
                table: "СurriculumTopicTeacher",
                column: "CurriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicMainLiterature_CurriculumTopicId",
                table: "СurriculumTopicMainLiterature",
                column: "CurriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicDepartment_CurriculumTopicId",
                table: "СurriculumTopicDepartment",
                column: "CurriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicConsultationTopic_CurriculumTopicId",
                table: "СurriculumTopicConsultationTopic",
                column: "CurriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicAdditionalLiterature_CurriculumTopicId",
                table: "СurriculumTopicAdditionalLiterature",
                column: "CurriculumTopicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicTrainingProgram",
                table: "СurriculumTopicTrainingProgram");

            migrationBuilder.DropIndex(
                name: "IX_СurriculumTopicTrainingProgram_CurriculumTopicId",
                table: "СurriculumTopicTrainingProgram");

            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicTheQuestion",
                table: "СurriculumTopicTheQuestion");

            migrationBuilder.DropIndex(
                name: "IX_СurriculumTopicTheQuestion_CurriculumTopicId",
                table: "СurriculumTopicTheQuestion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicTeacherCategory",
                table: "СurriculumTopicTeacherCategory");

            migrationBuilder.DropIndex(
                name: "IX_СurriculumTopicTeacherCategory_CurriculumTopicId",
                table: "СurriculumTopicTeacherCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicTeacher",
                table: "СurriculumTopicTeacher");

            migrationBuilder.DropIndex(
                name: "IX_СurriculumTopicTeacher_CurriculumTopicId",
                table: "СurriculumTopicTeacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicMainLiterature",
                table: "СurriculumTopicMainLiterature");

            migrationBuilder.DropIndex(
                name: "IX_СurriculumTopicMainLiterature_CurriculumTopicId",
                table: "СurriculumTopicMainLiterature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicDepartment",
                table: "СurriculumTopicDepartment");

            migrationBuilder.DropIndex(
                name: "IX_СurriculumTopicDepartment_CurriculumTopicId",
                table: "СurriculumTopicDepartment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicConsultationTopic",
                table: "СurriculumTopicConsultationTopic");

            migrationBuilder.DropIndex(
                name: "IX_СurriculumTopicConsultationTopic_CurriculumTopicId",
                table: "СurriculumTopicConsultationTopic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicAdditionalLiterature",
                table: "СurriculumTopicAdditionalLiterature");

            migrationBuilder.DropIndex(
                name: "IX_СurriculumTopicAdditionalLiterature_CurriculumTopicId",
                table: "СurriculumTopicAdditionalLiterature");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicTrainingProgram",
                table: "СurriculumTopicTrainingProgram",
                columns: new[] { "CurriculumTopicId", "TrainingProgramId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicTheQuestion",
                table: "СurriculumTopicTheQuestion",
                columns: new[] { "CurriculumTopicId", "TheQuestionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicTeacherCategory",
                table: "СurriculumTopicTeacherCategory",
                columns: new[] { "CurriculumTopicId", "TeacherCategoryId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicTeacher",
                table: "СurriculumTopicTeacher",
                columns: new[] { "CurriculumTopicId", "TeacherId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicMainLiterature",
                table: "СurriculumTopicMainLiterature",
                columns: new[] { "CurriculumTopicId", "MainLiteratureId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicDepartment",
                table: "СurriculumTopicDepartment",
                columns: new[] { "CurriculumTopicId", "DepartmentId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicConsultationTopic",
                table: "СurriculumTopicConsultationTopic",
                columns: new[] { "CurriculumTopicId", "ConsultationTopicId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicAdditionalLiterature",
                table: "СurriculumTopicAdditionalLiterature",
                columns: new[] { "CurriculumTopicId", "AdditionalLiteratureId" });
        }
    }
}
