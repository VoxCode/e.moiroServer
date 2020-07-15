using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace e.moiroServer.Migrations
{
    public partial class EditContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicAdditionalLiteratures_AdditionalLiteratures_~",
                table: "СurriculumTopicAdditionalLiteratures");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicAdditionalLiteratures_CuriculumTopics_Curicu~",
                table: "СurriculumTopicAdditionalLiteratures");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicConsultationTopics_CuriculumTopics_Curiculum~",
                table: "СurriculumTopicConsultationTopics");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicDepartmens_CuriculumTopics_CuriculumTopicId",
                table: "СurriculumTopicDepartmens");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicMainLiteratures_CuriculumTopics_CuriculumTop~",
                table: "СurriculumTopicMainLiteratures");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicMainLiteratures_MainLiteratures_MainLiteratu~",
                table: "СurriculumTopicMainLiteratures");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicTeacherCategories_CuriculumTopics_CuriculumT~",
                table: "СurriculumTopicTeacherCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicTeacherCategories_TeacherCategories_TeacherC~",
                table: "СurriculumTopicTeacherCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicTeachers_CuriculumTopics_CuriculumTopicId",
                table: "СurriculumTopicTeachers");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicTeachers_Teachers_TeacherId",
                table: "СurriculumTopicTeachers");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicTheQuestions_CuriculumTopics_CuriculumTopicId",
                table: "СurriculumTopicTheQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicTranningPrograms_CuriculumTopics_CuriculumTo~",
                table: "СurriculumTopicTranningPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicTranningPrograms_TrainingPrograms_TrainingPr~",
                table: "СurriculumTopicTranningPrograms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicTheQuestions",
                table: "СurriculumTopicTheQuestions");

            migrationBuilder.DropIndex(
                name: "IX_СurriculumTopicTheQuestions_CuriculumTopicId",
                table: "СurriculumTopicTheQuestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicDepartmens",
                table: "СurriculumTopicDepartmens");

            migrationBuilder.DropIndex(
                name: "IX_СurriculumTopicDepartmens_CuriculumTopicId",
                table: "СurriculumTopicDepartmens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicConsultationTopics",
                table: "СurriculumTopicConsultationTopics");

            migrationBuilder.DropIndex(
                name: "IX_СurriculumTopicConsultationTopics_CuriculumTopicId",
                table: "СurriculumTopicConsultationTopics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicTranningPrograms",
                table: "СurriculumTopicTranningPrograms");

            migrationBuilder.DropIndex(
                name: "IX_СurriculumTopicTranningPrograms_CuriculumTopicId",
                table: "СurriculumTopicTranningPrograms");

            migrationBuilder.DropIndex(
                name: "IX_СurriculumTopicTranningPrograms_TrainingProgramId",
                table: "СurriculumTopicTranningPrograms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicTeachers",
                table: "СurriculumTopicTeachers");

            migrationBuilder.DropIndex(
                name: "IX_СurriculumTopicTeachers_CuriculumTopicId",
                table: "СurriculumTopicTeachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicTeacherCategories",
                table: "СurriculumTopicTeacherCategories");

            migrationBuilder.DropIndex(
                name: "IX_СurriculumTopicTeacherCategories_CuriculumTopicId",
                table: "СurriculumTopicTeacherCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicMainLiteratures",
                table: "СurriculumTopicMainLiteratures");

            migrationBuilder.DropIndex(
                name: "IX_СurriculumTopicMainLiteratures_CuriculumTopicId",
                table: "СurriculumTopicMainLiteratures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicAdditionalLiteratures",
                table: "СurriculumTopicAdditionalLiteratures");

            migrationBuilder.DropIndex(
                name: "IX_СurriculumTopicAdditionalLiteratures_CuriculumTopicId",
                table: "СurriculumTopicAdditionalLiteratures");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "СurriculumTopicTheQuestions");

            migrationBuilder.DropColumn(
                name: "CuriculumTopicId",
                table: "СurriculumTopicTheQuestions");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "СurriculumTopicDepartmens");

            migrationBuilder.DropColumn(
                name: "CuriculumTopicId",
                table: "СurriculumTopicDepartmens");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "СurriculumTopicConsultationTopics");

            migrationBuilder.DropColumn(
                name: "CuriculumTopicId",
                table: "СurriculumTopicConsultationTopics");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "СurriculumTopicTranningPrograms");

            migrationBuilder.DropColumn(
                name: "CuriculumTopicId",
                table: "СurriculumTopicTranningPrograms");

            migrationBuilder.DropColumn(
                name: "TrainingProgramId",
                table: "СurriculumTopicTranningPrograms");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "СurriculumTopicTeachers");

            migrationBuilder.DropColumn(
                name: "CuriculumTopicId",
                table: "СurriculumTopicTeachers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "СurriculumTopicTeacherCategories");

            migrationBuilder.DropColumn(
                name: "CuriculumTopicId",
                table: "СurriculumTopicTeacherCategories");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "СurriculumTopicMainLiteratures");

            migrationBuilder.DropColumn(
                name: "CuriculumTopicId",
                table: "СurriculumTopicMainLiteratures");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "СurriculumTopicAdditionalLiteratures");

            migrationBuilder.DropColumn(
                name: "CuriculumTopicId",
                table: "СurriculumTopicAdditionalLiteratures");

            migrationBuilder.RenameTable(
                name: "СurriculumTopicTranningPrograms",
                newName: "СurriculumTopicTranningProgram");

            migrationBuilder.RenameTable(
                name: "СurriculumTopicTeachers",
                newName: "СurriculumTopicTeacher");

            migrationBuilder.RenameTable(
                name: "СurriculumTopicTeacherCategories",
                newName: "СurriculumTopicTeacherCategory");

            migrationBuilder.RenameTable(
                name: "СurriculumTopicMainLiteratures",
                newName: "СurriculumTopicMainLiterature");

            migrationBuilder.RenameTable(
                name: "СurriculumTopicAdditionalLiteratures",
                newName: "СurriculumTopicAdditionalLiterature");

            migrationBuilder.RenameIndex(
                name: "IX_СurriculumTopicTeachers_TeacherId",
                table: "СurriculumTopicTeacher",
                newName: "IX_СurriculumTopicTeacher_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_СurriculumTopicTeacherCategories_TeacherCategoryId",
                table: "СurriculumTopicTeacherCategory",
                newName: "IX_СurriculumTopicTeacherCategory_TeacherCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_СurriculumTopicMainLiteratures_MainLiteratureId",
                table: "СurriculumTopicMainLiterature",
                newName: "IX_СurriculumTopicMainLiterature_MainLiteratureId");

            migrationBuilder.RenameIndex(
                name: "IX_СurriculumTopicAdditionalLiteratures_AdditionalLiteratureId",
                table: "СurriculumTopicAdditionalLiterature",
                newName: "IX_СurriculumTopicAdditionalLiterature_AdditionalLiteratureId");

            migrationBuilder.AddColumn<int>(
                name: "CurriculumTopicId",
                table: "СurriculumTopicTheQuestions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurriculumTopicId",
                table: "СurriculumTopicDepartmens",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurriculumTopicId",
                table: "СurriculumTopicConsultationTopics",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurriculumTopicId",
                table: "СurriculumTopicTranningProgram",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TranningProgramId",
                table: "СurriculumTopicTranningProgram",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurriculumTopicId",
                table: "СurriculumTopicTeacher",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurriculumTopicId",
                table: "СurriculumTopicTeacherCategory",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurriculumTopicId",
                table: "СurriculumTopicMainLiterature",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurriculumTopicId",
                table: "СurriculumTopicAdditionalLiterature",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicTheQuestions",
                table: "СurriculumTopicTheQuestions",
                columns: new[] { "CurriculumTopicId", "TheQuestionsId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicDepartmens",
                table: "СurriculumTopicDepartmens",
                columns: new[] { "CurriculumTopicId", "DepartmensId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicConsultationTopics",
                table: "СurriculumTopicConsultationTopics",
                columns: new[] { "CurriculumTopicId", "ConsultationTopicsId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicTranningProgram",
                table: "СurriculumTopicTranningProgram",
                columns: new[] { "CurriculumTopicId", "TranningProgramId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicTeacher",
                table: "СurriculumTopicTeacher",
                columns: new[] { "CurriculumTopicId", "TeacherId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicTeacherCategory",
                table: "СurriculumTopicTeacherCategory",
                columns: new[] { "CurriculumTopicId", "TeacherCategoryId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicMainLiterature",
                table: "СurriculumTopicMainLiterature",
                columns: new[] { "CurriculumTopicId", "MainLiteratureId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicAdditionalLiterature",
                table: "СurriculumTopicAdditionalLiterature",
                columns: new[] { "CurriculumTopicId", "AdditionalLiteratureId" });

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTranningProgram_TranningProgramId",
                table: "СurriculumTopicTranningProgram",
                column: "TranningProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicAdditionalLiterature_AdditionalLiteratures_A~",
                table: "СurriculumTopicAdditionalLiterature",
                column: "AdditionalLiteratureId",
                principalTable: "AdditionalLiteratures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicAdditionalLiterature_CuriculumTopics_Curricu~",
                table: "СurriculumTopicAdditionalLiterature",
                column: "CurriculumTopicId",
                principalTable: "CuriculumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicConsultationTopics_CuriculumTopics_Curriculu~",
                table: "СurriculumTopicConsultationTopics",
                column: "CurriculumTopicId",
                principalTable: "CuriculumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicDepartmens_CuriculumTopics_CurriculumTopicId",
                table: "СurriculumTopicDepartmens",
                column: "CurriculumTopicId",
                principalTable: "CuriculumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicMainLiterature_CuriculumTopics_CurriculumTop~",
                table: "СurriculumTopicMainLiterature",
                column: "CurriculumTopicId",
                principalTable: "CuriculumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicMainLiterature_MainLiteratures_MainLiteratur~",
                table: "СurriculumTopicMainLiterature",
                column: "MainLiteratureId",
                principalTable: "MainLiteratures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicTeacher_CuriculumTopics_CurriculumTopicId",
                table: "СurriculumTopicTeacher",
                column: "CurriculumTopicId",
                principalTable: "CuriculumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicTeacher_Teachers_TeacherId",
                table: "СurriculumTopicTeacher",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicTeacherCategory_CuriculumTopics_CurriculumTo~",
                table: "СurriculumTopicTeacherCategory",
                column: "CurriculumTopicId",
                principalTable: "CuriculumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicTeacherCategory_TeacherCategories_TeacherCat~",
                table: "СurriculumTopicTeacherCategory",
                column: "TeacherCategoryId",
                principalTable: "TeacherCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicTheQuestions_CuriculumTopics_CurriculumTopic~",
                table: "СurriculumTopicTheQuestions",
                column: "CurriculumTopicId",
                principalTable: "CuriculumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicTranningProgram_CuriculumTopics_CurriculumTo~",
                table: "СurriculumTopicTranningProgram",
                column: "CurriculumTopicId",
                principalTable: "CuriculumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicTranningProgram_TrainingPrograms_TranningPro~",
                table: "СurriculumTopicTranningProgram",
                column: "TranningProgramId",
                principalTable: "TrainingPrograms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicAdditionalLiterature_AdditionalLiteratures_A~",
                table: "СurriculumTopicAdditionalLiterature");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicAdditionalLiterature_CuriculumTopics_Curricu~",
                table: "СurriculumTopicAdditionalLiterature");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicConsultationTopics_CuriculumTopics_Curriculu~",
                table: "СurriculumTopicConsultationTopics");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicDepartmens_CuriculumTopics_CurriculumTopicId",
                table: "СurriculumTopicDepartmens");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicMainLiterature_CuriculumTopics_CurriculumTop~",
                table: "СurriculumTopicMainLiterature");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicMainLiterature_MainLiteratures_MainLiteratur~",
                table: "СurriculumTopicMainLiterature");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicTeacher_CuriculumTopics_CurriculumTopicId",
                table: "СurriculumTopicTeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicTeacher_Teachers_TeacherId",
                table: "СurriculumTopicTeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicTeacherCategory_CuriculumTopics_CurriculumTo~",
                table: "СurriculumTopicTeacherCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicTeacherCategory_TeacherCategories_TeacherCat~",
                table: "СurriculumTopicTeacherCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicTheQuestions_CuriculumTopics_CurriculumTopic~",
                table: "СurriculumTopicTheQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicTranningProgram_CuriculumTopics_CurriculumTo~",
                table: "СurriculumTopicTranningProgram");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicTranningProgram_TrainingPrograms_TranningPro~",
                table: "СurriculumTopicTranningProgram");

            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicTheQuestions",
                table: "СurriculumTopicTheQuestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicDepartmens",
                table: "СurriculumTopicDepartmens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicConsultationTopics",
                table: "СurriculumTopicConsultationTopics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_СurriculumTopicTranningProgram",
                table: "СurriculumTopicTranningProgram");

            migrationBuilder.DropIndex(
                name: "IX_СurriculumTopicTranningProgram_TranningProgramId",
                table: "СurriculumTopicTranningProgram");

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
                name: "PK_СurriculumTopicAdditionalLiterature",
                table: "СurriculumTopicAdditionalLiterature");

            migrationBuilder.DropColumn(
                name: "CurriculumTopicId",
                table: "СurriculumTopicTheQuestions");

            migrationBuilder.DropColumn(
                name: "CurriculumTopicId",
                table: "СurriculumTopicDepartmens");

            migrationBuilder.DropColumn(
                name: "CurriculumTopicId",
                table: "СurriculumTopicConsultationTopics");

            migrationBuilder.DropColumn(
                name: "CurriculumTopicId",
                table: "СurriculumTopicTranningProgram");

            migrationBuilder.DropColumn(
                name: "TranningProgramId",
                table: "СurriculumTopicTranningProgram");

            migrationBuilder.DropColumn(
                name: "CurriculumTopicId",
                table: "СurriculumTopicTeacherCategory");

            migrationBuilder.DropColumn(
                name: "CurriculumTopicId",
                table: "СurriculumTopicTeacher");

            migrationBuilder.DropColumn(
                name: "CurriculumTopicId",
                table: "СurriculumTopicMainLiterature");

            migrationBuilder.DropColumn(
                name: "CurriculumTopicId",
                table: "СurriculumTopicAdditionalLiterature");

            migrationBuilder.RenameTable(
                name: "СurriculumTopicTranningProgram",
                newName: "СurriculumTopicTranningPrograms");

            migrationBuilder.RenameTable(
                name: "СurriculumTopicTeacherCategory",
                newName: "СurriculumTopicTeacherCategories");

            migrationBuilder.RenameTable(
                name: "СurriculumTopicTeacher",
                newName: "СurriculumTopicTeachers");

            migrationBuilder.RenameTable(
                name: "СurriculumTopicMainLiterature",
                newName: "СurriculumTopicMainLiteratures");

            migrationBuilder.RenameTable(
                name: "СurriculumTopicAdditionalLiterature",
                newName: "СurriculumTopicAdditionalLiteratures");

            migrationBuilder.RenameIndex(
                name: "IX_СurriculumTopicTeacherCategory_TeacherCategoryId",
                table: "СurriculumTopicTeacherCategories",
                newName: "IX_СurriculumTopicTeacherCategories_TeacherCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_СurriculumTopicTeacher_TeacherId",
                table: "СurriculumTopicTeachers",
                newName: "IX_СurriculumTopicTeachers_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_СurriculumTopicMainLiterature_MainLiteratureId",
                table: "СurriculumTopicMainLiteratures",
                newName: "IX_СurriculumTopicMainLiteratures_MainLiteratureId");

            migrationBuilder.RenameIndex(
                name: "IX_СurriculumTopicAdditionalLiterature_AdditionalLiteratureId",
                table: "СurriculumTopicAdditionalLiteratures",
                newName: "IX_СurriculumTopicAdditionalLiteratures_AdditionalLiteratureId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicTheQuestions",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "CuriculumTopicId",
                table: "СurriculumTopicTheQuestions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicDepartmens",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "CuriculumTopicId",
                table: "СurriculumTopicDepartmens",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicConsultationTopics",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "CuriculumTopicId",
                table: "СurriculumTopicConsultationTopics",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicTranningPrograms",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "CuriculumTopicId",
                table: "СurriculumTopicTranningPrograms",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrainingProgramId",
                table: "СurriculumTopicTranningPrograms",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicTeacherCategories",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "CuriculumTopicId",
                table: "СurriculumTopicTeacherCategories",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicTeachers",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "CuriculumTopicId",
                table: "СurriculumTopicTeachers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicMainLiteratures",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "CuriculumTopicId",
                table: "СurriculumTopicMainLiteratures",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "СurriculumTopicAdditionalLiteratures",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "CuriculumTopicId",
                table: "СurriculumTopicAdditionalLiteratures",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicTheQuestions",
                table: "СurriculumTopicTheQuestions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicDepartmens",
                table: "СurriculumTopicDepartmens",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicConsultationTopics",
                table: "СurriculumTopicConsultationTopics",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicTranningPrograms",
                table: "СurriculumTopicTranningPrograms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicTeacherCategories",
                table: "СurriculumTopicTeacherCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicTeachers",
                table: "СurriculumTopicTeachers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicMainLiteratures",
                table: "СurriculumTopicMainLiteratures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_СurriculumTopicAdditionalLiteratures",
                table: "СurriculumTopicAdditionalLiteratures",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTheQuestions_CuriculumTopicId",
                table: "СurriculumTopicTheQuestions",
                column: "CuriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicDepartmens_CuriculumTopicId",
                table: "СurriculumTopicDepartmens",
                column: "CuriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicConsultationTopics_CuriculumTopicId",
                table: "СurriculumTopicConsultationTopics",
                column: "CuriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTranningPrograms_CuriculumTopicId",
                table: "СurriculumTopicTranningPrograms",
                column: "CuriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTranningPrograms_TrainingProgramId",
                table: "СurriculumTopicTranningPrograms",
                column: "TrainingProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTeacherCategories_CuriculumTopicId",
                table: "СurriculumTopicTeacherCategories",
                column: "CuriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicTeachers_CuriculumTopicId",
                table: "СurriculumTopicTeachers",
                column: "CuriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicMainLiteratures_CuriculumTopicId",
                table: "СurriculumTopicMainLiteratures",
                column: "CuriculumTopicId");

            migrationBuilder.CreateIndex(
                name: "IX_СurriculumTopicAdditionalLiteratures_CuriculumTopicId",
                table: "СurriculumTopicAdditionalLiteratures",
                column: "CuriculumTopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicAdditionalLiteratures_AdditionalLiteratures_~",
                table: "СurriculumTopicAdditionalLiteratures",
                column: "AdditionalLiteratureId",
                principalTable: "AdditionalLiteratures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicAdditionalLiteratures_CuriculumTopics_Curicu~",
                table: "СurriculumTopicAdditionalLiteratures",
                column: "CuriculumTopicId",
                principalTable: "CuriculumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicConsultationTopics_CuriculumTopics_Curiculum~",
                table: "СurriculumTopicConsultationTopics",
                column: "CuriculumTopicId",
                principalTable: "CuriculumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicDepartmens_CuriculumTopics_CuriculumTopicId",
                table: "СurriculumTopicDepartmens",
                column: "CuriculumTopicId",
                principalTable: "CuriculumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicMainLiteratures_CuriculumTopics_CuriculumTop~",
                table: "СurriculumTopicMainLiteratures",
                column: "CuriculumTopicId",
                principalTable: "CuriculumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicMainLiteratures_MainLiteratures_MainLiteratu~",
                table: "СurriculumTopicMainLiteratures",
                column: "MainLiteratureId",
                principalTable: "MainLiteratures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicTeacherCategories_CuriculumTopics_CuriculumT~",
                table: "СurriculumTopicTeacherCategories",
                column: "CuriculumTopicId",
                principalTable: "CuriculumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicTeacherCategories_TeacherCategories_TeacherC~",
                table: "СurriculumTopicTeacherCategories",
                column: "TeacherCategoryId",
                principalTable: "TeacherCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicTeachers_CuriculumTopics_CuriculumTopicId",
                table: "СurriculumTopicTeachers",
                column: "CuriculumTopicId",
                principalTable: "CuriculumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicTeachers_Teachers_TeacherId",
                table: "СurriculumTopicTeachers",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicTheQuestions_CuriculumTopics_CuriculumTopicId",
                table: "СurriculumTopicTheQuestions",
                column: "CuriculumTopicId",
                principalTable: "CuriculumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicTranningPrograms_CuriculumTopics_CuriculumTo~",
                table: "СurriculumTopicTranningPrograms",
                column: "CuriculumTopicId",
                principalTable: "CuriculumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicTranningPrograms_TrainingPrograms_TrainingPr~",
                table: "СurriculumTopicTranningPrograms",
                column: "TrainingProgramId",
                principalTable: "TrainingPrograms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
