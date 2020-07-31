using Microsoft.EntityFrameworkCore.Migrations;

namespace e.moiroServer.Migrations
{
    public partial class CT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CuriculumTopics_CurriculumSections_CurriculumSectionId",
                table: "CuriculumTopics");

            migrationBuilder.DropForeignKey(
                name: "FK_CuriculumTopics_OccupationForms_OccupationFormId",
                table: "CuriculumTopics");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicAdditionalLiterature_CuriculumTopics_Curricu~",
                table: "СurriculumTopicAdditionalLiterature");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicConsultationTopic_CuriculumTopics_Curriculum~",
                table: "СurriculumTopicConsultationTopic");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicDepartment_CuriculumTopics_CurriculumTopicId",
                table: "СurriculumTopicDepartment");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicMainLiterature_CuriculumTopics_CurriculumTop~",
                table: "СurriculumTopicMainLiterature");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicTeacher_CuriculumTopics_CurriculumTopicId",
                table: "СurriculumTopicTeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicTeacherCategory_CuriculumTopics_CurriculumTo~",
                table: "СurriculumTopicTeacherCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicTheQuestion_CuriculumTopics_CurriculumTopicId",
                table: "СurriculumTopicTheQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicTrainingProgram_CuriculumTopics_CurriculumTo~",
                table: "СurriculumTopicTrainingProgram");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CuriculumTopics",
                table: "CuriculumTopics");

            migrationBuilder.RenameTable(
                name: "CuriculumTopics",
                newName: "CurriculumTopics");

            migrationBuilder.RenameIndex(
                name: "IX_CuriculumTopics_OccupationFormId",
                table: "CurriculumTopics",
                newName: "IX_CurriculumTopics_OccupationFormId");

            migrationBuilder.RenameIndex(
                name: "IX_CuriculumTopics_CurriculumSectionId",
                table: "CurriculumTopics",
                newName: "IX_CurriculumTopics_CurriculumSectionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CurriculumTopics",
                table: "CurriculumTopics",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CurriculumTopics_CurriculumSections_CurriculumSectionId",
                table: "CurriculumTopics",
                column: "CurriculumSectionId",
                principalTable: "CurriculumSections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CurriculumTopics_OccupationForms_OccupationFormId",
                table: "CurriculumTopics",
                column: "OccupationFormId",
                principalTable: "OccupationForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicAdditionalLiterature_CurriculumTopics_Curric~",
                table: "СurriculumTopicAdditionalLiterature",
                column: "CurriculumTopicId",
                principalTable: "CurriculumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicConsultationTopic_CurriculumTopics_Curriculu~",
                table: "СurriculumTopicConsultationTopic",
                column: "CurriculumTopicId",
                principalTable: "CurriculumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicDepartment_CurriculumTopics_CurriculumTopicId",
                table: "СurriculumTopicDepartment",
                column: "CurriculumTopicId",
                principalTable: "CurriculumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicMainLiterature_CurriculumTopics_CurriculumTo~",
                table: "СurriculumTopicMainLiterature",
                column: "CurriculumTopicId",
                principalTable: "CurriculumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicTeacher_CurriculumTopics_CurriculumTopicId",
                table: "СurriculumTopicTeacher",
                column: "CurriculumTopicId",
                principalTable: "CurriculumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicTeacherCategory_CurriculumTopics_CurriculumT~",
                table: "СurriculumTopicTeacherCategory",
                column: "CurriculumTopicId",
                principalTable: "CurriculumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicTheQuestion_CurriculumTopics_CurriculumTopic~",
                table: "СurriculumTopicTheQuestion",
                column: "CurriculumTopicId",
                principalTable: "CurriculumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicTrainingProgram_CurriculumTopics_CurriculumT~",
                table: "СurriculumTopicTrainingProgram",
                column: "CurriculumTopicId",
                principalTable: "CurriculumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurriculumTopics_CurriculumSections_CurriculumSectionId",
                table: "CurriculumTopics");

            migrationBuilder.DropForeignKey(
                name: "FK_CurriculumTopics_OccupationForms_OccupationFormId",
                table: "CurriculumTopics");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicAdditionalLiterature_CurriculumTopics_Curric~",
                table: "СurriculumTopicAdditionalLiterature");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicConsultationTopic_CurriculumTopics_Curriculu~",
                table: "СurriculumTopicConsultationTopic");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicDepartment_CurriculumTopics_CurriculumTopicId",
                table: "СurriculumTopicDepartment");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicMainLiterature_CurriculumTopics_CurriculumTo~",
                table: "СurriculumTopicMainLiterature");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicTeacher_CurriculumTopics_CurriculumTopicId",
                table: "СurriculumTopicTeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicTeacherCategory_CurriculumTopics_CurriculumT~",
                table: "СurriculumTopicTeacherCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicTheQuestion_CurriculumTopics_CurriculumTopic~",
                table: "СurriculumTopicTheQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_СurriculumTopicTrainingProgram_CurriculumTopics_CurriculumT~",
                table: "СurriculumTopicTrainingProgram");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CurriculumTopics",
                table: "CurriculumTopics");

            migrationBuilder.RenameTable(
                name: "CurriculumTopics",
                newName: "CuriculumTopics");

            migrationBuilder.RenameIndex(
                name: "IX_CurriculumTopics_OccupationFormId",
                table: "CuriculumTopics",
                newName: "IX_CuriculumTopics_OccupationFormId");

            migrationBuilder.RenameIndex(
                name: "IX_CurriculumTopics_CurriculumSectionId",
                table: "CuriculumTopics",
                newName: "IX_CuriculumTopics_CurriculumSectionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CuriculumTopics",
                table: "CuriculumTopics",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CuriculumTopics_CurriculumSections_CurriculumSectionId",
                table: "CuriculumTopics",
                column: "CurriculumSectionId",
                principalTable: "CurriculumSections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CuriculumTopics_OccupationForms_OccupationFormId",
                table: "CuriculumTopics",
                column: "OccupationFormId",
                principalTable: "OccupationForms",
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
                name: "FK_СurriculumTopicConsultationTopic_CuriculumTopics_Curriculum~",
                table: "СurriculumTopicConsultationTopic",
                column: "CurriculumTopicId",
                principalTable: "CuriculumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicDepartment_CuriculumTopics_CurriculumTopicId",
                table: "СurriculumTopicDepartment",
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
                name: "FK_СurriculumTopicTeacher_CuriculumTopics_CurriculumTopicId",
                table: "СurriculumTopicTeacher",
                column: "CurriculumTopicId",
                principalTable: "CuriculumTopics",
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
                name: "FK_СurriculumTopicTheQuestion_CuriculumTopics_CurriculumTopicId",
                table: "СurriculumTopicTheQuestion",
                column: "CurriculumTopicId",
                principalTable: "CuriculumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_СurriculumTopicTrainingProgram_CuriculumTopics_CurriculumTo~",
                table: "СurriculumTopicTrainingProgram",
                column: "CurriculumTopicId",
                principalTable: "CuriculumTopics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
